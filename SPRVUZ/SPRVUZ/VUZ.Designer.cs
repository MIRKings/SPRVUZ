namespace SPRVUZ
{
    partial class VUZ
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наГлавнуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.POKAZ = new System.Windows.Forms.ComboBox();
            this.ClearBUT = new System.Windows.Forms.Button();
            this.SEARCHBUT = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.UPDATEBUT = new System.Windows.Forms.Button();
            this.ChangeBUT = new System.Windows.Forms.Button();
            this.DELBUT = new System.Windows.Forms.Button();
            this.ADDBUT = new System.Windows.Forms.Button();
            this.IDCITY = new SPRVUZ.GrayTXT();
            this.NameVUZ = new SPRVUZ.GrayTXT();
            this.CODEVUZ = new SPRVUZ.GrayTXT();
            this.grayTXT1 = new SPRVUZ.GrayTXT();
            this.OfficialAdress = new SPRVUZ.GrayTXT();
            this.Number = new SPRVUZ.GrayTXT();
            this.SiteVUZ = new SPRVUZ.GrayTXT();
            this.priznak = new SPRVUZ.GrayTXT();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.показатьДанныеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наГлавнуюToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // наГлавнуюToolStripMenuItem
            // 
            this.наГлавнуюToolStripMenuItem.Name = "наГлавнуюToolStripMenuItem";
            this.наГлавнуюToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.наГлавнуюToolStripMenuItem.Text = "На главную";
            this.наГлавнуюToolStripMenuItem.Click += new System.EventHandler(this.наГлавнуюToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // показатьДанныеToolStripMenuItem
            // 
            this.показатьДанныеToolStripMenuItem.Name = "показатьДанныеToolStripMenuItem";
            this.показатьДанныеToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.показатьДанныеToolStripMenuItem.Text = "Показать данные";
            this.показатьДанныеToolStripMenuItem.Click += new System.EventHandler(this.показатьДанныеToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.POKAZ);
            this.splitContainer1.Panel2.Controls.Add(this.ClearBUT);
            this.splitContainer1.Panel2.Controls.Add(this.IDCITY);
            this.splitContainer1.Panel2.Controls.Add(this.NameVUZ);
            this.splitContainer1.Panel2.Controls.Add(this.SEARCHBUT);
            this.splitContainer1.Panel2.Controls.Add(this.CODEVUZ);
            this.splitContainer1.Panel2.Controls.Add(this.grayTXT1);
            this.splitContainer1.Panel2.Controls.Add(this.OfficialAdress);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.UPDATEBUT);
            this.splitContainer1.Panel2.Controls.Add(this.Number);
            this.splitContainer1.Panel2.Controls.Add(this.ChangeBUT);
            this.splitContainer1.Panel2.Controls.Add(this.SiteVUZ);
            this.splitContainer1.Panel2.Controls.Add(this.DELBUT);
            this.splitContainer1.Panel2.Controls.Add(this.priznak);
            this.splitContainer1.Panel2.Controls.Add(this.ADDBUT);
            this.splitContainer1.Size = new System.Drawing.Size(805, 472);
            this.splitContainer1.SplitterDistance = 325;
            this.splitContainer1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(805, 325);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // POKAZ
            // 
            this.POKAZ.FormattingEnabled = true;
            this.POKAZ.Location = new System.Drawing.Point(12, 62);
            this.POKAZ.Name = "POKAZ";
            this.POKAZ.Size = new System.Drawing.Size(232, 21);
            this.POKAZ.TabIndex = 57;
            this.POKAZ.Text = "СПРАВОЧНИК ГОРОДА";
            this.POKAZ.SelectedIndexChanged += new System.EventHandler(this.POKAZ_SelectedIndexChanged);
            // 
            // ClearBUT
            // 
            this.ClearBUT.Location = new System.Drawing.Point(605, 60);
            this.ClearBUT.Name = "ClearBUT";
            this.ClearBUT.Size = new System.Drawing.Size(86, 23);
            this.ClearBUT.TabIndex = 56;
            this.ClearBUT.Text = "Очистить поля";
            this.ClearBUT.UseVisualStyleBackColor = true;
            this.ClearBUT.Click += new System.EventHandler(this.ClearBUT_Click);
            // 
            // SEARCHBUT
            // 
            this.SEARCHBUT.Location = new System.Drawing.Point(697, 109);
            this.SEARCHBUT.Name = "SEARCHBUT";
            this.SEARCHBUT.Size = new System.Drawing.Size(75, 23);
            this.SEARCHBUT.TabIndex = 54;
            this.SEARCHBUT.Text = "Поиск";
            this.SEARCHBUT.UseVisualStyleBackColor = true;
            this.SEARCHBUT.Click += new System.EventHandler(this.SEARCHBUT_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Код ВУЗа",
            "Наименование ВУЗа",
            "ID города",
            "Юридический адрес",
            "Номер телефона",
            "Веб-сайт",
            "Признак"});
            this.comboBox1.Location = new System.Drawing.Point(11, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 21);
            this.comboBox1.TabIndex = 52;
            // 
            // UPDATEBUT
            // 
            this.UPDATEBUT.Location = new System.Drawing.Point(524, 60);
            this.UPDATEBUT.Name = "UPDATEBUT";
            this.UPDATEBUT.Size = new System.Drawing.Size(75, 23);
            this.UPDATEBUT.TabIndex = 51;
            this.UPDATEBUT.Text = "Обновить";
            this.UPDATEBUT.UseVisualStyleBackColor = true;
            this.UPDATEBUT.Click += new System.EventHandler(this.UPDATEBUT_Click);
            // 
            // ChangeBUT
            // 
            this.ChangeBUT.Location = new System.Drawing.Point(443, 60);
            this.ChangeBUT.Name = "ChangeBUT";
            this.ChangeBUT.Size = new System.Drawing.Size(75, 23);
            this.ChangeBUT.TabIndex = 50;
            this.ChangeBUT.Text = "Изменить";
            this.ChangeBUT.UseVisualStyleBackColor = true;
            this.ChangeBUT.Click += new System.EventHandler(this.ChangeBUT_Click);
            // 
            // DELBUT
            // 
            this.DELBUT.Location = new System.Drawing.Point(350, 60);
            this.DELBUT.Name = "DELBUT";
            this.DELBUT.Size = new System.Drawing.Size(87, 23);
            this.DELBUT.TabIndex = 49;
            this.DELBUT.Tag = "Удаление";
            this.DELBUT.Text = "Удалить";
            this.DELBUT.UseVisualStyleBackColor = true;
            this.DELBUT.Click += new System.EventHandler(this.DELBUT_Click);
            // 
            // ADDBUT
            // 
            this.ADDBUT.Location = new System.Drawing.Point(250, 60);
            this.ADDBUT.Name = "ADDBUT";
            this.ADDBUT.Size = new System.Drawing.Size(94, 23);
            this.ADDBUT.TabIndex = 48;
            this.ADDBUT.Text = "Добавить";
            this.ADDBUT.UseVisualStyleBackColor = true;
            this.ADDBUT.Click += new System.EventHandler(this.ADDBUT_Click);
            // 
            // IDCITY
            // 
            this.IDCITY.Cue = "ID города";
            this.IDCITY.Location = new System.Drawing.Point(697, 7);
            this.IDCITY.Name = "IDCITY";
            this.IDCITY.Size = new System.Drawing.Size(100, 20);
            this.IDCITY.TabIndex = 55;
            // 
            // NameVUZ
            // 
            this.NameVUZ.Cue = "Наименование ВУЗа";
            this.NameVUZ.Location = new System.Drawing.Point(111, 7);
            this.NameVUZ.Name = "NameVUZ";
            this.NameVUZ.Size = new System.Drawing.Size(580, 20);
            this.NameVUZ.TabIndex = 41;
            // 
            // CODEVUZ
            // 
            this.CODEVUZ.Cue = "Код ВУЗа";
            this.CODEVUZ.Location = new System.Drawing.Point(11, 7);
            this.CODEVUZ.Name = "CODEVUZ";
            this.CODEVUZ.Size = new System.Drawing.Size(94, 20);
            this.CODEVUZ.TabIndex = 42;
            // 
            // grayTXT1
            // 
            this.grayTXT1.Cue = null;
            this.grayTXT1.Location = new System.Drawing.Point(252, 109);
            this.grayTXT1.Name = "grayTXT1";
            this.grayTXT1.Size = new System.Drawing.Size(412, 20);
            this.grayTXT1.TabIndex = 53;
            // 
            // OfficialAdress
            // 
            this.OfficialAdress.Cue = "Юридический адрес";
            this.OfficialAdress.Location = new System.Drawing.Point(11, 33);
            this.OfficialAdress.Name = "OfficialAdress";
            this.OfficialAdress.Size = new System.Drawing.Size(314, 20);
            this.OfficialAdress.TabIndex = 43;
            // 
            // Number
            // 
            this.Number.Cue = "Номер телефона";
            this.Number.Location = new System.Drawing.Point(331, 34);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(147, 20);
            this.Number.TabIndex = 45;
            // 
            // SiteVUZ
            // 
            this.SiteVUZ.Cue = "Веб-сайт";
            this.SiteVUZ.Location = new System.Drawing.Point(484, 34);
            this.SiteVUZ.Name = "SiteVUZ";
            this.SiteVUZ.Size = new System.Drawing.Size(180, 20);
            this.SiteVUZ.TabIndex = 46;
            // 
            // priznak
            // 
            this.priznak.Cue = "Признак";
            this.priznak.Location = new System.Drawing.Point(670, 34);
            this.priznak.Name = "priznak";
            this.priznak.Size = new System.Drawing.Size(122, 20);
            this.priznak.TabIndex = 47;
            // 
            // VUZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 496);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VUZ";
            this.Text = "Вузы";
            this.Load += new System.EventHandler(this.VUZ_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наГлавнуюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GrayTXT NameVUZ;
        private System.Windows.Forms.Button SEARCHBUT;
        private GrayTXT CODEVUZ;
        private GrayTXT grayTXT1;
        private GrayTXT OfficialAdress;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button UPDATEBUT;
        private GrayTXT Number;
        private System.Windows.Forms.Button ChangeBUT;
        private GrayTXT SiteVUZ;
        private System.Windows.Forms.Button DELBUT;
        private GrayTXT priznak;
        private System.Windows.Forms.Button ADDBUT;
        private GrayTXT IDCITY;
        private System.Windows.Forms.Button ClearBUT;
        private System.Windows.Forms.ComboBox POKAZ;
        private System.Windows.Forms.ToolStripMenuItem показатьДанныеToolStripMenuItem;
    }
}