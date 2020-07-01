namespace SPRVUZ
{
    partial class SAVE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PHOTO = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SaveBUT = new System.Windows.Forms.Button();
            this.priznak = new SPRVUZ.GrayTXT();
            this.SiteVUZ = new SPRVUZ.GrayTXT();
            this.Number = new SPRVUZ.GrayTXT();
            this.OfficialAdress = new SPRVUZ.GrayTXT();
            this.NameVUZ = new SPRVUZ.GrayTXT();
            this.CODEVUZ = new SPRVUZ.GrayTXT();
            this.IDCITY = new System.Windows.Forms.ComboBox();
            this.городаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PhotoVUZ = new SPRVUZ.GrayTXT();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.городаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 173);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(249, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Изображение:";
            // 
            // PHOTO
            // 
            this.PHOTO.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PHOTO.Location = new System.Drawing.Point(254, 245);
            this.PHOTO.Name = "PHOTO";
            this.PHOTO.Size = new System.Drawing.Size(123, 32);
            this.PHOTO.TabIndex = 20;
            this.PHOTO.Text = "Обзор...";
            this.PHOTO.UseVisualStyleBackColor = true;
            this.PHOTO.Click += new System.EventHandler(this.PHOTO_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 382);
            this.button3.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 33);
            this.button3.TabIndex = 24;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SaveBUT
            // 
            this.SaveBUT.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBUT.Location = new System.Drawing.Point(189, 382);
            this.SaveBUT.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.SaveBUT.Name = "SaveBUT";
            this.SaveBUT.Size = new System.Drawing.Size(145, 33);
            this.SaveBUT.TabIndex = 25;
            this.SaveBUT.Text = "Добавить";
            this.SaveBUT.UseVisualStyleBackColor = true;
            this.SaveBUT.Click += new System.EventHandler(this.SaveBUT_Click);
            // 
            // priznak
            // 
            this.priznak.Cue = "Признак";
            this.priznak.Location = new System.Drawing.Point(12, 168);
            this.priznak.Name = "priznak";
            this.priznak.Size = new System.Drawing.Size(365, 20);
            this.priznak.TabIndex = 6;
            // 
            // SiteVUZ
            // 
            this.SiteVUZ.Cue = "Веб-сайт";
            this.SiteVUZ.Location = new System.Drawing.Point(12, 142);
            this.SiteVUZ.Name = "SiteVUZ";
            this.SiteVUZ.Size = new System.Drawing.Size(365, 20);
            this.SiteVUZ.TabIndex = 5;
            // 
            // Number
            // 
            this.Number.Cue = "Номер телефона";
            this.Number.Location = new System.Drawing.Point(12, 116);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(365, 20);
            this.Number.TabIndex = 4;
            // 
            // OfficialAdress
            // 
            this.OfficialAdress.Cue = "Юридический адрес";
            this.OfficialAdress.Location = new System.Drawing.Point(12, 90);
            this.OfficialAdress.Name = "OfficialAdress";
            this.OfficialAdress.Size = new System.Drawing.Size(365, 20);
            this.OfficialAdress.TabIndex = 3;
            // 
            // NameVUZ
            // 
            this.NameVUZ.Cue = "Наименование ВУЗа";
            this.NameVUZ.Location = new System.Drawing.Point(12, 38);
            this.NameVUZ.Name = "NameVUZ";
            this.NameVUZ.Size = new System.Drawing.Size(365, 20);
            this.NameVUZ.TabIndex = 1;
            // 
            // CODEVUZ
            // 
            this.CODEVUZ.Cue = "Код ВУЗа";
            this.CODEVUZ.Location = new System.Drawing.Point(13, 12);
            this.CODEVUZ.Name = "CODEVUZ";
            this.CODEVUZ.Size = new System.Drawing.Size(364, 20);
            this.CODEVUZ.TabIndex = 26;
            // 
            // IDCITY
            // 
            this.IDCITY.DataSource = this.городаBindingSource;
            this.IDCITY.DisplayMember = "Название_города";
            this.IDCITY.FormattingEnabled = true;
            this.IDCITY.Location = new System.Drawing.Point(13, 63);
            this.IDCITY.Name = "IDCITY";
            this.IDCITY.Size = new System.Drawing.Size(364, 21);
            this.IDCITY.TabIndex = 27;
            this.IDCITY.ValueMember = "ID_города";
            // 
           // PhotoVUZ
            // 
            this.PhotoVUZ.Cue = "вставьте пробел";
            this.PhotoVUZ.Location = new System.Drawing.Point(249, 308);
            this.PhotoVUZ.Name = "PhotoVUZ";
            this.PhotoVUZ.Size = new System.Drawing.Size(129, 20);
            this.PhotoVUZ.TabIndex = 28;
            // 
            // SAVE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 424);
            this.Controls.Add(this.PhotoVUZ);
            this.Controls.Add(this.IDCITY);
            this.Controls.Add(this.CODEVUZ);
            this.Controls.Add(this.SaveBUT);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PHOTO);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.priznak);
            this.Controls.Add(this.SiteVUZ);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.OfficialAdress);
            this.Controls.Add(this.NameVUZ);
            this.Name = "SAVE";
            this.Text = "Добавление ВУЗов";
            this.Load += new System.EventHandler(this.SAVE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.городаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GrayTXT NameVUZ;
        private GrayTXT OfficialAdress;
        private GrayTXT Number;
        private GrayTXT SiteVUZ;
        private GrayTXT priznak;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button PHOTO;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button SaveBUT;
        private GrayTXT CODEVUZ;
        private System.Windows.Forms.ComboBox IDCITY;
        private System.Windows.Forms.BindingSource городаBindingSource;
        private GrayTXT PhotoVUZ;
    }
}