namespace STO_DB
{
    partial class FormWorkHours
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
            this.dgvWorkHours = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkHours)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWorkHours
            // 
            this.dgvWorkHours.AllowUserToAddRows = false;
            this.dgvWorkHours.AllowUserToDeleteRows = false;
            this.dgvWorkHours.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvWorkHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkHours.Location = new System.Drawing.Point(12, 12);
            this.dgvWorkHours.Name = "dgvWorkHours";
            this.dgvWorkHours.ReadOnly = true;
            this.dgvWorkHours.Size = new System.Drawing.Size(965, 497);
            this.dgvWorkHours.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.SeaShell;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Location = new System.Drawing.Point(994, 22);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(98, 37);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // FormWorkHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STO_DB.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(1113, 521);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dgvWorkHours);
            this.Name = "FormWorkHours";
            this.Text = "График работы сотрудников";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btAdd;
        public System.Windows.Forms.DataGridView dgvWorkHours;
    }
}