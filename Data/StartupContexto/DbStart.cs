﻿using Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.StartupContexto
{
    public class DbStart : CreateDatabaseIfNotExists<ContextoBanco>
    {
        public override void InitializeDatabase(ContextoBanco context)
        {
            context.Categoria.Add(new Domain.Entidades.Categoria("Supermercado"));

            context.Categoria.Add(new Domain.Entidades.Categoria("Restaurante"));

            context.Categoria.Add(new Domain.Entidades.Categoria("Borracharia"));


            context.Categoria.Add(new Domain.Entidades.Categoria("Posto"));
            context.Categoria.Add(new Domain.Entidades.Categoria("Oficina"));

            context.SaveChanges();
            base.InitializeDatabase(context);
        }
    }
}
