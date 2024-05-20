namespace WinFrigg
{
    partial class Splash
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            picSplashLogo = new PictureBox();
            SplashTimer = new System.Windows.Forms.Timer(components);
            pnlTransparent = new Panel();
            ((System.ComponentModel.ISupportInitialize)picSplashLogo).BeginInit();
            pnlTransparent.SuspendLayout();
            SuspendLayout();
            // 
            // picSplashLogo
            // 
            picSplashLogo.BackColor = Color.Transparent;
            picSplashLogo.Dock = DockStyle.Top;
            picSplashLogo.Image = Properties.Resources.Logo;
            picSplashLogo.Location = new Point(0, 0);
            picSplashLogo.Margin = new Padding(10);
            picSplashLogo.Name = "picSplashLogo";
            picSplashLogo.Size = new Size(300, 342);
            picSplashLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picSplashLogo.TabIndex = 0;
            picSplashLogo.TabStop = false;
            // 
            // SplashTimer
            // 
            SplashTimer.Interval = 1420;
            SplashTimer.Tick += SplashTimer_Tick;
            // 
            // pnlTransparent
            // 
            pnlTransparent.BackColor = Color.Transparent;
            pnlTransparent.Controls.Add(picSplashLogo);
            pnlTransparent.Dock = DockStyle.Fill;
            pnlTransparent.Location = new Point(0, 0);
            pnlTransparent.Name = "pnlTransparent";
            pnlTransparent.Size = new Size(300, 342);
            pnlTransparent.TabIndex = 1;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            ClientSize = new Size(300, 342);
            Controls.Add(pnlTransparent);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Splash";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            TopMost = true;
            TransparencyKey = SystemColors.InactiveCaptionText;
            ((System.ComponentModel.ISupportInitialize)picSplashLogo).EndInit();
            pnlTransparent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picSplashLogo;
        private System.Windows.Forms.Timer SplashTimer;
        private Panel pnlTransparent;
    }
}