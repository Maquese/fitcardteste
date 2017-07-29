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
        void Editar(EstabelecimentoDTO estabelecimento);

        IList<EstabelecimentoDTO> Listar();
        void Novo(EstabelecimentoDTO estabelecimento);

        EstabelecimentoDTO Buscar(Guid id);

        void Excluir(Guid id);
    }
}
