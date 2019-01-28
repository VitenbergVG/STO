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
    public partial class FormAboutCurrentRepair : Form
    {
        ClassDB db;

        public FormAboutCurrentRepair(string surnameEmployee, string date)
        {
            InitializeComponent();
            db = new ClassDB();
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].HeaderCell.Value = "Ремонтная работа";
            dataGridView1.Columns[1].HeaderCell.Value = "Фамилия клиента";
            dataGridView1.Columns[2].HeaderCell.Value = "Марка автомобиля";
            dataGridView1.Columns[3].HeaderCell.Value = "Модель автомобиля";
            dataGridView1.Columns[4].HeaderCell.Value = "Фамилия сотрудника";
            dataGridView1.Columns[5].HeaderCell.Value = "Должность сотрудника";
            dataGridView1.Columns[6].HeaderCell.Value = "Дата";
            dataGridView1.Columns[7].HeaderCell.Value = "Время начала";
            dataGridView1.Columns[8].HeaderCell.Value = "Время окончания";
            db.ShowInfoCurrentRepair(surnameEmployee, date, dataGridView1);
        }
    }
}
