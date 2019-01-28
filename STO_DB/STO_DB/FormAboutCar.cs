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
    public partial class FormAboutCar : Form
    {
        ClassDB db;

        public FormAboutCar(string curRow)
        {
            InitializeComponent();
            db = new ClassDB();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].HeaderCell.Value = "id";
            dataGridView1.Columns[1].HeaderCell.Value = "Модель";
            dataGridView1.Columns[2].HeaderCell.Value = "Марка";
            db.ShowInfoCar("id_client",dataGridView1, curRow);
        }


    }
}
