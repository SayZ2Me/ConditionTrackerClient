namespace ClientApplication.Forms.WorkPanels
{
    partial class Home
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
            this.HomePagePanel = new System.Windows.Forms.Panel();
            this.HomePageLabel = new System.Windows.Forms.Label();
            this.HomePagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePagePanel
            // 
            this.HomePagePanel.Controls.Add(this.HomePageLabel);
            this.HomePagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomePagePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePagePanel.Name = "HomePagePanel";
            this.HomePagePanel.Size = new System.Drawing.Size(800, 70);
            this.HomePagePanel.TabIndex = 2;
            // 
            // HomePageLabel
            // 
            this.HomePageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomePageLabel.Location = new System.Drawing.Point(0, 0);
            this.HomePageLabel.Name = "HomePageLabel";
            this.HomePageLabel.Size = new System.Drawing.Size(800, 70);
            this.HomePageLabel.TabIndex = 0;
            this.HomePageLabel.Text = "Домашняя страница";
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomePagePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.HomePagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel HomePagePanel;
        private Label HomePageLabel;
    }
}