using Frigg.Common;
using ReaLTaiizor.Child.Crown;
using ReaLTaiizor.Controls;

namespace WinFrigg.Components.Common
{
    public partial class SpectrogramFileListControl : UserControl
    {
        private readonly CrownListView listView = new()
        {
            Dock = DockStyle.Fill
        };

        public SpectrogramFileListControl()
        {
            InitializeComponent();
            InitializeListView();
        }

        // Define an event to notify when a file is selected
        public event EventHandler<string>? FileSelected;

        private void InitializeListView()
        {
            Controls.Add(listView);
            LoadFiles();
            listView.SelectedIndicesChanged += ListView_SelectedIndicesChanged;
        }

        private void ListView_SelectedIndicesChanged(object? sender, EventArgs e)
        {
            // Check if there is any selected item and raise the FileSelected event
            if (listView.SelectedIndices.Count > 0)
            {
                int selectedIndex = listView.SelectedIndices[0];
                if (selectedIndex >= 0 && selectedIndex < listView.Items.Count)
                {
                    CrownListItem selectedItem = listView.Items[selectedIndex];
                    if (selectedItem.Tag is FileInfo fileInfo)
                    {
                        FileSelected?.Invoke(this, fileInfo.FullName);
                    }
                }
            }
        }

        private void LoadFiles()
        {
            string folderPath = Config.Folders.SpectrogramFolder;
            if (Directory.Exists(folderPath))
            {
                List<FileInfo> pngFiles = Directory.GetFiles(folderPath, "*.png")
                                        .Select(filePath => new FileInfo(filePath))
                                        .OrderByDescending(fileInfo => fileInfo.LastWriteTime)
                                        .ToList();

                listView.Items.Clear();
                foreach (FileInfo file in pngFiles)
                {
                    CrownListItem crownListItem = new() { Text = file.Name, Tag = file };
                    listView.Items.Add(crownListItem);
                }
            }
        }
    }
}