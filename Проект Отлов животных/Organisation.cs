using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Проект_Отлов_животных.Models;

namespace Проект_Отлов_животных
{
    public partial class Organisation : Form
    {
        public Organisation(List<Models.User> users,List<Models.Type_Of_Organization> type, List<Models.Locality> locality)
        {
            user = users;
            InitializeComponent();
            comboBox1.DataSource = type;
            comboBox1.DisplayMember = "Title";
            comboBox1.ValueMember = "Id";

            comboBox2.DataSource = locality;
            comboBox2.DisplayMember = "Adress";
            comboBox2.ValueMember = "Id";
        }
        List<Models.User> user;

        private void AddOrgButton_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Locality localityId = (Models.Locality)comboBox2.SelectedItem;
                Models.Type_Of_Organization typeOrgId = (Models.Type_Of_Organization)comboBox1.SelectedItem;
                Models.Organization organization = new Models.Organization
                {
                    Title = textBox2.Text,
                    TypeOfId = typeOrgId.Id,
                    INN = textBox3.Text,
                    KPP = textBox4.Text,
                    Sole_Properietor = textBox5.Text,
                    Registation_addres = textBox6.Text,
                    LocalityId = localityId.Id,
                };
                RegisterOrganization organizationHandler = new RegisterOrganization();
                organizationHandler.SaveOrganization(organization);
                MessageBox.Show("Данные добавлены");
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении данных");
            }
        }
    }
}
