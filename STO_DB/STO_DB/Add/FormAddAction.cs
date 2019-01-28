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
    public partial class FormAddAction : Form
    {
        ClassDB db;

        public FormAddAction()
        {
            InitializeComponent();
            db = new ClassDB();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string factQuery;
            FormActions fa = new FormActions();
            factQuery = "(`name`, `text`) VALUES('" + tbNameAction.Text + "', '" + tbTextAction.Text + "');";
            db.Add("actions", factQuery, fa.dataGridView1);
            Hide();
        }
    }
}
