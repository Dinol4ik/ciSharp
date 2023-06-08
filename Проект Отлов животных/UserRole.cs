using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_Отлов_животных
{
    internal class UserRole
    {
        public List<string>? chkerRoleAplication(List<Models.User> user)
        {
            if (user[0].Role == "Оператор ОМСУ")
            {
                List<string> s = new List<string> { "save", "read", "delete", "" };
                return s;
            }
            else if (user[0].Role == "Куратор ОМСУ")
            {
                List<string> s = new List<string> { "", "read", "", "update" };
                return s;
            }
            return null;
        }
        public List<string>? chkerRoleCard(List<Models.User> user)
        {
            if (user[0].Role == "Оператор ОМСУ")
            {
                List<string> s = new List<string> { "save", "edit", "delete", "update" };
                return s;
            }
            return null;
        }
        public List<string>? chkerRoleOrg(List<Models.User> user)
        {
            if (user[0].Role == "Оператор ОМСУ")
            {
                List<string> s = new List<string> { "save", "edit", "delete", "update" };
                return s;
            }
            return null;
        }
        public List<string>? chkerRoleContract(List<Models.User> user)
        {
            if (user[0].Role == "Оператор ОМСУ")
            {
                List<string> s = new List<string> { "save", "edit", "delete", "" };
                return s;
            }
            return null;
        }
    }
}
