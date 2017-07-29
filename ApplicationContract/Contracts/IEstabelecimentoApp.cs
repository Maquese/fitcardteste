using ApplicationContract.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationContract.Contracts
{
    public interface IEstabelecimentoApp : IApplication
    {
        IList<EstabelecimentoDTO> Listar();
        void Novo(EstabelecimentoDTO estabelecimento);
    }
}
