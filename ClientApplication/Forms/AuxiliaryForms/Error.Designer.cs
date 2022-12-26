namespace ClientApplication.Forms.AuxiliaryForms
{
    partial class Error
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
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.buttonClose1 = new ClientApplication.UserControls.ButtonClose();
            this.ErrorImage = new System.Windows.Forms.Panel();
            this.ErrorDescription = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ErrorMessage.Location = new System.Drawing.Point(64, 38);
            this.ErrorMessage.Margin = new System.Windows.Forms.Padding(5);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(402, 45);
            this.ErrorMessage.TabIndex = 0;
            this.ErrorMessage.Text = "Error message";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.Header.Controls.Add(this.buttonClose1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(2, 2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(476, 30);
            this.Header.TabIndex = 1;
            this.Header.Tag = "Header";
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // buttonClose1
            // 
            this.buttonClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose1.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose1.BackgroundImage = global::ClientApplication.Properties.Resources.ButtonClose;
            this.buttonClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClose1.hideWindow = true;
            this.buttonClose1.Location = new System.Drawing.Point(429, 2);
            this.buttonClose1.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.buttonClose1.Name = "buttonClose1";
            this.buttonClose1.Size = new System.Drawing.Size(36, 26);
            this.buttonClose1.TabIndex = 3;
            this.buttonClose1.Tag = "Fixed";
            // 
            // ErrorImage
            // 
            this.ErrorImage.BackColor = System.Drawing.Color.Transparent;
            this.ErrorImage.BackgroundImage = global::ClientApplication.Properties.Resources.IndicatorRed;
            this.ErrorImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ErrorImage.Location = new System.Drawing.Point(7, 40);
            this.ErrorImage.Margin = new System.Windows.Forms.Padding(5);
            this.ErrorImage.Name = "ErrorImage";
            this.ErrorImage.Size = new System.Drawing.Size(47, 47);
            this.ErrorImage.TabIndex = 2;
            this.ErrorImage.Tag = "Fixed";
            // 
            // ErrorDescription
            // 
            this.ErrorDescription.Location = new System.Drawing.Point(64, 93);
            this.ErrorDescription.Margin = new System.Windows.Forms.Padding(5);
            this.ErrorDescription.Name = "ErrorDescription";
            this.ErrorDescription.Size = new System.Drawing.Size(402, 163);
            this.ErrorDescription.TabIndex = 3;
            this.ErrorDescription.Text = "Error message";
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(480, 270);
            this.Controls.Add(this.ErrorDescription);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.ErrorImage);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Error";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Error";
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label ErrorMessage;
        private Panel Header;
        private Panel ErrorImage;
        private UserControls.ButtonClose buttonClose1;
        private Label ErrorDescription;
    }
}