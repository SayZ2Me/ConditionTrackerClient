namespace ClientApplication
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.ButtonContainer = new System.Windows.Forms.Panel();
            this.Submit = new ClientApplication.UserControls.InputHandlers.ButtonCustom();
            this.SaveEmailPanel = new System.Windows.Forms.Panel();
            this.SaveEmailToggle = new ClientApplication.UserControls.InputHandlers.ButtonToggle();
            this.SaveEmailLabel = new System.Windows.Forms.Label();
            this.SplitterPanel3 = new System.Windows.Forms.Panel();
            this.Password = new ClientApplication.UserControls.InputHandlers.TextBoxCustom();
            this.SplitterPanel2 = new System.Windows.Forms.Panel();
            this.Email = new ClientApplication.UserControls.InputHandlers.TextBoxCustom();
            this.SplitterPanel1 = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose1 = new ClientApplication.UserControls.ButtonClose();
            this.ImagePanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.ButtonContainer.SuspendLayout();
            this.SaveEmailPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImagePanel
            // 
            this.ImagePanel.BackColor = System.Drawing.Color.Transparent;
            this.ImagePanel.BackgroundImage = global::ClientApplication.Properties.Resources.LoginFade;
            this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImagePanel.Controls.Add(this.label1);
            this.ImagePanel.Controls.Add(this.version);
            this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ImagePanel.Location = new System.Drawing.Point(0, 0);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(350, 640);
            this.ImagePanel.TabIndex = 0;
            this.ImagePanel.Tag = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 95);
            this.label1.TabIndex = 1;
            this.label1.Tag = "Fixed";
            this.label1.Text = "Предиктивная аналитика\r\nВерсии 0.0.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // version
            // 
            this.version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.version.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.version.Location = new System.Drawing.Point(250, 0);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(100, 95);
            this.version.TabIndex = 0;
            this.version.Tag = "Fixed";
            this.version.Text = "Версия\r\n0.0.5";
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPanel.Controls.Add(this.ButtonContainer);
            this.LoginPanel.Controls.Add(this.SaveEmailPanel);
            this.LoginPanel.Controls.Add(this.SplitterPanel3);
            this.LoginPanel.Controls.Add(this.Password);
            this.LoginPanel.Controls.Add(this.SplitterPanel2);
            this.LoginPanel.Controls.Add(this.Email);
            this.LoginPanel.Controls.Add(this.SplitterPanel1);
            this.LoginPanel.Controls.Add(this.LogoPanel);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(350, 60);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Padding = new System.Windows.Forms.Padding(100, 0, 100, 100);
            this.LoginPanel.Size = new System.Drawing.Size(610, 580);
            this.LoginPanel.TabIndex = 1;
            this.LoginPanel.Tag = "Background";
            // 
            // ButtonContainer
            // 
            this.ButtonContainer.Controls.Add(this.Submit);
            this.ButtonContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonContainer.Location = new System.Drawing.Point(100, 380);
            this.ButtonContainer.Name = "ButtonContainer";
            this.ButtonContainer.Padding = new System.Windows.Forms.Padding(40);
            this.ButtonContainer.Size = new System.Drawing.Size(410, 120);
            this.ButtonContainer.TabIndex = 6;
            this.ButtonContainer.Tag = "";
            // 
            // Submit
            // 
            this.Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Submit.Checked = false;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.Submit.IconDark = null;
            this.Submit.IconHighLight = null;
            this.Submit.IconLight = null;
            this.Submit.Location = new System.Drawing.Point(40, 40);
            this.Submit.MainOnClick = false;
            this.Submit.Name = "Submit";
            this.Submit.OnPanel = false;
            this.Submit.Size = new System.Drawing.Size(330, 40);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Войти";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Enter_Click);
            // 
            // SaveEmailPanel
            // 
            this.SaveEmailPanel.BackColor = System.Drawing.SystemColors.Control;
            this.SaveEmailPanel.Controls.Add(this.SaveEmailToggle);
            this.SaveEmailPanel.Controls.Add(this.SaveEmailLabel);
            this.SaveEmailPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveEmailPanel.Location = new System.Drawing.Point(100, 340);
            this.SaveEmailPanel.Name = "SaveEmailPanel";
            this.SaveEmailPanel.Size = new System.Drawing.Size(410, 40);
            this.SaveEmailPanel.TabIndex = 8;
            this.SaveEmailPanel.Tag = "BackGround";
            // 
            // SaveEmailToggle
            // 
            this.SaveEmailToggle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveEmailToggle.Location = new System.Drawing.Point(349, 8);
            this.SaveEmailToggle.Margin = new System.Windows.Forms.Padding(8);
            this.SaveEmailToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.SaveEmailToggle.Name = "SaveEmailToggle";
            this.SaveEmailToggle.Size = new System.Drawing.Size(49, 24);
            this.SaveEmailToggle.TabIndex = 3;
            this.SaveEmailToggle.TabStop = false;
            this.SaveEmailToggle.UseVisualStyleBackColor = true;
            // 
            // SaveEmailLabel
            // 
            this.SaveEmailLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveEmailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(240)))));
            this.SaveEmailLabel.Location = new System.Drawing.Point(0, 0);
            this.SaveEmailLabel.Name = "SaveEmailLabel";
            this.SaveEmailLabel.Size = new System.Drawing.Size(338, 40);
            this.SaveEmailLabel.TabIndex = 0;
            this.SaveEmailLabel.Tag = "Fixed";
            this.SaveEmailLabel.Text = "Сохранить адрес электронной почты";
            this.SaveEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SplitterPanel3
            // 
            this.SplitterPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitterPanel3.Location = new System.Drawing.Point(100, 300);
            this.SplitterPanel3.Name = "SplitterPanel3";
            this.SplitterPanel3.Size = new System.Drawing.Size(410, 40);
            this.SplitterPanel3.TabIndex = 7;
            this.SplitterPanel3.Tag = "";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.Password.BackgroundImage = global::ClientApplication.Properties.Resources.IconLockLight;
            this.Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.Password.Location = new System.Drawing.Point(100, 260);
            this.Password.MinimumSize = new System.Drawing.Size(120, 40);
            this.Password.Name = "Password";
            this.Password.PlaceholderText = "Введите пароль";
            this.Password.Size = new System.Drawing.Size(410, 40);
            this.Password.TabIndex = 1;
            this.Password.Tag = "";
            this.Password.UseSystemPasswordChar = true;
            // 
            // SplitterPanel2
            // 
            this.SplitterPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitterPanel2.Location = new System.Drawing.Point(100, 220);
            this.SplitterPanel2.Name = "SplitterPanel2";
            this.SplitterPanel2.Size = new System.Drawing.Size(410, 40);
            this.SplitterPanel2.TabIndex = 5;
            this.SplitterPanel2.Tag = "";
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.Email.BackgroundImage = global::ClientApplication.Properties.Resources.IconUserLight;
            this.Email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Email.Dock = System.Windows.Forms.DockStyle.Top;
            this.Email.Location = new System.Drawing.Point(100, 180);
            this.Email.MinimumSize = new System.Drawing.Size(120, 40);
            this.Email.Name = "Email";
            this.Email.PlaceholderText = "Введите адрес электронной почты";
            this.Email.Size = new System.Drawing.Size(410, 40);
            this.Email.TabIndex = 0;
            this.Email.Tag = "";
            this.Email.UseSystemPasswordChar = false;
            // 
            // SplitterPanel1
            // 
            this.SplitterPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitterPanel1.Location = new System.Drawing.Point(100, 140);
            this.SplitterPanel1.Name = "SplitterPanel1";
            this.SplitterPanel1.Size = new System.Drawing.Size(410, 40);
            this.SplitterPanel1.TabIndex = 4;
            this.SplitterPanel1.Tag = "";
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackgroundImage = global::ClientApplication.Properties.Resources.LoginBanner;
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(100, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(410, 140);
            this.LogoPanel.TabIndex = 2;
            this.LogoPanel.Tag = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClose1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(350, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(610, 60);
            this.panel1.TabIndex = 2;
            this.panel1.Tag = "Background";
            // 
            // buttonClose1
            // 
            this.buttonClose1.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose1.BackgroundImage")));
            this.buttonClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClose1.hideWindow = false;
            this.buttonClose1.Location = new System.Drawing.Point(607, 12);
            this.buttonClose1.Name = "buttonClose1";
            this.buttonClose1.Size = new System.Drawing.Size(21, 21);
            this.buttonClose1.TabIndex = 0;
            this.buttonClose1.Tag = "Fixed";
            // 
            // Login
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.ControlBox = false;
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ImagePanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(960, 640);
            this.MinimumSize = new System.Drawing.Size(960, 640);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ImagePanel.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.ButtonContainer.ResumeLayout(false);
            this.SaveEmailPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ImagePanel;
        private Panel LoginPanel;
        private UserControls.InputHandlers.TextBoxCustom Password;
        private UserControls.InputHandlers.TextBoxCustom Email;
        private Panel LogoPanel;
        private Panel ButtonContainer;
        private Panel SplitterPanel2;
        private Panel SplitterPanel1;
        private UserControls.InputHandlers.ButtonCustom Submit;
        private Panel SaveEmailPanel;
        private Panel SplitterPanel3;
        private Label SaveEmailLabel;
        private UserControls.InputHandlers.ButtonToggle SaveEmailToggle;
        private Panel panel1;
        private UserControls.ButtonClose buttonClose1;
        private Label version;
        private Label label1;
    }
}