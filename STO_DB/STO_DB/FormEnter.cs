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
    public partial class FormEnter : Form
    {
        int statusLogin = 0;

        const int ADMIN = 1;
        const int USER = 2;


        public FormEnter()
        {
            InitializeComponent();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            switch (tbLogin.Text)
            {
                case "admin":
                    if (tbPass.Text == "admin")
                    {
                        MessageBox.Show("Вы вошли как админинстратор");
                        statusLogin = ADMIN;
                        FormMain fmAdmin = new FormMain(statusLogin);
                        fmAdmin.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Введены неверные данные");
                    }
                    break;

                case "user":
                    MessageBox.Show("Вы вошли как штатный сотрудник");
                    statusLogin = USER;
                    FormMain fmUser = new FormMain(statusLogin);
                    fmUser.ShowDialog();
                    break;

                default:
                    MessageBox.Show("Введены неверные данные");
                    break;
            }
        }
    }
}
