namespace ClientApplication.UserControls
{
    partial class ButtonMinimize
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
            this.SuspendLayout();
            // 
            // ButtonMinimize
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::ClientApplication.Properties.Resources.ButtonMinimize;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "ButtonMinimize";
            this.Size = new System.Drawing.Size(21, 21);
            this.Tag = "Fixed";
            this.Click += new System.EventHandler(this.ButtonMinimize_Click);
            this.MouseEnter += new System.EventHandler(this.ButtonMinimize_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ButtonMinimize_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
