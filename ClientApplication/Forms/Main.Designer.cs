﻿namespace ClientApplication.Forms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Header = new System.Windows.Forms.Panel();
            this.buttonMinimize1 = new ClientApplication.UserControls.ButtonMinimize();
            this.buttonClose1 = new ClientApplication.UserControls.ButtonClose();
            this.buttonMaximize1 = new ClientApplication.UserControls.ButtonMaximize();
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.ButtonShutdown = new ClientApplication.UserControls.InputHandlers.ButtonCustom();
            this.ShutdownMenu = new ClientApplication.UserControls.InputHandlers.DropdownMenu(this.components);
            this.LogoutShutdownMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MinimizeToTrayShutdownMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitApplicationShutdownMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ButtonSettings = new ClientApplication.UserControls.InputHandlers.ButtonCustom();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ButtonMonitoring = new ClientApplication.UserControls.InputHandlers.ButtonCustom();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonDevices = new ClientApplication.UserControls.InputHandlers.ButtonCustom();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonHome = new ClientApplication.UserControls.InputHandlers.ButtonCustom();
            this.hidePanel1 = new ClientApplication.UserControls.ElementContainers.HidePanel();
            this.WorkPanel = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            this.ToolPanel.SuspendLayout();
            this.ShutdownMenu.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.Header.Controls.Add(this.buttonMinimize1);
            this.Header.Controls.Add(this.buttonClose1);
            this.Header.Controls.Add(this.buttonMaximize1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(2, 2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(940, 30);
            this.Header.TabIndex = 0;
            this.Header.Tag = "Header";
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // buttonMinimize1
            // 
            this.buttonMinimize1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize1.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize1.BackgroundImage = global::ClientApplication.Properties.Resources.ButtonMinimize;
            this.buttonMinimize1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMinimize1.Location = new System.Drawing.Point(830, 2);
            this.buttonMinimize1.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.buttonMinimize1.Name = "buttonMinimize1";
            this.buttonMinimize1.Size = new System.Drawing.Size(36, 26);
            this.buttonMinimize1.TabIndex = 1;
            this.buttonMinimize1.Tag = "Fixed";
            // 
            // buttonClose1
            // 
            this.buttonClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose1.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose1.BackgroundImage = global::ClientApplication.Properties.Resources.ButtonClose;
            this.buttonClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClose1.hideWindow = false;
            this.buttonClose1.Location = new System.Drawing.Point(902, 2);
            this.buttonClose1.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.buttonClose1.Name = "buttonClose1";
            this.buttonClose1.Size = new System.Drawing.Size(36, 26);
            this.buttonClose1.TabIndex = 0;
            this.buttonClose1.Tag = "Fixed";
            // 
            // buttonMaximize1
            // 
            this.buttonMaximize1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize1.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaximize1.BackgroundImage = global::ClientApplication.Properties.Resources.ButtonMaximize;
            this.buttonMaximize1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMaximize1.Location = new System.Drawing.Point(866, 2);
            this.buttonMaximize1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.buttonMaximize1.Name = "buttonMaximize1";
            this.buttonMaximize1.Size = new System.Drawing.Size(36, 26);
            this.buttonMaximize1.TabIndex = 1;
            this.buttonMaximize1.Tag = "Fixed";
            // 
            // ToolPanel
            // 
            this.ToolPanel.Controls.Add(this.ButtonShutdown);
            this.ToolPanel.Controls.Add(this.panel5);
            this.ToolPanel.Controls.Add(this.panel4);
            this.ToolPanel.Controls.Add(this.panel3);
            this.ToolPanel.Controls.Add(this.panel2);
            this.ToolPanel.Controls.Add(this.hidePanel1);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolPanel.Location = new System.Drawing.Point(2, 32);
            this.ToolPanel.MaximumSize = new System.Drawing.Size(243, 0);
            this.ToolPanel.MinimumSize = new System.Drawing.Size(43, 0);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(43, 467);
            this.ToolPanel.TabIndex = 1;
            this.ToolPanel.Tag = "BackGround";
            // 
            // ButtonShutdown
            // 
            this.ButtonShutdown.BackColor = System.Drawing.Color.Transparent;
            this.ButtonShutdown.Checked = false;
            this.ButtonShutdown.ContextMenuStrip = this.ShutdownMenu;
            this.ButtonShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShutdown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonShutdown.FlatAppearance.BorderSize = 0;
            this.ButtonShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShutdown.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonShutdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.ButtonShutdown.IconDark = global::ClientApplication.Properties.Resources.IconShutdownDark;
            this.ButtonShutdown.IconHighLight = global::ClientApplication.Properties.Resources.IconShutdownMain;
            this.ButtonShutdown.IconLight = global::ClientApplication.Properties.Resources.IconShutdownLight;
            this.ButtonShutdown.Image = global::ClientApplication.Properties.Resources.IconShutdownDark;
            this.ButtonShutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShutdown.Location = new System.Drawing.Point(0, 424);
            this.ButtonShutdown.MainOnClick = false;
            this.ButtonShutdown.Name = "ButtonShutdown";
            this.ButtonShutdown.OnPanel = false;
            this.ButtonShutdown.Size = new System.Drawing.Size(43, 43);
            this.ButtonShutdown.TabIndex = 3;
            this.ButtonShutdown.Text = "    Завершение";
            this.ButtonShutdown.UseVisualStyleBackColor = false;
            this.ButtonShutdown.Click += new System.EventHandler(this.ButtonShutdown_Click);
            // 
            // ShutdownMenu
            // 
            this.ShutdownMenu.IsMainMenu = false;
            this.ShutdownMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutShutdownMenuButton,
            this.MinimizeToTrayShutdownMenuButton,
            this.ExitApplicationShutdownMenuButton});
            this.ShutdownMenu.MenuItemHeight = 25;
            this.ShutdownMenu.MenuItemTextColor = System.Drawing.Color.Empty;
            this.ShutdownMenu.Name = "ShutdownMenu";
            this.ShutdownMenu.PrimaryColor = System.Drawing.Color.Empty;
            this.ShutdownMenu.Size = new System.Drawing.Size(176, 70);
            // 
            // LogoutShutdownMenuButton
            // 
            this.LogoutShutdownMenuButton.Name = "LogoutShutdownMenuButton";
            this.LogoutShutdownMenuButton.Size = new System.Drawing.Size(175, 22);
            this.LogoutShutdownMenuButton.Text = "Выйти из системы";
            this.LogoutShutdownMenuButton.Click += new System.EventHandler(this.LogoutShutdownMenuButton_Click);
            // 
            // MinimizeToTrayShutdownMenuButton
            // 
            this.MinimizeToTrayShutdownMenuButton.Name = "MinimizeToTrayShutdownMenuButton";
            this.MinimizeToTrayShutdownMenuButton.Size = new System.Drawing.Size(175, 22);
            this.MinimizeToTrayShutdownMenuButton.Text = "Свернуть в трей";
            this.MinimizeToTrayShutdownMenuButton.Click += new System.EventHandler(this.MinimizeToTrayShutdownMenuButton_Click);
            // 
            // ExitApplicationShutdownMenuButton
            // 
            this.ExitApplicationShutdownMenuButton.Name = "ExitApplicationShutdownMenuButton";
            this.ExitApplicationShutdownMenuButton.Size = new System.Drawing.Size(175, 22);
            this.ExitApplicationShutdownMenuButton.Text = "Завершить сеанс";
            this.ExitApplicationShutdownMenuButton.Click += new System.EventHandler(this.ExitApplicationShutdownMenuButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.ButtonSettings);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 187);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel5.Size = new System.Drawing.Size(43, 48);
            this.panel5.TabIndex = 5;
            this.panel5.Tag = "Fixed";
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSettings.Checked = false;
            this.ButtonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSettings.FlatAppearance.BorderSize = 0;
            this.ButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.ButtonSettings.IconDark = global::ClientApplication.Properties.Resources.IconSettingsDark;
            this.ButtonSettings.IconHighLight = global::ClientApplication.Properties.Resources.IconSettingsMain;
            this.ButtonSettings.IconLight = global::ClientApplication.Properties.Resources.IconSettingsLight;
            this.ButtonSettings.Image = global::ClientApplication.Properties.Resources.IconSettingsDark;
            this.ButtonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSettings.Location = new System.Drawing.Point(0, 5);
            this.ButtonSettings.MainOnClick = false;
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.OnPanel = false;
            this.ButtonSettings.Size = new System.Drawing.Size(43, 43);
            this.ButtonSettings.TabIndex = 3;
            this.ButtonSettings.Text = "    Настройки";
            this.ButtonSettings.UseVisualStyleBackColor = false;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.ButtonMonitoring);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 139);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel4.Size = new System.Drawing.Size(43, 48);
            this.panel4.TabIndex = 4;
            this.panel4.Tag = "Fixed";
            // 
            // ButtonMonitoring
            // 
            this.ButtonMonitoring.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMonitoring.Checked = false;
            this.ButtonMonitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMonitoring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonMonitoring.FlatAppearance.BorderSize = 0;
            this.ButtonMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMonitoring.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonMonitoring.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.ButtonMonitoring.IconDark = global::ClientApplication.Properties.Resources.IconMonitorDark;
            this.ButtonMonitoring.IconHighLight = global::ClientApplication.Properties.Resources.IconMonitorMain;
            this.ButtonMonitoring.IconLight = global::ClientApplication.Properties.Resources.IconMonitorLight;
            this.ButtonMonitoring.Image = global::ClientApplication.Properties.Resources.IconMonitorDark;
            this.ButtonMonitoring.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonMonitoring.Location = new System.Drawing.Point(0, 5);
            this.ButtonMonitoring.MainOnClick = false;
            this.ButtonMonitoring.Name = "ButtonMonitoring";
            this.ButtonMonitoring.OnPanel = false;
            this.ButtonMonitoring.Size = new System.Drawing.Size(43, 43);
            this.ButtonMonitoring.TabIndex = 2;
            this.ButtonMonitoring.Text = "    Мониторинг";
            this.ButtonMonitoring.UseVisualStyleBackColor = false;
            this.ButtonMonitoring.Click += new System.EventHandler(this.ButtonMonitoring_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.ButtonDevices);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 91);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel3.Size = new System.Drawing.Size(43, 48);
            this.panel3.TabIndex = 3;
            this.panel3.Tag = "Fixed";
            // 
            // ButtonDevices
            // 
            this.ButtonDevices.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDevices.Checked = false;
            this.ButtonDevices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDevices.FlatAppearance.BorderSize = 0;
            this.ButtonDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDevices.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.ButtonDevices.IconDark = global::ClientApplication.Properties.Resources.IconDevicesDark;
            this.ButtonDevices.IconHighLight = global::ClientApplication.Properties.Resources.IconDevicesMain;
            this.ButtonDevices.IconLight = global::ClientApplication.Properties.Resources.IconDevicesLight;
            this.ButtonDevices.Image = global::ClientApplication.Properties.Resources.IconDevicesDark;
            this.ButtonDevices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDevices.Location = new System.Drawing.Point(0, 5);
            this.ButtonDevices.MainOnClick = false;
            this.ButtonDevices.Name = "ButtonDevices";
            this.ButtonDevices.OnPanel = false;
            this.ButtonDevices.Size = new System.Drawing.Size(43, 43);
            this.ButtonDevices.TabIndex = 1;
            this.ButtonDevices.Text = "    Устройства";
            this.ButtonDevices.UseVisualStyleBackColor = false;
            this.ButtonDevices.Click += new System.EventHandler(this.ButtonDevices_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.ButtonHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(43, 48);
            this.panel2.TabIndex = 2;
            this.panel2.Tag = "Fixed";
            // 
            // ButtonHome
            // 
            this.ButtonHome.BackColor = System.Drawing.Color.Transparent;
            this.ButtonHome.Checked = false;
            this.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonHome.FlatAppearance.BorderSize = 0;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.ButtonHome.IconDark = global::ClientApplication.Properties.Resources.IconHomeDark;
            this.ButtonHome.IconHighLight = global::ClientApplication.Properties.Resources.IconHomeMain;
            this.ButtonHome.IconLight = global::ClientApplication.Properties.Resources.IconHomeLight;
            this.ButtonHome.Image = global::ClientApplication.Properties.Resources.IconHomeDark;
            this.ButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonHome.Location = new System.Drawing.Point(0, 5);
            this.ButtonHome.MainOnClick = false;
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.OnPanel = false;
            this.ButtonHome.Size = new System.Drawing.Size(43, 43);
            this.ButtonHome.TabIndex = 0;
            this.ButtonHome.Text = "    Домашняя";
            this.ButtonHome.UseVisualStyleBackColor = false;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // hidePanel1
            // 
            this.hidePanel1.BackColor = System.Drawing.Color.Transparent;
            this.hidePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hidePanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hidePanel1.IconHideDark = global::ClientApplication.Properties.Resources.IconLeftDark;
            this.hidePanel1.IconHideLight = global::ClientApplication.Properties.Resources.IconLeftLight;
            this.hidePanel1.IconHideMain = global::ClientApplication.Properties.Resources.IconLeftMain;
            this.hidePanel1.IconShowDark = global::ClientApplication.Properties.Resources.IconRightDark;
            this.hidePanel1.IconShowLight = global::ClientApplication.Properties.Resources.IconRightLight;
            this.hidePanel1.IconShowMain = global::ClientApplication.Properties.Resources.IconRightMain;
            this.hidePanel1.Location = new System.Drawing.Point(0, 0);
            this.hidePanel1.MaxWidth = 243;
            this.hidePanel1.MinWidth = 43;
            this.hidePanel1.Name = "hidePanel1";
            this.hidePanel1.Size = new System.Drawing.Size(43, 43);
            this.hidePanel1.Step = 20;
            this.hidePanel1.TabIndex = 0;
            this.hidePanel1.Tag = "Fixed";
            // 
            // WorkPanel
            // 
            this.WorkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkPanel.Location = new System.Drawing.Point(45, 32);
            this.WorkPanel.Name = "WorkPanel";
            this.WorkPanel.Size = new System.Drawing.Size(897, 467);
            this.WorkPanel.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.WorkPanel);
            this.Controls.Add(this.ToolPanel);
            this.Controls.Add(this.Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Header.ResumeLayout(false);
            this.ToolPanel.ResumeLayout(false);
            this.ShutdownMenu.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Header;
        private UserControls.ButtonMinimize buttonMinimize1;
        private UserControls.ButtonMaximize buttonMaximize1;
        private UserControls.ButtonClose buttonClose1;
        private Panel ToolPanel;
        private UserControls.InputHandlers.DropdownMenu ShutdownMenu;
        private ToolStripMenuItem LogoutShutdownMenuButton;
        private ToolStripMenuItem MinimizeToTrayShutdownMenuButton;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private ToolStripMenuItem ExitApplicationShutdownMenuButton;
        private UserControls.InputHandlers.ButtonCustom ButtonHome;
        private UserControls.ElementContainers.HidePanel hidePanel1;
        private UserControls.InputHandlers.ButtonCustom ButtonSettings;
        private UserControls.InputHandlers.ButtonCustom ButtonMonitoring;
        private UserControls.InputHandlers.ButtonCustom ButtonDevices;
        private UserControls.InputHandlers.ButtonCustom ButtonShutdown;
        private Panel WorkPanel;
    }
}