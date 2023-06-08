using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Проект_Отлов_животных
{
    public partial class RegisterApplicationForm : Form
    {
        public RegisterApplicationForm(List<Models.User> users, List<Models.Locality> data,string roleUser)
        {

            
            InitializeComponent();
            listBox1.SelectedIndex = 0;
            //foreach (Models.Locality locality in data)
            //{
            //    comboBox1.Items.Add(locality);
            //}
            localityAdress.DataSource = data;
            localityAdress.DisplayMember = "Adress";
            localityAdress.ValueMember = "Id";
        }
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
            try
            {
                var date = dateTimePicker1.Value.ToString();
                var kategory = listBox1.SelectedItem.ToString();
                var desc = textBox3.Text;
                //var localityID = new Models.Locality { Adress = comboBox1.SelectedItem.ToString(),  };
                Models.Locality localityID = (Models.Locality)localityAdress.SelectedItem;
                bool chekBox = checkBox1.Checked;
                var animalHabital = textBox1.Text;
                var number = int.Parse(textBox2.Text);
                Models.Applications applications = new Models.Applications
                {
                    Date = date,
                    Description = desc,
                    Kategory = kategory,
                    //Locality = localityID,
                    AnimalHabitat = animalHabital,
                    LocalityId = localityID.Id,
                    number = number,
                    UrgencyOfExecution = chekBox
                };
                AplicationHandler aplicationHandler = new AplicationHandler();
                aplicationHandler.SaveAplication(applications);
                MessageBox.Show("Заявка добавлена");
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка, проверьте правильность данных");
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
