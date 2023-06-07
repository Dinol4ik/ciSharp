using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Проект_Отлов_животных.Models;

namespace Проект_Отлов_животных
{
    public class Application
    {
        public int Id { get; set; }
        public string? Date { get; set; }
        public string? Kategory { get; set; }
        public string? AnimalHabitat { get; set; }
        public string? Description { get; set; }
        public bool? UrgencyOfExecution { get; set; }
        public string? LocalityAddress { get; set; }
        public int? Number {  get; set; }
        public Application(int? number,bool? urgencyOfExecution, string? date, string? kategory, int id, string? animalHabitat, string? description, string? localityAddress)
        {
            Number = number;
            UrgencyOfExecution = urgencyOfExecution;
            Date = date;
            Kategory = kategory;
            Id = id;
            AnimalHabitat = animalHabitat;
            Description = description;
            LocalityAddress = localityAddress;
        }

    }
}
