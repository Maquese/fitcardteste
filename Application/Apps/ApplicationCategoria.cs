using ApplicationContract.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationContract.DTOS;
using Domain.Entidades;

namespace Application.Apps
{
    public partial class Application : ICategoriaApp
    {
        public void Adicionar(CategoriaDTO categoria)
        {
            _RepositorioCategoria.Adicionar(new Categoria(categoria.Nome));
                       
        }

        public CategoriaDTO BuscarPorNome(string nome)
        {
            var categoria = _RepositorioCategoria.BuscarPorNome(nome);
            var retorno = new CategoriaDTO();
            if(categoria != null)
            {
                retorno.Id = categoria.Id;
                retorno.Nome = categoria.Nome;
            }

            return retorno;
        }

        IList<CategoriaDTO> ICategoriaApp.Listar()
        {
            IList<CategoriaDTO> retorno = new List<CategoriaDTO>();

            var lista = _RepositorioCategoria.Listar();

            foreach (var item in lista)
            {
                retorno.Add(new CategoriaDTO { Id = item.Id, Nome = item.Nome });
            }
            return retorno;
        }
    }
}
