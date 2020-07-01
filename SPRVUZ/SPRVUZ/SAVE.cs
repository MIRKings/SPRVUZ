using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPRVUZ
{
    public partial class SAVE : Form
    {
        public static string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gusei\source\repos\SPRVUZ\SPRVUZ\VUZBD.accdb";
        private OleDbConnection Conn = new  OleDbConnection(ConnectionString);

        public static byte[] GetImage(string FileString)
        {
            FileStream ImageStream = new FileStream(FileString, FileMode.Open, FileAccess.Read);
            BinaryReader ImageReader = new BinaryReader(ImageStream);
            return ImageReader.ReadBytes(Convert.ToInt32(ImageStream.Length));
        }

        public string imgloc = "";

        public SAVE()
        {
            InitializeComponent();
            Conn.Open();
        }

        private void PHOTO_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
                dlg.Title = "Выберите фотографию фурнитуры";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            pictureBox1.ImageLocation = imgloc;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ifrm = Application.OpenForms["VUZ"];
            ifrm.Show();
            this.Close();
        }

        private void SAVE_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vUZBDDataSet.Города". При необходимости она может быть перемещена или удалена.
           // this.городаTableAdapter.Fill(this.vUZBDDataSet.Города);

        }

        private void SaveBUT_Click(object sender, EventArgs e)
        {
            if((CODEVUZ.Text != "")&& (NameVUZ.Text != "" ) && (IDCITY.Text !=""))
            {
                if (imgloc == "")
                {
                    string comst = "INSERT INTO ВУЗы VALUES ('" + CODEVUZ.Text + "','" + NameVUZ.Text + "','" + IDCITY.Text + "','" +OfficialAdress.Text + "','" + Number.Text + "','" + 
                        SiteVUZ.Text + "','" + priznak.Text + "','"+ PhotoVUZ.Text + "');";
                    OleDbCommand com = new OleDbCommand(comst, Conn);
                  //  com.Parameters.Add("@Photo", OleDbType.Image, GetImage(imgloc).Length).Value = GetImage(imgloc);
                    com.ExecuteNonQuery();
                    Conn.Close();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Поле 'Код ВУЗа','Наименование ВУЗа', 'Назвние города', обязательны к заполнению!");
            }
        }
    }
}
