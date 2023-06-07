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
            AddContractBut = new Button();
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            OrganizationName = new ComboBox();
            label6 = new Label();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // AddContractBut
            // 
            AddContractBut.Location = new Point(297, 298);
            AddContractBut.Name = "AddContractBut";
            AddContractBut.Size = new Size(75, 23);
            AddContractBut.TabIndex = 2;
            AddContractBut.Text = "Добавить";
            AddContractBut.UseVisualStyleBackColor = true;
            AddContractBut.Click += AddContractBut_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(297, 143);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 64;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(167, 149);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 63;
            label8.Text = "Дата конца";
            // 
            // OrganizationName
            // 
            OrganizationName.FormattingEnabled = true;
            OrganizationName.Location = new Point(297, 241);
            OrganizationName.Name = "OrganizationName";
            OrganizationName.Size = new Size(121, 23);
            OrganizationName.TabIndex = 62;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(167, 201);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 61;
            label6.Text = "Номер контракта";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(297, 198);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(161, 24);
            textBox4.TabIndex = 60;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(297, 79);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 59;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(167, 241);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 58;
            label5.Text = "Организация";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(167, 85);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 57;
            label9.Text = "Дата начала ";
            // 
            // Contract
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker2);
            Controls.Add(label8);
            Controls.Add(OrganizationName);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(AddContractBut);
            Name = "Contract";
            Text = "Contract";
            ResumeLayout(false);
            PerformLayout();
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