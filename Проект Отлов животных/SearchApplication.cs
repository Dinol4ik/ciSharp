using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class SearchApplication : Form
    {
        public SearchApplication(List<Application> application)
        {
            data = application;
            InitializeComponent();
            dataGridView1.DataSource = data.GetRange(0, data.Count);
            label2.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
        }
        List<Application> data;

        private void button1_Click(object sender, EventArgs e)
        {
            string application = textBox1.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(label2.Text);

            if (data.Find(x => x.Id == id) != null) { data.Remove(data.Find(x => x.Id == id)); }
            AplicationHandler aplicationHandler = new AplicationHandler();
            aplicationHandler.DeleteAplication(id);
            dataGridView1.DataSource = data.GetRange(0, data.Count);
            dataGridView1.Refresh();
            label2.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
