namespace ClientApplication.UserControls.ElementContainers
{
    partial class ScrollPanelVertical
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
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.scrollBarVertical = new ClientApplication.UserControls.InputHandlers.ScrollBarVertical();
            this.SuspendLayout();
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
            // scrollBarVertical
            // 
            this.scrollBarVertical.Dock = System.Windows.Forms.DockStyle.Right;
            this.scrollBarVertical.Location = new System.Drawing.Point(1183, 0);
            this.scrollBarVertical.Name = "scrollBarVertical";
            this.scrollBarVertical.ParentPanel = this.ContentPanel;
            this.scrollBarVertical.Size = new System.Drawing.Size(17, 600);
            this.scrollBarVertical.TabIndex = 0;
            this.scrollBarVertical.Tag = "Panel";
            // 
            // ScrollPanelVertical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scrollBarVertical);
            this.Controls.Add(this.ContentPanel);
            this.Name = "ScrollPanelVertical";
            this.Size = new System.Drawing.Size(1200, 600);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel ContentPanel;
        private InputHandlers.ScrollBarVertical scrollBarVertical;
    }
}
