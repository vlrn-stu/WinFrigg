using System.Data;
using Timer = System.Windows.Forms.Timer;

namespace WinFrigg.Components.Common
{
    public partial class PagedDataControl : UserControl
    {
        private readonly DataTable _dataTable = new();
        private readonly Timer _refreshTimer = new();
        private string _csvFilePath = string.Empty;
        private int _currentPage = 1;
        private int _pageSize = 30;
        private int _totalRecords = 0;

        public PagedDataControl()
        {
            InitializeComponent();
            InitializeTimer();
        }

        public string CsvFilePath
        {
            get => _csvFilePath;
            set
            {
                _csvFilePath = value;
                ReloadData();
            }
        }

        public int PageSize
        {
            get => _pageSize;
            set
            {
                _pageSize = value;
                ReloadData();
            }
        }

        private void BtnFirstPage_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            ReloadData();
        }

        private void BtnLastPage_Click(object sender, EventArgs e)
        {
            _currentPage = (_totalRecords + _pageSize - 1) / _pageSize;
            ReloadData();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void InitializeTimer()
        {
            _refreshTimer.Interval = 1000;
            _refreshTimer.Tick += (sender, e) => ReloadData();
            _refreshTimer.Start();
        }

        private void NumCurrentPage_ValueChanged(object sender, EventArgs e)
        {
            if (_currentPage != (int)numCurrentPage.Value)
            {
                _currentPage = (int)numCurrentPage.Value;
                ReloadData();
            }
        }

        private void ReloadData()
        {
            if (string.IsNullOrEmpty(_csvFilePath) || !File.Exists(_csvFilePath))
            {
                _dataTable.Clear();
                numCurrentPage.Value = 1;
                lblViewOrderAndTotal.Text = $"0 - 0\nout of\n0";
                lblPageCount.Text = $"0/";
                return;
            }

            List<string> allLines = File.ReadLines(_csvFilePath).ToList();

            int previousTotalPages = (_totalRecords + _pageSize - 1) / _pageSize;
            bool wasOnLastPage = previousTotalPages == _currentPage;
            _totalRecords = allLines.Count - 1;

            if (_totalRecords <= 0)
            {
                return;
            }

            // Populate headers if not yet populated
            if (_dataTable.Columns.Count == 0)
            {
                string[] headers = allLines[0].Split('`');
                foreach (string header in headers)
                {
                    _ = _dataTable.Columns.Add(header);
                }
            }

            // Account for overlap page even for one record
            int totalPages = (_totalRecords + _pageSize - 1) / _pageSize;

            if (wasOnLastPage && totalPages > previousTotalPages)
            {
                _currentPage = totalPages;
            }

            int startLine = ((_currentPage - 1) * _pageSize) + 1;
            int endLine = Math.Min(startLine + _pageSize, _totalRecords + 1);

            _dataTable.Rows.Clear();
            for (int i = startLine; i < endLine; i++)
            {
                string[] values = allLines[i].Split('`');
                _ = _dataTable.Rows.Add(values);
            }

            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            dataGridView.DataSource = _dataTable;
            numCurrentPage.Minimum = 1;
            int totalPages = (_totalRecords + _pageSize - 1) / _pageSize;
            numCurrentPage.Maximum = totalPages;
            numCurrentPage.Value = _currentPage;
            lblViewOrderAndTotal.Text = $"{(_currentPage * _pageSize) - _pageSize + 1} - {Math.Min(_currentPage * _pageSize, _totalRecords)}\n out of\n{_totalRecords}";
            lblPageCount.Text = $"{totalPages}/";
        }
    }
}