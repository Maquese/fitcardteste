using ApplicationContract.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationContract.Contracts
{
    public interface ICategoriaApp : IApplication
    {
        void Adicionar(CategoriaDTO categoria);

        CategoriaDTO BuscarPorNome(string nome);
    }
}
