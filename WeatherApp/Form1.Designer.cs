namespace WeatherApp
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGetInfo = new System.Windows.Forms.Button();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxServerInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGetInfo
            // 
            this.buttonGetInfo.Location = new System.Drawing.Point(12, 12);
            this.buttonGetInfo.Name = "buttonGetInfo";
            this.buttonGetInfo.Size = new System.Drawing.Size(191, 71);
            this.buttonGetInfo.TabIndex = 0;
            this.buttonGetInfo.Text = "Отправить запрос";
            this.buttonGetInfo.UseVisualStyleBackColor = true;
            this.buttonGetInfo.Click += new System.EventHandler(this.buttonGetInfo_Click);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCity.Location = new System.Drawing.Point(209, 12);
            this.textBoxCity.Multiline = true;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(295, 71);
            this.textBoxCity.TabIndex = 1;
            this.textBoxCity.Text = "Vladikavkaz";
            // 
            // textBoxServerInfo
            // 
            this.textBoxServerInfo.Location = new System.Drawing.Point(12, 101);
            this.textBoxServerInfo.Multiline = true;
            this.textBoxServerInfo.Name = "textBoxServerInfo";
            this.textBoxServerInfo.Size = new System.Drawing.Size(492, 323);
            this.textBoxServerInfo.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.textBoxServerInfo);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.buttonGetInfo);
            this.Name = "MainForm";
            this.Text = "Погода";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetInfo;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxServerInfo;
    }
}

