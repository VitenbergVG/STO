using STO_DB.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STO_DB
{
    public partial class FormClientsToday : Form
    {
        ClassDB db;

        int i = 1;

        string timeStartRepair;

        public FormClientsToday()
        {
            InitializeComponent();
            db = new ClassDB();
        }

        private void btNewClient_Click(object sender, EventArgs e)
        {
            timeStartRepair = DateTime.Now.ToString("HH:mm:ss");
            DialogResult dialogResult = MessageBox.Show("Добавить клиента из уже существующих?", "Новый клиент", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FormPicClient fpc = new FormPicClient();
                fpc.ShowDialog();
                Console.WriteLine(fpc.currentRow);
                CreateTab(fpc.currentRow);
            }
            else if (dialogResult == DialogResult.No)
            {
                CreateTab();
            }

        }

        //Для неизвестного клиента
        private void CreateTab()
        {
            //добавление вкладки
            TabPage newTabPage = new TabPage();
            newTabPage.Text = "Клиент" + i++;
            tabControl1.TabPages.Add(newTabPage);

            Label lbIdDriver = new Label();
            TextBox tbIdDriver = new TextBox();

            Label lbSurnameDriver = new Label();
            TextBox tbSurnameDriver = new TextBox();

            Label lbNameDriver = new Label();
            TextBox tbNameDriver = new TextBox();

            Label lbPatronimycDriver = new Label();
            TextBox tbPatronimycDriver = new TextBox();

            Label lbModelCar = new Label();
            TextBox tbModelCar = new TextBox();

            Label lbBrandCar = new Label();
            TextBox tbBrandCar = new TextBox();

            Label lbYearCar = new Label();
            TextBox tbYearCar = new TextBox();

            Label lbNumberSTSCar = new Label();
            TextBox tbNumberSTSCar = new TextBox();

            Label lbPhoneNumber = new Label();
            TextBox tbPhoneNumber = new TextBox();

            lbIdDriver.Text = "ID водителя: ";
            lbIdDriver.Width = 130;
            lbIdDriver.Location = new Point(10, 20);
            newTabPage.Controls.Add(lbIdDriver);

            tbIdDriver.Location = new Point(150, 20);
            newTabPage.Controls.Add(tbIdDriver);

            lbSurnameDriver.Text = "Фамилия водителя: ";
            lbSurnameDriver.Width = 130;
            lbSurnameDriver.Location = new Point(10, 50);
            newTabPage.Controls.Add(lbSurnameDriver);

            tbSurnameDriver.Location = new Point(150, 50);
            newTabPage.Controls.Add(tbSurnameDriver);

            lbNameDriver.Text = "Имя водителя: ";
            lbNameDriver.Width = 130;
            lbNameDriver.Location = new Point(10, 80);
            newTabPage.Controls.Add(lbNameDriver);

            tbNameDriver.Location = new Point(150, 80);
            newTabPage.Controls.Add(tbNameDriver);

            lbPatronimycDriver.Text = "Отчество водителя: ";
            lbPatronimycDriver.Width = 130;
            lbPatronimycDriver.Location = new Point(10, 110);
            newTabPage.Controls.Add(lbPatronimycDriver);

            tbPatronimycDriver.Location = new Point(150, 110);
            newTabPage.Controls.Add(tbPatronimycDriver);

            lbPhoneNumber.Text = "Мобильный телефон: ";
            lbPhoneNumber.Width = 130;
            lbPhoneNumber.Location = new Point(10, 140);
            newTabPage.Controls.Add(lbPhoneNumber);

            tbPhoneNumber.Location = new Point(150, 140);
            newTabPage.Controls.Add(tbPhoneNumber);

            lbModelCar.Text = "Модель машины: ";
            lbModelCar.Width = 130;
            lbModelCar.Location = new Point(10, 170);
            newTabPage.Controls.Add(lbModelCar);

            tbModelCar.Location = new Point(150, 170);
            newTabPage.Controls.Add(tbModelCar);

            lbBrandCar.Text = "Марка машины: ";
            lbBrandCar.Width = 130;
            lbBrandCar.Location = new Point(10, 200);
            newTabPage.Controls.Add(lbBrandCar);

            tbBrandCar.Location = new Point(150, 200);
            newTabPage.Controls.Add(tbBrandCar);

            lbYearCar.Text = "Год выпуска: ";
            lbYearCar.Width = 130;
            lbYearCar.Location = new Point(10, 230);
            newTabPage.Controls.Add(lbYearCar);

            tbYearCar.Location = new Point(150, 230);
            newTabPage.Controls.Add(tbYearCar);

            lbNumberSTSCar.Text = "Номер СТС: ";
            lbNumberSTSCar.Width = 130;
            lbNumberSTSCar.Location = new Point(10, 260);
            newTabPage.Controls.Add(lbNumberSTSCar);

            tbNumberSTSCar.Location = new Point(150, 260);
            newTabPage.Controls.Add(tbNumberSTSCar);


            Label lbAddRepairs = new Label();
            lbAddRepairs.Text = "Добавить ремонтную работу:";
            lbAddRepairs.Width = 200;
            lbAddRepairs.Location = new Point(300, 20);
            newTabPage.Controls.Add(lbAddRepairs);

            //Сотрудник, выполняющий работу
            Label lbEmployee = new Label();
            lbEmployee.Text = "Сотрудник, выполняющий работу:";
            lbEmployee.Width = 200;
            lbEmployee.Location = new Point(300, 170);
            newTabPage.Controls.Add(lbEmployee);

            ComboBox cbEmployee = new ComboBox();
            cbEmployee.Location = new Point(300, 200);
            cbEmployee.Width = 260;
            cbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            newTabPage.Controls.Add(cbEmployee);

            //Ремонтная работа
            Label lbNameRepairs = new Label();
            lbNameRepairs.Text = "Ремонтная работа:";
            lbNameRepairs.Width = 200;
            lbNameRepairs.Location = new Point(300, 110);
            newTabPage.Controls.Add(lbNameRepairs);

            ComboBox cbNameRepairs = new ComboBox();
            cbNameRepairs.Location = new Point(300, 140);
            cbNameRepairs.Width = 260;
            cbNameRepairs.DropDownStyle = ComboBoxStyle.DropDownList;
            newTabPage.Controls.Add(cbNameRepairs);
            cbNameRepairs.SelectedIndexChanged += (sender, e) =>
            {
                cbEmployee.Items.Clear();
                db.SearchSurnameEmployeesForRepair(cbEmployee, cbNameRepairs.Text.ToString());
            };

            //Категория ремнотной работы
            Label lbCategoryRepairs = new Label();
            lbCategoryRepairs.Text = "Категория ремнотной работы:";
            lbCategoryRepairs.Width = 200;
            lbCategoryRepairs.Location = new Point(300, 50);
            newTabPage.Controls.Add(lbCategoryRepairs);

            ComboBox cbCategoryRepairs = new ComboBox();
            cbCategoryRepairs.Location = new Point(300, 80);
            cbCategoryRepairs.Width = 260;
            db.SearchCategories(cbCategoryRepairs);
            cbCategoryRepairs.DropDownStyle = ComboBoxStyle.DropDownList;
            newTabPage.Controls.Add(cbCategoryRepairs);
            cbCategoryRepairs.SelectedIndexChanged += (sender, e) =>
            {
                cbNameRepairs.Items.Clear();
                db.SearchNameRepairs(cbCategoryRepairs.Text.ToString(), cbNameRepairs);
            };

            //Кнопка сохранить
            Button btSaveChanges = new Button();
            btSaveChanges.Height = 50;
            btSaveChanges.Width = 150;
            btSaveChanges.Text = "Сохранить изменения";
            btSaveChanges.Location = new Point(200, 400);
            newTabPage.Controls.Add(btSaveChanges);
            btSaveChanges.Click += (sender, args) =>
            {
                if (tbSurnameDriver.Text == "" || tbNameDriver.Text == "" || tbPatronimycDriver.Text == "" || tbBrandCar.Text == ""
                || tbModelCar.Text == "" || tbYearCar.Text == "" || tbNumberSTSCar.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните все поля");
                    return;
                }

                AddClientToDB(tbSurnameDriver.Text, tbNameDriver.Text, tbPatronimycDriver.Text, tbPhoneNumber.Text, tbBrandCar.Text, tbModelCar.Text,
                tbYearCar.Text, tbNumberSTSCar.Text);
                newTabPage.Text = tbNameDriver.Text + "/" + tbModelCar.Text;
                MessageBox.Show("Изменения сохранены");
            };

            Label lbRepairs = new Label();
            lbRepairs.Text = "Ремонтные работы по машине:";
            lbRepairs.Width = 200;
            lbRepairs.Location = new Point(600, 20);
            newTabPage.Controls.Add(lbRepairs);

            Label labRepairsCosts = new Label();
            labRepairsCosts.Text = "Стоимость:";
            labRepairsCosts.Width = 70;
            labRepairsCosts.Location = new Point(910, 20);
            newTabPage.Controls.Add(labRepairsCosts);

            Label labEmployeesRepairs = new Label();
            labEmployeesRepairs.Text = "Сотрудник:";
            labEmployeesRepairs.Width = 200;
            labEmployeesRepairs.Location = new Point(990, 20);
            newTabPage.Controls.Add(labEmployeesRepairs);
            
            //Список цен на работы
            ListBox lbRepairsCosts = new ListBox();
            lbRepairsCosts.Height = 500;
            lbRepairsCosts.Width = 70;
            lbRepairsCosts.Location = new Point(910, 50);
            newTabPage.Controls.Add(lbRepairsCosts);

            //Список сотруников, выполняющих работу
            ListBox lbEmployeesRepairs = new ListBox();
            lbEmployeesRepairs.Height = 500;
            lbEmployeesRepairs.Width = 150;
            lbEmployeesRepairs.Location = new Point(990, 50);
            newTabPage.Controls.Add(lbEmployeesRepairs);

            //Список работ проводимых по машине
            CheckedListBox clbRepairs = new CheckedListBox();
            clbRepairs.Height = 500;
            clbRepairs.Width = 300;
            clbRepairs.Location = new Point(600, 50);
            newTabPage.Controls.Add(clbRepairs);
            clbRepairs.SelectedIndexChanged += (sender, args) =>
            {
                lbEmployeesRepairs.SelectedIndex = clbRepairs.SelectedIndex;
                lbRepairsCosts.SelectedIndex = clbRepairs.SelectedIndex;

                if (clbRepairs.GetItemChecked(clbRepairs.SelectedIndex)) //&& clbRepairs.SelectedIndex != -1) - проверка для того чтобы нельзя было нажать на пустой clb
                {
                    string[] strEmployee = lbEmployeesRepairs.SelectedItem.ToString().Split(new char[] { ' ' });
                    int idEmployee = Convert.ToInt32(strEmployee[strEmployee.Length - 1]);

                    string factQuery;
                    FormWorkHoursRepairs fwhr = new FormWorkHoursRepairs();
                    factQuery = "(`work_hours_id_work_hours`, `repairs_id_repair`, `clients_id_client`, `time_start`, `time_finish`) VALUES('" +
                               db.SearchIdWorkHours(idEmployee, DateTime.Today.ToString("yyyy-MM-dd")) + "', '" +
                               db.SearchIdRepairs(clbRepairs.SelectedItem.ToString()) +
                               "', '" + tbIdDriver.Text + "', '" + timeStartRepair + "', '" + DateTime.Now.ToString("HH:mm:ss") + "');";
                    db.Add("current_repairs", factQuery, fwhr.dgvWorkHoursRepairs);
                }
            };

            //Общая стоимость
            Label lbRepairsTotalCost = new Label();
            lbRepairsTotalCost.Text = "Итоговая стоимость:\n" + 0 + " рублей";
            lbRepairsTotalCost.Width = 100;
            lbRepairsTotalCost.Height = 100;
            lbRepairsTotalCost.Location = new Point(910, 550);
            newTabPage.Controls.Add(lbRepairsTotalCost);

            //Кнопка добавить ремонтные работы
            Button btAddRepairs = new Button();
            btAddRepairs.Height = 50;
            btAddRepairs.Width = 150;
            btAddRepairs.Text = "Добавить работу по машине";
            btAddRepairs.Location = new Point(300, 260);
            newTabPage.Controls.Add(btAddRepairs);
            btAddRepairs.Click += (sender, args) =>
            {
                if (cbNameRepairs.Text != "" && cbEmployee.Text != "")
                {
                    clbRepairs.Items.Add(cbNameRepairs.Text);
                    db.SearchCostRepairs(cbNameRepairs.Text, lbRepairsCosts);
                    lbEmployeesRepairs.Items.Add(cbEmployee.Text);
                    int totalCost = 0;

                    for (int i = 0; i < lbRepairsCosts.Items.Count; i++)
                    {
                        totalCost += Convert.ToInt32(lbRepairsCosts.Items[i].ToString());
                    }

                    lbRepairsTotalCost.Text = "Итоговая стоимость:\n" + totalCost + " рублей";
                }
                else
                {
                    MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка");
                }
            };


            //Печать
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.PrintPage += (sender, e) =>
            {
                String repairs = "";
                for (int i = 0; i < clbRepairs.Items.Count; i++)
                {
                    repairs += i + 1 + ". " + clbRepairs.Items[i].ToString() + "\n";
                }

                String result =
                tbNameDriver.Text + ", спасибо, что выбрали именно нас!" + "\n\n" +
                "\t" + "Счёт на оказание услуг авторемонта:" + "\n\n" +
                repairs + "\n" +
                "Итоговая стоимость: ";

                int totalCost = 0;
                String costs = "";
                for (int i = 0; i < lbRepairsCosts.Items.Count; i++)
                {
                    costs += lbRepairsCosts.Items[i].ToString() + " рублей" + "\n";
                    totalCost += Convert.ToInt32(lbRepairsCosts.Items[i].ToString());
                }

                String resultCost = costs + "\n" + totalCost + " рублей";

                e.Graphics.DrawString(result, new Font("Arial", 12), Brushes.Black, 100, 100);
                e.Graphics.DrawString(resultCost, new Font("Arial", 12), Brushes.Black, 600, 160);
            };

            //Кнопка Печать - составление счёта на оказание услуг
            Button btPrint = new Button();
            btPrint.Height = 50;
            btPrint.Width = 150;
            btPrint.Text = "Печатать счёт";
            btPrint.Location = new Point(30, 400);
            newTabPage.Controls.Add(btPrint);
            btPrint.Click += (sender, args) =>
            {
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument1;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            };

            //Кнопка завершить работу по клиенту
            Button btFinishRepair = new Button();
            btFinishRepair.Height = 50;
            btFinishRepair.Width = 150;
            btFinishRepair.Text = "Завершить работу по машине";
            btFinishRepair.Location = new Point(370, 400);
            newTabPage.Controls.Add(btFinishRepair);
            btFinishRepair.Click += (sender, args) =>
            {
                tabControl1.TabPages.Remove(newTabPage);
            };
        }

        //Для клиента из БД
        private void CreateTab(string currentClient)
        {
            //id Клиента
            int idClient;

            //добавление вкладки
            TabPage newTabPage = new TabPage();
            newTabPage.Text = "Клиент" + i++;
            tabControl1.TabPages.Add(newTabPage);

            Label lbIdDriver = new Label();
            TextBox tbIdDriver = new TextBox();

            Label lbSurnameDriver = new Label();
            TextBox tbSurnameDriver = new TextBox();

            Label lbNameDriver = new Label();
            TextBox tbNameDriver = new TextBox();

            Label lbPatronimycDriver = new Label();
            TextBox tbPatronimycDriver = new TextBox();

            Label lbModelCar = new Label();
            TextBox tbModelCar = new TextBox();

            Label lbBrandCar = new Label();
            TextBox tbBrandCar = new TextBox();

            Label lbYearCar = new Label();
            TextBox tbYearCar = new TextBox();

            Label lbNumberSTSCar = new Label();
            TextBox tbNumberSTSCar = new TextBox();

            Label lbPhoneNumber = new Label();
            TextBox tbPhoneNumber = new TextBox();

            lbIdDriver.Text = "ID водителя: ";
            lbIdDriver.Width = 130;
            lbIdDriver.Location = new Point(10, 20);
            newTabPage.Controls.Add(lbIdDriver);

            tbIdDriver.Location = new Point(150, 20);
            db.ShowPickedClient("clients", "id_client", currentClient, "id_client", tbIdDriver);
            newTabPage.Controls.Add(tbIdDriver);

            lbSurnameDriver.Text = "Фамилия водителя: ";
            lbSurnameDriver.Width = 130;
            lbSurnameDriver.Location = new Point(10, 50);
            newTabPage.Controls.Add(lbSurnameDriver);

            tbSurnameDriver.Location = new Point(150, 50);
            db.ShowPickedClient("clients", "id_client", currentClient, "surname", tbSurnameDriver);
            newTabPage.Controls.Add(tbSurnameDriver);

            lbNameDriver.Text = "Имя водителя: ";
            lbNameDriver.Width = 130;
            lbNameDriver.Location = new Point(10, 80);
            newTabPage.Controls.Add(lbNameDriver);

            tbNameDriver.Location = new Point(150, 80);
            db.ShowPickedClient("clients", "id_client", currentClient, "name", tbNameDriver);
            newTabPage.Controls.Add(tbNameDriver);

            lbPatronimycDriver.Text = "Отчество водителя: ";
            lbPatronimycDriver.Width = 130;
            lbPatronimycDriver.Location = new Point(10, 110);
            newTabPage.Controls.Add(lbPatronimycDriver);

            tbPatronimycDriver.Location = new Point(150, 110);
            db.ShowPickedClient("clients", "id_client", currentClient, "patronimyc", tbPatronimycDriver);
            newTabPage.Controls.Add(tbPatronimycDriver);

            lbPhoneNumber.Text = "Мобильный телефон: ";
            lbPhoneNumber.Width = 130;
            lbPhoneNumber.Location = new Point(10, 140);
            db.ShowPickedClient("clients", "id_client", currentClient, "phone_number", tbPhoneNumber);
            newTabPage.Controls.Add(lbPhoneNumber);

            tbPhoneNumber.Location = new Point(150, 140);
            newTabPage.Controls.Add(tbPhoneNumber);

            lbModelCar.Text = "Модель машины: ";
            lbModelCar.Width = 130;
            lbModelCar.Location = new Point(10, 170);
            db.ShowPickedCar("clients", "cars", "id_client", "number_sts", currentClient, "model", tbModelCar);
            newTabPage.Controls.Add(lbModelCar);

            tbModelCar.Location = new Point(150, 170);
            newTabPage.Controls.Add(tbModelCar);

            lbBrandCar.Text = "Марка машины: ";
            lbBrandCar.Width = 130;
            lbBrandCar.Location = new Point(10, 200);
            db.ShowPickedCar("clients", "cars", "id_client", "number_sts", currentClient, "brand", tbBrandCar);
            newTabPage.Controls.Add(lbBrandCar);

            tbBrandCar.Location = new Point(150, 200);
            newTabPage.Controls.Add(tbBrandCar);

            lbYearCar.Text = "Год выпуска: ";
            lbYearCar.Width = 130;
            lbYearCar.Location = new Point(10, 230);
            db.ShowPickedCar("clients", "cars", "id_client", "number_sts", currentClient, "year_created", tbYearCar);
            newTabPage.Controls.Add(lbYearCar);

            tbYearCar.Location = new Point(150, 230);
            newTabPage.Controls.Add(tbYearCar);

            lbNumberSTSCar.Text = "Номер СТС: ";
            lbNumberSTSCar.Width = 130;
            lbNumberSTSCar.Location = new Point(10, 260);
            db.ShowPickedCar("clients", "cars", "id_client", "number_sts", currentClient, "number_sts", tbNumberSTSCar);
            newTabPage.Controls.Add(lbNumberSTSCar);

            tbNumberSTSCar.Location = new Point(150, 260);
            newTabPage.Controls.Add(tbNumberSTSCar);

            newTabPage.Text = tbNameDriver.Text + "/" + tbModelCar.Text;

            Label lbAddRepairs = new Label();
            lbAddRepairs.Text = "Добавить ремонтную работу:";
            lbAddRepairs.Width = 200;
            lbAddRepairs.Location = new Point(300, 20);
            newTabPage.Controls.Add(lbAddRepairs);

            //Сотрудник, выполняющий работу
            Label lbEmployee = new Label();
            lbEmployee.Text = "Сотрудник, выполняющий работу:";
            lbEmployee.Width = 200;
            lbEmployee.Location = new Point(300, 170);
            newTabPage.Controls.Add(lbEmployee);

            ComboBox cbEmployee = new ComboBox();
            cbEmployee.Location = new Point(300, 200);
            cbEmployee.Width = 260;
            cbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            newTabPage.Controls.Add(cbEmployee);

            //Ремонтная работа
            Label lbNameRepairs = new Label();
            lbNameRepairs.Text = "Ремонтная работа:";
            lbNameRepairs.Width = 200;
            lbNameRepairs.Location = new Point(300, 110);
            newTabPage.Controls.Add(lbNameRepairs);

            ComboBox cbNameRepairs = new ComboBox();
            cbNameRepairs.Location = new Point(300, 140);
            cbNameRepairs.Width = 260;
            cbNameRepairs.DropDownStyle = ComboBoxStyle.DropDownList;
            newTabPage.Controls.Add(cbNameRepairs);
            cbNameRepairs.SelectedIndexChanged += (sender, e) =>
            {
                cbEmployee.Items.Clear();
                db.SearchSurnameEmployeesForRepair(cbEmployee, cbNameRepairs.Text.ToString());
            };

            //Категория ремнотной работы
            Label lbCategoryRepairs = new Label();
            lbCategoryRepairs.Text = "Категория ремнотной работы:";
            lbCategoryRepairs.Width = 200;
            lbCategoryRepairs.Location = new Point(300, 50);
            newTabPage.Controls.Add(lbCategoryRepairs);

            ComboBox cbCategoryRepairs = new ComboBox();
            cbCategoryRepairs.Location = new Point(300, 80);
            cbCategoryRepairs.Width = 260;
            db.SearchCategories(cbCategoryRepairs);
            cbCategoryRepairs.DropDownStyle = ComboBoxStyle.DropDownList;
            newTabPage.Controls.Add(cbCategoryRepairs);
            cbCategoryRepairs.SelectedIndexChanged += (sender, e) =>
            {
                cbNameRepairs.Items.Clear();
                db.SearchNameRepairs(cbCategoryRepairs.Text.ToString(), cbNameRepairs);
            };

            //Кнопка сохранить
            Button btSaveChanges = new Button();
            btSaveChanges.Height = 50;
            btSaveChanges.Width = 150;
            btSaveChanges.Text = "Сохранить изменения";
            btSaveChanges.Location = new Point(200, 400);
            newTabPage.Controls.Add(btSaveChanges);
            btSaveChanges.Click += (sender, args) =>
            {
                if (tbSurnameDriver.Text == "" || tbNameDriver.Text == "" || tbPatronimycDriver.Text == "" || tbBrandCar.Text == ""
                || tbModelCar.Text == "" || tbYearCar.Text == "" || tbNumberSTSCar.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните все поля");
                    return;
                }

                AddClientToDB(tbSurnameDriver.Text, tbNameDriver.Text, tbPatronimycDriver.Text, tbPhoneNumber.Text, tbBrandCar.Text, tbModelCar.Text,
                tbYearCar.Text, tbNumberSTSCar.Text);
                newTabPage.Text = tbNameDriver.Text + "/" + tbModelCar.Text;
                MessageBox.Show("Изменения сохранены");
            };

            Label lbRepairs = new Label();
            lbRepairs.Text = "Ремонтные работы по машине:";
            lbRepairs.Width = 200;
            lbRepairs.Location = new Point(600, 20);
            newTabPage.Controls.Add(lbRepairs);

            Label labRepairsCosts = new Label();
            labRepairsCosts.Text = "Стоимость:";
            labRepairsCosts.Width = 70;
            labRepairsCosts.Location = new Point(910, 20);
            newTabPage.Controls.Add(labRepairsCosts);

            Label labEmployeesRepairs = new Label();
            labEmployeesRepairs.Text = "Сотрудник:";
            labEmployeesRepairs.Width = 200;
            labEmployeesRepairs.Location = new Point(990, 20);
            newTabPage.Controls.Add(labEmployeesRepairs);

            //Список цен на работы
            ListBox lbRepairsCosts = new ListBox();
            lbRepairsCosts.Height = 500;
            lbRepairsCosts.Width = 70;
            lbRepairsCosts.Location = new Point(910, 50);
            newTabPage.Controls.Add(lbRepairsCosts);

            //Список сотруников, выполняющих работу
            ListBox lbEmployeesRepairs = new ListBox();
            lbEmployeesRepairs.Height = 500;
            lbEmployeesRepairs.Width = 150;
            lbEmployeesRepairs.Location = new Point(990, 50);
            newTabPage.Controls.Add(lbEmployeesRepairs);

            //Список работ проводимых по машине
            CheckedListBox clbRepairs = new CheckedListBox();
            clbRepairs.Height = 500;
            clbRepairs.Width = 300;
            clbRepairs.Location = new Point(600, 50);
            newTabPage.Controls.Add(clbRepairs);
            clbRepairs.SelectedIndexChanged += (sender, args) =>
            {
                lbEmployeesRepairs.SelectedIndex = clbRepairs.SelectedIndex;
                lbRepairsCosts.SelectedIndex = clbRepairs.SelectedIndex;

                if (clbRepairs.GetItemChecked(clbRepairs.SelectedIndex)) //&& clbRepairs.SelectedIndex != -1) - проверка для того чтобы нельзя было нажать на пустой clb
                {
                    string[] strEmployee = lbEmployeesRepairs.SelectedItem.ToString().Split(new char[] { ' ' });
                    int idEmployee = Convert.ToInt32(strEmployee[strEmployee.Length - 1]);

                    string factQuery;
                    FormWorkHoursRepairs fwhr = new FormWorkHoursRepairs();
                    factQuery = "(`work_hours_id_work_hours`, `repairs_id_repair`, `clients_id_client`, `time_start`, `time_finish`) VALUES('" +
                               db.SearchIdWorkHours(idEmployee,DateTime.Today.ToString("yyyy-MM-dd")) + "', '" +
                               db.SearchIdRepairs(clbRepairs.SelectedItem.ToString()) +
                               "', '" + tbIdDriver.Text + "', '" + timeStartRepair + "', '" + DateTime.Now.ToString("HH:mm:ss") + "');";
                    db.Add("current_repairs", factQuery, fwhr.dgvWorkHoursRepairs);
                }
            };

            //Общая стоимость
            Label lbRepairsTotalCost = new Label();
            lbRepairsTotalCost.Text = "Итоговая стоимость:\n" + 0 + " рублей";
            lbRepairsTotalCost.Width = 100;
            lbRepairsTotalCost.Height = 100;
            lbRepairsTotalCost.Location = new Point(910, 550);
            newTabPage.Controls.Add(lbRepairsTotalCost);

            //Кнопка добавить ремонтные работы
            Button btAddRepairs = new Button();
            btAddRepairs.Height = 50;
            btAddRepairs.Width = 150;
            btAddRepairs.Text = "Добавить работу по машине";
            btAddRepairs.Location = new Point(300, 260);
            newTabPage.Controls.Add(btAddRepairs);
            btAddRepairs.Click += (sender, args) =>
            {
                if (cbNameRepairs.Text != "" && cbEmployee.Text != "")
                {
                    clbRepairs.Items.Add(cbNameRepairs.Text);
                    db.SearchCostRepairs(cbNameRepairs.Text, lbRepairsCosts);
                    lbEmployeesRepairs.Items.Add(cbEmployee.Text);
                    int totalCost = 0;

                    for (int i = 0; i < lbRepairsCosts.Items.Count; i++)
                    {
                        totalCost += Convert.ToInt32(lbRepairsCosts.Items[i].ToString());
                    }

                    lbRepairsTotalCost.Text = "Итоговая стоимость:\n" + totalCost + " рублей";
                }
                else
                {
                    MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка");
                }
            };

            //Печать
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.PrintPage += (sender, e) =>
            {
                String repairs = "";
                for (int i = 0; i < clbRepairs.Items.Count; i++)
                {
                    repairs += i + 1 + ". " + clbRepairs.Items[i].ToString() + "\n";
                }

                String result =
                tbNameDriver.Text + ", спасибо, что выбрали именно нас!" + "\n\n" +
                "\t" + "Счёт на оказание услуг авторемонта:" + "\n\n" +
                repairs + "\n" +
                "Итоговая стоимость: " +
                "\n\n*Гарантийный срок на оказанные услуги  устанавливается\n с даты приёмки Заказчиком выполненных работ\n" +
                "\t- на слесарные работы - не менее 3 месяцев или 30000км пробега\n" +
                "\t- на ремонт агргатов - не менее 6 месяцев или 30000км пробега\n" +
                "\t- на малярно-кузовные работы - не менее 6 месяцев или 50000км пробега\n" +
                "\t- на техническое обслуживание - до следующего ТО\n" +
                "\t- текущий ремонт - не менее 20 календарных дней или не менее 2000км пробега\n" +
                "\t- на запасные части (за исключением расходных) - не менее 6 месяцев\n";

                int totalCost = 0;
                String costs = "";
                for (int i = 0; i < lbRepairsCosts.Items.Count; i++)
                {
                    costs += lbRepairsCosts.Items[i].ToString() + " рублей" + "\n";
                    totalCost += Convert.ToInt32(lbRepairsCosts.Items[i].ToString());
                }

                String resultCost = costs + "\n" + totalCost + " рублей";

                e.Graphics.DrawString(result, new Font("Arial", 12), Brushes.Black, 100, 100);
                e.Graphics.DrawString(resultCost, new Font("Arial", 12), Brushes.Black, 600, 180);
            };

            //Кнопка Печать - составление счёта на оказание услуг
            Button btPrint = new Button();
            btPrint.Height = 50;
            btPrint.Width = 150;
            btPrint.Text = "Печатать счёт";
            btPrint.Location = new Point(30, 400);
            newTabPage.Controls.Add(btPrint);
            btPrint.Click += (sender, args) =>
            {
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument1;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            };


            //Кнопка завершить работу по клиенту
            Button btFinishRepair = new Button();
            btFinishRepair.Height = 50;
            btFinishRepair.Width = 150;
            btFinishRepair.Text = "Завершить работу по машине";
            btFinishRepair.Location = new Point(370, 400);
            newTabPage.Controls.Add(btFinishRepair);
            btFinishRepair.Click += (sender, args) =>
            {
                tabControl1.TabPages.Remove(newTabPage);
            };
        }

        private void AddClientToDB(string surname, string name, string patronimyc, string phone, string brand, string model, string year, string sts)
        {

            //Сначала делаем запрос к таблице с машинами потому что клиенты связаны с машинами

            string factQuery;

            FormCars fc = new FormCars();
            factQuery = "(`number_sts`, `brand`, `model`, `year_created`) VALUES('" +
                      sts + "', '" + brand + "', '" + model + "', '" + year + "');";
            db.Add("cars", factQuery, fc.dataGridView1);

            FormClients fm = new FormClients();
            factQuery = "(`surname`, `name`, `patronimyc`,`phone_number` ,`cars_number_sts`) VALUES('" +
                      surname + "', '" + name + "', '" + patronimyc + "', '" + phone + "', '" + sts + "');";
            db.Add("clients", factQuery, fm.dataGridView1);
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
    }
}
