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
    public partial class mainForm : Form
    {
        public mainForm(List<Models.User> data)
        {
            InitializeComponent();
            accountName.Text = data[0].Login;
            this.data = data;
            StartPosition = FormStartPosition.CenterParent;
        }
        List<Models.User> data;

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountName_Click(object sender, EventArgs e)
        {

        }

        private void актОтловаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void OrgAddBtn_Click(object sender, EventArgs e)
        {
            Organisation org = new Organisation();
            org.ShowDialog();
        }

        private void OrgDeleteBut_Click(object sender, EventArgs e)
        {
            SearchOrganisation org = new SearchOrganisation();
            org.ShowDialog();
        }

        private void AplicationRegBtn_Click(object sender, EventArgs e)
        {
            RegisterApplicationForm frap = new RegisterApplicationForm();
            frap.ShowDialog();
        }

        private void SearchApplicationBut_Click(object sender, EventArgs e)
        {
            AplicationHandler aplication = new AplicationHandler();
           var aplicationList = aplication.GetApplicationList();
            SearchApplication application = new SearchApplication(aplicationList);
            application.ShowDialog();
        }

        private void ActBtn_Click(object sender, EventArgs e)
        {
            AddActForm act = new AddActForm();
            act.ShowDialog();
        }

        private void SearchActBut_Click(object sender, EventArgs e)
        {
            SearchAct act = new SearchAct();
            act.ShowDialog();
        }

        private void AddContractBut_Click(object sender, EventArgs e)
        {

        }

        private void AccountBtn_Click_1(object sender, EventArgs e)
        {
            AccountForm frm = new AccountForm(data);
            frm.ShowDialog();
        }
    }
}
