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
    public partial class FormActions : Form
    {
        ClassDB db;

        public FormActions()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "Название";
            dataGridView1.Columns[2].HeaderCell.Value = "Текст";

            db = new ClassDB();
            db.LoadTables("actions", dataGridView1);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddAction faa = new FormAddAction();
            faa.ShowDialog();
            dataGridView1.Rows.Clear();
            db.LoadTables("actions", dataGridView1);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            db.Delete("`actions`", "id_action", dataGridView1);
            dataGridView1.Rows.Clear();
            db.LoadTables("actions", dataGridView1);
        }
    }
}
