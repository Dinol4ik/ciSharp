using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_Отлов_животных
{
    internal class RegisterOrganization
    {
        public List<OrganizationC> GetOrganizationList()
        {
            using (DB db = new DB())
            {
                var org = db.organizations
                                     .Select(p => new OrganizationC(p.Id, p.Title, p.TypeOf.Title, p.INN, p.KPP, p.Registation_addres, p.Sole_Properietor, p.Locality.Adress))
                                    .ToList();
                return org;

            }
        }

        public List<Models.Type_Of_Organization> type_organisation()
        {
            using (DB db = new DB())
            {
                var type_organisations = db.type_Of_Organizations.ToList();
                return type_organisations;
            }
        }

        public void DeleteOrganization(int index)
        {
            using (DB db = new DB())
            {
                var org = db.organizations.Where(p => p.Id == index).FirstOrDefault();
                if (org != null)
                {
                    db.organizations.Remove(org);
                    db.SaveChanges();
                }
            }
        }

        //int number, string date, string animalH, string desc, string Kategort, int locality,bool urg
        public void SaveOrganization(Models.Organization org)
        {
            using (DB dB = new DB())
            {
                dB.organizations.Add(org);
                dB.SaveChanges();
            }
        }

        public void EditOrganization(Models.Organization updateOrg)
        {
            using (DB dB = new DB())
            {
                //Models.Applications application  = new Models.Applications { Date=date, AnimalHabitat=animalH, Description =desc, Kategory = Kategort, LocalityId = locality, UrgencyOfExecution = urg};
                Models.Organization? org = dB.organizations.FirstOrDefault(p => p.Id == updateOrg.Id);
                if (org != null)
                {
                    org.Title = updateOrg.Title;
                    org.INN = updateOrg.INN;
                    org.KPP = updateOrg.KPP;
                    org.TypeOfId = updateOrg.TypeOfId;
                    org.Registation_addres = updateOrg.Registation_addres;
                    org.LocalityId = updateOrg.LocalityId;
                    org.Sole_Properietor = updateOrg.Sole_Properietor;
                }

                dB.SaveChanges();
            }
        }
    }
}
