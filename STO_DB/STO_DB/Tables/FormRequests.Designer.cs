namespace STO_DB
{
    partial class FormRequests
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btDelete = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.SeaShell;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Location = new System.Drawing.Point(805, 13);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(100, 39);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "Удалить заявку";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.SeaShell;
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Location = new System.Drawing.Point(805, 68);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(100, 39);
            this.btRefresh.TabIndex = 1;
            this.btRefresh.Text = "Обновить";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // FormRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STO_DB.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRequests";
            this.Text = "Заявки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btRefresh;
    }
}