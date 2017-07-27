using ApplicationContract.Contracts;
using DomainContracy.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Apps
{
    public partial class Application : IApplication
    {
        private IRepositorioCategoria _RepositorioCategoria;
        private IRepositorioEstabelecimento _RepositorioEstabelecimento;

        public Application(IRepositorioEstabelecimento estabelecimentoRepositorio, IRepositorioCategoria reposiotorioCategoria)
        {
            _RepositorioEstabelecimento = estabelecimentoRepositorio;
            _RepositorioCategoria = reposiotorioCategoria;
        }
    }
}
