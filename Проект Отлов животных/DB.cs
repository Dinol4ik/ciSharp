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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=46.101.129.250;Port=5432;Database=postgres;Username=postgres;Password=myPassword");
        }
    }
}
