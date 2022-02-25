using APICopaDoMundo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;

namespace APICopaDoMundo.Contexto
{
    public class Context:DbContext
    {
<<<<<<< HEAD
         public Context()
=======
        public Context()
>>>>>>> 22871f42d3aa08cb50e529dbc834718a9c16e300
        { }
        public Context(DbContextOptions<Context> options)
            : base(options)
        { }

        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<Confederacoes> Confederacoes { get; set; }
        public virtual DbSet<Potes> Potes { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
        }


    }
}
