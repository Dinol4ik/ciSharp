using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
