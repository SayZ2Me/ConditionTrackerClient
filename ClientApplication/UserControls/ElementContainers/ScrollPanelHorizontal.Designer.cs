namespace ClientApplication.UserControls.ElementContainers
{
    partial class ScrollPanelHorizontal
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
            this.scrollBarHorizontal = new ClientApplication.UserControls.InputHandlers.ScrollBarHorizontal();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // scrollBarHorizontal
            // 
            this.scrollBarHorizontal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.scrollBarHorizontal.Location = new System.Drawing.Point(0, 583);
            this.scrollBarHorizontal.Name = "scrollBarHorizontal";
            this.scrollBarHorizontal.ParentPanel = this.ContentPanel;
            this.scrollBarHorizontal.Size = new System.Drawing.Size(1200, 17);
            this.scrollBarHorizontal.TabIndex = 0;
            this.scrollBarHorizontal.Tag = "Panel";
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Padding = new System.Windows.Forms.Padding(10);
            this.ContentPanel.Size = new System.Drawing.Size(1200, 600);
            this.ContentPanel.TabIndex = 1;
            // 
            // ScrollPanelHorizontal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scrollBarHorizontal);
            this.Controls.Add(this.ContentPanel);
            this.Name = "ScrollPanelHorizontal";
            this.Size = new System.Drawing.Size(1200, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private InputHandlers.ScrollBarHorizontal scrollBarHorizontal;
        private Panel ContentPanel;
    }
}
