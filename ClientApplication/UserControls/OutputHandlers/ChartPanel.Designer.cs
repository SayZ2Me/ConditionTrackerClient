namespace ClientApplication.UserControls.OutputHandlers
{
    partial class ChartPanel
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
            this.chartController = new System.Windows.Forms.Panel();
            this.highValueLabel = new System.Windows.Forms.Label();
            this.midValueLabel = new System.Windows.Forms.Label();
            this.lowValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chartController
            // 
            this.chartController.Dock = System.Windows.Forms.DockStyle.Right;
            this.chartController.Location = new System.Drawing.Point(644, 0);
            this.chartController.Name = "chartController";
            this.chartController.Padding = new System.Windows.Forms.Padding(10);
            this.chartController.Size = new System.Drawing.Size(200, 420);
            this.chartController.TabIndex = 0;
            this.chartController.Tag = "Fixed";
            // 
            // highValueLabel
            // 
            this.highValueLabel.AutoSize = true;
            this.highValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.highValueLabel.Location = new System.Drawing.Point(3, 0);
            this.highValueLabel.Name = "highValueLabel";
            this.highValueLabel.Size = new System.Drawing.Size(51, 21);
            this.highValueLabel.TabIndex = 1;
            this.highValueLabel.Text = "label1";
            // 
            // midValueLabel
            // 
            this.midValueLabel.AutoSize = true;
            this.midValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.midValueLabel.Location = new System.Drawing.Point(3, 200);
            this.midValueLabel.Name = "midValueLabel";
            this.midValueLabel.Size = new System.Drawing.Size(54, 21);
            this.midValueLabel.TabIndex = 2;
            this.midValueLabel.Text = "label2";
            // 
            // lowValueLabel
            // 
            this.lowValueLabel.AutoSize = true;
            this.lowValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lowValueLabel.Location = new System.Drawing.Point(3, 399);
            this.lowValueLabel.Name = "lowValueLabel";
            this.lowValueLabel.Size = new System.Drawing.Size(54, 21);
            this.lowValueLabel.TabIndex = 3;
            this.lowValueLabel.Text = "label3";
            // 
            // ChartPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lowValueLabel);
            this.Controls.Add(this.midValueLabel);
            this.Controls.Add(this.highValueLabel);
            this.Controls.Add(this.chartController);
            this.Name = "ChartPanel";
            this.Size = new System.Drawing.Size(844, 420);
            this.Tag = "Fixed";
            this.SizeChanged += new System.EventHandler(this.ChartPanel_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel chartController;
        private Label highValueLabel;
        private Label midValueLabel;
        private Label lowValueLabel;
    }
}
