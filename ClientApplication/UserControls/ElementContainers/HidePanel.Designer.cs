namespace ClientApplication.UserControls.ElementContainers
{
    partial class HidePanel
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
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.HidePanelButton = new ClientApplication.UserControls.InputHandlers.ButtonCustom();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // HidePanelButton
            // 
            this.HidePanelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HidePanelButton.Checked = false;
            this.HidePanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HidePanelButton.FlatAppearance.BorderSize = 0;
            this.HidePanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HidePanelButton.IconDark = null;
            this.HidePanelButton.IconHighLight = null;
            this.HidePanelButton.IconLight = null;
            this.HidePanelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HidePanelButton.Location = new System.Drawing.Point(0, 0);
            this.HidePanelButton.MainOnClick = false;
            this.HidePanelButton.Name = "HidePanelButton";
            this.HidePanelButton.OnPanel = false;
            this.HidePanelButton.Size = new System.Drawing.Size(43, 43);
            this.HidePanelButton.TabIndex = 0;
            this.HidePanelButton.UseVisualStyleBackColor = true;
            this.HidePanelButton.Click += new System.EventHandler(this.HidePanel_Click);
            // 
            // HidePanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.HidePanelButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "HidePanel";
            this.Size = new System.Drawing.Size(43, 43);
            this.Tag = "Fixed";
            this.Load += new System.EventHandler(this.HidePanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private InputHandlers.ButtonCustom HidePanelButton;
    }
}
