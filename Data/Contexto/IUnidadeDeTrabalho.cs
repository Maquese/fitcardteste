﻿using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Contexto
{
    public interface IUnidadeDeTrabalho
    {
        ContextoBanco Contexto { get; }

        void Salvar();

    }
}
