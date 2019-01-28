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
    public partial class FormAddWorkHoursRepairs : Form
    {
        ClassDB db;
        int idRepair;
        int idClient;
        int idWorkHours;

        public FormAddWorkHoursRepairs()
        {
            InitializeComponent();
            db = new ClassDB();
            db.SearchCategories(cbCategoryRepair);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string factQuery;
            FormWorkHoursRepairs fwhr = new FormWorkHoursRepairs();
            factQuery = "(`work_hours_id_work_hours`, `repairs_id_repair`, `clients_id_client`, `time_start`, `time_finish`) VALUES('" +
                       idWorkHours + "', '" + idRepair + "', '" + idClient + "', '" + textBox4.Text + "', '" + textBox5.Text + "');";
            db.Add("current_repairs", factQuery, fwhr.dgvWorkHoursRepairs);
            Hide();
        }

        private void btPicClient_Click(object sender, EventArgs e)
        {
            FormPicClient fpc = new FormPicClient();
            fpc.ShowDialog();
            Console.WriteLine(fpc.currentRow);
            labelClient.Text = fpc.currentRow;
            idClient = Convert.ToInt32(fpc.currentRow);
        }

        private void cbCategoryRepair_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.SearchNameRepairs(cbCategoryRepair.Text.ToString(), cbNameRepair);
        }

        private void cbNameRepair_SelectedIndexChanged(object sender, EventArgs e)
        {
            idRepair = db.SearchIdRepairs(cbNameRepair.Text.ToString());
        }

        private void btPicWorkHours_Click(object sender, EventArgs e)
        {
            FormPicWorkHours fpwh = new FormPicWorkHours();
            fpwh.ShowDialog();
            Console.WriteLine(fpwh.currentRow);
            labelWorkHours.Text = fpwh.currentRow;
            idWorkHours = Convert.ToInt32(fpwh.currentRow);
        }
    }
}
