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
            localityAdress = new ComboBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            checkBox1 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label7 = new Label();
            label9 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(163, 530);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 54;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = true;
            // 
            // localityAdress
            // 
            localityAdress.FormattingEnabled = true;
            localityAdress.Location = new Point(163, 402);
            localityAdress.Name = "localityAdress";
            localityAdress.Size = new Size(121, 23);
            localityAdress.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 462);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 52;
            label6.Text = "Номер заявки";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 453);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 24);
            textBox2.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 342);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 50;
            label5.Text = "Место Обитание";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(163, 339);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(336, 24);
            textBox3.TabIndex = 49;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.Location = new Point(430, 402);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 19);
            checkBox1.TabIndex = 48;
            checkBox1.Text = "Срочно";
            checkBox1.UseVisualStyleBackColor = true;
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
            label4.Location = new Point(31, 410);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 46;
            label4.Text = "Адресс заказчика";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 211);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 45;
            label7.Text = "Описание";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 28);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 43;
            label9.Text = "Дата";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(163, 182);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(336, 141);
            textBox4.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(712, 45);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 40;
            label3.Text = "label3";
            // 
            // button2
            // 
            button2.Location = new Point(330, 530);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 39;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
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
            dataGridView1.Location = new Point(794, 236);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(554, 241);
            dataGridView1.TabIndex = 37;
            // 
            // button1
            // 
            button1.Location = new Point(1099, 149);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 36;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1099, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1124, 102);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 34;
            label1.Text = "Заявка";
            // 
            // SearchContract
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 708);
            Controls.Add(button3);
            Controls.Add(localityAdress);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(checkBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(label3);
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
        private ComboBox localityAdress;
        private Label label6;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label7;
        private Label label9;
        private TextBox textBox4;
        private Label label3;
        private Button button2;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}