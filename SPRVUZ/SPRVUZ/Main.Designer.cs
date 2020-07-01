namespace SPRVUZ
{
    partial class Main
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
            this.VUZ = new System.Windows.Forms.Button();
            this.CITY = new System.Windows.Forms.Button();
            this.Filials = new System.Windows.Forms.Button();
            this.ADMIN = new System.Windows.Forms.Button();
            this.EXITLABLE = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // VUZ
            // 
            this.VUZ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VUZ.Location = new System.Drawing.Point(12, 12);
            this.VUZ.Name = "VUZ";
            this.VUZ.Size = new System.Drawing.Size(214, 33);
            this.VUZ.TabIndex = 1;
            this.VUZ.Text = "Справочник ВУЗов";
            this.VUZ.UseVisualStyleBackColor = true;
            this.VUZ.Click += new System.EventHandler(this.VUZ_Click);
            // 
            // CITY
            // 
            this.CITY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CITY.Location = new System.Drawing.Point(12, 51);
            this.CITY.Name = "CITY";
            this.CITY.Size = new System.Drawing.Size(214, 33);
            this.CITY.TabIndex = 2;
            this.CITY.Text = "Справочник городов";
            this.CITY.UseVisualStyleBackColor = true;
            this.CITY.Click += new System.EventHandler(this.CITY_Click);
            // 
            // Filials
            // 
            this.Filials.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Filials.Location = new System.Drawing.Point(12, 90);
            this.Filials.Name = "Filials";
            this.Filials.Size = new System.Drawing.Size(214, 33);
            this.Filials.TabIndex = 3;
            this.Filials.Text = "Справочник ВУЗов (Филиалов)";
            this.Filials.UseVisualStyleBackColor = true;
            // 
            // ADMIN
            // 
            this.ADMIN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ADMIN.Location = new System.Drawing.Point(12, 129);
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Size = new System.Drawing.Size(214, 33);
            this.ADMIN.TabIndex = 4;
            this.ADMIN.Text = "Админу";
            this.ADMIN.UseVisualStyleBackColor = true;
            // 
            // EXITLABLE
            // 
            this.EXITLABLE.AutoSize = true;
            this.EXITLABLE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EXITLABLE.Location = new System.Drawing.Point(9, 176);
            this.EXITLABLE.Name = "EXITLABLE";
            this.EXITLABLE.Size = new System.Drawing.Size(39, 13);
            this.EXITLABLE.TabIndex = 5;
            this.EXITLABLE.TabStop = true;
            this.EXITLABLE.Text = "Выход";
            this.EXITLABLE.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EXITLABLE_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 198);
            this.Controls.Add(this.EXITLABLE);
            this.Controls.Add(this.ADMIN);
            this.Controls.Add(this.Filials);
            this.Controls.Add(this.CITY);
            this.Controls.Add(this.VUZ);
            this.Name = "Main";
            this.Text = "Главная";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button VUZ;
        private System.Windows.Forms.Button CITY;
        private System.Windows.Forms.Button Filials;
        private System.Windows.Forms.Button ADMIN;
        private System.Windows.Forms.LinkLabel EXITLABLE;
    }
}

