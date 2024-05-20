using Frigg.CTC.Signalling;
using Frigg.Devices.SDR;
using Frigg.Model;
using Frigg.Model.Encoding;
using System.Collections;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Frigg.CTC.Logic
{
    public class CTCTransmission
    {
        private readonly byte[] _doubleMtuPacket;
        private readonly IPEndPoint _endPoint;
        private readonly byte[] _mtuPacket;
        private readonly int _mtuSize = 1500;
        private readonly byte[] _tripleMtuPacket;
        private readonly UdpClient _udpClient;
        private CancellationTokenSource _cts = new();

        public CTCTransmission(string nicName)
        {
            _udpClient = new UdpClient();

            NetworkInterface? nic = NetworkInterface.GetAllNetworkInterfaces()
                                      .FirstOrDefault(n => n.Name == nicName && n.OperationalStatus == OperationalStatus.Up);
            IPInterfaceProperties? ipProps = nic?.GetIPProperties();
            UnicastIPAddressInformation unicastInfo = ipProps?.UnicastAddresses
                                     .FirstOrDefault(ua => ua.Address.AddressFamily == AddressFamily.InterNetwork) ?? throw new InvalidOperationException("No suitable IPv4 address found.");
            IPAddress ipAddress = unicastInfo.Address;
            IPAddress subnetMask = unicastInfo.IPv4Mask;
            IPAddress broadcastAddress = CalculateBroadcastAddress(ipAddress, subnetMask);
            _endPoint = new IPEndPoint(broadcastAddress, 42069);

            _mtuPacket = new byte[_mtuSize];
            _doubleMtuPacket = new byte[_mtuSize * 2];
            _tripleMtuPacket = new byte[_mtuSize * 7];
            Array.Fill(_mtuPacket, (byte)0xFF);
            Array.Fill(_doubleMtuPacket, (byte)0xFF);
            Array.Fill(_tripleMtuPacket, (byte)0xFF);
        }

        public static void Transmit(byte[] IQValues, ISDRDevice sdr)
        {
            sdr.TXVGAGain = 20;
            using Stream stream = sdr.Send();
            stream.Write(IQValues, 0, IQValues.Length);
            stream.Close();
        }

        public void Transmit(string message, ICTCEncoding encoding, bool record = false, ISDRDevice? sdr = null)
        {
            if (record)
            {
                StartRecording(sdr ?? throw new ArgumentNullException(nameof(sdr)));
            }

            // Start of transmission signal (Two triple MTU packets spaced appr. 1 second apart)
            _ = _udpClient.Send(_tripleMtuPacket, _doubleMtuPacket.Length, _endPoint);

            Thread.Sleep(1000);

            _ = _udpClient.Send(_tripleMtuPacket, _doubleMtuPacket.Length, _endPoint);

            // Transmission
            BitArray bits = encoding.GetBits(message);
            foreach (bool bit in bits)
            {
                _ = bit
                    ? _udpClient.Send(_doubleMtuPacket, _doubleMtuPacket.Length, _endPoint)
                    : _udpClient.Send(_mtuPacket, _mtuPacket.Length, _endPoint);

                Thread.Sleep(100);
            }

            // End of transmission signal
            _ = _udpClient.Send(_tripleMtuPacket, _doubleMtuPacket.Length, _endPoint);

            if (record)
            {
                StopRecording();
            }
        }

        public static void Transmit(StepParameterDictionary parameters, ISDRDevice sdr)
        {
            var encodingStep = new SignalGenerationStep
            {
                DoDrawSprectrogram = false,
                Parameters = parameters,
                OutputData = []
            };

            _ = encodingStep.PerformStep(null).Result;

            Transmit(encodingStep.OutputData, sdr);
        }

        private static IPAddress CalculateBroadcastAddress(IPAddress address, IPAddress mask)
        {
            byte[] ipAdressBytes = address.GetAddressBytes();
            byte[] subnetMaskBytes = mask.GetAddressBytes();
            byte[] broadcastAddress = new byte[ipAdressBytes.Length];
            for (int i = 0; i < ipAdressBytes.Length; i++)
            {
                broadcastAddress[i] = (byte)(ipAdressBytes[i] | (subnetMaskBytes[i] ^ 255));
            }

            return new IPAddress(broadcastAddress);
        }

        private void StartRecording(ISDRDevice selectedSDRDevice)
        {
            _cts = new CancellationTokenSource();
            _ = Task.Factory.StartNew(() =>
            {
                try
                {
                    IQDataRecorder.WriteStreamToFile(selectedSDRDevice, _cts.Token);
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("Operation was cancelled.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }, _cts.Token, TaskCreationOptions.LongRunning, TaskScheduler.Default);
        }

        private void StopRecording()
        {
            _cts.Cancel();
        }
    }
}