using Frigg.Devices.SDR;
using Frigg.Python;
using Python.Runtime;
using System.Drawing.Drawing2D;

namespace WinFrigg
{
    public partial class Splash : Form
    {
        private readonly App _app;

        public Splash(IEnumerable<ISDRDeviceManager> sdrDeviceManagers)
        {
            InitializeComponent();
            picSplashLogo.Image = SmoothResizeImage(picSplashLogo.Image, 240, 240);
            _app = new(sdrDeviceManagers);
            _app.FormClosed += AppForm_FormClosed;
            SplashTimer.Start();
        }

        private static Bitmap SmoothResizeImage(Image originalImage, int width, int height)
        {
            Bitmap resizedBitmap = new(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedBitmap))
            {
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.DrawImage(originalImage, new Rectangle(0, 0, width, height));
            }
            return resizedBitmap;
        }

        private void AppForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Close();
            PythonEngine.Shutdown();
            Application.Exit();
        }

        private void SplashTimer_Tick(object? sender, EventArgs e)
        {
            SplashTimer.Stop();
            string? pythonPath = PythonHelpers.FindPythonDllPath();
            try
            {
                if (string.IsNullOrEmpty(pythonPath))
                {
                    _ = MessageBox.Show("Python 3.8 was not found on this system. The application will now close.", "Python Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(-1);
                    return;
                }
                if (File.Exists(pythonPath))
                {
                    Runtime.PythonDLL = pythonPath;
                    PythonEngine.Initialize();
                    PythonInterop.InstallRequirements();
                }
                else
                {
                    _ = MessageBox.Show("Python 3.8 was not found on this system. The application will now close.", "Python Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(-1);
                    return;
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message);
            }

            Hide();
            _app.Show();
        }
    }
}