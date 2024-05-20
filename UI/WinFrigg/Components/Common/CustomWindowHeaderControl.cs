namespace WinFrigg.Components
{
    public partial class CustomWindowHeaderControl : UserControl
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public CustomWindowHeaderControl()
        {
            InitializeComponent();
        }

        private void CustomWindowHeaderControl_Load(object sender, EventArgs e)
        {
            if (Parent is Form parentForm)
            {
                lblTitle.Text = "WinFrigg - " + parentForm.Name;
            }
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            if (Parent is Form parentForm)
            {
                parentForm.Close();
            }
        }

        private void PicClose_MouseHover(object sender, EventArgs e)
        {
            picClose.BackColor = Color.FromArgb(100, 210, 150, 150);
            pnlClose.BackColor = Color.FromArgb(100, 210, 150, 150);
        }

        private void PicClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Transparent;
            pnlClose.BackColor = Color.Transparent;
        }

        private void PicMaximize_Click(object sender, EventArgs e)
        {
            if (Parent is Form parentForm)
            {
                parentForm.WindowState = parentForm.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            }
        }

        private void PicMaximize_MouseHover(object sender, EventArgs e)
        {
            pnlMaximize.BackColor = Color.FromArgb(100, 128, 128, 128);
        }

        private void PicMaximize_MouseLeave(object sender, EventArgs e)
        {
            pnlMaximize.BackColor = Color.Transparent;
        }

        private void PicMinimize_Click(object sender, EventArgs e)
        {
            if (Parent is Form parentForm)
            {
                parentForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void PicMinimize_MouseHover(object sender, EventArgs e)
        {
            picMinimize.BackColor = Color.FromArgb(100, 128, 128, 128);
            pnlMinimize.BackColor = Color.FromArgb(100, 128, 128, 128);
        }

        private void PicMinimize_MouseLeave(object sender, EventArgs e)
        {
            picMinimize.BackColor = Color.Transparent;
            pnlMinimize.BackColor = Color.Transparent;
        }

        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (Parent is not null)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = Parent.Location;
            }
        }

        private void PnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && Parent is not null)
            {
                Point difference = Point.Subtract(Cursor.Position, new Size(lastCursor));
                Parent.Location = Point.Add(lastForm, new Size(difference));
            }
        }

        private void PnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}