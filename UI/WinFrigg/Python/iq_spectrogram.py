import numpy as np
from scipy.signal import get_window
from PIL import Image

def process_iq_data(byte_data):
    i_data = byte_data[::2]  # Extract I (in-phase) data from even indices
    q_data = byte_data[1::2]  # Extract Q (quadrature-phase) data from odd indices
    iq_samples = i_data + 1j * q_data  # Combine I and Q data into complex IQ samples
    return iq_samples

def compute_spectrogram_and_save_fft(iq_samples, fft_size, overlap, window_type, output_path):
    window = get_window(window_type, fft_size)  # Generate the window function for the FFT
    step = fft_size - overlap  # Calculate step size for overlapping FFT
    shape = (fft_size, (iq_samples.shape[-1] - fft_size) // step + 1)
    iq_samples = iq_samples[:shape[1] * step]
    iq_samples = iq_samples.reshape(shape[1], step)
    # Pad the overlapping segments with zeros to match the window length
    iq_samples = np.concatenate([iq_samples, np.zeros((shape[1], overlap), dtype=iq_samples.dtype)], axis=1)
    iq_samples *= window  # Apply the window function to each segment
    spectrum = np.fft.fft(iq_samples, n=fft_size, axis=1)
    abs_spectrum = np.abs(spectrum[:, :fft_size // 2])  # Consider only the positive frequencies
    spectrum_db = 20 * np.log10(np.maximum(abs_spectrum, 1e-10))  # Convert the magnitude to dB scale
    # Normalize the dB values to the range 0-255
    spectrum_db = (spectrum_db - np.min(spectrum_db)) / (np.max(spectrum_db) - np.min(spectrum_db)) * 255
    return spectrum_db.astype(np.uint8)

def create_spectrogram_from_buffer(byte_data, output_path, fft_size=2500, overlap=256, window_type='hann'):
    byte_data = np.frombuffer(byte_data, dtype=np.int8)
    iq_samples = process_iq_data(byte_data)  # Process the byte data to obtain complex IQ samples
    spectrogram_data = compute_spectrogram_and_save_fft(iq_samples, fft_size, overlap, window_type, output_path)
    image = Image.fromarray(spectrogram_data, 'L')  # Convert the spectrogram data to an image
    image = image.transpose(Image.FLIP_TOP_BOTTOM)
    image.save(output_path)
