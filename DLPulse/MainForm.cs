using DLPulse.Helper;
using DLPulse.Model;
using DLPulse.Settings;
using System.Diagnostics;
using System.Text.Json;

namespace DLPulse
{
    public partial class MainForm : Form
    {
        private GlobalSettings _globalSettings;
        private SingleDownloadPageSettings _singleDownloadPageSettings;

        public MainForm()
        {
            InitializeComponent();
            _globalSettings = new GlobalSettings();
            _globalSettings.Load();
            _singleDownloadPageSettings = new SingleDownloadPageSettings();
            _singleDownloadPageSettings.Load();
            UpdateSingleDownloadPageFields();
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            _globalSettings.Save();
        }

        private void MainTabControl_Selected(object sender, TabControlEventArgs e)
        {
            ExecuatblePathTextBox.Text = _globalSettings.ExecutablePath;
            WorkingDirectoryTextBox.Text = _globalSettings.WorkingDirectory;

            UpdateSingleDownloadPageFields();
        }

        private void ExecuatblePathTextBox_TextChanged(object sender, EventArgs e)
        {
            _globalSettings.ExecutablePath = ExecuatblePathTextBox.Text;
        }

        private void WorkingDirectoryTextBox_TextChanged(object sender, EventArgs e)
        {
            _globalSettings.WorkingDirectory = WorkingDirectoryTextBox.Text;
        }

        private void ExecutablePathButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";
                dialog.Title = "Select Executable";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ExecuatblePathTextBox.Text = dialog.FileName;
                }
            }
        }

        private void WorkingDirectoryButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select Working Directory";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    WorkingDirectoryTextBox.Text = dialog.SelectedPath;
                }
            }
        }

        private void SingleGetMetadataButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_globalSettings.ExecutablePath))
            {
                MessageBox.Show("Please set the executable path first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> processOutput = ProcessRunner.RunProcess(_globalSettings.ExecutablePath, $"{SingleURLTextBox.Text} -j");

            if (processOutput == null || processOutput.Count == 0) return;

            try
            {
                using (JsonDocument doc = JsonDocument.Parse(processOutput[0]))
                {
                    _singleDownloadPageSettings.URLText = SingleURLTextBox.Text;
                    _singleDownloadPageSettings.LastFetchedMetadata = JsonSerializer.Deserialize<VideoMetadata>(doc.RootElement.GetRawText());

                    Debug.WriteLine(_singleDownloadPageSettings.LastFetchedMetadata?.ToString());

                    UpdateSingleDownloadPageFields();
                    _singleDownloadPageSettings.Save();
                }
            }
            catch (JsonException)
            {
                MessageBox.Show("The first output is not valid JSON.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SingleFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SingleVideoFormatComboBox.Text != null && _singleDownloadPageSettings.LastFetchedMetadata != null)
            {
                List<string> resolutions = _singleDownloadPageSettings.LastFetchedMetadata.Formats
                    .Where(f => f.Extension == SingleVideoFormatComboBox.Text && f.ACodec != "none" && f.VCodec != "none")
                    .Select(f => f.Resolution)
                    .Distinct()
                    .ToList();

                SingleVideoResolutionComboBox.Items.Clear();
                foreach (string resolution in resolutions) SingleVideoResolutionComboBox.Items.Add(resolution);
                if (resolutions.Count > 0) SingleVideoResolutionComboBox.SelectedIndex = 0;
            }
        }

        private void UpdateSingleDownloadPageFields()
        {
            if (_singleDownloadPageSettings.URLText != null) SingleURLTextBox.Text = _singleDownloadPageSettings.URLText;

            if (_singleDownloadPageSettings.LastFetchedMetadata != null)
            {
                SingleVideoFormatComboBox.Items.Clear();
                foreach (string format in _singleDownloadPageSettings.LastFetchedMetadata.Formats.Where(f => f.ACodec != "none" && f.VCodec != "none" && f.Extension != "mhtml").Select(f => f.Extension).Distinct().ToList()) 
                {
                    SingleVideoFormatComboBox.Items.Add(format);
                }
                SingleVideoFormatComboBox.SelectedIndex = 0;
            }
        }
    }
}
