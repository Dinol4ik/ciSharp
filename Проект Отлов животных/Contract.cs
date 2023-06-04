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
    public partial class Contract : Form
    {
        public Contract()
        {
            InitializeComponent();
        }

        private void AddContractBut_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            string date1 = textBox2.Text; // Дата заключения
            string date2 = textBox3.Text; // Дата действия
        }
    }
}
