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
    public partial class FormAddClients : Form
    {
        ClassDB db;

        public FormAddClients()
        {
            InitializeComponent();
            db = new ClassDB();
            db.SearchSTSCars(cbNumSTS);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string factQuery;
            FormClients fc = new FormClients();
            factQuery = "(`surname`, `name`, `patronimyc`, `phone_number`, `cars_number_sts`) VALUES('" +
                      textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + cbNumSTS.Text +"');";
            db.Add("clients", factQuery, fc.dataGridView1);
            this.Hide();
        }
    }
}

