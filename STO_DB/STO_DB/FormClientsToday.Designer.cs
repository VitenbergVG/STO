namespace STO_DB
{
    partial class FormClientsToday
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
            this.btNewClient = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btClients = new System.Windows.Forms.Button();
            this.btCars = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btNewClient
            // 
            this.btNewClient.BackColor = System.Drawing.Color.SeaShell;
            this.btNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNewClient.Location = new System.Drawing.Point(1218, 12);
            this.btNewClient.Name = "btNewClient";
            this.btNewClient.Size = new System.Drawing.Size(140, 44);
            this.btNewClient.TabIndex = 1;
            this.btNewClient.Text = "Новый клиент";
            this.btNewClient.UseVisualStyleBackColor = false;
            this.btNewClient.Click += new System.EventHandler(this.btNewClient_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1188, 655);
            this.tabControl1.TabIndex = 2;
            // 
            // btClients
            // 
            this.btClients.BackColor = System.Drawing.Color.SeaShell;
            this.btClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClients.Location = new System.Drawing.Point(1218, 90);
            this.btClients.Name = "btClients";
            this.btClients.Size = new System.Drawing.Size(140, 45);
            this.btClients.TabIndex = 3;
            this.btClients.Text = "Все клиенты";
            this.btClients.UseVisualStyleBackColor = false;
            this.btClients.Click += new System.EventHandler(this.btClients_Click);
            // 
            // btCars
            // 
            this.btCars.BackColor = System.Drawing.Color.SeaShell;
            this.btCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCars.Location = new System.Drawing.Point(1218, 175);
            this.btCars.Name = "btCars";
            this.btCars.Size = new System.Drawing.Size(140, 44);
            this.btCars.TabIndex = 4;
            this.btCars.Text = "Все машины";
            this.btCars.UseVisualStyleBackColor = false;
            this.btCars.Click += new System.EventHandler(this.btCars_Click);
            // 
            // FormClientsToday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STO_DB.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(1370, 679);
            this.Controls.Add(this.btCars);
            this.Controls.Add(this.btClients);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btNewClient);
            this.Name = "FormClientsToday";
            this.Text = "Система управления станцией ТО";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btNewClient;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btClients;
        private System.Windows.Forms.Button btCars;
    }
}