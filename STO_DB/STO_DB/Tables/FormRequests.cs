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
    public partial class FormRequests : Form
    {
        ClassDB db;

        public FormRequests()
        {
            InitializeComponent();
            db = new ClassDB();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].HeaderCell.Value = "ID заявки";
            dataGridView1.Columns[1].HeaderCell.Value = "Категория";
            dataGridView1.Columns[2].HeaderCell.Value = "ID клиента";
            dataGridView1.Columns[3].HeaderCell.Value = "Описание";
            db.LoadTables("requests", dataGridView1);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            db.Delete("`requests`", "id_request", dataGridView1);
            dataGridView1.Rows.Clear();
            db.LoadTables("requests", dataGridView1);
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            db.LoadTables("requests", dataGridView1);
        }
    }
}
