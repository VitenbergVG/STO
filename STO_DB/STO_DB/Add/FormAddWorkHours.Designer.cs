namespace STO_DB.Add
{
    partial class FormAddWorkHours
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
            this.cbSurnameEmployee = new System.Windows.Forms.ComboBox();
            this.cbDateOfWeek = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbDateStart = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRegularity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btAddRegularity = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSurnameEmployeeRegularity = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSurnameEmployee
            // 
            this.cbSurnameEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSurnameEmployee.FormattingEnabled = true;
            this.cbSurnameEmployee.Location = new System.Drawing.Point(242, 57);
            this.cbSurnameEmployee.Name = "cbSurnameEmployee";
            this.cbSurnameEmployee.Size = new System.Drawing.Size(220, 21);
            this.cbSurnameEmployee.TabIndex = 0;
            this.cbSurnameEmployee.SelectedIndexChanged += new System.EventHandler(this.cbSurnameEmployee_SelectedIndexChanged);
            // 
            // cbDateOfWeek
            // 
            this.cbDateOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDateOfWeek.FormattingEnabled = true;
            this.cbDateOfWeek.Location = new System.Drawing.Point(242, 109);
            this.cbDateOfWeek.Name = "cbDateOfWeek";
            this.cbDateOfWeek.Size = new System.Drawing.Size(220, 21);
            this.cbDateOfWeek.TabIndex = 1;
            this.cbDateOfWeek.SelectedIndexChanged += new System.EventHandler(this.cbDateOfWeek_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "День недели";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Фамилия сотрудника";
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.SeaShell;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Location = new System.Drawing.Point(430, 203);
            this.btAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(120, 47);
            this.btAdd.TabIndex = 55;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(566, 283);
            this.tabControl1.TabIndex = 56;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.cbDateOfWeek);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btAdd);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbSurnameEmployee);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(558, 257);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить смену";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.cbDateStart);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbRegularity);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btAddRegularity);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbSurnameEmployeeRegularity);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(558, 257);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить закономерность в расписание";
            // 
            // cbDateStart
            // 
            this.cbDateStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDateStart.FormattingEnabled = true;
            this.cbDateStart.Location = new System.Drawing.Point(211, 143);
            this.cbDateStart.Name = "cbDateStart";
            this.cbDateStart.Size = new System.Drawing.Size(220, 21);
            this.cbDateStart.TabIndex = 61;
            this.cbDateStart.SelectedIndexChanged += new System.EventHandler(this.cbDateStart_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "Дата начала";
            // 
            // cbRegularity
            // 
            this.cbRegularity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegularity.FormattingEnabled = true;
            this.cbRegularity.Items.AddRange(new object[] {
            "2 через 2",
            "2 через 1",
            "3 через 3"});
            this.cbRegularity.Location = new System.Drawing.Point(211, 90);
            this.cbRegularity.Name = "cbRegularity";
            this.cbRegularity.Size = new System.Drawing.Size(220, 21);
            this.cbRegularity.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Закономерность";
            // 
            // btAddRegularity
            // 
            this.btAddRegularity.BackColor = System.Drawing.Color.SeaShell;
            this.btAddRegularity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddRegularity.Location = new System.Drawing.Point(430, 203);
            this.btAddRegularity.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btAddRegularity.Name = "btAddRegularity";
            this.btAddRegularity.Size = new System.Drawing.Size(120, 47);
            this.btAddRegularity.TabIndex = 60;
            this.btAddRegularity.Text = "Добавить";
            this.btAddRegularity.UseVisualStyleBackColor = false;
            this.btAddRegularity.Click += new System.EventHandler(this.btAddRegularity_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Фамилия сотрудника";
            // 
            // cbSurnameEmployeeRegularity
            // 
            this.cbSurnameEmployeeRegularity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSurnameEmployeeRegularity.FormattingEnabled = true;
            this.cbSurnameEmployeeRegularity.Location = new System.Drawing.Point(211, 38);
            this.cbSurnameEmployeeRegularity.Name = "cbSurnameEmployeeRegularity";
            this.cbSurnameEmployeeRegularity.Size = new System.Drawing.Size(220, 21);
            this.cbSurnameEmployeeRegularity.TabIndex = 56;
            this.cbSurnameEmployeeRegularity.SelectedIndexChanged += new System.EventHandler(this.cbSurnameEmployeeRegularity_SelectedIndexChanged);
            // 
            // FormAddWorkHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STO_DB.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(596, 317);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAddWorkHours";
            this.Text = "Добавить смену сотруднику";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSurnameEmployee;
        private System.Windows.Forms.ComboBox cbDateOfWeek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbDateStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRegularity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAddRegularity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSurnameEmployeeRegularity;
    }
}