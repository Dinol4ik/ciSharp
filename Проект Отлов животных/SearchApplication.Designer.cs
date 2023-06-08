namespace Проект_Отлов_животных
{
    partial class SearchApplication
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            button2 = new Button();
            localityAdress = new ComboBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            checkBox1 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            listBox1 = new ListBox();
            textBox4 = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1097, 100);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Заявка";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1072, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(1072, 147);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 2;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(647, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(554, 241);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 24);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // button2
            // 
            button2.Location = new Point(303, 528);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            // 
            // localityAdress
            // 
            localityAdress.FormattingEnabled = true;
            localityAdress.Location = new Point(136, 400);
            localityAdress.Name = "localityAdress";
            localityAdress.Size = new Size(121, 23);
            localityAdress.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 460);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 31;
            label6.Text = "Номер заявки";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 451);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 24);
            textBox2.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 340);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 29;
            label5.Text = "Место Обитание";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 337);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(336, 24);
            textBox3.TabIndex = 28;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.Location = new Point(403, 400);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 19);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "Срочно";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(136, 18);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 408);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 25;
            label4.Text = "Адресс заказчика";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 209);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 24;
            label7.Text = "Описание";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 99);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 23;
            label8.Text = "Категория";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 26);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 22;
            label9.Text = "Дата";
            // 
            // listBox1
            // 
            listBox1.ForeColor = Color.FromArgb(0, 0, 64);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Водная", "Наземно-воздушная", "Назменая" });
            listBox1.Location = new Point(136, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(172, 94);
            listBox1.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(136, 180);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(336, 141);
            textBox4.TabIndex = 20;
            // 
            // button3
            // 
            button3.Location = new Point(136, 528);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 33;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SearchApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 703);
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
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(listBox1);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "SearchApplication";
            Text = "SearchApplication";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button button2;
        private ComboBox localityAdress;
        private Label label6;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private ListBox listBox1;
        private TextBox textBox4;
        private Button button3;
    }
}