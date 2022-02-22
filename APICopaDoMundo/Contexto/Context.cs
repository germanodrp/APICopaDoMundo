using APICopaDoMundo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;

namespace APICopaDoMundo.Contexto
{
    public class Context:DbContext
    {

        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<Confederacoes> Confederacao { get; set; }
        public virtual DbSet<Potes> Potes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
        }


    }
}
