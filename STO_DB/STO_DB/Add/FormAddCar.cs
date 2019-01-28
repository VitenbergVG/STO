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
    public partial class FormAddCar : Form
    {
        ClassDB db;

        public FormAddCar()
        {
            InitializeComponent();
            db = new ClassDB();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
                    string factQuery;
                    FormCars fc = new FormCars();
                    factQuery = "(`number_sts`, `brand`, `model`, `year_created`, `date_to`) VALUES('" +
                              tbNumSTS.Text + "', '" + tbBrand.Text + "', '" + tbModel.Text + "', '" + tbYear.Text + "', '"
                              + tbDateTO.Text + "');";
                    db.Add("cars", factQuery, fc.dataGridView1);
                    Hide();
        }
    }
}

