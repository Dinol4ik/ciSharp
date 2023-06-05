using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_Отлов_животных
{
    internal class AplicationHandler
    {
        public List<Application> GetApplicationList()
        {
            using (DB db = new DB())
            {
                var aplicat =  db.Applications
                                     .Select(p => new Application(p.UrgencyOfExecution,p.Date,p.Kategory,p.Id,p.AnimalHabitat,p.Description, p.Locality.Adress) )
                                    .ToList();
                return aplicat;

            }
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
    }
}
