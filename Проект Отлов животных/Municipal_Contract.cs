using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_Отлов_животных
{
    public class Municipal_Contract
    {
        public int Id { get; set; }
        public long? Number_contract { get; set; }
        public string? Date_of_action { get; set; }
        public string? Date_of_conclusion { get; set; }
        public string? Organization_title { get; set; }
        public Municipal_Contract(int id,long number_contract, string date_of_conlusion, string date_of_action, string? organization_title) {
            Id = id;
            Number_contract = number_contract;
            Date_of_action = date_of_action;
            Date_of_conclusion = date_of_conlusion;
            Organization_title = organization_title;
        }
    }
}
