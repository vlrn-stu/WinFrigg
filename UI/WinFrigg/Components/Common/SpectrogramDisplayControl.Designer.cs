namespace WinFrigg.Components.Common
{
    partial class SpectrogramDisplayControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSpectrogramDisplay = new FlowLayoutPanel();
            picSpectrogram = new ZoomablePictureBox();
            pnlSpectrogramDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSpectrogram).BeginInit();
            SuspendLayout();
            // 
            // pnlSpectrogramDisplay
            // 
            pnlSpectrogramDisplay.AutoScroll = true;
            pnlSpectrogramDisplay.AutoSize = true;
            pnlSpectrogramDisplay.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlSpectrogramDisplay.Controls.Add(picSpectrogram);
            pnlSpectrogramDisplay.Dock = DockStyle.Fill;
            pnlSpectrogramDisplay.Location = new Point(0, 0);
            pnlSpectrogramDisplay.Name = "pnlSpectrogramDisplay";
            pnlSpectrogramDisplay.Size = new Size(1500, 1000);
            pnlSpectrogramDisplay.TabIndex = 0;
            pnlSpectrogramDisplay.WrapContents = false;
            // 
            // picSpectrogram
            // 
            picSpectrogram.Image = null;
            picSpectrogram.Location = new Point(3, 3);
            picSpectrogram.Name = "picSpectrogram";
            picSpectrogram.Size = new Size(1000, 1000);
            picSpectrogram.TabIndex = 0;
            picSpectrogram.TabStop = false;
            // 
            // SpectrogramDisplayControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlSpectrogramDisplay);
            Name = "SpectrogramDisplayControl";
            Size = new Size(1500, 1000);
            pnlSpectrogramDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSpectrogram).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel pnlSpectrogramDisplay;
        private ZoomablePictureBox picSpectrogram;
    }
}
