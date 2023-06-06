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
    public partial class RegisterApplicationForm : Form
    {
        public RegisterApplicationForm(List<Models.Locality> data)
        {
            this.data = data;
            InitializeComponent();
            foreach (Models.Locality locality in data)
            {
                listBox2.Items.Insert(locality.Id - 1, locality.Adress.ToString());
            }
        }
        List<Models.Locality> data;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var date = dateTimePicker1.Value.ToString();
            var kategory = listBox1.SelectedItem.ToString();
            var desc = textBox3.Text;
            var localityID = listBox2.SelectedIndex;
    

        }

        private void RegisterApplicationForm_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
