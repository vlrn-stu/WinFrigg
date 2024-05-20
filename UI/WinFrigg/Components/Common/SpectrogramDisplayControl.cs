namespace WinFrigg.Components.Common
{
    public partial class SpectrogramDisplayControl : UserControl
    {
        public SpectrogramDisplayControl()
        {
            InitializeComponent();
            Visible = false;
        }

        public SpectrogramDisplayControl(Image? spectrogram = null, int? width = null)
        {
            InitializeComponent();
            if (spectrogram != null)
            {
                pnlSpectrogramDisplay.Visible = true;
                //pnlSpectrogramDisplay.Width = Width;
                picSpectrogram.Height = spectrogram.Height;
                picSpectrogram.Width = spectrogram.Width;
                picSpectrogram.Image = spectrogram;
                //picSpectrogram.Width = Width + 100;
                if (width is not null)
                {
                    picSpectrogram.Width = width.Value;
                }
                picSpectrogram.ResetZoom();
            }
            else
            {
                Visible = false;
            }
        }

        public SpectrogramDisplayControl(string? spectrogramImagePath = null, int? width = null)
        {
            InitializeComponent();
            if (spectrogramImagePath != null && File.Exists(spectrogramImagePath))
            {
                Bitmap image = new(spectrogramImagePath);
                picSpectrogram.Height = image.Height;
                picSpectrogram.Image = image;
                if (width is not null)
                {
                    picSpectrogram.Width = width.Value;
                }
                picSpectrogram.ResetZoom();
            }
            else
            {
                Visible = false;
            }
        }
    }
}