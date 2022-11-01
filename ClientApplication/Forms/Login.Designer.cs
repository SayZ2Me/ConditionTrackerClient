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
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.ButtonContainer = new System.Windows.Forms.Panel();
            this.Submit = new System.Windows.Forms.Button();
            this.Password = new ClientApplication.UserControls.InputHandlers.TextBox();
            this.SplitterPanel2 = new System.Windows.Forms.Panel();
            this.Username = new ClientApplication.UserControls.InputHandlers.TextBox();
            this.SplitterPanel1 = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LoginPanel.SuspendLayout();
            this.ButtonContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImagePanel
            // 
            this.ImagePanel.BackColor = System.Drawing.Color.Transparent;
            this.ImagePanel.BackgroundImage = global::ClientApplication.Properties.Resources.ButtonCloseEnter;
            this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ImagePanel.Location = new System.Drawing.Point(0, 0);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(320, 640);
            this.ImagePanel.TabIndex = 0;
            this.ImagePanel.Tag = "Fixed";
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPanel.Controls.Add(this.ButtonContainer);
            this.LoginPanel.Controls.Add(this.Password);
            this.LoginPanel.Controls.Add(this.SplitterPanel2);
            this.LoginPanel.Controls.Add(this.Username);
            this.LoginPanel.Controls.Add(this.SplitterPanel1);
            this.LoginPanel.Controls.Add(this.LogoPanel);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(320, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Padding = new System.Windows.Forms.Padding(100);
            this.LoginPanel.Size = new System.Drawing.Size(640, 640);
            this.LoginPanel.TabIndex = 1;
            this.LoginPanel.Tag = "Fixed";
            // 
            // ButtonContainer
            // 
            this.ButtonContainer.Controls.Add(this.Submit);
            this.ButtonContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonContainer.Location = new System.Drawing.Point(100, 400);
            this.ButtonContainer.Name = "ButtonContainer";
            this.ButtonContainer.Padding = new System.Windows.Forms.Padding(40);
            this.ButtonContainer.Size = new System.Drawing.Size(440, 120);
            this.ButtonContainer.TabIndex = 6;
            this.ButtonContainer.Tag = "Fixed";
            // 
            // Submit
            // 
            this.Submit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Submit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Submit.Location = new System.Drawing.Point(40, 40);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(360, 40);
            this.Submit.TabIndex = 3;
            this.Submit.Tag = "Button";
            this.Submit.Text = "Войти";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.Password.BackgroundImage = global::ClientApplication.Properties.Resources.IconLock;
            this.Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.Password.Location = new System.Drawing.Point(100, 360);
            this.Password.MinimumSize = new System.Drawing.Size(120, 40);
            this.Password.Name = "Password";
            this.Password.PlaceholderText = "Введите пароль";
            this.Password.Size = new System.Drawing.Size(440, 40);
            this.Password.TabIndex = 1;
            this.Password.Tag = "Fixed";
            this.Password.UseSystemPasswordChar = true;
            // 
            // SplitterPanel2
            // 
            this.SplitterPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitterPanel2.Location = new System.Drawing.Point(100, 320);
            this.SplitterPanel2.Name = "SplitterPanel2";
            this.SplitterPanel2.Size = new System.Drawing.Size(440, 40);
            this.SplitterPanel2.TabIndex = 5;
            this.SplitterPanel2.Tag = "Fixed";
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.Username.BackgroundImage = global::ClientApplication.Properties.Resources.IconUser;
            this.Username.Dock = System.Windows.Forms.DockStyle.Top;
            this.Username.Location = new System.Drawing.Point(100, 280);
            this.Username.MinimumSize = new System.Drawing.Size(120, 40);
            this.Username.Name = "Username";
            this.Username.PlaceholderText = "Введите логин";
            this.Username.Size = new System.Drawing.Size(440, 40);
            this.Username.TabIndex = 0;
            this.Username.Tag = "Fixed";
            this.Username.UseSystemPasswordChar = false;
            // 
            // SplitterPanel1
            // 
            this.SplitterPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitterPanel1.Location = new System.Drawing.Point(100, 240);
            this.SplitterPanel1.Name = "SplitterPanel1";
            this.SplitterPanel1.Size = new System.Drawing.Size(440, 40);
            this.SplitterPanel1.TabIndex = 4;
            this.SplitterPanel1.Tag = "Fixed";
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackgroundImage = global::ClientApplication.Properties.Resources.ButtonCloseEnter;
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(100, 100);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(440, 140);
            this.LogoPanel.TabIndex = 2;
            this.LogoPanel.Tag = "Fixed";
            // 
            // Login
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.ImagePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(960, 640);
            this.MinimumSize = new System.Drawing.Size(960, 640);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.LoginPanel.ResumeLayout(false);
            this.ButtonContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ImagePanel;
        private Panel LoginPanel;
        private UserControls.InputHandlers.TextBox Password;
        private UserControls.InputHandlers.TextBox Username;
        private Button Submit;
        private Panel LogoPanel;
        private Panel ButtonContainer;
        private Panel SplitterPanel2;
        private Panel SplitterPanel1;
    }
}