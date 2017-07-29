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
    public partial class Application : IEstabelecimentoApp
    {
        public IList<EstabelecimentoDTO> Listar()
        {
            IList<EstabelecimentoDTO> retorno = new List<EstabelecimentoDTO>();

            var lista = _RepositorioEstabelecimento.Listar();

            foreach (var item in lista)
            {
                retorno.Add(new EstabelecimentoDTO
                {
                    Id = item.Id,
                    Categoria = new CategoriaDTO { Id = item.Categoria.Id, Nome = item.Categoria.Nome },
                    Nome = item.Nome,
                    CNPJ = item.Cnpj,
                    Email = item.Email,
                    NomeFantasia = item.NomeFantasia,
                    Status = item.Status,
                    Telefone = item.Telefone
                });
            }
            return retorno;
        }

        public void Novo(EstabelecimentoDTO estabelecimento)
        {
            var categoria = _RepositorioCategoria.Encontrar(estabelecimento.CategoriaId);

            var Estabelecimento = new Estabelecimento(estabelecimento.Nome, estabelecimento.NomeFantasia,
                                                  estabelecimento.CNPJ, estabelecimento.Email, estabelecimento.Telefone, categoria,
                                                  estabelecimento.Status);

            _RepositorioEstabelecimento.Adicionar(Estabelecimento);

            _RepositorioEstabelecimento.Salvar();
            
        }
    }
}
