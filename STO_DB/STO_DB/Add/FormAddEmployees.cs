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
    public partial class FormAddEmployees : Form
    {
        ClassDB db;

        public FormAddEmployees()
        {
            InitializeComponent();
            db = new ClassDB();
            db.SearchPosition(cbPosition);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string factQuery;
            FormEmployees fe = new FormEmployees();
            factQuery = "(`surname`, `name`, `patronimyc`, `phone_number`,`position_position`) VALUES('" +
                      textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + cbPosition.Text + "');";
            db.Add("employees", factQuery, fe.dataGridView1);
            Hide();
        }
    }
}
