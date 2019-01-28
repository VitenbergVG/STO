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

namespace STO_DB
{
    public partial class FormWorkHours : Form
    {
        ClassDB db;
        List<DateTime> dates;
        List<int> idEmployees;
        List<string> surnameEmployees;

        public FormWorkHours()
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

            dgvWorkHours.ColumnCount = 14;
            dgvWorkHours.Columns[0].HeaderCell.Value = today.ToShortDateString();

            for (int i = 1; i < 14; i++)
            {
                dates.Add(today.AddDays(i));
                dgvWorkHours.Columns[i].HeaderCell.Value = dates[i].ToShortDateString();
            }

            db.WorkHoursNameEmployees(dgvWorkHours, idEmployees, surnameEmployees, dates);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddWorkHours fawh = new FormAddWorkHours(dates, surnameEmployees, idEmployees);
            fawh.ShowDialog();
            dgvWorkHours.Rows.Clear();
            RefreshTable();
        }
    }
}
