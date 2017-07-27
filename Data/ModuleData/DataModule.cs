using Data.Repostorios;
using Domain.Entidades;
using DomainContract.Contracts;
using DomainContracy.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ModuleData
{
    class DataModule : Ninject.Modules.NinjectModule
    {
        public override void Load() 
        {
            Bind<IRepositorioCategoria>().To<RepositorioCategoria>();
            Bind<IRepositorioEstabelecimento>().To<RepositorioEstabelecimento>();
        }
    }
}
