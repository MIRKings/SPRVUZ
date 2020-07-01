using System;
using System.Data.OleDb;
using System.Windows.Forms;
using SPRVUZ.Controller;

namespace SPRVUZ
{
    public partial class CITY : Form
    {
        Query controller;

       //private OleDbConnection connection = new OleDbConnection();

        public CITY()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);

           /* connection.ConnectionString = //@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\VUZBD.accdb";
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gusei\source\repos\SPRVUZ\SPRVUZ\VUZBD.accdb";*/
        }

        private void CITY_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vUZBDDataSet.Города". При необходимости она может быть перемещена или удалена.
         //   this.городаTableAdapter.Fill(this.vUZBDDataSet.Города);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Serch_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text == "ID города")
            {
             ///   городаBindingSource.Filter = "ID_города = \'" + grayTXT1.Text + "\'";                
            }
            else if (comboBox2.Text == "Название города")
            {
               /// городаBindingSource.Filter = "Название_города = \'" + grayTXT1.Text + "\'";
            }
        }

        private void ADd_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void OTmena_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        //добавление записи в бд
        private void ADDD_Click(object sender, EventArgs e)
        {
            controller.AddCITY(int.Parse(IDCITY.Text), NAMECity.Text);
            IDCITY.Clear();
            NAMECity.Clear();

            /* try
             {
                 connection.Open();
                 OleDbCommand command = new OleDbCommand();
                 command.Connection = connection;
                 if (IDCITY.Text != "" && NAMECity.Text != "")
                 {
                     command.CommandText = "INSERT INTO Города (ID_города,Название_города) VALUES('" + IDCITY.Text + "','" + NAMECity.Text + "')";
                     //
                     command.ExecuteNonQuery();
                     MessageBox.Show("Успешное сохранение");
                     connection.Close();
                 }
                 else
                     MessageBox.Show("Поля 'ID города', 'Название города' не должны быть пустыми");
             }
             catch (Exception ex)
             { MessageBox.Show("Ошибка!" + ex); }*/
        }

        //кнопка изменения
        private void Change_Click(object sender, EventArgs e)
        {
           /* try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                if (IDCITY.Text != "" && NAMECity.Text != "")
                {
                    if (MessageBox.Show("Изменить данную строку?", "Замена данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string query = "UPDATE Города SET Название_города='" + NAMECity.Text + "' WHERE ID_города=" + IDCITY.Text + "";

                        command.CommandText = query;
                        command.ExecuteNonQuery();
                        MessageBox.Show("Успешное изменение данных");
                        connection.Close();
                    }
                }
                else
                    MessageBox.Show("Поля 'ID города', 'Название города' не должны быть пустыми"); 
            }
            catch (Exception ex)
            { MessageBox.Show("Ошибка!" + ex); }*/
        }

        //отчистка полей
        private void ClearBUT_Click(object sender, EventArgs e)
        {
            IDCITY.Clear();
            NAMECity.Clear();
        }

       
        private void BACKBUT_Click(object sender, EventArgs e)
        {
            Form main = Application.OpenForms["Main"];
            main.Show();
            this.Close();
        }

        //Обновление бд
        private void UPDATEBUT_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateCITY();
            // this.городаTableAdapter.Fill(this.vUZBDDataSet.Города);
        }

        //Удаление данной записи
        private void DELBUT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить выбранные данные?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                controller.DeleteCITY(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID_города"].Value.ToString()));
            }
            /* try
             {
                 connection.Open();
                 OleDbCommand command = new OleDbCommand();
                 command.Connection = connection;
                 if (IDCITY.Text != "")
                 {

                 }
                 else
                     MessageBox.Show("Поле 'ID города' не должно быть пустыми");
                 command.ExecuteNonQuery();
                 
                 connection.Close();

             }
             catch (Exception ex)
             { MessageBox.Show("Ошибка!" + ex); }*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {/*
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                IDCITY.Text = row.Cells[0].Value.ToString();
                NAMECity.Text = row.Cells[1].Value.ToString();

            }*/
        }

        //Код для отображения данных в текст боксах
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach(DataGridViewCell selectedCell in dataGridView1.SelectedCells)
                {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                IDCITY.Text = row.Cells[0].Value.ToString();
                NAMECity.Text = row.Cells[1].Value.ToString();
            }           
        }

        private void SHOWDATA_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateCITY();

        }
    }
}
