namespace WinFrigg.Components.Common
{
    public partial class ZoomablePictureBox : PictureBox
    {
        private const float ZOOM_INCREMENT = 0.1f;
        private Image? originalImage = null;
        private float zoomFactor = 1.0f;

        public ZoomablePictureBox()
        {
            MouseWheel += ZoomablePictureBox_MouseWheel;
            SizeMode = PictureBoxSizeMode.Normal;
        }

        public new Image? Image
        {
            get => base.Image;
            set
            {
                originalImage = value;
                base.Image = value;
                ResetZoom();
            }
        }

        public void ResetZoom()
        {
            if (originalImage != null)
            {
                float widthRatio = (float)Width / originalImage.Width;
                float heightRatio = (float)Height / originalImage.Height;
                zoomFactor = Math.Min(widthRatio, heightRatio);
                ApplyZoom();
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _ = Focus();
        }

        private void ApplyZoom()
        {
            if (originalImage != null)
            {
                int newWidth = (int)(originalImage.Width * zoomFactor);
                int newHeight = (int)(originalImage.Height * zoomFactor);
                Bitmap bitmap = new(newWidth, newHeight);

                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.Clear(BackColor);
                    g.DrawImage(originalImage, 0, 0, newWidth, newHeight);
                }

                if (base.Image != null && base.Image != originalImage)
                {
                    base.Image.Dispose();
                }

                base.Image = bitmap;
            }
        }

        private void ZoomablePictureBox_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                if (e.Delta > 0)
                {
                    zoomFactor += ZOOM_INCREMENT;
                }
                else if (e.Delta < 0)
                {
                    zoomFactor = Math.Max(zoomFactor - ZOOM_INCREMENT, ZOOM_INCREMENT);
                }

                ApplyZoom();
            }
        }
    }
}