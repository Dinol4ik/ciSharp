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
            button3 = new Button();
            SuspendLayout();
            // 
            // accountName
            // 
            accountName.AutoSize = true;
            accountName.Location = new Point(739, 43);
            accountName.Name = "accountName";
            accountName.Size = new Size(38, 15);
            accountName.TabIndex = 1;
            accountName.Text = "label1";
            accountName.Click += accountName_Click;
            // 
            // AccountBtn
            // 
            AccountBtn.Location = new Point(12, 12);
            AccountBtn.Name = "AccountBtn";
            AccountBtn.Size = new Size(156, 23);
            AccountBtn.TabIndex = 2;
            AccountBtn.Text = "Личный аккаунт";
            AccountBtn.UseVisualStyleBackColor = true;
            AccountBtn.Click += AccountBtn_Click;
            // 
            // ActBtn
            // 
            ActBtn.Location = new Point(184, 12);
            ActBtn.Name = "ActBtn";
            ActBtn.Size = new Size(75, 23);
            ActBtn.TabIndex = 3;
            ActBtn.Text = "Акт отлова";
            ActBtn.UseVisualStyleBackColor = true;
            // 
            // AplicationRegBtn
            // 
            AplicationRegBtn.Location = new Point(274, 12);
            AplicationRegBtn.Name = "AplicationRegBtn";
            AplicationRegBtn.Size = new Size(178, 23);
            AplicationRegBtn.TabIndex = 4;
            AplicationRegBtn.Text = "Регистрация заявки";
            AplicationRegBtn.UseVisualStyleBackColor = true;
            AplicationRegBtn.Click += AplicationRegBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(458, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "что-то еще";
            button3.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(AplicationRegBtn);
            Controls.Add(ActBtn);
            Controls.Add(AccountBtn);
            Controls.Add(accountName);
            Name = "mainForm";
            Text = "MainForm";
            Load += mainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label accountName;
        private Button AccountBtn;
        private Button ActBtn;
        private Button AplicationRegBtn;
        private Button button3;
    }
}