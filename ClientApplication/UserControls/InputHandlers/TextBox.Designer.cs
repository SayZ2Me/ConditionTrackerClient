namespace ClientApplication.UserControls.InputHandlers
{
    partial class TextBox
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
            this.InputField = new System.Windows.Forms.TextBox();
            this.Image = new System.Windows.Forms.Panel();
            this.Underscore = new System.Windows.Forms.Panel();
            this.InputFIeldContainer = new System.Windows.Forms.Panel();
            this.Option = new System.Windows.Forms.Button();
            this.InputFIeldContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputField
            // 
            this.InputField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputField.Dock = System.Windows.Forms.DockStyle.Top;
            this.InputField.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputField.Location = new System.Drawing.Point(5, 5);
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(310, 25);
            this.InputField.TabIndex = 0;
            this.InputField.WordWrap = false;
            // 
            // Image
            // 
            this.Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Image.Dock = System.Windows.Forms.DockStyle.Left;
            this.Image.Location = new System.Drawing.Point(0, 0);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(40, 40);
            this.Image.TabIndex = 1;
            // 
            // Underscore
            // 
            this.Underscore.Dock = System.Windows.Forms.DockStyle.Top;
            this.Underscore.Location = new System.Drawing.Point(5, 30);
            this.Underscore.Name = "Underscore";
            this.Underscore.Size = new System.Drawing.Size(310, 1);
            this.Underscore.TabIndex = 2;
            this.Underscore.Tag = "Main";
            // 
            // InputFIeldContainer
            // 
            this.InputFIeldContainer.Controls.Add(this.Underscore);
            this.InputFIeldContainer.Controls.Add(this.InputField);
            this.InputFIeldContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputFIeldContainer.Location = new System.Drawing.Point(40, 0);
            this.InputFIeldContainer.Name = "InputFIeldContainer";
            this.InputFIeldContainer.Padding = new System.Windows.Forms.Padding(5);
            this.InputFIeldContainer.Size = new System.Drawing.Size(320, 40);
            this.InputFIeldContainer.TabIndex = 3;
            // 
            // Option
            // 
            this.Option.BackgroundImage = global::ClientApplication.Properties.Resources.IconUnhide;
            this.Option.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Option.Dock = System.Windows.Forms.DockStyle.Right;
            this.Option.FlatAppearance.BorderSize = 0;
            this.Option.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option.Location = new System.Drawing.Point(360, 0);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(40, 40);
            this.Option.TabIndex = 4;
            this.Option.UseVisualStyleBackColor = true;
            this.Option.Click += new System.EventHandler(this.Option_Click);
            // 
            // TextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InputFIeldContainer);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.Option);
            this.MinimumSize = new System.Drawing.Size(120, 40);
            this.Name = "TextBox";
            this.Size = new System.Drawing.Size(400, 40);
            this.Load += new System.EventHandler(this.TextBox_Load);
            this.InputFIeldContainer.ResumeLayout(false);
            this.InputFIeldContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox InputField;
        private Panel Image;
        private Panel Underscore;
        private Panel InputFIeldContainer;
        private Button Option;
    }
}
