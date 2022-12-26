namespace ClientApplication.UserControls.OutputHandlers
{
    partial class DevicePanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonOptions = new ClientApplication.UserControls.InputHandlers.ButtonCustom();
            this.DeviceID = new System.Windows.Forms.Label();
            this.DeviceName = new System.Windows.Forms.Label();
            this.OpenSensorTab = new ClientApplication.UserControls.InputHandlers.ButtonCustom();
            this.IpLabel = new System.Windows.Forms.Label();
            this.DeviceIpAdress = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.DeviceRealAdress = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DeviceOptions = new ClientApplication.UserControls.InputHandlers.DropdownMenu(this.components);
            this.открытьВНовомОкнеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeviceOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonOptions
            // 
            this.ButtonOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonOptions.Checked = false;
            this.ButtonOptions.FlatAppearance.BorderSize = 0;
            this.ButtonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.ButtonOptions.IconDark = global::ClientApplication.Properties.Resources.IconOptionsDark;
            this.ButtonOptions.IconHighLight = global::ClientApplication.Properties.Resources.IconOptionsMain;
            this.ButtonOptions.IconLight = global::ClientApplication.Properties.Resources.IconOptionsLight;
            this.ButtonOptions.Image = global::ClientApplication.Properties.Resources.IconOptionsDark;
            this.ButtonOptions.Location = new System.Drawing.Point(370, 13);
            this.ButtonOptions.MainOnClick = true;
            this.ButtonOptions.Name = "ButtonOptions";
            this.ButtonOptions.OnPanel = false;
            this.ButtonOptions.Size = new System.Drawing.Size(40, 40);
            this.ButtonOptions.TabIndex = 1;
            this.ButtonOptions.UseVisualStyleBackColor = true;
            this.ButtonOptions.Click += new System.EventHandler(this.ButtonOptions_Click);
            // 
            // DeviceID
            // 
            this.DeviceID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeviceID.Location = new System.Drawing.Point(114, 13);
            this.DeviceID.Name = "DeviceID";
            this.DeviceID.Size = new System.Drawing.Size(250, 20);
            this.DeviceID.TabIndex = 2;
            this.DeviceID.Text = "999999999";
            // 
            // DeviceName
            // 
            this.DeviceName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeviceName.Location = new System.Drawing.Point(114, 33);
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Size = new System.Drawing.Size(250, 20);
            this.DeviceName.TabIndex = 3;
            this.DeviceName.Text = "PlaceHolder";
            // 
            // OpenSensorTab
            // 
            this.OpenSensorTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OpenSensorTab.Checked = false;
            this.OpenSensorTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenSensorTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OpenSensorTab.FlatAppearance.BorderSize = 0;
            this.OpenSensorTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenSensorTab.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenSensorTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(123)))));
            this.OpenSensorTab.IconDark = null;
            this.OpenSensorTab.IconHighLight = null;
            this.OpenSensorTab.IconLight = null;
            this.OpenSensorTab.Location = new System.Drawing.Point(10, 125);
            this.OpenSensorTab.MainOnClick = false;
            this.OpenSensorTab.Name = "OpenSensorTab";
            this.OpenSensorTab.OnPanel = false;
            this.OpenSensorTab.Size = new System.Drawing.Size(400, 40);
            this.OpenSensorTab.TabIndex = 5;
            this.OpenSensorTab.Text = "Открыть";
            this.OpenSensorTab.UseVisualStyleBackColor = true;
            this.OpenSensorTab.Click += new System.EventHandler(this.OpenSensorTab_Click);
            // 
            // IpLabel
            // 
            this.IpLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IpLabel.Location = new System.Drawing.Point(13, 53);
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(95, 20);
            this.IpLabel.TabIndex = 6;
            this.IpLabel.Text = "Ip адрес";
            // 
            // DeviceIpAdress
            // 
            this.DeviceIpAdress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeviceIpAdress.Location = new System.Drawing.Point(114, 53);
            this.DeviceIpAdress.Name = "DeviceIpAdress";
            this.DeviceIpAdress.Size = new System.Drawing.Size(296, 20);
            this.DeviceIpAdress.TabIndex = 7;
            this.DeviceIpAdress.Text = "111.111.111.111";
            // 
            // AdressLabel
            // 
            this.AdressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdressLabel.Location = new System.Drawing.Point(13, 73);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(95, 20);
            this.AdressLabel.TabIndex = 8;
            this.AdressLabel.Text = "Физ. адрес";
            // 
            // DeviceRealAdress
            // 
            this.DeviceRealAdress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeviceRealAdress.Location = new System.Drawing.Point(114, 73);
            this.DeviceRealAdress.Name = "DeviceRealAdress";
            this.DeviceRealAdress.Size = new System.Drawing.Size(296, 45);
            this.DeviceRealAdress.TabIndex = 9;
            this.DeviceRealAdress.Text = "PlaceHolder\r\nPlaceHolder";
            // 
            // IdLabel
            // 
            this.IdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.Location = new System.Drawing.Point(13, 13);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(95, 20);
            this.IdLabel.TabIndex = 11;
            this.IdLabel.Text = "ID";
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(13, 33);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(95, 20);
            this.NameLabel.TabIndex = 12;
            this.NameLabel.Text = "Название";
            // 
            // DeviceOptions
            // 
            this.DeviceOptions.IsMainMenu = false;
            this.DeviceOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьВНовомОкнеToolStripMenuItem});
            this.DeviceOptions.MenuItemHeight = 25;
            this.DeviceOptions.MenuItemTextColor = System.Drawing.Color.Empty;
            this.DeviceOptions.Name = "DeviceOptions";
            this.DeviceOptions.PrimaryColor = System.Drawing.Color.Empty;
            this.DeviceOptions.Size = new System.Drawing.Size(199, 26);
            // 
            // открытьВНовомОкнеToolStripMenuItem
            // 
            this.открытьВНовомОкнеToolStripMenuItem.Name = "открытьВНовомОкнеToolStripMenuItem";
            this.открытьВНовомОкнеToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.открытьВНовомОкнеToolStripMenuItem.Text = "Открыть в новом окне";
            // 
            // DevicePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.DeviceRealAdress);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.DeviceIpAdress);
            this.Controls.Add(this.IpLabel);
            this.Controls.Add(this.OpenSensorTab);
            this.Controls.Add(this.DeviceName);
            this.Controls.Add(this.DeviceID);
            this.Controls.Add(this.ButtonOptions);
            this.Name = "DevicePanel";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(420, 175);
            this.Tag = "Fixed";
            this.Load += new System.EventHandler(this.DevicePanel_Load);
            this.Resize += new System.EventHandler(this.DevicePanel_Resize);
            this.DeviceOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private InputHandlers.ButtonCustom ButtonOptions;
        private Label DeviceID;
        private Label DeviceName;
        private InputHandlers.ButtonCustom OpenSensorTab;
        private Label IpLabel;
        private Label DeviceIpAdress;
        private Label AdressLabel;
        private Label DeviceRealAdress;
        private Label IdLabel;
        private Label NameLabel;
        private InputHandlers.DropdownMenu DeviceOptions;
        private ToolStripMenuItem открытьВНовомОкнеToolStripMenuItem;
    }
}
