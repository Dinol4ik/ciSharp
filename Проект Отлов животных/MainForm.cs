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
using static System.Net.Mime.MediaTypeNames;
using static Проект_Отлов_животных.Models;

namespace Проект_Отлов_животных
{
    public partial class mainForm : Form
    {
        //List<Models.User> data
        public mainForm()
        {
            InitializeComponent();
            //accountName.Text = data[0].Login;
            //this.data = data;
            StartPosition = FormStartPosition.CenterParent;
        }
        //List<Models.User> data;

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
            AplicationHandler allLocality = new AplicationHandler();
            var locality = allLocality.localities();
            RegisterApplicationForm frap = new RegisterApplicationForm(locality);
            frap.ShowDialog();
        }

        private void SearchApplicationBut_Click(object sender, EventArgs e)
        {
            AplicationHandler aplication = new AplicationHandler();
            var aplicationList = aplication.GetApplicationList();
            AplicationHandler allLocality = new AplicationHandler();
            var locality = allLocality.localities();
            SearchApplication application = new SearchApplication(aplicationList, locality);
            application.ShowDialog();
        }

        private void AddContractBut_Click(object sender, EventArgs e)
        {

        }

        private void AccountBtn_Click_1(object sender, EventArgs e)
        {
            //AccountForm frm = new AccountForm(data);
            //frm.ShowDialog();
        }

        private void mainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void SearchActBut_Click(object sender, EventArgs e)
        {
            RegisterAct act = new RegisterAct();
            var actList = act.GetActList();

            var organisation = act.organisation();
            var contract = act.municipal_contract();
            var application = act.GetApplication();

            SearchAct actForm = new SearchAct(actList, organisation, contract, application);
            actForm.ShowDialog();
        }

        private void ActBtn_Click(object sender, EventArgs e)
        {
            RegisterAct act = new RegisterAct();
            var actList = act.GetActList();

            var organisation = act.organisation();
            var contract = act.municipal_contract();
            var application = act.GetApplication();

            AddActForm actForm = new AddActForm(organisation, contract, application);
            actForm.ShowDialog();
        }

        private void SearchApplicationBut_Click_1(object sender, EventArgs e)
        {
        }

        private void SearchContractBut_Click(object sender, EventArgs e)
        {
            SearchContract Form = new SearchContract();
            Form.ShowDialog();
        }
    }
}
