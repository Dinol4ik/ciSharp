namespace Проект_Отлов_животных
{
    partial class SearchContract
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
            button3 = new Button();
            OrganizationName = new ComboBox();
            label6 = new Label();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label9 = new Label();
            button2 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(118, 255);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 54;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // OrganizationName
            // 
            OrganizationName.FormattingEnabled = true;
            OrganizationName.Location = new Point(163, 174);
            OrganizationName.Name = "OrganizationName";
            OrganizationName.Size = new Size(121, 23);
            OrganizationName.TabIndex = 53;
            OrganizationName.SelectedIndexChanged += localityAdress_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 142);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 52;
            label6.Text = "Номер контракта";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 133);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 24);
            textBox2.TabIndex = 51;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(163, 20);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 182);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 46;
            label4.Text = "Организация";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 28);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 43;
            label9.Text = "Дата начала ";
            // 
            // button2
            // 
            button2.Location = new Point(285, 255);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 39;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(482, 26);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 38;
            label2.Text = "label2";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(541, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(554, 241);
            dataGridView1.TabIndex = 37;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(770, 162);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 36;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(770, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(795, 115);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 34;
            label1.Text = "Заявка";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(163, 81);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 90);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 55;
            label8.Text = "Дата конца";
            // 
            // SearchContract
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 708);
            Controls.Add(dateTimePicker2);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(OrganizationName);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "SearchContract";
            Text = "SearchContract";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private ComboBox OrganizationName;
        private Label label6;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label9;
        private Button button2;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label label8;
    }
}