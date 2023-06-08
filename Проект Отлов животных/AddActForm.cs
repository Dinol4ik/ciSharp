using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект_Отлов_животных
{
    public partial class AddActForm : Form
    {
        public AddActForm(List<Models.User> users, List<Models.Organization> organizations, List<Models.Municipal_contract> contract, List<Models.Applications> applications)
        {
            InitializeComponent();
            comboBox3.DataSource = applications;
            comboBox3.DisplayMember = "number";
            comboBox3.ValueMember = "Id";

            comboBox1.DataSource = organizations;
            comboBox1.DisplayMember = "Title";
            comboBox1.ValueMember = "Id";

            comboBox2.DataSource = contract;
            comboBox2.DisplayMember = "Number";
            comboBox2.ValueMember = "Id";
        }

        private void AddActBut_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Organization organisationId = (Models.Organization)comboBox1.SelectedItem;
                Models.Municipal_contract contractId = (Models.Municipal_contract)comboBox2.SelectedItem;
                Models.Applications applicate = (Models.Applications)comboBox3.SelectedItem;
                Models.Act_Of_Capture applications = new Models.Act_Of_Capture
                {
                    Act_Number = long.Parse(textBox9.Text),
                    Amount_Of_Dogs = textBox8.Text,
                    Amount_Of_Cats = textBox3.Text,
                    Amount_Of_Animals = textBox4.Text,
                    Target = textBox6.Text,
                    Date_Of_Capture = dateTimePicker1.Value.ToString(),
                    OrganizationId = organisationId.Id,
                    Municipal_ContractId = contractId.Id,
                    ApplicationId = applicate.Id
                };
                //if (data.Find(x => x.Id == id) != null) { data.Remove(data.Find(x => x.Id == id)); }
                RegisterAct aplicationHandler = new RegisterAct();
                aplicationHandler.SaveAct(applications);
                MessageBox.Show("Данные добавленны");
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении");
            }
        }
    }
}
