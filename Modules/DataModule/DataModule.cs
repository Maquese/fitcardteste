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
            Bind<IRepositorioCategoria>().To<RepositorioCategoria>().InSingletonScope(); 
            Bind<IRepositorioEstabelecimento>().To<RepositorioEstabelecimento>().InSingletonScope(); 
            Bind<IUnidadeDeTrabalho>().To<UnidadeDeTrabalho>().InSingletonScope();
        }
    }
}
