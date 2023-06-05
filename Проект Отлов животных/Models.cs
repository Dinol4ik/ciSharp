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
            public string? Login  { get; set; }
            public string? Password { get; set; }
            public string? Role { get; set; }
            public string? Company { get; set; }
            public string? OMS { get; set; }
        }
        public class Locality
        {
            public int Id { get; set; }
            public string? Adress { get; set; }
            public string? Administration { get; set;}
            public List<Applications> Applications { get; set; } = new(); // Заявки

        }

        public class Applications
        {
            
            public int Id { get; set; }
            public string? Date { get; set; }
            public string? Kategory { get; set; }
            public string? AnimalHabitat { get; set; }
            public string? Description { get; set; }
            public bool? UrgencyOfExecution { get; set; }
            public int LocalityId { get; set; }
            public Locality? Locality { get; set;}  // Место нахождения

        }

    }
}
