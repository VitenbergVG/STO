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
    public partial class FormRepairs : Form
    {
        ClassDB db;
        public FormRepairs()
        {
            InitializeComponent();
            db = new ClassDB();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderCell.Value = "ID работы";
            dataGridView1.Columns[1].HeaderCell.Value = "Наименование";
            dataGridView1.Columns[2].HeaderCell.Value = "Категория";
            dataGridView1.Columns[3].HeaderCell.Value = "Цена";
            dataGridView1.Columns[4].HeaderCell.Value = "Должность";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            db.LoadTables("repairs", dataGridView1);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddRepairs fAdd = new FormAddRepairs();
            fAdd.ShowDialog();
            dataGridView1.Rows.Clear();
            db.LoadTables("repairs", dataGridView1);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            db.Delete("`repairs`", "id_repair", dataGridView1);
            dataGridView1.Rows.Clear();
            db.LoadTables("repairs", dataGridView1);
        }
    }
}
