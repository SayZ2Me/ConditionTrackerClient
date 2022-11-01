namespace ClientApplication.Forms.WorkPanels
{
    partial class Monitoring
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
            this.MonitoringPanel = new System.Windows.Forms.Panel();
            this.MonitoringLabel = new System.Windows.Forms.Label();
            this.MonitoringPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MonitoringPanel
            // 
            this.MonitoringPanel.Controls.Add(this.MonitoringLabel);
            this.MonitoringPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MonitoringPanel.Location = new System.Drawing.Point(0, 0);
            this.MonitoringPanel.Name = "MonitoringPanel";
            this.MonitoringPanel.Size = new System.Drawing.Size(800, 70);
            this.MonitoringPanel.TabIndex = 3;
            // 
            // MonitoringLabel
            // 
            this.MonitoringLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonitoringLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MonitoringLabel.Location = new System.Drawing.Point(0, 0);
            this.MonitoringLabel.Name = "MonitoringLabel";
            this.MonitoringLabel.Size = new System.Drawing.Size(800, 70);
            this.MonitoringLabel.TabIndex = 0;
            this.MonitoringLabel.Text = "Мониторинг";
            // 
            // Monitoring
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MonitoringPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Monitoring";
            this.Text = "Monitoring";
            this.Load += new System.EventHandler(this.Monitoring_Load);
            this.MonitoringPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MonitoringPanel;
        private Label MonitoringLabel;
    }
}