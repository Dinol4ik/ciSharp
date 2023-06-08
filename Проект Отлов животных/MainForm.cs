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

        public mainForm(List<Models.User> data)
        {
            InitializeComponent();
            accountName.Text = data[0].Role;
            roleUser = data[0].Role;
            this.data = data;
            StartPosition = FormStartPosition.CenterParent;
            //////// role power strength
            if (roleUser == "Оператор ОМСУ")
            {
                ActBtn.Visible = false;

            }
            else if (roleUser == "Куратор ВетСлужбы"
                || roleUser == "Подписант ВетСлужбы"
                || roleUser == "Куратор ОМСУ"
                || roleUser == "Подписант ОМСУ"
                || roleUser == "Подписант по отлову"
                )
            {
                ActBtn.Visible = false;
                AddContractBut.Visible = false;
                AplicationRegBtn.Visible = false;
            }
            else if (roleUser == "Куратор по отлову")
            {
                OrgAddBtn.Visible = false;
                AplicationRegBtn.Visible = false;
                AddContractBut.Visible = false;

            }
        }
        string roleUser;
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

        private void AccountBtn_Click_1(object sender, EventArgs e)
        {
            //AccountForm frm = new AccountForm(data);
            //frm.ShowDialog();
        }

        private void mainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void OrgSearchBut_Click(object sender, EventArgs e)
        {
            RegisterOrganization organizationHandler = new RegisterOrganization();
            var organizations = organizationHandler.GetOrganizationList();
            var type_org = organizationHandler.type_organisation();

            AplicationHandler allLocality = new AplicationHandler();
            var locality = allLocality.localities();

            SearchOrganisation org = new SearchOrganisation(data,organizations, locality, type_org, roleUser);
            org.ShowDialog();
        }

        private void SearchActBut_Click(object sender, EventArgs e)
        {
            RegisterAct act = new RegisterAct();
            var actList = act.GetActList();

            var organisation = act.organisation();
            var contract = act.municipal_contract();
            var application = act.GetApplication();

            SearchAct actForm = new SearchAct(data,actList, organisation, contract, application, roleUser);
            actForm.ShowDialog();
        }

        private void SearchContractBut_Click(object sender, EventArgs e)
        {
            MunicipalHandler contract = new MunicipalHandler();
            var org = contract.OrganizationsName();
            var contracts = contract.GetContractsList();
            SearchContract Form = new SearchContract(data,contracts, org, roleUser);
            Form.ShowDialog();
        }

        private void AddContractBut_Click(object sender, EventArgs e)
        {
            MunicipalHandler contract = new MunicipalHandler();
            var org = contract.OrganizationsName();
            Contract Form = new Contract(org, roleUser);
            Form.ShowDialog();
        }

        private void OrgAddBtn_Click(object sender, EventArgs e)
        {
            RegisterOrganization orgList = new RegisterOrganization();
            var organisation_type = orgList.type_organisation();

            AplicationHandler allLocality = new AplicationHandler();
            var locality = allLocality.localities();

            Organisation org = new Organisation(data,organisation_type, locality);
            org.ShowDialog();
        }

        private void AplicationRegBtn_Click(object sender, EventArgs e)
        {
            AplicationHandler allLocality = new AplicationHandler();
            var locality = allLocality.localities();
            RegisterApplicationForm frap = new RegisterApplicationForm(data,locality, roleUser);
            frap.ShowDialog();
        }

        private void ActBtn_Click(object sender, EventArgs e)
        {
            RegisterAct act = new RegisterAct();
            var actList = act.GetActList();

            var organisation = act.organisation();
            var contract = act.municipal_contract();
            var application = act.GetApplication();

            AddActForm actForm = new AddActForm(data,organisation, contract, application);
            actForm.ShowDialog();
        }

        private void SearchApplicationBut_Click(object sender, EventArgs e)
        {
            AplicationHandler aplication = new AplicationHandler();
            var aplicationList = aplication.GetApplicationList();
            AplicationHandler allLocality = new AplicationHandler();
            var locality = allLocality.localities();
            SearchApplication application = new SearchApplication(data,aplicationList, locality, roleUser);
            application.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) //Карточка животного
        {
            AplicationHandler apl = new AplicationHandler();
            var application = apl.aplicatList();
            var locality = apl.localities();

            AnimalCard actForm = new AnimalCard(application, locality);
            actForm.ShowDialog();
        }
    }
}
