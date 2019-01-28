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

namespace STO_DB
{
    public partial class FormMain : Form
    {
        //StatusLogin
        const int ADMIN = 1;
        const int USER = 2;

        public FormMain(int statusLogin)
        {
            InitializeComponent();
            if (statusLogin == USER)
            {
                btEmployees.Visible = false;
                btActions.Visible = false;
                btWorkHours.Visible = false;
            }
        }

        private void btClients_Click(object sender, EventArgs e)
        {
            FormClients fc = new FormClients();
            fc.ShowDialog();
        }

        private void btCars_Click(object sender, EventArgs e)
        {
            FormCars fCars = new FormCars();
            fCars.ShowDialog();
        }

        private void btTodayClients_Click(object sender, EventArgs e)
        {
            FormClientsToday fct = new FormClientsToday();
            fct.ShowDialog();
        }

        private void btAbout_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void btEmployees_Click(object sender, EventArgs e)
        {
            FormEmployees fe = new FormEmployees();
            fe.ShowDialog();
        }

        private void btRequests_Click(object sender, EventArgs e)
        {
            FormRequests fr = new FormRequests();
            fr.ShowDialog();
        }

        private void btRepairs_Click(object sender, EventArgs e)
        {
            FormRepairs fr = new FormRepairs();
            fr.ShowDialog();
        }

        private void btWorkHours_Click(object sender, EventArgs e)
        {
            FormWorkHours fwh = new FormWorkHours();
            fwh.ShowDialog();
        }

        private void btActions_Click(object sender, EventArgs e)
        {
            FormActions fa = new FormActions();
            fa.ShowDialog();
        }

        private void btWorkHoursRepairs_Click(object sender, EventArgs e)
        {
            FormWorkHoursRepairs fwhr = new FormWorkHoursRepairs();
            fwhr.ShowDialog();

            //Сделать окно наподобии formWorkHours только вместо слова работает чтобы 
            //там появлялись конкретные работы, которые можно добавить по нажатию на кнопку добавления

            //в таблице так же должны быть столбцы-даты и строки-сотрудники.

            //после каждой работы делать \n для переноса на следующую строчку

            //Добавить в таблицу информацию о клиенте, над машиной которого производились работы

            //пример строки: str += "Клиент:" + surnameClient + "Работа:" + nameRepairs + "\n";
        }
    }
}
