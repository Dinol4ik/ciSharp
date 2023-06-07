using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static Проект_Отлов_животных.Models;

namespace Проект_Отлов_животных
{
    internal class DB : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Applications> Applications { get; set; } = null!;
        public DbSet<Locality> Locality { get; set; } = null!;
        public DbSet<Type_Of_Organization> type_Of_Organizations { get; set; } = null!;
        public DbSet<Organization> organizations { get; set; } = null!;
        public DbSet<Municipal_contract> municipal_Contracts { get; set; } = null!;
        public DbSet<Act_Of_Capture> act_Of_Captures { get; set; } = null!;
        public DbSet<Card_Animal> card_Animals { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=46.101.129.250;Port=5432;Database=postgres;Username=postgres;Password=myPassword");
        }
    }
}
