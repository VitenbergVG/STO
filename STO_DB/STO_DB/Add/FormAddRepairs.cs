using STO_DB.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STO_DB.Add
{
    public partial class FormAddRepairs : Form
    {
        ClassDB db;

        public FormAddRepairs()
        {
            InitializeComponent();
            db = new ClassDB();
            db.SearchPosition(cbPosition);
            db.SearchCategories(cbCategory);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string factQuery;
            FormRepairs fc = new FormRepairs();
            factQuery = "(`id_repair`, `name`, `category`, `cost`, `position_position`) VALUES('" +
                      textBox1.Text + "', '" + textBox2.Text + "', '" + cbCategory.Text + "', '" + textBox4.Text + "', '" + cbPosition.Text + "');";
            db.Add("repairs", factQuery, fc.dataGridView1);
            this.Hide();
        }
    }
}
