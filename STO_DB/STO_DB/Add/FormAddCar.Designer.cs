namespace STO_DB
{
    partial class FormAddCar
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
            this.btAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDateTO = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbNumSTS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.SeaShell;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Location = new System.Drawing.Point(192, 260);
            this.btAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(120, 47);
            this.btAdd.TabIndex = 27;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Дата последнего ТО";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Модель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Год выпуска";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Номер СТС";
            // 
            // tbDateTO
            // 
            this.tbDateTO.Location = new System.Drawing.Point(227, 208);
            this.tbDateTO.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbDateTO.Name = "tbDateTO";
            this.tbDateTO.Size = new System.Drawing.Size(279, 20);
            this.tbDateTO.TabIndex = 21;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(227, 108);
            this.tbModel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(279, 20);
            this.tbModel.TabIndex = 20;
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(227, 63);
            this.tbBrand.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(279, 20);
            this.tbBrand.TabIndex = 19;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(227, 154);
            this.tbYear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(279, 20);
            this.tbYear.TabIndex = 18;
            // 
            // tbNumSTS
            // 
            this.tbNumSTS.Location = new System.Drawing.Point(227, 20);
            this.tbNumSTS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbNumSTS.Name = "tbNumSTS";
            this.tbNumSTS.Size = new System.Drawing.Size(279, 20);
            this.tbNumSTS.TabIndex = 17;
            // 
            // FormAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STO_DB.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(539, 329);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDateTO);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbNumSTS);
            this.Name = "FormAddCar";
            this.Text = "Добавить машину";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDateTO;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbNumSTS;
    }
}