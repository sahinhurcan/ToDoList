using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoTest.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=SH\\SAYAZ;database=todo; integrated security=true;");
        }




        public DbSet<kullanicilar> kullanicilars { get; set; }
        public DbSet<gorevler> gorevlers { get; set; }
        public DbSet<Firmalar> Firmalars { get; set; }
    }
}
