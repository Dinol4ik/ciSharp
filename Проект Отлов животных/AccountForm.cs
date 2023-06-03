using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект_Отлов_животных
{
    public partial class AccountForm : Form
    {
        public AccountForm(List<Models.User> data)
        {
            InitializeComponent();
            this.data = data;
            label1.Text = data[0].Login;
            label2.Text = data[0].Role;
            label3.Text = data[0].Company;
            label4.Text = data[0].OMS;
        }
        List<Models.User> data;
    }
}
