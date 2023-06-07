using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_Отлов_животных
{
    internal class RegisterAct
    {
        public List<Act> GetActList()
        {
            using (DB db = new DB())
            {
                var aplicat =  db.act_Of_Captures
                                     .Select(p => new Act(p.Act_Number, p.Amount_Of_Dogs, p.Amount_Of_Cats, p.Amount_Of_Animals, p.Target, p.Id,p.Date_Of_Capture, p.Municipal_Contract.Number, p.Organization.Title) )
                                    .ToList();
                return aplicat;

            }
        }

        public void DeleteAct(int index)
        {
            using (DB db = new DB())
            {
                var act = db.act_Of_Captures.Where(p => p.Id == index).FirstOrDefault();
                if (act != null) {
                    db.act_Of_Captures.Remove(act);
                    db.SaveChanges();
                }
            }
        }

        public List<Models.Organization> organisation()
        {
            using (DB db = new DB())
            {
                var organisations = db.organizations.ToList();
                return organisations;
            }
        }

        public List<Models.Applications> GetApplication()
        {
            using (DB db = new DB())
            {
                var application = db.Applications.ToList();
                return application;
            }
        }

        public List<Models.Municipal_contract> municipal_contract()
        {
            using (DB db = new DB())
            {
                var municipal_conctract = db.municipal_Contracts.ToList();
                return municipal_conctract;
            }
        }

        //int number, string date, string animalH, string desc, string Kategort, int locality,bool urg
        public void SaveAct(Models.Act_Of_Capture act)
        {
            using (DB dB = new DB())
            {         
                dB.act_Of_Captures.Add(act);
                dB.SaveChanges();
            }          
        }

        public void EditAct(Models.Act_Of_Capture updatedAct)
        {
            using (DB dB = new DB())
            {
                //Models.Applications application  = new Models.Applications { Date=date, AnimalHabitat=animalH, Description =desc, Kategory = Kategort, LocalityId = locality, UrgencyOfExecution = urg};
                Models.Act_Of_Capture? act = dB.act_Of_Captures.FirstOrDefault(p => p.Id == updatedAct.Id);
                if (act != null)
                {
                    act.Date_Of_Capture = updatedAct.Date_Of_Capture;
                    act.Amount_Of_Cats = updatedAct.Amount_Of_Cats;
                    act.Amount_Of_Animals = updatedAct.Amount_Of_Animals;
                    act.Amount_Of_Dogs = updatedAct.Amount_Of_Dogs;
                    act.Act_Number = updatedAct.Act_Number;
                    act.Municipal_ContractId = updatedAct.Municipal_ContractId;
                    act.OrganizationId = updatedAct.OrganizationId;
                    act.Target = updatedAct.Target;
                }

                dB.SaveChanges();
            }
        }
    }
}
