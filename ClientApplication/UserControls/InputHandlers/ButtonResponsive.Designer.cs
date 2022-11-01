namespace ClientApplication.UserControls.InputHandlers
{
    partial class ButtonResponsive
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
            this.ResponsiveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResponsiveButton
            // 
            this.ResponsiveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ResponsiveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResponsiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResponsiveButton.FlatAppearance.BorderSize = 0;
            this.ResponsiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResponsiveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResponsiveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResponsiveButton.Location = new System.Drawing.Point(0, 0);
            this.ResponsiveButton.Name = "ResponsiveButton";
            this.ResponsiveButton.Size = new System.Drawing.Size(240, 40);
            this.ResponsiveButton.TabIndex = 0;
            this.ResponsiveButton.UseVisualStyleBackColor = true;
            this.ResponsiveButton.MouseEnter += new System.EventHandler(this.ResponsiveButton_MouseEnter);
            this.ResponsiveButton.MouseLeave += new System.EventHandler(this.ResponsiveButton_MouseLeave);
            // 
            // ButtonResponsive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResponsiveButton);
            this.Name = "ButtonResponsive";
            this.Size = new System.Drawing.Size(240, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private Button ResponsiveButton;
    }
}
