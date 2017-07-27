using ApplicationContract.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ModuleApp
{
    public class AppModule : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IApplication>().To<Application.Apps.Application>();
        }
    }
}
