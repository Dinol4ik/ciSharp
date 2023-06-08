using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Проект_Отлов_животных
{
    internal class AuthHandler
    {
       public List<Models.User> autharization(string login, string password)
        {
            using (DB db = new DB())
            {
                var users =  db.Users
                                    .Where(p => p.Login == login && p.Password == password)
                                    .ToList();
                return (users);

            }
        }

    }
}
