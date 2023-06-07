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
    public partial class Organisation : Form
    {
        public Organisation()
        {
            InitializeComponent();
        }

        private void AddOrgButton_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string INN = textBox2.Text;
            string KPP = textBox3.Text;
            string adress = textBox4.Text;
            string IP = textBox5.Text;
        }
    }
}
