namespace ClientApplication.Forms.WorkPanels
{
    partial class Settings
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
            this.SeetingsContainer = new System.Windows.Forms.SplitContainer();
            this.AccountPanel = new System.Windows.Forms.Panel();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.DarkThemePanel = new System.Windows.Forms.Panel();
            this.DarkThemeToggle = new ClientApplication.UserControls.InputHandlers.ButtonToggle();
            this.DarkThemeLabel = new System.Windows.Forms.Label();
            this.AppClosePanel = new System.Windows.Forms.Panel();
            this.AppCloseToggle = new ClientApplication.UserControls.InputHandlers.ButtonToggle();
            this.buttonToggle1 = new ClientApplication.UserControls.InputHandlers.ButtonToggle();
            this.AppCloseLabel = new System.Windows.Forms.Label();
            this.AppSettingsPanel = new System.Windows.Forms.Panel();
            this.SaveApplicationSettings = new System.Windows.Forms.Button();
            this.AppSettingsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SeetingsContainer)).BeginInit();
            this.SeetingsContainer.Panel1.SuspendLayout();
            this.SeetingsContainer.Panel2.SuspendLayout();
            this.SeetingsContainer.SuspendLayout();
            this.AccountPanel.SuspendLayout();
            this.DarkThemePanel.SuspendLayout();
            this.AppClosePanel.SuspendLayout();
            this.AppSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeetingsContainer
            // 
            this.SeetingsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeetingsContainer.IsSplitterFixed = true;
            this.SeetingsContainer.Location = new System.Drawing.Point(0, 0);
            this.SeetingsContainer.Name = "SeetingsContainer";
            // 
            // SeetingsContainer.Panel1
            // 
            this.SeetingsContainer.Panel1.Controls.Add(this.AccountPanel);
            this.SeetingsContainer.Panel1.Tag = "Panel";
            // 
            // SeetingsContainer.Panel2
            // 
            this.SeetingsContainer.Panel2.Controls.Add(this.DarkThemePanel);
            this.SeetingsContainer.Panel2.Controls.Add(this.AppClosePanel);
            this.SeetingsContainer.Panel2.Controls.Add(this.AppSettingsPanel);
            this.SeetingsContainer.Panel2.Tag = "Panel";
            this.SeetingsContainer.Size = new System.Drawing.Size(805, 500);
            this.SeetingsContainer.SplitterDistance = 399;
            this.SeetingsContainer.SplitterWidth = 5;
            this.SeetingsContainer.TabIndex = 0;
            this.SeetingsContainer.Tag = "BackGround";
            // 
            // AccountPanel
            // 
            this.AccountPanel.Controls.Add(this.AccountLabel);
            this.AccountPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountPanel.Location = new System.Drawing.Point(0, 0);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Size = new System.Drawing.Size(399, 70);
            this.AccountPanel.TabIndex = 0;
            // 
            // AccountLabel
            // 
            this.AccountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccountLabel.Location = new System.Drawing.Point(0, 0);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(399, 70);
            this.AccountLabel.TabIndex = 0;
            this.AccountLabel.Text = "Аккаунт";
            // 
            // DarkThemePanel
            // 
            this.DarkThemePanel.Controls.Add(this.DarkThemeToggle);
            this.DarkThemePanel.Controls.Add(this.DarkThemeLabel);
            this.DarkThemePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DarkThemePanel.Location = new System.Drawing.Point(0, 110);
            this.DarkThemePanel.Name = "DarkThemePanel";
            this.DarkThemePanel.Size = new System.Drawing.Size(401, 40);
            this.DarkThemePanel.TabIndex = 2;
            // 
            // DarkThemeToggle
            // 
            this.DarkThemeToggle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DarkThemeToggle.Checked = true;
            this.DarkThemeToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DarkThemeToggle.DisabledBackColor = System.Drawing.Color.Gray;
            this.DarkThemeToggle.DisabledToggleColor = System.Drawing.Color.Gainsboro;
            this.DarkThemeToggle.EnabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(168)))), ((int)(((byte)(164)))));
            this.DarkThemeToggle.EnabledToggleColor = System.Drawing.Color.WhiteSmoke;
            this.DarkThemeToggle.Location = new System.Drawing.Point(344, 8);
            this.DarkThemeToggle.Margin = new System.Windows.Forms.Padding(8);
            this.DarkThemeToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.DarkThemeToggle.Name = "DarkThemeToggle";
            this.DarkThemeToggle.Size = new System.Drawing.Size(49, 24);
            this.DarkThemeToggle.TabIndex = 1;
            this.DarkThemeToggle.UseVisualStyleBackColor = true;
            this.DarkThemeToggle.CheckStateChanged += new System.EventHandler(this.DarkThemeToggle_CheckStateChanged);
            // 
            // DarkThemeLabel
            // 
            this.DarkThemeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DarkThemeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DarkThemeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DarkThemeLabel.Location = new System.Drawing.Point(0, 0);
            this.DarkThemeLabel.Name = "DarkThemeLabel";
            this.DarkThemeLabel.Size = new System.Drawing.Size(300, 40);
            this.DarkThemeLabel.TabIndex = 0;
            this.DarkThemeLabel.Text = "Тёмная тема";
            this.DarkThemeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AppClosePanel
            // 
            this.AppClosePanel.Controls.Add(this.AppCloseToggle);
            this.AppClosePanel.Controls.Add(this.buttonToggle1);
            this.AppClosePanel.Controls.Add(this.AppCloseLabel);
            this.AppClosePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppClosePanel.Location = new System.Drawing.Point(0, 70);
            this.AppClosePanel.Name = "AppClosePanel";
            this.AppClosePanel.Size = new System.Drawing.Size(401, 40);
            this.AppClosePanel.TabIndex = 3;
            // 
            // AppCloseToggle
            // 
            this.AppCloseToggle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppCloseToggle.Checked = true;
            this.AppCloseToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AppCloseToggle.DisabledBackColor = System.Drawing.Color.Gray;
            this.AppCloseToggle.DisabledToggleColor = System.Drawing.Color.Gainsboro;
            this.AppCloseToggle.EnabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(168)))), ((int)(((byte)(164)))));
            this.AppCloseToggle.EnabledToggleColor = System.Drawing.Color.WhiteSmoke;
            this.AppCloseToggle.Location = new System.Drawing.Point(344, 8);
            this.AppCloseToggle.Margin = new System.Windows.Forms.Padding(8);
            this.AppCloseToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.AppCloseToggle.Name = "AppCloseToggle";
            this.AppCloseToggle.Size = new System.Drawing.Size(49, 24);
            this.AppCloseToggle.TabIndex = 2;
            this.AppCloseToggle.UseVisualStyleBackColor = true;
            this.AppCloseToggle.CheckStateChanged += new System.EventHandler(this.AppCloseToggle_CheckStateChanged);
            // 
            // buttonToggle1
            // 
            this.buttonToggle1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToggle1.Checked = true;
            this.buttonToggle1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buttonToggle1.DisabledBackColor = System.Drawing.Color.Gray;
            this.buttonToggle1.DisabledToggleColor = System.Drawing.Color.Gainsboro;
            this.buttonToggle1.EnabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(168)))), ((int)(((byte)(164)))));
            this.buttonToggle1.EnabledToggleColor = System.Drawing.Color.WhiteSmoke;
            this.buttonToggle1.Location = new System.Drawing.Point(545, 8);
            this.buttonToggle1.Margin = new System.Windows.Forms.Padding(8);
            this.buttonToggle1.MinimumSize = new System.Drawing.Size(45, 22);
            this.buttonToggle1.Name = "buttonToggle1";
            this.buttonToggle1.Size = new System.Drawing.Size(49, 22);
            this.buttonToggle1.TabIndex = 1;
            this.buttonToggle1.UseVisualStyleBackColor = true;
            // 
            // AppCloseLabel
            // 
            this.AppCloseLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AppCloseLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppCloseLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AppCloseLabel.Location = new System.Drawing.Point(0, 0);
            this.AppCloseLabel.Name = "AppCloseLabel";
            this.AppCloseLabel.Size = new System.Drawing.Size(300, 40);
            this.AppCloseLabel.TabIndex = 0;
            this.AppCloseLabel.Text = "При закрытии окна сворачивать приложение в трэй";
            this.AppCloseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AppSettingsPanel
            // 
            this.AppSettingsPanel.Controls.Add(this.SaveApplicationSettings);
            this.AppSettingsPanel.Controls.Add(this.AppSettingsLabel);
            this.AppSettingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppSettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.AppSettingsPanel.Name = "AppSettingsPanel";
            this.AppSettingsPanel.Size = new System.Drawing.Size(401, 70);
            this.AppSettingsPanel.TabIndex = 1;
            // 
            // SaveApplicationSettings
            // 
            this.SaveApplicationSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveApplicationSettings.BackgroundImage = global::ClientApplication.Properties.Resources.IconSave;
            this.SaveApplicationSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SaveApplicationSettings.FlatAppearance.BorderSize = 0;
            this.SaveApplicationSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveApplicationSettings.Location = new System.Drawing.Point(346, 12);
            this.SaveApplicationSettings.Name = "SaveApplicationSettings";
            this.SaveApplicationSettings.Size = new System.Drawing.Size(43, 43);
            this.SaveApplicationSettings.TabIndex = 1;
            this.SaveApplicationSettings.UseVisualStyleBackColor = true;
            this.SaveApplicationSettings.Click += new System.EventHandler(this.SaveApplicationSettings_Click);
            // 
            // AppSettingsLabel
            // 
            this.AppSettingsLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AppSettingsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppSettingsLabel.Location = new System.Drawing.Point(0, 0);
            this.AppSettingsLabel.Name = "AppSettingsLabel";
            this.AppSettingsLabel.Size = new System.Drawing.Size(225, 70);
            this.AppSettingsLabel.TabIndex = 0;
            this.AppSettingsLabel.Text = "Приложение";
            this.AppSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(805, 500);
            this.Controls.Add(this.SeetingsContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.SeetingsContainer.Panel1.ResumeLayout(false);
            this.SeetingsContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SeetingsContainer)).EndInit();
            this.SeetingsContainer.ResumeLayout(false);
            this.AccountPanel.ResumeLayout(false);
            this.DarkThemePanel.ResumeLayout(false);
            this.AppClosePanel.ResumeLayout(false);
            this.AppSettingsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer SeetingsContainer;
        private Panel AccountPanel;
        private Label AccountLabel;
        private Panel AppSettingsPanel;
        private Label AppSettingsLabel;
        private Panel DarkThemePanel;
        private Label DarkThemeLabel;
        private UserControls.InputHandlers.ButtonToggle DarkThemeToggle;
        private Button SaveApplicationSettings;
        private Panel AppClosePanel;
        private UserControls.InputHandlers.ButtonToggle AppCloseToggle;
        private UserControls.InputHandlers.ButtonToggle buttonToggle1;
        private Label AppCloseLabel;
    }
}