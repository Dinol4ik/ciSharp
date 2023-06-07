using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_Отлов_животных
{
    public class Act
    {
        public int Id { get; set; }
        public long? Number_aplication { get; set; }
        public string? Dogs_amount { get; set; }
        public string? Cats_amount { get; set; }
        public string? Animals_amount { get; set; }
        public string? Capture_date { get; set; }
        public long? Municipal_contract { get; set; }
        public string? Organisation { get; set; }
        public string? Target { get; set; }
        public Act(long? number_aplication, string? dogs_amount, string? cats_amount, string? animals_amount, string? target, int id, string? capture_date, long? municipal_contract, string? organisation)
        {
            Number_aplication = number_aplication;
            Dogs_amount = dogs_amount;
            Cats_amount = cats_amount;
            Animals_amount = animals_amount;
            Target = target;
            Id = id;
            Capture_date = capture_date;
            Municipal_contract = municipal_contract;
            Organisation = organisation;      
        }
    }
}
