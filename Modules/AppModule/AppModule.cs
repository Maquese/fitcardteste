using Application.Apps;
using ApplicationContract.Contracts;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.AppModule
{
    public class AppModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IApplication>().To<Application.Apps.Application>();
            Bind<ICategoriaApp>().To<Application.Apps.Application>();
            Bind<IEstabelecimentoApp>().To<Application.Apps.Application>();
        }
    }
}
