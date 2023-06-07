namespace Проект_Отлов_животных
{
    partial class mainForm
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
            accountName = new Label();
            AccountBtn = new Button();
            ActBtn = new Button();
            AplicationRegBtn = new Button();
            AddContractBut = new Button();
            label1 = new Label();
            OrgAddBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            OrgSearchBut = new Button();
            SearchApplicationBut = new Button();
            SearchActBut = new Button();
            SearchContractBut = new Button();
            SuspendLayout();
            // 
            // accountName
            // 
            accountName.AutoSize = true;
            accountName.Location = new Point(733, 47);
            accountName.Name = "accountName";
            accountName.Size = new Size(38, 15);
            accountName.TabIndex = 1;
            accountName.Text = "label1";
            // 
            // AccountBtn
            // 
            AccountBtn.Location = new Point(12, 12);
            AccountBtn.Name = "AccountBtn";
            AccountBtn.Size = new Size(156, 23);
            AccountBtn.TabIndex = 2;
            AccountBtn.Text = "Личный аккаунт";
            AccountBtn.UseVisualStyleBackColor = true;
            // 
            // ActBtn
            // 
            ActBtn.Location = new Point(324, 116);
            ActBtn.Name = "ActBtn";
            ActBtn.Size = new Size(148, 23);
            ActBtn.TabIndex = 3;
            ActBtn.Text = "Добавление акта";
            ActBtn.UseVisualStyleBackColor = true;
            // 
            // AplicationRegBtn
            // 
            AplicationRegBtn.Location = new Point(140, 116);
            AplicationRegBtn.Name = "AplicationRegBtn";
            AplicationRegBtn.Size = new Size(178, 23);
            AplicationRegBtn.TabIndex = 4;
            AplicationRegBtn.Text = "Регистрация заявки";
            AplicationRegBtn.UseVisualStyleBackColor = true;
            // 
            // AddContractBut
            // 
            AddContractBut.Location = new Point(478, 116);
            AddContractBut.Name = "AddContractBut";
            AddContractBut.Size = new Size(153, 23);
            AddContractBut.TabIndex = 5;
            AddContractBut.Text = "Добавление контракта";
            AddContractBut.UseVisualStyleBackColor = true;
            AddContractBut.Click += AddContractBut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 77);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 6;
            label1.Text = "Организация";
            // 
            // OrgAddBtn
            // 
            OrgAddBtn.Location = new Point(12, 116);
            OrgAddBtn.Name = "OrgAddBtn";
            OrgAddBtn.Size = new Size(109, 23);
            OrgAddBtn.TabIndex = 7;
            OrgAddBtn.Text = "Добавление Орг";
            OrgAddBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 77);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 8;
            label2.Text = "Заявки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 77);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 9;
            label3.Text = "Акты";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(478, 77);
            label4.Name = "label4";
            label4.Size = new Size(153, 15);
            label4.TabIndex = 10;
            label4.Text = "Муниципальный контракт";
            // 
            // OrgSearchBut
            // 
            OrgSearchBut.Location = new Point(12, 145);
            OrgSearchBut.Name = "OrgSearchBut";
            OrgSearchBut.Size = new Size(109, 41);
            OrgSearchBut.TabIndex = 11;
            OrgSearchBut.Text = "Поиск организации";
            OrgSearchBut.UseVisualStyleBackColor = true;
            OrgSearchBut.Click += OrgSearchBut_Click;
            // 
            // SearchApplicationBut
            // 
            SearchApplicationBut.Location = new Point(140, 145);
            SearchApplicationBut.Name = "SearchApplicationBut";
            SearchApplicationBut.Size = new Size(178, 41);
            SearchApplicationBut.TabIndex = 12;
            SearchApplicationBut.Text = "Список заявок";
            SearchApplicationBut.UseVisualStyleBackColor = true;
            // 
            // SearchActBut
            // 
            SearchActBut.Location = new Point(324, 145);
            SearchActBut.Name = "SearchActBut";
            SearchActBut.Size = new Size(148, 41);
            SearchActBut.TabIndex = 13;
            SearchActBut.Text = "Список актов";
            SearchActBut.UseVisualStyleBackColor = true;
            SearchActBut.Click += SearchActBut_Click;
            // 
            // SearchContractBut
            // 
            SearchContractBut.Location = new Point(478, 145);
            SearchContractBut.Name = "SearchContractBut";
            SearchContractBut.Size = new Size(153, 41);
            SearchContractBut.TabIndex = 14;
            SearchContractBut.Text = "Список контрактов";
            SearchContractBut.UseVisualStyleBackColor = true;
            SearchContractBut.Click += SearchContractBut_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchContractBut);
            Controls.Add(SearchActBut);
            Controls.Add(SearchApplicationBut);
            Controls.Add(OrgSearchBut);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(OrgAddBtn);
            Controls.Add(label1);
            Controls.Add(AddContractBut);
            Controls.Add(AplicationRegBtn);
            Controls.Add(ActBtn);
            Controls.Add(AccountBtn);
            Controls.Add(accountName);
            Name = "mainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label accountName;
        private Button AccountBtn;
        private Button ActBtn;
        private Button AplicationRegBtn;
        private Button AddContractBut;
        private Label label1;
        private Button OrgAddBtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button OrgSearchBut;
        private Button SearchApplicationBut;
        private Button SearchActBut;
        private Button SearchContractBut;
    }
}