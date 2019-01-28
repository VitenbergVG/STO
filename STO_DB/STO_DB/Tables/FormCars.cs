using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace STO_DB
{
    public partial class FormCars : Form
    {
        ClassDB db;

        public FormCars()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderCell.Value = "СТС";
            dataGridView1.Columns[1].HeaderCell.Value = "Марка";
            dataGridView1.Columns[2].HeaderCell.Value = "Модель";
            dataGridView1.Columns[3].HeaderCell.Value = "Год выпуска";
            dataGridView1.Columns[4].HeaderCell.Value = "Дата последнего ТО";
            db = new ClassDB();
            db.LoadTables("cars", dataGridView1);
        }        

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddCar fAdd = new FormAddCar();
            fAdd.ShowDialog();
            dataGridView1.Rows.Clear();
            db.LoadTables("cars", dataGridView1);
        }

        private void btDelete_Click(object sender, EventArgs e)
        { 
            db.Delete("`cars`", "number_sts", dataGridView1);
            dataGridView1.Rows.Clear();
            db.LoadTables("cars", dataGridView1);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            db.SearchCar("cars", tbSearch.Text, dataGridView1);
        }
    }
}
