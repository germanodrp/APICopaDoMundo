using APICopaDoMundo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;

namespace APICopaDoMundo.Contexto
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source = 201.62.57.93 ;Database = BD040160; User Id= RA040160;Password = 040160");
        }

        public DbSet<Paises> Paises { get; set; }
        public DbSet<Confederacoes> Confederacao { get; set; }
        public DbSet<Potes> Potes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }


    }
}
