using Data.Contexto;
using Data.Repostorios;
using DomainContracy.Contracts;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.DataModule
{
    public class DataModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepositorioCategoria>().To<RepositorioCategoria>();
            Bind<IRepositorioEstabelecimento>().To<RepositorioEstabelecimento>();
            Bind<IUnidadeDeTrabalho>().To<UnidadeDeTrabalho>().InSingletonScope();
        }
    }
}
