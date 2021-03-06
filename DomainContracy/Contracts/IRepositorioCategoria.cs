﻿using Domain.Entidades;
using DomainContract.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainContracy.Contracts
{
    public interface IRepositorioCategoria : IRepositorioBase<Categoria>
    {
        Categoria BuscarPorNome(string nome);
    }
}
