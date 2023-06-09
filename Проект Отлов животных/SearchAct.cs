using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Проект_Отлов_животных.Models;

namespace Проект_Отлов_животных
{
    public partial class SearchAct : Form
    {
        public SearchAct(List<Models.User> users,List<Act> act, List<Models.Organization> organizations, List<Models.Municipal_contract> contract, List<Models.Applications> applications, string roleUser)
        {
            data = act;
            InitializeComponent();
            comboBox3.DataSource = applications;
            comboBox3.DisplayMember = "number";
            comboBox3.ValueMember = "Id";
            if (roleUser == "Куратор ВетСлужбы"
                || roleUser == "Подписант ВетСлужбы"
                || roleUser == "Куратор ОМСУ"
                || roleUser == "Подписант ОМСУ"
                || roleUser == "Подписант по отлову"|| roleUser == "Куратор по отлову")
            {
                button2.Visible = false;
                button3.Visible = false;

            }
            user = users;
            comboBox1.DataSource = organizations;
            comboBox1.DisplayMember = "Title";
            comboBox1.ValueMember = "Id";

            comboBox2.DataSource = contract;
            comboBox2.DisplayMember = "Number";
            comboBox2.ValueMember = "Id";

            dataGridView1.DataSource = act.GetRange(0, act.Count);
            label2.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
        }
        List<Act> data;
        List<Models.User> user;
        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(label2.Text);

                Models.Organization organisationId = (Models.Organization)comboBox1.SelectedItem;
                Models.Municipal_contract contractId = (Models.Municipal_contract)comboBox2.SelectedItem;
                Models.Act_Of_Capture acted = new Models.Act_Of_Capture
                {
                    Id = int.Parse(label2.Text),
                    Act_Number = long.Parse(textBox9.Text),
                    Amount_Of_Dogs = textBox8.Text,
                    Amount_Of_Cats = textBox3.Text,
                    Amount_Of_Animals = textBox4.Text,
                    Target = textBox6.Text,
                    Date_Of_Capture = dateTimePicker1.Value.ToString(),
                    OrganizationId = organisationId.Id,
                    Municipal_ContractId = contractId.Id
                };
                //if (data.Find(x => x.Id == id) != null) { data.Remove(data.Find(x => x.Id == id)); }

                RegisterAct register = new RegisterAct();
                register.EditAct(acted);
                dataGridView1.DataSource = data.GetRange(0, data.Count);
                dataGridView1.Refresh();
                MessageBox.Show("Данные обновленны");
            }
            catch
            {
                MessageBox.Show("Ошибка при обновлении данных!");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            var number = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            var dogs_amount = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            var cats_amount = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            var animals_amount = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            var date = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
            var target = dataGridView1[8, dataGridView1.CurrentRow.Index].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(date);
            textBox9.Text = number;
            textBox8.Text = dogs_amount;
            textBox3.Text = cats_amount;
            textBox4.Text = animals_amount;
            textBox6.Text = target;
            //textBox6.Text = target;          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(label2.Text);

                if (data.Find(x => x.Id == id) != null) { data.Remove(data.Find(x => x.Id == id)); }
                RegisterAct aplicationHandler = new RegisterAct();
                aplicationHandler.DeleteAct(id);
                dataGridView1.DataSource = data.GetRange(0, data.Count);
                dataGridView1.Refresh();
                MessageBox.Show("Данные удалены");
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении данных!");
            }
        }
    }
}
