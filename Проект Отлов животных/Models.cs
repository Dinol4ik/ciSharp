using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Проект_Отлов_животных
{
    public static class Models
    {
        public class User
        {
            public int Id { get; set; }
            public string? Login { get; set; }
            public string? Password { get; set; }
            public string? Role { get; set; }
            public int? OrganizationId { get; set; }
            public Organization? Organization  { get; set; }
        }
        public class Locality
        {
            public int Id { get; set; }
            public string? Adress { get; set; }
            public string? Administration { get; set; }
            public List<Applications> Applications { get; set; } = new(); // Заявки
            public List<Type_Of_Organization> type_Of_Organizations { get; set; } = new();
            public List<Card_Animal> card_Animals { get; set; } = new();

        }

        public class Applications
        {
            public int Id { get; set; }
            public string? Date { get; set; }
            public int? number { get; set; }
            public string? Kategory { get; set; }
            public string? AnimalHabitat { get; set; }
            public string? Description { get; set; }
            public bool? UrgencyOfExecution { get; set; }
            public int LocalityId { get; set; }
            public Locality? Locality { get; set; }  // Место нахождения
            public List<Act_Of_Capture> act_Of_Captures { get; set; } = new();
            public List<Card_Animal> card_Animals { get; set; } = new();

        }
        public class Type_Of_Organization
        {
            public int Id { get; set; }
            public string? Title { get; set; }
            public List<Type_Of_Organization> type_Of_Organizations { get; set; } = new();

        }

        public class Organization
        {
            public int Id { get; set; }
            public string? Title { get; set; }
            public string? INN { get; set; }
            public string? KPP { get; set; }
            public string? Registation_addres { get; set; }
            public string? Sole_Properietor { get; set; }
            public int LocalityId { get; set; }
            public Locality? Locality { get; set; }
            public int TypeOfId  { get; set; }
            public Type_Of_Organization? TypeOf { get; set; }
            public List<Municipal_contract> Municipal_contracts { get; set; } = new();
            public List<Act_Of_Capture> act_Of_Captures { get; set; } = new();
            public List<User> users { get; set; } = new();
        }

        public class Municipal_contract
        {
            public int Id { get; set; }
            public long? Number { get; set; }
            public string? Date_Of_Action { get; set; }
            public string? Date_Of_Conclusion { get; set; }
            public int OrganizationId { get; set; }
            public Organization? Organization { get; set; }
            public List<Act_Of_Capture> act_Of_Captures { get; set; } = new();

        }
        public class Act_Of_Capture
        {
            public int Id { get; set; }
            public long? Act_Number { get; set; }
            public string? Amount_Of_Dogs{ get; set; }
            public string? Amount_Of_Cats { get; set; }
            public string? Amount_Of_Animals { get; set; }
            public string? Date_Of_Capture { get; set; }
            public string? Target { get; set; }
            public int OrganizationId { get; set; }
            public Organization? Organization { get; set; }
            public int ApplicationId { get; set; }
            public Applications? Application { get; set; }
            public int Municipal_ContractId { get; set; }
            public Municipal_contract? Municipal_Contract { get; set; }

        }
        public class Card_Animal
        {
            public int Id { get; set; }
            public long? Kategory { get; set; }
            public string? Gender { get; set; }
            public string? Breed { get; set; }
            public string? Color { get; set; }
            public string? Ears { get; set; }
            public string? Tail { get; set; }
            public string? Special_signs { get; set; }
            public string? Indentification_label { get; set; }
            public string? Chip_number { get; set; }
            public int ApplicationId { get; set; }
            public Applications? Application { get; set; }
            public int LocalityId { get; set; }
            public Locality? Locality { get; set; }

        }



    }
}
