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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static Проект_Отлов_животных.Models;

namespace Проект_Отлов_животных
{
    public partial class SearchApplication : Form
    {
        public SearchApplication(List<Models.User> users, List<Application> application, List<Models.Locality> localitiy, string roleUser)
        {
            data = application;
            user = users;
            InitializeComponent();
            if (roleUser == "Куратор ВетСлужбы"
                || roleUser == "Подписант ВетСлужбы"
                || roleUser == "Куратор ОМСУ"
                || roleUser == "Подписант ОМСУ"
                || roleUser == "Подписант по отлову"
                || roleUser == "Куратор по отлову")
            {
                button2.Visible = false;
                button3.Visible = false;

            }

            localityAdress.DataSource = localitiy;
            localityAdress.DisplayMember = "Adress";
            localityAdress.ValueMember = "Id";
            listBox1.SelectedIndex = 0;
            dataGridView1.DataSource = data.GetRange(0, data.Count);
            label2.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
        }
        List<Application> data;
        List<Models.User> user;

        private void button1_Click(object sender, EventArgs e)
        {
            string application = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(label2.Text);

                if (data.Find(x => x.Id == id) != null) { data.Remove(data.Find(x => x.Id == id)); }
                AplicationHandler aplicationHandler = new AplicationHandler();
                aplicationHandler.DeleteAplication(id);
                dataGridView1.DataSource = data.GetRange(0, data.Count);
                dataGridView1.Refresh();
                MessageBox.Show("Запись удалена");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка при удалении");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                UserRole role = new UserRole();
                var dostup = role.chkerRoleAplication(user);
                if (dostup != null && dostup.IndexOf("save") != -1)
                {
                    try
                    {
                    var kat = listBox1.SelectedItem.ToString();
                    Models.Locality localityID = (Models.Locality)localityAdress.SelectedItem;
                    Models.Applications applications = new Models.Applications
                    {
                        Id = int.Parse(label2.Text),
                        Date = dateTimePicker1.Value.ToString(),
                        Description = textBox4.Text,
                        Kategory = kat,
                        //Locality = localityID,
                        AnimalHabitat = textBox3.Text,
                        LocalityId = localityID.Id,
                        number = int.Parse(textBox2.Text),
                        UrgencyOfExecution = Convert.ToBoolean(checkBox1.Checked)
                    };
                    AplicationHandler aplicationHandler = new AplicationHandler();
                    aplicationHandler.EditAplication(applications);
                    MessageBox.Show("Запись успешно изменена!");
                }
                catch 
                {

                    MessageBox.Show("Произошла ошибка проверьте правильность данных!");
                }
                
                }
                else MessageBox.Show("У вас нет прав!");
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            var dat = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            var descr = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            var habit = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            bool chek = Convert.ToBoolean(dataGridView1[5, dataGridView1.CurrentRow.Index].Value);
            var number = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dat);
            textBox4.Text = descr;
            textBox3.Text = habit;
            textBox2.Text = number;
            checkBox1.Checked = chek;
        }

    }
}
