using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STO_DB
{
    class ClassDB
    {
        public static MySqlConnection GetDBConnection(string host, int port, string database, string username, string password)
        {
            String connString = "Server=" + host + ";Database=" + database
                 + ";port=" + port + ";User Id=" + username + ";password=" + password + ";CharSet=utf8";//;SslMode=none

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "sto_db";
            string username = "root"; //root/BOBAH
            string password = "0689";//0689/1234Z/root

            return GetDBConnection(host, port, database, username, password);
        }

        //Заполнение массива данными
        public List<string[]> LoadTables(string table, DataGridView dataSource)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT* FROM `sto_db`." + table, conn);
            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();

            int count = dataSource.ColumnCount;
            while (reader.Read())
            {
                data.Add(new string[count]);
                for (int i = 0; i < count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data)
            {
                dataSource.Rows.Add(s);
            }
            return data;
        }

        //Удаление
        public List<string[]> Delete(string table, string columnID, DataGridView dataSource)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("DELETE FROM `sto_db`. " + table + "WHERE `" + columnID + "` = '" + dataSource.CurrentRow.Cells[0].Value.ToString() + "' ;", conn);//DataSourceHK.CurrentRow.Cells[0].Value.ToString()
            Console.WriteLine(dataSource.CurrentRow.Cells[0].Value.ToString());
            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();

            int count = dataSource.ColumnCount;
            while (reader.Read())
            {
                data.Add(new string[count]);//ADD
                for (int i = 0; i < count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data)
            {
                dataSource.Rows.Add(s);
            }
            return data;
        }

        //Добавление элементов
        public List<string[]> Add(string table, string query, DataGridView dataSource)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `sto_db`." + table + query, conn);
            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();

            int count = dataSource.ColumnCount;
            while (reader.Read())
            {
                data.Add(new string[count]);
                for (int i = 0; i < count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data)
            {
                dataSource.Rows.Add(s);
            }
            return data;

        }

        //Поиск данных по машине
        public List<string[]> SearchCar(string table, string str, DataGridView dataSource)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT* FROM `sto_db`." + table + " WHERE number_sts LIKE '%" + str +
                "%' OR brand LIKE '%" + str +
                "%' OR model LIKE '%" + str +
                "%' OR year_created LIKE '%" + str +
                "%' OR date_to LIKE '%" + str +
                "%';", conn);
            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();

            int count = dataSource.ColumnCount;
            while (reader.Read())
            {
                data.Add(new string[count]);
                for (int i = 0; i < count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data)
            {
                dataSource.Rows.Add(s);
            }
            return data;
        }

        //Поиск данных по клиенту
        public List<string[]> SearchClient(string table, string str, DataGridView dataSource)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT* FROM `sto_db`." + table + " WHERE id_client LIKE '%" + str +
                "%' OR surname LIKE '%" + str +
                "%' OR name LIKE '%" + str +
                "%' OR patronimyc LIKE '%" + str +
                "%' OR cars_number_sts LIKE '%" + str +
                "%';", conn);
            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();

            int count = dataSource.ColumnCount;
            while (reader.Read())
            {
                data.Add(new string[count]);
                for (int i = 0; i < count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data)
            {
                dataSource.Rows.Add(s);
            }
            return data;
        }

        //Прсомотр информации о машине клиента
        public List<string[]> ShowInfoCar(string columnID, DataGridView dataSource, string curRow)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT clients." + columnID + ", cars.model, cars.brand FROM clients" +
                " JOIN cars ON clients.cars_number_sts = cars.number_sts WHERE clients.id_client = '" + curRow + "'", conn);
            Console.WriteLine(curRow);
            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();

            int count = dataSource.ColumnCount;
            while (reader.Read())
            {
                data.Add(new string[count]);//ADD
                for (int i = 0; i < count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data)
            {
                dataSource.Rows.Add(s);
            }
            return data;
        }

        //Информация по выбранному клиенту
        public List<string[]> ShowPickedClient(string table, string columnID, string curRow, string atribute, TextBox tbSource)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT " + atribute + " FROM sto_db." + table + " WHERE " + columnID + " = '" + curRow + "'", conn);
            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tbSource.Text = reader[0].ToString();
            }
            reader.Close();
            conn.Close();
            return data;
        }

        //Информация по выбранной машине
        public List<string[]> ShowPickedCar(string table1, string table2, string columnID1, string columnID2, string curRow, string atribute, TextBox tbSource)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT " + table2 + "." + atribute + " FROM " + table1 + " JOIN " + table2 + " ON " + table1 + ".cars_number_sts = " + table2 + "."
                + columnID2 + " WHERE " + table1 + "." + columnID1 + " = '" + curRow + "'", conn);
            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tbSource.Text = reader[0].ToString();
            }
            reader.Close();
            conn.Close();
            return data;
        }

        //Поиск номеров СТС машин
        public List<string[]> SearchSTSCars(ComboBox dataSource)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT number_sts FROM `sto_db`.cars", conn);
            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dataSource.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
            return data;
        }

        //Категории ремонтных работ
        public List<string[]> SearchCategories(ComboBox dataSource)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT name_categories_repairs FROM `sto_db`.categories_repairs", conn);
            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dataSource.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
            return data;
        }

        //Все ремонтные работы в категории
        public void SearchNameRepairs(string category, ComboBox dataSource)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT name FROM `sto_db`.repairs WHERE category = '" + category + "'", conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dataSource.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
        }

        //Цена выбранной ремонтной работы
        public void SearchCostRepairs(string name, ListBox dataSource)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT cost FROM `sto_db`.repairs WHERE name = '" + name + "'", conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dataSource.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
        }

        //Поиск должностей в таблице должностей
        public void SearchPosition(ComboBox dataSource)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT position FROM `sto_db`.position", conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dataSource.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
        }

        //Смена названий заголовков строк в таблице на неповторяющиеся фамилии сотрудников
        public void WorkHoursNameEmployees(DataGridView dataSource, List<int> idEmployees, List<string> surnameEmployees, List<DateTime> dates)
        {
            WorkHoursWeekDays(dates);//Заполнение таблицы дат в БД
            MySqlConnection conn = GetDBConnection();
            conn.Open();

            MySqlCommand command = new MySqlCommand("SELECT distinct surname, id_employee FROM employees", conn);//получение всех неповторяющихся сотрудников(их фамилий и id)

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int indexRow = dataSource.Rows.Add();
                dataSource.Rows[indexRow].HeaderCell.Value = reader[0].ToString();
                dataSource.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;

                surnameEmployees.Add(reader[0].ToString());
                idEmployees.Add(Convert.ToInt32(reader[1].ToString()));
            }

            for (int i = 0; i < dataSource.RowCount; i++)
            {
                for (int j = 0; j < dataSource.ColumnCount; j++)
                {
                    dataSource.Rows[i].Cells[j].Value = Works(idEmployees[i], dates[j].ToString("yyyy-MM-dd"));//
                }
            }

            reader.Close();
            conn.Close();
        }

        //Добавление дат на месяц(пока на неделю) и удаление ненужных дат, смен и работ в эти даты
        public void WorkHoursWeekDays(List<DateTime> dates)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();
            string values = "";

            for (int i = 0; i < dates.Count() - 1; i++)
            {
                values += "('" + dates[i].ToString("yyyy-MM-dd") + "'), ";
            }

            values += "('" + dates[dates.Count() - 1].ToString("yyyy-MM-dd") + "')";


            string valuesDelete = "";

            for (int i = 0; i < dates.Count() - 1; i++)
            {
                valuesDelete += "dates_of_month != '" + dates[i].ToString("yyyy-MM-dd") + "' and ";
            }

            valuesDelete += "dates_of_month != '" + dates[dates.Count() - 1].ToString("yyyy-MM-dd") + "'";

            MySqlCommand command = new MySqlCommand("delete t1 "
                + "from current_repairs t1 "
                + "join work_hours on work_hours.id_work_hours = t1.work_hours_id_work_hours and work_hours." + valuesDelete + "; "
                + "delete from work_hours where " + valuesDelete + ";"
                + "delete from dates_of_month where " + valuesDelete + ";"
                + "INSERT IGNORE INTO `sto_db`.dates_of_month (`dates_of_month`) VALUES " + values + ";", conn);//Добавить несколько дат из списка
            MySqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Close();
        }

        //Поиск среди всех дат и сотрудников рабочих смен
        public string Works(int id, string date)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT id_work_hours FROM sto_db.work_hours where employees_id_employee = '" + id
                + "' and dates_of_month = '" + date + "';", conn);
            MySqlDataReader reader = command.ExecuteReader();

            string result = "";

            while (reader.Read())
            {
                result = reader[0].ToString();
                result = "Работает";//
            }

            reader.Close();
            conn.Close();

            return result;
        }

        //Смена названий заголовков строк в таблице на неповторяющиеся фамилии сотрудников для расписания работ
        public void WorkHoursRepairsNameEmployees(DataGridView dataSource, List<int> idEmployees, List<string> surnameEmployees, List<DateTime> dates)
        {
            WorkHoursWeekDays(dates);//Заполнение таблицы дат в БД
            MySqlConnection conn = GetDBConnection();
            conn.Open();

            MySqlCommand command = new MySqlCommand("SELECT distinct surname, id_employee FROM employees", conn);//получение всех неповторяющихся сотрудников(их фамилий и id)

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int indexRow = dataSource.Rows.Add();
                dataSource.Rows[indexRow].HeaderCell.Value = reader[0].ToString();
                dataSource.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;

                surnameEmployees.Add(reader[0].ToString());
                idEmployees.Add(Convert.ToInt32(reader[1].ToString()));
            }

            int idWorkHours;

            for (int i = 0; i < dataSource.RowCount; i++)
            {
                for (int j = 0; j < dataSource.ColumnCount; j++)
                {
                    idWorkHours = SearchIdWorkHours(idEmployees[i], dates[j].ToString("yyyy-MM-dd"));
                    Console.WriteLine(idWorkHours);
                    dataSource.Rows[i].Cells[j].Value = CurrentRepairs(idWorkHours);//, 1, 22);
                }
            }

            reader.Close();
            conn.Close();
        }

        //Конкретная ремонтная работа
        public string CurrentRepairs(int idWorkHours)//, int idRepair, int idClient)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();

            MySqlCommand command = new MySqlCommand("SELECT clients.surname, repairs.name FROM current_repairs " +
                "JOIN clients ON current_repairs.clients_id_client = clients.id_client " +
                "JOIN repairs ON current_repairs.repairs_id_repair = repairs.id_repair " +
                "where work_hours_id_work_hours = '" + idWorkHours + "';", conn);

            //MySqlCommand command = new MySqlCommand("SELECT clients_id_client, repairs_id_repair FROM current_repairs where " +
            //    "work_hours_id_work_hours = '" + idWorkHours //+ "' and repairs_id_repair = '" + idRepair + "' and clients_id_client = '" + idClient 
            //    + "';", conn);
            MySqlDataReader reader = command.ExecuteReader();

            string result = "";

            while (reader.Read())
            {
                result += reader[0].ToString() + " - " + reader[1].ToString() + "\n";
            }

            reader.Close();
            conn.Close();

            return result;
        }

        //Поиск ID рабочих смен в таблице work_hours(рабочих смен)
        public int SearchIdWorkHours(int idEmployee, string date)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT id_work_hours FROM work_hours WHERE employees_id_employee = '" + idEmployee + "'" +
                " and dates_of_month = '" + date + "';", conn);
            MySqlDataReader reader = command.ExecuteReader();

            int resId = 0;

            while (reader.Read())
            {
                resId = Convert.ToInt32(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
            return resId;
        }

        //ID ремонтной работы по ее названию
        public int SearchIdRepairs(string name)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT id_repair FROM `sto_db`.repairs WHERE name = '" + name + "'", conn);
            MySqlDataReader reader = command.ExecuteReader();

            int resId = 0;

            while (reader.Read())
            {
                resId = Convert.ToInt32(reader[0].ToString());
            }

            reader.Close();
            conn.Close();

            return resId;
        }

        //Поиск данных по рабочим сменам
        public List<string[]> SearchWorkHours(string str, DataGridView dataSource)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();

            MySqlCommand command = new MySqlCommand("SELECT id_work_hours, dates_of_month, employees.surname, employees.position_position " +
                "FROM work_hours " +
                "JOIN employees ON work_hours.employees_id_employee = employees.id_employee " +
                "WHERE id_work_hours LIKE '%" + str +
                "%' OR dates_of_month LIKE '%" + str +
                "%' OR surname LIKE '%" + str +
                "%' OR position_position LIKE '%" + str +
                "%';", conn);

            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();

            int count = dataSource.ColumnCount;
            while (reader.Read())
            {
                data.Add(new string[count]);
                for (int i = 0; i < count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data)
            {
                dataSource.Rows.Add(s);
            }
            return data;
        }

        //Поиск данных по рабочим сменам для их дальнейшего выбора, с доп. информацией по работающему сотруднику
        public List<string[]> SearchWorkHoursForPic(DataGridView dataSource)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT id_work_hours, dates_of_month, employees.surname, employees.position_position FROM work_hours " +
                "JOIN employees ON work_hours.employees_id_employee = employees.id_employee; ", conn);
            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();

            int count = dataSource.ColumnCount;
            while (reader.Read())
            {
                data.Add(new string[count]);
                for (int i = 0; i < count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data)
            {
                dataSource.Rows.Add(s);
            }
            return data;
        }

        //Поиск сотрудников которые могут выполнять определенную работу и работают в данный момент
        public void SearchSurnameEmployeesForRepair(ComboBox dataSource, string nameRepair)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();

            DateTime today = DateTime.Today;

            MySqlCommand command = new MySqlCommand("SELECT employees.surname, employees.id_employee FROM repairs " +
                "JOIN employees ON repairs.position_position = employees.position_position " +
                "JOIN work_hours ON employees.id_employee = work_hours.employees_id_employee " +
                "WHERE repairs.name = '" + nameRepair + "' and work_hours.dates_of_month = '" + today.ToString("yyyy-MM-dd") + "'; ", conn);

            //MySqlCommand command = new MySqlCommand("SELECT employees.surname FROM repairs " +
            //    "JOIN employees ON repairs.position_position = employees.position_position " +
            //    "WHERE repairs.name = '" + nameRepair + "'; ", conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dataSource.Items.Add(reader[0].ToString() + "/id: " + reader[1].ToString());
            }
            reader.Close();
            conn.Close();
        }

        /*
        //Поиск ID сотрудника по его фамилии
        public void SearchIdEmployees(ComboBox dataSource, string nameRepair)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();

            DateTime today = DateTime.Today;

            MySqlCommand command = new MySqlCommand("SELECT employees.surname FROM repairs " +
                "JOIN employees ON repairs.position_position = employees.position_position " +
                "JOIN work_hours ON employees.id_employee = work_hours.employees_id_employee " +
                "WHERE repairs.name = '" + nameRepair + "' and work_hours.dates_of_month = '" + today.ToString("yyyy-MM-dd") + "'; ", conn);

            //MySqlCommand command = new MySqlCommand("SELECT employees.surname FROM repairs " +
            //    "JOIN employees ON repairs.position_position = employees.position_position " +
            //    "WHERE repairs.name = '" + nameRepair + "'; ", conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dataSource.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
        }
        */

        //Прсомотр информации о конкретной работе
        public List<string[]> ShowInfoCurrentRepair(string surnameEmployee, string date, DataGridView dataSource)
        {
            MySqlConnection conn = GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT repairs.name , clients.surname, cars.brand, cars.model, employees.surname, " +
                "employees.position_position, work_hours.dates_of_month, time_start, time_finish FROM current_repairs " +
                "join work_hours on current_repairs.work_hours_id_work_hours = work_hours.id_work_hours " +
                "join repairs on current_repairs.repairs_id_repair = repairs.id_repair " +
                "join clients on current_repairs.clients_id_client = clients.id_client " +
                "join cars on clients.cars_number_sts = cars.number_sts " +
                "join employees on work_hours.employees_id_employee = employees.id_employee " +
                "where work_hours.dates_of_month = '" + date + "' and employees.surname = '" + surnameEmployee + "';", conn);
            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();

            int count = dataSource.ColumnCount;
            while (reader.Read())
            {
                data.Add(new string[count]);
                for (int i = 0; i < count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data)
            {
                dataSource.Rows.Add(s);
            }
            return data;
        }
    }
}