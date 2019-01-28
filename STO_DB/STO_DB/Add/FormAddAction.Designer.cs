namespace STO_DB.Add
{
    partial class FormAddAction
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbTextAction = new System.Windows.Forms.TextBox();
            this.tbNameAction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.SeaShell;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Location = new System.Drawing.Point(169, 134);
            this.btAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(120, 47);
            this.btAdd.TabIndex = 34;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Текст акции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Название акции";
            // 
            // tbTextAction
            // 
            this.tbTextAction.Location = new System.Drawing.Point(219, 76);
            this.tbTextAction.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbTextAction.Name = "tbTextAction";
            this.tbTextAction.Size = new System.Drawing.Size(279, 20);
            this.tbTextAction.TabIndex = 30;
            // 
            // tbNameAction
            // 
            this.tbNameAction.Location = new System.Drawing.Point(219, 27);
            this.tbNameAction.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbNameAction.Name = "tbNameAction";
            this.tbNameAction.Size = new System.Drawing.Size(279, 20);
            this.tbNameAction.TabIndex = 28;
            // 
            // FormAddAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STO_DB.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(512, 208);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTextAction);
            this.Controls.Add(this.tbNameAction);
            this.Name = "FormAddAction";
            this.Text = "Акции";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTextAction;
        private System.Windows.Forms.TextBox tbNameAction;
    }
}