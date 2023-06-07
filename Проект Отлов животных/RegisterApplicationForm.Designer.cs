namespace Проект_Отлов_животных
{
    partial class RegisterApplicationForm
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
            components = new System.ComponentModel.Container();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            applicationBindingSource = new BindingSource(components);
            initialBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            checkBox1 = new CheckBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            localityAdress = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)applicationBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)initialBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(215, 164);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(336, 141);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // listBox1
            // 
            listBox1.ForeColor = Color.FromArgb(0, 0, 64);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Водная", "Наземно-воздушная", "Назменая" });
            listBox1.Location = new Point(215, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(172, 94);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // applicationBindingSource
            // 
            applicationBindingSource.DataSource = typeof(Application);
            // 
            // initialBindingSource
            // 
            //initialBindingSource.DataSource = typeof(Migrations.Initial);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 10);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 6;
            label1.Text = "Дата";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 83);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 7;
            label2.Text = "Категория";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 193);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 8;
            label3.Text = "Описание";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 392);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 9;
            label4.Text = "Адресс заказчика";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(215, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.Location = new Point(482, 384);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Срочно";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(304, 526);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(215, 321);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(336, 24);
            textBox1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 324);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 16;
            label5.Text = "Место Обитание";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(215, 435);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 24);
            textBox2.TabIndex = 17;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 444);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 18;
            label6.Text = "Номер заявки";
            // 
            // localityAdress
            // 
            localityAdress.FormattingEnabled = true;
            localityAdress.Location = new Point(215, 384);
            localityAdress.Name = "localityAdress";
            localityAdress.Size = new Size(121, 23);
            localityAdress.TabIndex = 19;
            localityAdress.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // RegisterApplicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 657);
            Controls.Add(localityAdress);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Name = "RegisterApplicationForm";
            Text = "RegisterApplicationForm";
            Load += RegisterApplicationForm_Load;
            ((System.ComponentModel.ISupportInitialize)applicationBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)initialBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox3;
        private ListBox listBox1;
        private BindingSource initialBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
        private BindingSource applicationBindingSource;
        private Button button1;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private ComboBox localityAdress;
    }
}