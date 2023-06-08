using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Проект_Отлов_животных.Migrations;

namespace Проект_Отлов_животных
{
    internal class AplicationHandler
    {
        public List<Application> GetApplicationList()
        {
            using (DB db = new DB())
            {
                var aplicat =  db.Applications
                                     .Select(p => new Application(p.number,p.UrgencyOfExecution,p.Date,p.Kategory,p.Id,p.AnimalHabitat,p.Description, p.Locality.Adress) )
                                    .ToList();
                return aplicat;

            }
        }
        public bool IsValid(Models.Applications application)
        {
            if (application != null)
            {
                return true;
            }
            else return false;
        }
        public void DeleteAplication(int index)
        {
            using (DB db = new DB())
            {
                var aplicat = db.Applications.Where(p => p.Id == index).FirstOrDefault();
                if (aplicat != null) {
                    db.Applications.Remove(aplicat);
                    db.SaveChanges();
                }
            }
        }
        public List<Models.Locality> localities()
        {
            using (DB db = new DB())
            {
                var locality = db.Locality.ToList();
                return locality;
            }
        }
        public List<Models.Applications> aplicatList()
        {
            using (DB db = new DB())
            {
                var apl = db.Applications.ToList();
                return apl;
            }
        }
        //int number, string date, string animalH, string desc, string Kategort, int locality,bool urg
        public void SaveAplication(Models.Applications aplicate )
        {
            if (IsValid(aplicate))
            {
                using (DB dB = new DB())
                {
                    //Models.Applications application  = new Models.Applications { Date=date, AnimalHabitat=animalH, Description =desc, Kategory = Kategort, LocalityId = locality, UrgencyOfExecution = urg};
                    dB.Applications.Add(aplicate);
                    dB.SaveChanges();
                }
            }
            else MessageBox.Show("Валидация не прошла");
        }
        public List<Models.Applications> ApplicationFinde(string title)
        {
            using (DB db = new DB())
            {
                //var aplicat = db.Applications.Where(u => EF.Functions.Like(u.Kategory.ToString(), "%во%")).AsEnumerable().ToList();
                
                List<Models.Applications> aplicat = new List<Models.Applications>();
                foreach (var item in db.Applications.Where(i => (i.Kategory.Contains("На"))))
                {
                    aplicat.Add(item);
                }
                
                //var aplicat = db.Applications.Where(i=> (i.Kategory.Contains("во"))).ToList();

                //var aplicat = db.Applications.Select(s => new { s.Kategory }).ToList();
                return aplicat;
            }
        }
        public void EditAplication(Models.Applications aplicate)
        {
            using (DB dB = new DB())
            {
                //Models.Applications application  = new Models.Applications { Date=date, AnimalHabitat=animalH, Description =desc, Kategory = Kategort, LocalityId = locality, UrgencyOfExecution = urg};
                Models.Applications? aplication = dB.Applications.FirstOrDefault(p => p.Id == aplicate.Id);
                if (aplication != null)
                {
                    aplication.number = aplicate.number;
                    aplication.Date = aplicate.Date;
                    aplication.Description = aplicate.Description;
                    aplication.AnimalHabitat = aplicate.AnimalHabitat;
                    aplication.LocalityId = aplicate.LocalityId;
                    aplication.Kategory =   aplicate.Kategory;
                    aplication.UrgencyOfExecution = aplicate.UrgencyOfExecution;
                }

                dB.SaveChanges();
            }
        }

    }
}
