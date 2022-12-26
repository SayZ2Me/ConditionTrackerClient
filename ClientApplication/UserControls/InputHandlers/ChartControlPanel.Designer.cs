namespace ClientApplication.UserControls.InputHandlers
{
    partial class ChartControlPanel
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
            this.buttonSwitch = new ClientApplication.UserControls.InputHandlers.ButtonToggle();
            this.sensorType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSwitch.Location = new System.Drawing.Point(361, 5);
            this.buttonSwitch.MinimumSize = new System.Drawing.Size(45, 22);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(49, 24);
            this.buttonSwitch.TabIndex = 0;
            this.buttonSwitch.Text = "buttonToggle1";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonToggle1_Click);
            // 
            // sensorType
            // 
            this.sensorType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sensorType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sensorType.Location = new System.Drawing.Point(5, 5);
            this.sensorType.Name = "sensorType";
            this.sensorType.Size = new System.Drawing.Size(356, 24);
            this.sensorType.TabIndex = 1;
            this.sensorType.Text = "label1";
            this.sensorType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChartControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sensorType);
            this.Controls.Add(this.buttonSwitch);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ChartControlPanel";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(415, 34);
            this.Tag = "BackGround";
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonToggle buttonSwitch;
        private Label sensorType;
    }
}
