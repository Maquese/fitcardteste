﻿using Data.StartupContexto;
using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Contexto
{
    public class ContextoBanco : DbContext
    {
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Estabelecimento> Estabelecimento { get; set; }

        public ContextoBanco() : base("DbTeste")
        {
            Database.SetInitializer<ContextoBanco>(new DbStart());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
