using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Contexto;
using DomainContracy.Contracts;

namespace Data.Repostorios
{
    public class RepositorioEstabelecimento : RepositorioBase<Estabelecimento>, IRepositorioEstabelecimento
    {
        private IUnidadeDeTrabalho _UnidadeDeTrabalho;

        public RepositorioEstabelecimento(IUnidadeDeTrabalho unidadeTrabalho) : base(unidadeTrabalho)
        {
            _UnidadeDeTrabalho = unidadeTrabalho;
        }
    }
}
