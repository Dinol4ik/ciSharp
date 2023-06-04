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
    public partial class AddActForm : Form
    {
        public AddActForm()
        {
            InitializeComponent();
        }

        private void AddActBut_Click(object sender, EventArgs e)
        {
            string number_act = textBox1.Text;
            string dogs = textBox2.Text;
            string cats = textBox3.Text;
            string animals = textBox4.Text;
            string date = textBox5.Text;
            string target = textBox6.Text;
            string contract = textBox7.Text;
        }
    }
}
