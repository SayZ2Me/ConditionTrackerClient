namespace ClientApplication.Forms.WorkPanels
{
    partial class Devices
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
            this.DevicesPanel = new System.Windows.Forms.Panel();
            this.DevicesLabel = new System.Windows.Forms.Label();
            this.DevicesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DevicesPanel
            // 
            this.DevicesPanel.Controls.Add(this.DevicesLabel);
            this.DevicesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DevicesPanel.Location = new System.Drawing.Point(0, 0);
            this.DevicesPanel.Name = "DevicesPanel";
            this.DevicesPanel.Size = new System.Drawing.Size(800, 70);
            this.DevicesPanel.TabIndex = 3;
            // 
            // DevicesLabel
            // 
            this.DevicesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DevicesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DevicesLabel.Location = new System.Drawing.Point(0, 0);
            this.DevicesLabel.Name = "DevicesLabel";
            this.DevicesLabel.Size = new System.Drawing.Size(800, 70);
            this.DevicesLabel.TabIndex = 0;
            this.DevicesLabel.Text = "Устройства";
            // 
            // Devices
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DevicesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Devices";
            this.Text = "Devices";
            this.Load += new System.EventHandler(this.Devices_Load);
            this.DevicesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel DevicesPanel;
        private Label DevicesLabel;
    }
}