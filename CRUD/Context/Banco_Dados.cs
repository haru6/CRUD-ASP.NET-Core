using CRUD.Models.Classe;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Context
{
    public class Banco_Dados : DbContext
    {
        public virtual DbSet <Cliente> Clientes { get; set; }

        public Banco_Dados(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>().HasKey(x => x.Id);
        }
    }
}
