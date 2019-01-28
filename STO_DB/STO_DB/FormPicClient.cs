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
    public partial class FormPicClient : Form
    {
        ClassDB db;
        public string currentRow;

        public FormPicClient()
        {
            InitializeComponent();
            db = new ClassDB();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].HeaderCell.Value = "ID Клиента";
            dataGridView1.Columns[1].HeaderCell.Value = "Фамилия";
            dataGridView1.Columns[2].HeaderCell.Value = "Имя";
            dataGridView1.Columns[3].HeaderCell.Value = "Отчество";
            dataGridView1.Columns[4].HeaderCell.Value = "Мобильный телефон";
            dataGridView1.Columns[5].HeaderCell.Value = "Номер СТС машины";
            db.LoadTables("clients", dataGridView1);
        }

        public void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentRow = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Hide();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            db.SearchClient("clients", tbSearch.Text, dataGridView1);
        }
    }
}
