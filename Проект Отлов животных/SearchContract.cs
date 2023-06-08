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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Проект_Отлов_животных.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace Проект_Отлов_животных
{
    public partial class SearchContract : Form
    {
        public SearchContract(List<Models.User> users, List<Municipal_ContractC> contracts, List<Models.Organization> organizations, string roleUser)
        {
            data = contracts;
            user= users;
            InitializeComponent();
            if (roleUser == "Куратор ВетСлужбы"
                || roleUser == "Подписант ВетСлужбы"
                || roleUser == "Куратор ОМСУ"
                || roleUser == "Подписант ОМСУ"
                || roleUser == "Подписант по отлову")
            {
                button2.Visible = false;
                button3.Visible = false;

            }
            OrganizationName.DataSource = organizations;
            OrganizationName.DisplayMember = "title";
            OrganizationName.ValueMember = "Id";
            dataGridView1.DataSource = data.GetRange(0, data.Count);
        }
        List<Municipal_ContractC> data;
        List<Models.User> user;
        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            var dat1 = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            var dat2 = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            var number = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dat1);
            dateTimePicker2.Value = Convert.ToDateTime(dat2);
            textBox2.Text = number;
        }

        private void localityAdress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                UserRole role = new UserRole();
                var dostup = role.chkerRoleContract(user);
                if (dostup != null && dostup.IndexOf("update") != -1)
                {
                    int id = int.Parse(label2.Text);
                    Models.Organization organisationId = (Models.Organization)OrganizationName.SelectedItem;
                    Models.Municipal_contract contract_edit = new Models.Municipal_contract
                    {
                        Id = id,
                        Date_Of_Action = dateTimePicker1.Value.ToString(),
                        Date_Of_Conclusion = dateTimePicker2.Value.ToString(),
                        Number = long.Parse(textBox2.Text),
                        OrganizationId = organisationId.Id

                    };
                    MunicipalHandler aplicationHandler = new MunicipalHandler();
                    aplicationHandler.EditContract(contract_edit);
                    MessageBox.Show("Запись отредактирована!");
                }
                else MessageBox.Show("Нет прав");
            } 
            catch (Exception)
            {

                MessageBox.Show("Произошла ошибка, проверьте правильность данных!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(label2.Text);

                if (data.Find(x => x.Id == id) != null) { data.Remove(data.Find(x => x.Id == id)); }
                MunicipalHandler aplicationHandler = new MunicipalHandler();
                aplicationHandler.DeleteContract(id);
                dataGridView1.DataSource = data.GetRange(0, data.Count);
                dataGridView1.Refresh();
                MessageBox.Show("Запись Удалена");
            }
            catch (Exception)
            {
                MessageBox.Show("Удалить не получилось");

            }
        }
    }
}
