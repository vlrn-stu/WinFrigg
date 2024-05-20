namespace WinFrigg
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            richTextBoxGeneral.Text = richTextBoxGeneral.Text.Replace("{version}", System.Reflection.Assembly.GetExecutingAssembly()?.GetName()?.Version?.ToString() ?? "1.0.0");
        }
    }
}