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
        public EstabelecimentoDTO Buscar(Guid id)
        {
            var estabelecimento = _RepositorioEstabelecimento.Encontrar(id);

            return new EstabelecimentoDTO {Id = estabelecimento.Id, Categoria = new CategoriaDTO { Id = estabelecimento.Categoria.Id, Nome = estabelecimento.Categoria.Nome },
                                           CNPJ = estabelecimento.Cnpj, Email = estabelecimento.Email, Nome = estabelecimento.Nome, NomeFantasia = estabelecimento.NomeFantasia,
                                           Status = estabelecimento.Status, Telefone = estabelecimento.Telefone };
        }

        public void Editar(EstabelecimentoDTO estabelecimento)
        {
            var estab = _RepositorioEstabelecimento.Encontrar(estabelecimento.Id);
            estab.Modificar(estabelecimento.Nome, estabelecimento.NomeFantasia, estabelecimento.CNPJ, estabelecimento.Email, estabelecimento.Telefone,
                            _RepositorioCategoria.Encontrar(estabelecimento.IdCategoria), estabelecimento.Status);
            _RepositorioEstabelecimento.Salvar();
        }

        public void Excluir(Guid id)
        {
           _RepositorioEstabelecimento.Remover(_RepositorioEstabelecimento.Encontrar(id));
            _RepositorioCategoria.Salvar();
        }

        public IList<EstabelecimentoDTO> Listar()
        {
            IList<EstabelecimentoDTO> retorno = new List<EstabelecimentoDTO>();

            var lista = _RepositorioEstabelecimento.ListarEstabelecimentos();

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
            var categoria = _RepositorioCategoria.Encontrar(estabelecimento.IdCategoria);

            var Estabelecimento = new Estabelecimento(estabelecimento.Nome, estabelecimento.NomeFantasia,
                                                  estabelecimento.CNPJ, estabelecimento.Email, estabelecimento.Telefone, categoria,
                                                  estabelecimento.Status);

            _RepositorioEstabelecimento.Adicionar(Estabelecimento);

            _RepositorioEstabelecimento.Salvar();
            
        }
    }
}
