using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Проект_Отлов_животных.Models;

namespace Проект_Отлов_животных
{
    public partial class SearchOrganisation : Form
    {
        public SearchOrganisation(List<OrganizationC> org, List<Models.Locality> locality, List<Models.Type_Of_Organization> type, string roleUser)
        {
            data = org;
            InitializeComponent();

            comboBox1.DataSource = locality;
            comboBox1.DisplayMember = "Adress";
            comboBox1.ValueMember = "Id";
            if (roleUser == "Куратор по отлову")
            {
                button2.Visible = false;
                button3.Visible = false;

            }

            comboBox2.DataSource = type;
            comboBox2.DisplayMember = "Title";
            comboBox2.ValueMember = "Id";

            dataGridView1.DataSource = org.GetRange(0, org.Count);
            label2.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
        }
        List<OrganizationC> data;

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            var title = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            var inn = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            var kpp = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            var adress = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
            var ipOrOoo = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();

            textBox2.Text = title;
            textBox3.Text = inn;
            textBox4.Text = kpp;
            textBox5.Text = ipOrOoo;
            textBox6.Text = adress;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(label2.Text);

                Models.Locality localityId = (Models.Locality)comboBox1.SelectedItem;
                Models.Type_Of_Organization typeOrgId = (Models.Type_Of_Organization)comboBox2.SelectedItem;
                Models.Organization organization = new Models.Organization
                {
                    Id = int.Parse(label2.Text),
                    Title = textBox2.Text,
                    TypeOfId = typeOrgId.Id,
                    INN = textBox3.Text,
                    KPP = textBox4.Text,
                    Sole_Properietor = textBox5.Text,
                    Registation_addres = textBox6.Text,
                    LocalityId = localityId.Id,
                };
                //if (data.Find(x => x.Id == id) != null) { data.Remove(data.Find(x => x.Id == id)); }
                RegisterOrganization organizationHandler = new RegisterOrganization();
                organizationHandler.EditOrganization(organization);

                dataGridView1.DataSource = data.GetRange(0, data.Count);
                dataGridView1.Refresh();
                MessageBox.Show("Данные обновленны");
            }
            catch
            {
                MessageBox.Show("Ошибка! Проверьте правильность данных");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(label2.Text);

                if (data.Find(x => x.Id == id) != null) { data.Remove(data.Find(x => x.Id == id)); }
                RegisterOrganization organizationHandler = new RegisterOrganization();
                organizationHandler.DeleteOrganization(id);
                dataGridView1.DataSource = data.GetRange(0, data.Count);
                dataGridView1.Refresh();
                MessageBox.Show("Данные удалены");
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении данных");
            }
        }
    }
}
