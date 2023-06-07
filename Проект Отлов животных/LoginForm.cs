using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace Проект_Отлов_животных
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            errorLogin.Visible = false;
        }

        async private void signIn_Click(object sender, EventArgs e)
        {
            AuthHandler authHandler = new AuthHandler();
            var auth = authHandler.autharization(textLogin.Text, textPassword.Text);
            if (auth.Count > 0)
            {
                //mainForm mainForm = new mainForm(auth);
                Visible = false;
                //mainForm.ShowDialog(this);
                Visible = true;
            }
            else { errorLogin.Visible = true; }
        }

        private void textLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}