using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_Отлов_животных
{
    internal class MunicipalHandler
    {
        public List<Municipal_ContractC> GetContractsList()
        {
            using (DB db = new DB())
            {
                var contract = db.municipal_Contracts
                                     .Select(p => new Municipal_ContractC(p.Id, p.Number,p.Date_Of_Conclusion,p.Date_Of_Action, p.Organization.Title))
                                    .ToList();
                return contract;
            }
        }
        public void DeleteContract(int index)
        {
            using (DB db = new DB())
            {
                var contract = db.municipal_Contracts.Where(p => p.Id == index).FirstOrDefault();
                if (contract != null)
                {
                    db.municipal_Contracts.Remove(contract);
                    db.SaveChanges();
                }
            }
        }
        public List<Models.Organization> OrganizationsName()
        {
            using (DB db = new DB())
            {
                var organization_name = db.organizations.ToList();
                return organization_name;
            }
        }
        //int number, string date, string animalH, string desc, string Kategort, int locality,bool urg
        public void SaveContract(Models.Municipal_contract contract)
        {
            using (DB dB = new DB())
            {
                //Models.Applications application  = new Models.Applications { Date=date, AnimalHabitat=animalH, Description =desc, Kategory = Kategort, LocalityId = locality, UrgencyOfExecution = urg};
                dB.municipal_Contracts.Add(contract);
                dB.SaveChanges();
            }
        }
        public void EditContract(Models.Municipal_contract contract)
        {
            using (DB dB = new DB())
            {
                //Models.Applications application  = new Models.Applications { Date=date, AnimalHabitat=animalH, Description =desc, Kategory = Kategort, LocalityId = locality, UrgencyOfExecution = urg};
                Models.Municipal_contract? edit_contract = dB.municipal_Contracts.FirstOrDefault(p => p.Id == contract.Id);
                if (edit_contract != null)
                {
                    edit_contract.Number = contract.Number;
                    edit_contract.Date_Of_Conclusion = contract.Date_Of_Conclusion;
                    edit_contract.Date_Of_Action = contract.Date_Of_Action;
                    edit_contract.OrganizationId = contract.OrganizationId;
                }

                dB.SaveChanges();
            }
        }
    }
}
