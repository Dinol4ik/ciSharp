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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Проект_Отлов_животных
{
    public partial class Contract : Form
    {
        public Contract(List<Models.User> users, List<Models.Organization> organizations, string roleUser)
        {
            user = users;
            InitializeComponent();
            OrganizationName.DataSource = organizations;
            OrganizationName.DisplayMember = "title";
            OrganizationName.ValueMember = "Id";
        }
        List<Models.User> user;
        private void AddContractBut_Click(object sender, EventArgs e)
        {
            try
            {
                var date1 = dateTimePicker1.Value.ToString();
                var date2 = dateTimePicker1.Value.ToString();
                var number = long.Parse(textBox4.Text);
                Models.Organization organisationId = (Models.Organization)OrganizationName.SelectedItem;
                Models.Municipal_contract contract = new Models.Municipal_contract
                {
                    Date_Of_Action = date1,
                    Date_Of_Conclusion = date2,
                    Number = number,
                    OrganizationId = organisationId.Id
                };
                MunicipalHandler contractHandler = new MunicipalHandler();
                contractHandler.SaveContract(contract);
                MessageBox.Show("Запись добавлена!");
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность ввода!");
            }
            
        }
    }
}
