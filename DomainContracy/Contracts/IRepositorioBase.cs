using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainContracy.Contracts
{
    public interface IRepositorioBase<T> where T : Entidade
    {
        void Adicionar(T entidade);
        void Remover(T entidade);
        T Encontrar(Guid id);
        void Modificar(T entidade);
        IList<T> Listar();
    }
}
