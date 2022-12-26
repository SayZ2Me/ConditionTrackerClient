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
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.hidePanel1 = new ClientApplication.UserControls.ElementContainers.HidePanel();
            this.scrollPanelVertical = new ClientApplication.UserControls.ElementContainers.ScrollPanelVertical();
            this.ToolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolPanel
            // 
            this.ToolPanel.BackColor = System.Drawing.Color.Transparent;
            this.ToolPanel.Controls.Add(this.hidePanel1);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ToolPanel.Location = new System.Drawing.Point(757, 0);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(43, 450);
            this.ToolPanel.TabIndex = 0;
            this.ToolPanel.Tag = "BackGround";
            // 
            // hidePanel1
            // 
            this.hidePanel1.BackColor = System.Drawing.Color.Transparent;
            this.hidePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hidePanel1.IconHideDark = global::ClientApplication.Properties.Resources.IconRightDark;
            this.hidePanel1.IconHideLight = global::ClientApplication.Properties.Resources.IconRightLight;
            this.hidePanel1.IconHideMain = global::ClientApplication.Properties.Resources.IconRightMain;
            this.hidePanel1.IconShowDark = global::ClientApplication.Properties.Resources.IconLeftDark;
            this.hidePanel1.IconShowLight = global::ClientApplication.Properties.Resources.IconLeftLight;
            this.hidePanel1.IconShowMain = global::ClientApplication.Properties.Resources.IconLeftMain;
            this.hidePanel1.Location = new System.Drawing.Point(0, 0);
            this.hidePanel1.MaxWidth = 243;
            this.hidePanel1.MinWidth = 43;
            this.hidePanel1.Name = "hidePanel1";
            this.hidePanel1.Size = new System.Drawing.Size(43, 43);
            this.hidePanel1.Step = 20;
            this.hidePanel1.TabIndex = 1;
            this.hidePanel1.Tag = "Fixed";
            // 
            // scrollPanelVertical
            // 
            this.scrollPanelVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanelVertical.Location = new System.Drawing.Point(0, 0);
            this.scrollPanelVertical.Name = "scrollPanelVertical";
            this.scrollPanelVertical.Size = new System.Drawing.Size(757, 450);
            this.scrollPanelVertical.TabIndex = 1;
            // 
            // Monitoring
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scrollPanelVertical);
            this.Controls.Add(this.ToolPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Monitoring";
            this.Text = "Monitoring";
            this.Load += new System.EventHandler(this.Monitoring_Load);
            this.ToolPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ToolPanel;
        private UserControls.ElementContainers.HidePanel hidePanel1;
        private UserControls.ElementContainers.ScrollPanelVertical scrollPanelVertical;
    }
}