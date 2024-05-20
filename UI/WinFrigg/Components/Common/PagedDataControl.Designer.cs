
namespace WinFrigg.Components.Common
{
    partial class PagedDataControl
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlToolbar = new Panel();
            pnlPageControl = new Panel();
            numCurrentPage = new ReaLTaiizor.Controls.CrownNumeric();
            btnFirstPage = new ReaLTaiizor.Controls.CrownButton();
            btnLastPage = new ReaLTaiizor.Controls.CrownButton();
            pnlPagesInfo = new Panel();
            lblViewOrderAndTotal = new ReaLTaiizor.Controls.CrownLabel();
            lblPageCount = new ReaLTaiizor.Controls.CrownLabel();
            dataGridView = new DataGridView();
            timerRefresh = new System.Windows.Forms.Timer(components);
            pnlToolbar.SuspendLayout();
            pnlPageControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCurrentPage).BeginInit();
            pnlPagesInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // pnlToolbar
            // 
            pnlToolbar.Controls.Add(pnlPageControl);
            pnlToolbar.Controls.Add(pnlPagesInfo);
            pnlToolbar.Dock = DockStyle.Bottom;
            pnlToolbar.Location = new Point(0, 385);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(971, 50);
            pnlToolbar.TabIndex = 0;
            // 
            // pnlPageControl
            // 
            pnlPageControl.Controls.Add(numCurrentPage);
            pnlPageControl.Controls.Add(btnFirstPage);
            pnlPageControl.Controls.Add(btnLastPage);
            pnlPageControl.Dock = DockStyle.Left;
            pnlPageControl.Location = new Point(129, 0);
            pnlPageControl.Name = "pnlPageControl";
            pnlPageControl.Size = new Size(154, 50);
            pnlPageControl.TabIndex = 5;
            // 
            // numCurrentPage
            // 
            numCurrentPage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numCurrentPage.Location = new Point(6, 12);
            numCurrentPage.Name = "numCurrentPage";
            numCurrentPage.Size = new Size(77, 27);
            numCurrentPage.TabIndex = 0;
            numCurrentPage.ValueChanged += NumCurrentPage_ValueChanged;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Font = new Font("Segoe UI", 6F);
            btnFirstPage.Location = new Point(88, 12);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Padding = new Padding(5);
            btnFirstPage.Size = new Size(27, 27);
            btnFirstPage.TabIndex = 1;
            btnFirstPage.Text = "<<";
            btnFirstPage.Click += BtnFirstPage_Click;
            // 
            // btnLastPage
            // 
            btnLastPage.Font = new Font("Segoe UI", 6F);
            btnLastPage.Location = new Point(121, 12);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Padding = new Padding(5);
            btnLastPage.Size = new Size(27, 27);
            btnLastPage.TabIndex = 2;
            btnLastPage.Text = ">>";
            btnLastPage.Click += BtnLastPage_Click;
            // 
            // pnlPagesInfo
            // 
            pnlPagesInfo.AutoSize = true;
            pnlPagesInfo.Controls.Add(lblViewOrderAndTotal);
            pnlPagesInfo.Controls.Add(lblPageCount);
            pnlPagesInfo.Dock = DockStyle.Left;
            pnlPagesInfo.Location = new Point(0, 0);
            pnlPagesInfo.Name = "pnlPagesInfo";
            pnlPagesInfo.Size = new Size(129, 50);
            pnlPagesInfo.TabIndex = 4;
            // 
            // lblViewOrderAndTotal
            // 
            lblViewOrderAndTotal.Dock = DockStyle.Left;
            lblViewOrderAndTotal.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblViewOrderAndTotal.ForeColor = Color.FromArgb(220, 220, 220);
            lblViewOrderAndTotal.Location = new Point(0, 0);
            lblViewOrderAndTotal.Name = "lblViewOrderAndTotal";
            lblViewOrderAndTotal.Size = new Size(74, 50);
            lblViewOrderAndTotal.TabIndex = 4;
            lblViewOrderAndTotal.Text = "20 \r\nout of \r\n0";
            lblViewOrderAndTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPageCount
            // 
            lblPageCount.Dock = DockStyle.Right;
            lblPageCount.ForeColor = Color.FromArgb(220, 220, 220);
            lblPageCount.Location = new Point(74, 0);
            lblPageCount.Name = "lblPageCount";
            lblPageCount.Size = new Size(55, 50);
            lblPageCount.TabIndex = 3;
            lblPageCount.Text = "0 /";
            lblPageCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView.BackgroundColor = Color.FromArgb(42, 42, 42);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(69, 69, 69);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(74, 110, 174);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(42, 42, 42);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(74, 110, 174);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(69, 69, 69);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(74, 110, 174);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView.ShowEditingIcon = false;
            dataGridView.Size = new Size(971, 385);
            dataGridView.TabIndex = 1;
            // 
            // PagedDataControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(dataGridView);
            Controls.Add(pnlToolbar);
            Name = "PagedDataControl";
            Size = new Size(971, 435);
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlPageControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numCurrentPage).EndInit();
            pnlPagesInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Panel pnlToolbar;
        private DataGridView dataGridView;
        private ReaLTaiizor.Controls.CrownLabel lblPageCount;
        private ReaLTaiizor.Controls.CrownButton btnLastPage;
        private ReaLTaiizor.Controls.CrownButton btnFirstPage;
        private ReaLTaiizor.Controls.CrownNumeric numCurrentPage;
        private Panel pnlPageControl;
        private Panel pnlPagesInfo;
        private ReaLTaiizor.Controls.CrownLabel lblViewOrderAndTotal;
        public System.Windows.Forms.Timer timerRefresh;
    }
}
