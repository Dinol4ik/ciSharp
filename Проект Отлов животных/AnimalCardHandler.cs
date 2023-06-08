using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_Отлов_животных
{
    internal class AnimalCardHandler
    {
        public void SaveCard(Models.Card_Animal card)
        {
            using (DB dB = new DB())
            {
                //Models.Applications application  = new Models.Applications { Date=date, AnimalHabitat=animalH, Description =desc, Kategory = Kategort, LocalityId = locality, UrgencyOfExecution = urg};
                dB.card_Animals.Add(card);
                dB.SaveChanges();
            }
        }
    }
}
