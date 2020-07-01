using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace SPRVUZ.Controller
{
    class Query
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;
        BindingSource bindingSource;
       
        public Query(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        //показ и обновление данных городов
        public DataTable UpdateCITY()
        {
            try
            {
                connection.Open();
                dataAdapter = new OleDbDataAdapter("SELECT * FROM Города", connection);
                bufferTable.Clear();
                dataAdapter.Fill(bufferTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!" + ex);
            }
            return bufferTable;
        }
        //показ и обновление данных ВУЗОВ
        public DataTable UpdateVUZ()
        {
            try
            {
                connection.Open();
                dataAdapter = new OleDbDataAdapter("SELECT * FROM ВУЗы", connection);
                bufferTable.Clear();
                dataAdapter.Fill(bufferTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!" + ex);
            }
            return bufferTable;

        }

        //Добавление данных в таблицу город
        public void AddCITY(int IDCITY, string NAMECity)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand($"INSERT INTO Города (ID_города, Название_города) VALUES(IDCITY, NAMECity)", connection);
                command.Parameters.AddWithValue("ID_города", IDCITY);
                command.Parameters.AddWithValue("Название_города", NAMECity);
                command.ExecuteNonQuery();
                MessageBox.Show("Успешное сохранение");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!" + ex);
            }
        }

        //Добавление данных в таблицу ВУЗы
        public void AddVUZ(int CODEVUZ, string NameVUZ, int IDCITY, string OfficialAdress, string Number, string SiteVUZ, string priznak)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand($"INSERT INTO ВУЗы(Код_ВУЗа,Наименование_ВУЗа,ID_города,Юридический_адрес,Номер_телефона,Веб_сайт,Признак)" +
                    $" VALUES(CODEVUZ,  NameVUZ,  IDCITY,  OfficialAdress,  Number,  SiteVUZ,  prizna)", connection);
                command.Parameters.AddWithValue("Код_ВУЗа", CODEVUZ);
                command.Parameters.AddWithValue("Наименование_ВУЗа", NameVUZ);
                command.Parameters.AddWithValue("ID_города", IDCITY);
                command.Parameters.AddWithValue("Юридический_адрес", OfficialAdress);
                command.Parameters.AddWithValue("Номер_телефона", Number);
                command.Parameters.AddWithValue("Веб_сайт", SiteVUZ);
                command.Parameters.AddWithValue("Признак", priznak);
                MessageBox.Show("Успешное сохранение");
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!" + ex);
            }
        }

        //Удаление из бд города
        public void DeleteCITY(int IDCITY)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand($"DELETE FROM Города WHERE ID_города = {IDCITY}", connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Успешное удаление данных");
                dataAdapter.Fill(bufferTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!" + ex);
            }

        }

        //Удаление из бд города
        public void DeleteVUZ(int CODEVUZ)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand($"DELETE FROM ВУЗы WHERE Код_ВУЗа = {CODEVUZ}", connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Успешное удаление данных");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!" + ex);
            }
        }

       /* public string source(string grayTXT1)
        {
           
        }*/
    }
}
