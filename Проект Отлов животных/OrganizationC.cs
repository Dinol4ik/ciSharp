using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_Отлов_животных
{
    public class OrganizationC
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Type { get; set; }
        public string? Inn { get; set; }
        public string? Kpp { get; set; }
        public string? RegisterAdress { get; set; }
        public string? IpOrOoo { get; set; }
        public string? Locality { get; set; }

        public OrganizationC(int id, string title, string? type, string inn, string? kpp, string? registerAdress, string? iporooo, string? locality)
        {
            Id = id;
            Title = title;
            Type = type;
            Inn = inn;
            Kpp = kpp;
            RegisterAdress = registerAdress;
            IpOrOoo = iporooo;
            Locality = locality;
        }
    }
}
