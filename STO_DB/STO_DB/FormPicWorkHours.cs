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
    public partial class FormPicWorkHours : Form
    {
        ClassDB db;
        public string currentRow;

        public FormPicWorkHours()
        {
            InitializeComponent();
            db = new ClassDB();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].HeaderCell.Value = "ID Смены";
            dataGridView1.Columns[1].HeaderCell.Value = "Дата";
            dataGridView1.Columns[2].HeaderCell.Value = "Фамилия сотрудника";
            dataGridView1.Columns[3].HeaderCell.Value = "Должность";
            db.SearchWorkHoursForPic(dataGridView1);
        }

        public void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentRow = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Hide();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            db.SearchWorkHours(tbSearch.Text, dataGridView1);
        }
    }
}
