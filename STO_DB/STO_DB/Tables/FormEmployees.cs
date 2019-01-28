using MySql.Data.MySqlClient;
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
    public partial class FormEmployees : Form
    {
        ClassDB db;

        public FormEmployees()
        {
            InitializeComponent();
            db = new ClassDB();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].HeaderCell.Value = "ID сотрудника";
            dataGridView1.Columns[1].HeaderCell.Value = "Фамилия";
            dataGridView1.Columns[2].HeaderCell.Value = "Имя";
            dataGridView1.Columns[3].HeaderCell.Value = "Отчество";
            dataGridView1.Columns[4].HeaderCell.Value = "Мобильный телефон";
            dataGridView1.Columns[5].HeaderCell.Value = "Должность";
            db.LoadTables("employees", dataGridView1);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddEmployees fAdd = new FormAddEmployees();
            fAdd.ShowDialog();
            dataGridView1.Rows.Clear();
            db.LoadTables("employees", dataGridView1);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            db.Delete("`employees`", "id_employee", dataGridView1);
            dataGridView1.Rows.Clear();
            db.LoadTables("employees", dataGridView1);
        }
    }
}
