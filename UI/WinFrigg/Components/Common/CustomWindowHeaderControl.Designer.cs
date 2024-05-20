namespace WinFrigg.Components
{
    partial class CustomWindowHeaderControl
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
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new ReaLTaiizor.Controls.ForeverLabel();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.pnlClose = new System.Windows.Forms.Panel();
            this.pnlMaximize = new System.Windows.Forms.Panel();
            this.picMaximize = new System.Windows.Forms.PictureBox();
            this.pnlMinimize = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            this.pnlMaximize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            this.SuspendLayout();
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = global::WinFrigg.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(276, 6);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(18, 18);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.PicClose_Click);
            this.picClose.MouseLeave += new System.EventHandler(this.PicClose_MouseLeave);
            this.picClose.MouseHover += new System.EventHandler(this.PicClose_MouseHover);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.picMinimize);
            this.pnlHeader.Controls.Add(this.picClose);
            this.pnlHeader.Controls.Add(this.pnlClose);
            this.pnlHeader.Controls.Add(this.pnlMaximize);
            this.pnlHeader.Controls.Add(this.pnlMinimize);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(300, 30);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 30);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "WinFrigg - {Form}";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picMinimize
            // 
            this.picMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimize.BackColor = System.Drawing.Color.Transparent;
            this.picMinimize.Image = global::WinFrigg.Properties.Resources.minimize;
            this.picMinimize.Location = new System.Drawing.Point(216, 6);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(18, 18);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 3;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.PicMinimize_Click);
            this.picMinimize.MouseLeave += new System.EventHandler(this.PicMinimize_MouseLeave);
            this.picMinimize.MouseHover += new System.EventHandler(this.PicMinimize_MouseHover);
            // 
            // pnlClose
            // 
            this.pnlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClose.Location = new System.Drawing.Point(270, 0);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(30, 30);
            this.pnlClose.TabIndex = 4;
            // 
            // pnlMaximize
            // 
            this.pnlMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMaximize.Controls.Add(this.picMaximize);
            this.pnlMaximize.Location = new System.Drawing.Point(240, 0);
            this.pnlMaximize.Name = "pnlMaximize";
            this.pnlMaximize.Size = new System.Drawing.Size(30, 30);
            this.pnlMaximize.TabIndex = 5;
            // 
            // picMaximize
            // 
            this.picMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMaximize.BackColor = System.Drawing.Color.Transparent;
            this.picMaximize.Image = global::WinFrigg.Properties.Resources.maximize;
            this.picMaximize.Location = new System.Drawing.Point(6, 6);
            this.picMaximize.Name = "picMaximize";
            this.picMaximize.Size = new System.Drawing.Size(18, 18);
            this.picMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMaximize.TabIndex = 2;
            this.picMaximize.TabStop = false;
            this.picMaximize.Click += new System.EventHandler(this.PicMaximize_Click);
            this.picMaximize.MouseLeave += new System.EventHandler(this.PicMaximize_MouseLeave);
            this.picMaximize.MouseHover += new System.EventHandler(this.PicMaximize_MouseHover);
            // 
            // pnlMinimize
            // 
            this.pnlMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMinimize.BackColor = System.Drawing.Color.Transparent;
            this.pnlMinimize.Location = new System.Drawing.Point(210, 0);
            this.pnlMinimize.Name = "pnlMinimize";
            this.pnlMinimize.Size = new System.Drawing.Size(30, 30);
            this.pnlMinimize.TabIndex = 6;
            // 
            // CustomWindowHeaderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHeader);
            this.DoubleBuffered = true;
            this.Name = "CustomWindowHeaderControl";
            this.Size = new System.Drawing.Size(300, 30);
            this.Load += new System.EventHandler(this.CustomWindowHeaderControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            this.pnlMaximize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picClose;
        private Panel pnlHeader;
        private PictureBox picMaximize;
        private PictureBox picMinimize;
        private Panel pnlClose;
        private Panel pnlMaximize;
        private Panel pnlMinimize;
        private ReaLTaiizor.Controls.ForeverLabel lblTitle;
    }
}
