namespace MissionPlanner.Wizard
{
    partial class DialCalib
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageLabel1 = new MissionPlanner.Controls.ImageLabel();
            this.BUT_continue = new MissionPlanner.Controls.MyButton();
            this.SuspendLayout();
            // 
            // imageLabel1
            // 
            this.imageLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imageLabel1.Image = global::MissionPlanner.Properties.Resources.calibration01;
            this.imageLabel1.Location = new System.Drawing.Point(60, 40);
            this.imageLabel1.Name = "imageLabel1";
            this.imageLabel1.Size = new System.Drawing.Size(383, 246);
            this.imageLabel1.TabIndex = 8;
            // 
            // BUT_continue
            // 
            this.BUT_continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BUT_continue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_continue.Location = new System.Drawing.Point(195, 323);
            this.BUT_continue.Name = "BUT_continue";
            this.BUT_continue.Size = new System.Drawing.Size(122, 23);
            this.BUT_continue.TabIndex = 9;
            this.BUT_continue.Text = "Start";
            this.BUT_continue.UseVisualStyleBackColor = true;
            this.BUT_continue.Click += new System.EventHandler(this.BUT_continue_Click);
            // 
            // DialCalib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(508, 358);
            this.Controls.Add(this.BUT_continue);
            this.Controls.Add(this.imageLabel1);
            this.Name = "DialCalib";
            this.Load += new System.EventHandler(this.Calib_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calib_Close);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ImageLabel imageLabel1;
        private Controls.MyButton BUT_continue;
    }
}
