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
            this.labelTemp = new System.Windows.Forms.Label();
            this.listBoxCities = new System.Windows.Forms.ListBox();
            this.dataGridViewCities = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).BeginInit();
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
            this.textBoxCity.Size = new System.Drawing.Size(928, 71);
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
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemp.Location = new System.Drawing.Point(520, 15);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(0, 32);
            this.labelTemp.TabIndex = 3;
            // 
            // listBoxCities
            // 
            this.listBoxCities.FormattingEnabled = true;
            this.listBoxCities.ItemHeight = 16;
            this.listBoxCities.Location = new System.Drawing.Point(510, 101);
            this.listBoxCities.Name = "listBoxCities";
            this.listBoxCities.Size = new System.Drawing.Size(208, 324);
            this.listBoxCities.TabIndex = 4;
            this.listBoxCities.SelectedIndexChanged += new System.EventHandler(this.listBoxCities_SelectedIndexChanged);
            // 
            // dataGridViewCities
            // 
            this.dataGridViewCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCities.Location = new System.Drawing.Point(724, 101);
            this.dataGridViewCities.Name = "dataGridViewCities";
            this.dataGridViewCities.RowHeadersWidth = 51;
            this.dataGridViewCities.RowTemplate.Height = 24;
            this.dataGridViewCities.Size = new System.Drawing.Size(413, 324);
            this.dataGridViewCities.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 433);
            this.Controls.Add(this.dataGridViewCities);
            this.Controls.Add(this.listBoxCities);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.textBoxServerInfo);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.buttonGetInfo);
            this.Name = "MainForm";
            this.Text = "Погода";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetInfo;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxServerInfo;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.ListBox listBoxCities;
        private System.Windows.Forms.DataGridView dataGridViewCities;
    }
}

