using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Проект_Отлов_животных.Models;

namespace Проект_Отлов_животных
{
    public partial class AnimalCard : Form
    {
        public AnimalCard(List<Models.Applications> apl, List<Models.Locality> loc)
        {
            InitializeComponent();

            comboBox1.DataSource = apl;
            comboBox1.DisplayMember = "number";
            comboBox1.ValueMember = "Id";

            comboBox2.DataSource = loc;
            comboBox2.DisplayMember = "Adress";
            comboBox2.ValueMember = "Id";
        }

        private void AnimalCard_Load(object sender, EventArgs e)
        {
           
        }

        private void AddOrgButton_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Locality localityId = (Models.Locality)comboBox2.SelectedItem;
                Models.Applications aplicatId = (Models.Applications)comboBox1.SelectedItem;
                Models.Card_Animal animal_card = new Models.Card_Animal
                {
                    Kategory = long.Parse(textBox1.Text),
                    Gender = textBox2.Text,
                    Breed = textBox3.Text,
                    Color = textBox4.Text,
                    Ears = textBox5.Text,
                    Tail = textBox6.Text,
                    Special_signs = textBox7.Text,
                    Indentification_label = textBox8.Text,
                    Chip_number = textBox9.Text,
                    ApplicationId = aplicatId.Id,
                    LocalityId = localityId.Id,
                };
                AnimalCardHandler animal_cards = new AnimalCardHandler();
                animal_cards.SaveCard(animal_card);
                MessageBox.Show("Данные добавлены");
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении данных");
            }
        }
    }
}
