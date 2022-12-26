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
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.hidePanel = new ClientApplication.UserControls.ElementContainers.HidePanel();
            this.scrollPanelVertical = new ClientApplication.UserControls.ElementContainers.ScrollPanelVertical();
            this.ToolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolPanel
            // 
            this.ToolPanel.Controls.Add(this.hidePanel);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ToolPanel.Location = new System.Drawing.Point(757, 0);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(43, 450);
            this.ToolPanel.TabIndex = 0;
            this.ToolPanel.Tag = "Background";
            // 
            // hidePanel
            // 
            this.hidePanel.BackColor = System.Drawing.Color.Transparent;
            this.hidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.hidePanel.IconHideDark = global::ClientApplication.Properties.Resources.IconRightDark;
            this.hidePanel.IconHideLight = global::ClientApplication.Properties.Resources.IconRightLight;
            this.hidePanel.IconHideMain = global::ClientApplication.Properties.Resources.IconRightMain;
            this.hidePanel.IconShowDark = global::ClientApplication.Properties.Resources.IconLeftDark;
            this.hidePanel.IconShowLight = global::ClientApplication.Properties.Resources.IconLeftLight;
            this.hidePanel.IconShowMain = global::ClientApplication.Properties.Resources.IconLeftMain;
            this.hidePanel.Location = new System.Drawing.Point(0, 0);
            this.hidePanel.MaxWidth = 243;
            this.hidePanel.MinWidth = 43;
            this.hidePanel.Name = "hidePanel";
            this.hidePanel.Size = new System.Drawing.Size(43, 43);
            this.hidePanel.Step = 20;
            this.hidePanel.TabIndex = 0;
            this.hidePanel.Tag = "Fixed";
            // 
            // scrollPanelVertical
            // 
            this.scrollPanelVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanelVertical.Location = new System.Drawing.Point(0, 0);
            this.scrollPanelVertical.Name = "scrollPanelVertical";
            this.scrollPanelVertical.Size = new System.Drawing.Size(757, 450);
            this.scrollPanelVertical.TabIndex = 4;
            // 
            // Devices
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scrollPanelVertical);
            this.Controls.Add(this.ToolPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Devices";
            this.Text = "Devices";
            this.Load += new System.EventHandler(this.Devices_Load);
            this.ToolPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel ToolPanel;
        private UserControls.ElementContainers.HidePanel hidePanel;
        private UserControls.ElementContainers.ScrollPanelVertical scrollPanelVertical;
    }
}