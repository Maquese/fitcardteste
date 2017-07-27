using Data.Contexto;
using Domain.Entidades;
using DomainContracy.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repostorios
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : Entidade
    {
        private IUnidadeDeTrabalho _UnidadeTrabalho;

        public DbSet<T> Repositorio
        {
            get
            {
                return _UnidadeTrabalho.Contexto.Set<T>();
            }
        }        

        public RepositorioBase(IUnidadeDeTrabalho unidadeTrabalho)
        {
            _UnidadeTrabalho = unidadeTrabalho;
            
        }

        public void Adicionar(T entidade)
        {
            Repositorio.Add(entidade);
        }

        public T Encontrar(Guid id)
        {
           return Repositorio.Find(id);
        }

        public IList<T> Listar()
        {
            return Repositorio.ToList();
        }

        public void Modificar(T entidade)
        {
            _UnidadeTrabalho.Contexto.Entry<T>(entidade).State = EntityState.Modified;
        }

        public void Remover(T entidade)
        {
            Repositorio.Remove(entidade);
        }

        public void Salvar()
        {
            _UnidadeTrabalho.Salvar();
        }
    }
}
