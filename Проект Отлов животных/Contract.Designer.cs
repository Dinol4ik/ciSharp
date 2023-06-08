namespace Проект_Отлов_животных
{
    partial class Contract
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
            this.AddContractBut = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.OrganizationName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddContractBut
            // 
            this.AddContractBut.Location = new System.Drawing.Point(339, 397);
            this.AddContractBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddContractBut.Name = "AddContractBut";
            this.AddContractBut.Size = new System.Drawing.Size(86, 31);
            this.AddContractBut.TabIndex = 2;
            this.AddContractBut.Text = "Добавить";
            this.AddContractBut.UseVisualStyleBackColor = true;
            this.AddContractBut.Click += new System.EventHandler(this.AddContractBut_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(339, 191);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(228, 27);
            this.dateTimePicker2.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Дата конца";
            // 
            // OrganizationName
            // 
            this.OrganizationName.FormattingEnabled = true;
            this.OrganizationName.Location = new System.Drawing.Point(339, 321);
            this.OrganizationName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrganizationName.Name = "OrganizationName";
            this.OrganizationName.Size = new System.Drawing.Size(138, 28);
            this.OrganizationName.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Номер контракта";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(339, 264);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(183, 31);
            this.textBox4.TabIndex = 60;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(339, 105);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 27);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "Организация";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "Дата начала ";
            // 
            // Contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.OrganizationName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AddContractBut);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Contract";
            this.Text = "Contract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button AddContractBut;
        private DateTimePicker dateTimePicker2;
        private Label label8;
        private ComboBox OrganizationName;
        private Label label6;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label9;
    }
}