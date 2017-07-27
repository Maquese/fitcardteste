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
        private DbSet<T> _Repositorio;

        public DbSet<T> Repositorio
        {
            get
            {
                return _Repositorio;
            }
        }
        

        public RepositorioBase(IUnidadeDeTrabalho unidadeTrabalho)
        {
            _UnidadeTrabalho = unidadeTrabalho;
            _Repositorio = unidadeTrabalho.Contexto.Set<T>();
            
        }

        public void Adicionar(T entidade)
        {
            _Repositorio.Add(entidade);
        }

        public T Encontrar(Guid id)
        {
           return _Repositorio.Find(id);
        }

        public IList<T> Listar()
        {
            return _Repositorio.ToList();
        }

        public void Modificar(T entidade)
        {
            _UnidadeTrabalho.Contexto.Entry<T>(entidade).State = EntityState.Modified;
        }

        public void Remover(T entidade)
        {
            _Repositorio.Remove(entidade);
        }
    }
}
