namespace DLPulse
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainTabControl = new TabControl();
            SingleDownloadPage = new TabPage();
            SingleGetMetadataButton = new Button();
            SingleTabControl = new TabControl();
            VideoPage = new TabPage();
            SingleDownloadEmbedVideoThumnailCheckBox = new CheckBox();
            SingleVideoResolutionComboBox = new ComboBox();
            SingleResolutionLabel = new Label();
            SingleFormatLabel = new Label();
            SingleVideoFormatComboBox = new ComboBox();
            AudioPage = new TabPage();
            SingleURLLabel = new Label();
            SingleURLTextBox = new TextBox();
            SettingsPage = new TabPage();
            SaveSettingsButton = new Button();
            WorkingDirectoryButton = new Button();
            WorkingDirectoryLabel = new Label();
            WorkingDirectoryTextBox = new TextBox();
            ExecutablePathButton = new Button();
            ExecutablePathLabel = new Label();
            ExecuatblePathTextBox = new TextBox();
            SingleDownloadDownloadButton = new Button();
            MainTabControl.SuspendLayout();
            SingleDownloadPage.SuspendLayout();
            SingleTabControl.SuspendLayout();
            VideoPage.SuspendLayout();
            SettingsPage.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(SingleDownloadPage);
            MainTabControl.Controls.Add(SettingsPage);
            MainTabControl.Location = new Point(12, 12);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(680, 417);
            MainTabControl.TabIndex = 4;
            MainTabControl.Selected += MainTabControl_Selected;
            // 
            // SingleDownloadPage
            // 
            SingleDownloadPage.Controls.Add(SingleGetMetadataButton);
            SingleDownloadPage.Controls.Add(SingleTabControl);
            SingleDownloadPage.Controls.Add(SingleURLLabel);
            SingleDownloadPage.Controls.Add(SingleURLTextBox);
            SingleDownloadPage.Location = new Point(4, 24);
            SingleDownloadPage.Name = "SingleDownloadPage";
            SingleDownloadPage.Size = new Size(672, 389);
            SingleDownloadPage.TabIndex = 2;
            SingleDownloadPage.Text = "Single Download";
            SingleDownloadPage.UseVisualStyleBackColor = true;
            // 
            // SingleGetMetadataButton
            // 
            SingleGetMetadataButton.Location = new Point(545, 23);
            SingleGetMetadataButton.Name = "SingleGetMetadataButton";
            SingleGetMetadataButton.Size = new Size(120, 23);
            SingleGetMetadataButton.TabIndex = 3;
            SingleGetMetadataButton.Text = "Get Metadata";
            SingleGetMetadataButton.UseVisualStyleBackColor = true;
            SingleGetMetadataButton.Click += SingleGetMetadataButton_Click;
            // 
            // SingleTabControl
            // 
            SingleTabControl.Controls.Add(VideoPage);
            SingleTabControl.Controls.Add(AudioPage);
            SingleTabControl.Location = new Point(5, 52);
            SingleTabControl.Name = "SingleTabControl";
            SingleTabControl.SelectedIndex = 0;
            SingleTabControl.Size = new Size(664, 334);
            SingleTabControl.TabIndex = 2;
            // 
            // VideoPage
            // 
            VideoPage.Controls.Add(SingleDownloadDownloadButton);
            VideoPage.Controls.Add(SingleDownloadEmbedVideoThumnailCheckBox);
            VideoPage.Controls.Add(SingleVideoResolutionComboBox);
            VideoPage.Controls.Add(SingleResolutionLabel);
            VideoPage.Controls.Add(SingleFormatLabel);
            VideoPage.Controls.Add(SingleVideoFormatComboBox);
            VideoPage.Location = new Point(4, 24);
            VideoPage.Name = "VideoPage";
            VideoPage.Padding = new Padding(3);
            VideoPage.Size = new Size(656, 306);
            VideoPage.TabIndex = 0;
            VideoPage.Text = "Video";
            VideoPage.UseVisualStyleBackColor = true;
            // 
            // SingleDownloadEmbedVideoThumnailCheckBox
            // 
            SingleDownloadEmbedVideoThumnailCheckBox.Appearance = Appearance.Button;
            SingleDownloadEmbedVideoThumnailCheckBox.AutoSize = true;
            SingleDownloadEmbedVideoThumnailCheckBox.Location = new Point(268, 19);
            SingleDownloadEmbedVideoThumnailCheckBox.Name = "SingleDownloadEmbedVideoThumnailCheckBox";
            SingleDownloadEmbedVideoThumnailCheckBox.Size = new Size(115, 25);
            SingleDownloadEmbedVideoThumnailCheckBox.TabIndex = 7;
            SingleDownloadEmbedVideoThumnailCheckBox.Text = "Embed Thumbnail";
            SingleDownloadEmbedVideoThumnailCheckBox.UseVisualStyleBackColor = true;
            // 
            // SingleVideoResolutionComboBox
            // 
            SingleVideoResolutionComboBox.FormattingEnabled = true;
            SingleVideoResolutionComboBox.Location = new Point(137, 21);
            SingleVideoResolutionComboBox.Name = "SingleVideoResolutionComboBox";
            SingleVideoResolutionComboBox.Size = new Size(125, 23);
            SingleVideoResolutionComboBox.TabIndex = 6;
            // 
            // SingleResolutionLabel
            // 
            SingleResolutionLabel.AutoSize = true;
            SingleResolutionLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SingleResolutionLabel.Location = new Point(137, 3);
            SingleResolutionLabel.Name = "SingleResolutionLabel";
            SingleResolutionLabel.Size = new Size(63, 15);
            SingleResolutionLabel.TabIndex = 5;
            SingleResolutionLabel.Text = "Resolution";
            // 
            // SingleFormatLabel
            // 
            SingleFormatLabel.AutoSize = true;
            SingleFormatLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SingleFormatLabel.Location = new Point(6, 3);
            SingleFormatLabel.Name = "SingleFormatLabel";
            SingleFormatLabel.Size = new Size(45, 15);
            SingleFormatLabel.TabIndex = 4;
            SingleFormatLabel.Text = "Format";
            // 
            // SingleVideoFormatComboBox
            // 
            SingleVideoFormatComboBox.FormattingEnabled = true;
            SingleVideoFormatComboBox.Location = new Point(6, 21);
            SingleVideoFormatComboBox.Name = "SingleVideoFormatComboBox";
            SingleVideoFormatComboBox.Size = new Size(125, 23);
            SingleVideoFormatComboBox.TabIndex = 0;
            SingleVideoFormatComboBox.SelectedIndexChanged += SingleFormatComboBox_SelectedIndexChanged;
            // 
            // AudioPage
            // 
            AudioPage.Location = new Point(4, 24);
            AudioPage.Name = "AudioPage";
            AudioPage.Padding = new Padding(3);
            AudioPage.Size = new Size(656, 306);
            AudioPage.TabIndex = 1;
            AudioPage.Text = "Audio";
            AudioPage.UseVisualStyleBackColor = true;
            // 
            // SingleURLLabel
            // 
            SingleURLLabel.AutoSize = true;
            SingleURLLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SingleURLLabel.Location = new Point(5, 5);
            SingleURLLabel.Name = "SingleURLLabel";
            SingleURLLabel.Size = new Size(31, 15);
            SingleURLLabel.TabIndex = 1;
            SingleURLLabel.Text = "URL:";
            // 
            // SingleURLTextBox
            // 
            SingleURLTextBox.Location = new Point(5, 23);
            SingleURLTextBox.Name = "SingleURLTextBox";
            SingleURLTextBox.Size = new Size(534, 23);
            SingleURLTextBox.TabIndex = 0;
            // 
            // SettingsPage
            // 
            SettingsPage.Controls.Add(SaveSettingsButton);
            SettingsPage.Controls.Add(WorkingDirectoryButton);
            SettingsPage.Controls.Add(WorkingDirectoryLabel);
            SettingsPage.Controls.Add(WorkingDirectoryTextBox);
            SettingsPage.Controls.Add(ExecutablePathButton);
            SettingsPage.Controls.Add(ExecutablePathLabel);
            SettingsPage.Controls.Add(ExecuatblePathTextBox);
            SettingsPage.Location = new Point(4, 24);
            SettingsPage.Name = "SettingsPage";
            SettingsPage.Padding = new Padding(3);
            SettingsPage.Size = new Size(672, 389);
            SettingsPage.TabIndex = 1;
            SettingsPage.Text = "Settings";
            SettingsPage.UseVisualStyleBackColor = true;
            // 
            // SaveSettingsButton
            // 
            SaveSettingsButton.Location = new Point(546, 360);
            SaveSettingsButton.Name = "SaveSettingsButton";
            SaveSettingsButton.Size = new Size(120, 23);
            SaveSettingsButton.TabIndex = 6;
            SaveSettingsButton.Text = "Save Settings";
            SaveSettingsButton.UseVisualStyleBackColor = true;
            SaveSettingsButton.Click += SaveSettingsButton_Click;
            // 
            // WorkingDirectoryButton
            // 
            WorkingDirectoryButton.Location = new Point(591, 65);
            WorkingDirectoryButton.Name = "WorkingDirectoryButton";
            WorkingDirectoryButton.Size = new Size(75, 23);
            WorkingDirectoryButton.TabIndex = 5;
            WorkingDirectoryButton.Text = "Browse";
            WorkingDirectoryButton.UseVisualStyleBackColor = true;
            WorkingDirectoryButton.Click += WorkingDirectoryButton_Click;
            // 
            // WorkingDirectoryLabel
            // 
            WorkingDirectoryLabel.AutoSize = true;
            WorkingDirectoryLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WorkingDirectoryLabel.Location = new Point(6, 47);
            WorkingDirectoryLabel.Name = "WorkingDirectoryLabel";
            WorkingDirectoryLabel.Size = new Size(108, 15);
            WorkingDirectoryLabel.TabIndex = 4;
            WorkingDirectoryLabel.Text = "Working Directory:";
            // 
            // WorkingDirectoryTextBox
            // 
            WorkingDirectoryTextBox.Location = new Point(6, 65);
            WorkingDirectoryTextBox.Name = "WorkingDirectoryTextBox";
            WorkingDirectoryTextBox.Size = new Size(579, 23);
            WorkingDirectoryTextBox.TabIndex = 3;
            WorkingDirectoryTextBox.TextChanged += WorkingDirectoryTextBox_TextChanged;
            // 
            // ExecutablePathButton
            // 
            ExecutablePathButton.Location = new Point(591, 21);
            ExecutablePathButton.Name = "ExecutablePathButton";
            ExecutablePathButton.Size = new Size(75, 23);
            ExecutablePathButton.TabIndex = 2;
            ExecutablePathButton.Text = "Browse";
            ExecutablePathButton.UseVisualStyleBackColor = true;
            ExecutablePathButton.Click += ExecutablePathButton_Click;
            // 
            // ExecutablePathLabel
            // 
            ExecutablePathLabel.AutoSize = true;
            ExecutablePathLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExecutablePathLabel.Location = new Point(6, 3);
            ExecutablePathLabel.Name = "ExecutablePathLabel";
            ExecutablePathLabel.Size = new Size(94, 15);
            ExecutablePathLabel.TabIndex = 1;
            ExecutablePathLabel.Text = "Executable Path:";
            // 
            // ExecuatblePathTextBox
            // 
            ExecuatblePathTextBox.Location = new Point(6, 21);
            ExecuatblePathTextBox.Name = "ExecuatblePathTextBox";
            ExecuatblePathTextBox.Size = new Size(579, 23);
            ExecuatblePathTextBox.TabIndex = 0;
            ExecuatblePathTextBox.TextChanged += ExecuatblePathTextBox_TextChanged;
            // 
            // SingleDownloadDownloadButton
            // 
            SingleDownloadDownloadButton.Location = new Point(525, 20);
            SingleDownloadDownloadButton.Name = "SingleDownloadDownloadButton";
            SingleDownloadDownloadButton.Size = new Size(125, 23);
            SingleDownloadDownloadButton.TabIndex = 8;
            SingleDownloadDownloadButton.Text = "Download";
            SingleDownloadDownloadButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 441);
            Controls.Add(MainTabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "DLPulse";
            MainTabControl.ResumeLayout(false);
            SingleDownloadPage.ResumeLayout(false);
            SingleDownloadPage.PerformLayout();
            SingleTabControl.ResumeLayout(false);
            VideoPage.ResumeLayout(false);
            VideoPage.PerformLayout();
            SettingsPage.ResumeLayout(false);
            SettingsPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button SettingsButton;
        private Button SingleDownloadButton;
        private TabControl MainTabControl;
        private TabPage tabPage1;
        private TabPage SettingsPage;
        private Button WorkingDirectoryButton;
        private Label WorkingDirectoryLabel;
        private TextBox WorkingDirectoryTextBox;
        private Button ExecutablePathButton;
        private Label ExecutablePathLabel;
        private TextBox ExecuatblePathTextBox;
        private TabPage SingleDownloadPage;
        private Button SaveSettingsButton;
        private Label SingleURLLabel;
        private TextBox SingleURLTextBox;
        private TabControl SingleTabControl;
        private TabPage VideoPage;
        private TabPage AudioPage;
        private Button SingleGetMetadataButton;
        private ComboBox SingleVideoResolutionComboBox;
        private Label SingleResolutionLabel;
        private Label SingleFormatLabel;
        private ComboBox SingleVideoFormatComboBox;
        private CheckBox SingleDownloadEmbedVideoThumnailCheckBox;
        private Button SingleDownloadDownloadButton;
    }
}
