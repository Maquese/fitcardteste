using Domain.Entidades;
using DomainContracy.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Contexto;

namespace Data.Repostorios
{
    public class RepositorioCategoria : RepositorioBase<Categoria> , IRepositorioCategoria
    {
        private IUnidadeDeTrabalho _UnidadeTrabalho;
        public RepositorioCategoria(IUnidadeDeTrabalho unidadeTrabalho) : base(unidadeTrabalho)
        {
            _UnidadeTrabalho = unidadeTrabalho;
        }

        public Categoria BuscarPorNome(string nome)
        {
            return Repositorio.Where(x => x.Nome.ToUpper().Equals(nome.ToUpper())).FirstOrDefault();
        }
    }
}
