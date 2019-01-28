using STO_DB.Add;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STO_DB.Tables
{
    public partial class FormWorkHoursRepairs : Form
    {
        ClassDB db;
        List<DateTime> dates;
        List<int> idEmployees;
        List<string> surnameEmployees;
        
        //после каждой работы делать \n для переноса на следующую строчку

        //Добавить в таблицу информацию о клиенте, над машиной которого производились работы

        //пример строки: str += "Клиент:" + surnameClient + "Работа:" + nameRepairs + "\n";

        public FormWorkHoursRepairs()
        {
            InitializeComponent();
            db = new ClassDB();
            RefreshTable();
        }


        private void RefreshTable()
        {
            dates = new List<DateTime>();//Список дат
            idEmployees = new List<int>();//Список id сотрудников
            surnameEmployees = new List<string>();//Список фамилий сотрудников

            DateTime today = DateTime.Today;

            dates.Add(today);

            dgvWorkHoursRepairs.ColumnCount = 14;
            dgvWorkHoursRepairs.Columns[0].HeaderCell.Value = today.ToShortDateString();

            for (int i = 1; i < 14; i++)
            {
                dates.Add(today.AddDays(i));
                dgvWorkHoursRepairs.Columns[i].HeaderCell.Value = dates[i].ToShortDateString();
            }

            db.WorkHoursRepairsNameEmployees(dgvWorkHoursRepairs, idEmployees, surnameEmployees, dates);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddWorkHoursRepairs fawh = new FormAddWorkHoursRepairs();
            fawh.ShowDialog();
            dgvWorkHoursRepairs.Rows.Clear();
            RefreshTable();
        }

        private void dgvWorkHoursRepairs_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string surnameEmployee = dgvWorkHoursRepairs.Rows[dgvWorkHoursRepairs.CurrentCell.RowIndex].HeaderCell.Value.ToString();
            DateTime date = Convert.ToDateTime(dgvWorkHoursRepairs.Columns[dgvWorkHoursRepairs.CurrentCell.ColumnIndex].HeaderText.ToString());
            string strDate = date.ToString("yyyy-MM-dd");

            FormAboutCurrentRepair facr = new FormAboutCurrentRepair(surnameEmployee, strDate);
            facr.ShowDialog();
        }
    }
}
