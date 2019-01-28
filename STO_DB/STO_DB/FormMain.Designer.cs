namespace STO_DB
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btClients = new System.Windows.Forms.Button();
            this.btCars = new System.Windows.Forms.Button();
            this.btTodayClients = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btAbout = new System.Windows.Forms.Button();
            this.btEmployees = new System.Windows.Forms.Button();
            this.btRequests = new System.Windows.Forms.Button();
            this.btRepairs = new System.Windows.Forms.Button();
            this.btWorkHours = new System.Windows.Forms.Button();
            this.btActions = new System.Windows.Forms.Button();
            this.btWorkHoursRepairs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btClients
            // 
            this.btClients.BackColor = System.Drawing.Color.SeaShell;
            this.btClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClients.Location = new System.Drawing.Point(226, 70);
            this.btClients.Name = "btClients";
            this.btClients.Size = new System.Drawing.Size(133, 47);
            this.btClients.TabIndex = 1;
            this.btClients.Text = "Все клиенты";
            this.btClients.UseVisualStyleBackColor = false;
            this.btClients.Click += new System.EventHandler(this.btClients_Click);
            // 
            // btCars
            // 
            this.btCars.BackColor = System.Drawing.Color.SeaShell;
            this.btCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCars.Location = new System.Drawing.Point(46, 148);
            this.btCars.Name = "btCars";
            this.btCars.Size = new System.Drawing.Size(133, 47);
            this.btCars.TabIndex = 2;
            this.btCars.Text = "Машины клиентов";
            this.btCars.UseVisualStyleBackColor = false;
            this.btCars.Click += new System.EventHandler(this.btCars_Click);
            // 
            // btTodayClients
            // 
            this.btTodayClients.BackColor = System.Drawing.Color.SeaShell;
            this.btTodayClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTodayClients.Location = new System.Drawing.Point(46, 70);
            this.btTodayClients.Name = "btTodayClients";
            this.btTodayClients.Size = new System.Drawing.Size(133, 47);
            this.btTodayClients.TabIndex = 3;
            this.btTodayClients.Text = "Клиенты сегодня";
            this.btTodayClients.UseVisualStyleBackColor = false;
            this.btTodayClients.Click += new System.EventHandler(this.btTodayClients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(101, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добро пожаловать в систему управления\r\nстанцией технического обслуживания";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAbout
            // 
            this.btAbout.BackColor = System.Drawing.Color.SeaShell;
            this.btAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbout.Location = new System.Drawing.Point(226, 224);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(133, 47);
            this.btAbout.TabIndex = 6;
            this.btAbout.Text = "О программе";
            this.btAbout.UseVisualStyleBackColor = false;
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // btEmployees
            // 
            this.btEmployees.BackColor = System.Drawing.Color.SeaShell;
            this.btEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmployees.Location = new System.Drawing.Point(46, 295);
            this.btEmployees.Name = "btEmployees";
            this.btEmployees.Size = new System.Drawing.Size(133, 47);
            this.btEmployees.TabIndex = 7;
            this.btEmployees.Text = "Сотрудники";
            this.btEmployees.UseVisualStyleBackColor = false;
            this.btEmployees.Click += new System.EventHandler(this.btEmployees_Click);
            // 
            // btRequests
            // 
            this.btRequests.BackColor = System.Drawing.Color.SeaShell;
            this.btRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRequests.Location = new System.Drawing.Point(226, 148);
            this.btRequests.Name = "btRequests";
            this.btRequests.Size = new System.Drawing.Size(133, 47);
            this.btRequests.TabIndex = 8;
            this.btRequests.Text = "Заявки";
            this.btRequests.UseVisualStyleBackColor = false;
            this.btRequests.Click += new System.EventHandler(this.btRequests_Click);
            // 
            // btRepairs
            // 
            this.btRepairs.BackColor = System.Drawing.Color.SeaShell;
            this.btRepairs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRepairs.Location = new System.Drawing.Point(46, 224);
            this.btRepairs.Name = "btRepairs";
            this.btRepairs.Size = new System.Drawing.Size(133, 47);
            this.btRepairs.TabIndex = 8;
            this.btRepairs.Text = "Ремонтные работы";
            this.btRepairs.UseVisualStyleBackColor = false;
            this.btRepairs.Click += new System.EventHandler(this.btRepairs_Click);
            // 
            // btWorkHours
            // 
            this.btWorkHours.BackColor = System.Drawing.Color.SeaShell;
            this.btWorkHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btWorkHours.Location = new System.Drawing.Point(226, 295);
            this.btWorkHours.Name = "btWorkHours";
            this.btWorkHours.Size = new System.Drawing.Size(133, 47);
            this.btWorkHours.TabIndex = 8;
            this.btWorkHours.Text = "Расписание";
            this.btWorkHours.UseVisualStyleBackColor = false;
            this.btWorkHours.Click += new System.EventHandler(this.btWorkHours_Click);
            // 
            // btActions
            // 
            this.btActions.BackColor = System.Drawing.Color.SeaShell;
            this.btActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btActions.Location = new System.Drawing.Point(46, 365);
            this.btActions.Name = "btActions";
            this.btActions.Size = new System.Drawing.Size(133, 47);
            this.btActions.TabIndex = 8;
            this.btActions.Text = "Акции";
            this.btActions.UseVisualStyleBackColor = false;
            this.btActions.Click += new System.EventHandler(this.btActions_Click);
            // 
            // btWorkHoursRepairs
            // 
            this.btWorkHoursRepairs.BackColor = System.Drawing.Color.SeaShell;
            this.btWorkHoursRepairs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btWorkHoursRepairs.Location = new System.Drawing.Point(226, 365);
            this.btWorkHoursRepairs.Name = "btWorkHoursRepairs";
            this.btWorkHoursRepairs.Size = new System.Drawing.Size(133, 47);
            this.btWorkHoursRepairs.TabIndex = 8;
            this.btWorkHoursRepairs.Text = "Расписание работ";
            this.btWorkHoursRepairs.UseVisualStyleBackColor = false;
            this.btWorkHoursRepairs.Click += new System.EventHandler(this.btWorkHoursRepairs_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STO_DB.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(413, 424);
            this.Controls.Add(this.btActions);
            this.Controls.Add(this.btWorkHoursRepairs);
            this.Controls.Add(this.btWorkHours);
            this.Controls.Add(this.btRepairs);
            this.Controls.Add(this.btRequests);
            this.Controls.Add(this.btEmployees);
            this.Controls.Add(this.btAbout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTodayClients);
            this.Controls.Add(this.btCars);
            this.Controls.Add(this.btClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btClients;
        private System.Windows.Forms.Button btCars;
        private System.Windows.Forms.Button btTodayClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAbout;
        private System.Windows.Forms.Button btEmployees;
        private System.Windows.Forms.Button btRequests;
        private System.Windows.Forms.Button btRepairs;
        private System.Windows.Forms.Button btWorkHours;
        private System.Windows.Forms.Button btActions;
        private System.Windows.Forms.Button btWorkHoursRepairs;
    }
}