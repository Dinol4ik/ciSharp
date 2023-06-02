namespace Проект_Отлов_животных
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            password = new Label();
            label1 = new Label();
            textLogin = new TextBox();
            textPassword = new TextBox();
            signIn = new Button();
            errorLogin = new Label();
            SuspendLayout();
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(275, 171);
            password.Name = "password";
            password.Size = new Size(49, 15);
            password.TabIndex = 1;
            password.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 121);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Логин";
            // 
            // textLogin
            // 
            textLogin.Location = new Point(341, 121);
            textLogin.Name = "textLogin";
            textLogin.Size = new Size(100, 23);
            textLogin.TabIndex = 3;
            textLogin.TextChanged += textLogin_TextChanged;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(341, 171);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(100, 23);
            textPassword.TabIndex = 4;
            textPassword.TextChanged += textPassword_TextChanged;
            // 
            // signIn
            // 
            signIn.Location = new Point(342, 235);
            signIn.Name = "signIn";
            signIn.Size = new Size(75, 23);
            signIn.TabIndex = 5;
            signIn.Text = "войти";
            signIn.UseVisualStyleBackColor = true;
            signIn.Click += signIn_Click;
            // 
            // errorLogin
            // 
            errorLogin.AutoSize = true;
            errorLogin.BackColor = Color.IndianRed;
            errorLogin.ForeColor = SystemColors.ButtonHighlight;
            errorLogin.Location = new Point(304, 59);
            errorLogin.Name = "errorLogin";
            errorLogin.Size = new Size(194, 15);
            errorLogin.TabIndex = 6;
            errorLogin.Text = "Неправильный логин или пароль";
            errorLogin.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(errorLogin);
            Controls.Add(signIn);
            Controls.Add(textPassword);
            Controls.Add(textLogin);
            Controls.Add(label1);
            Controls.Add(password);
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label password;
        private Label label1;
        private TextBox textLogin;
        private TextBox textPassword;
        private Button signIn;
        private Label errorLogin;
    }
}