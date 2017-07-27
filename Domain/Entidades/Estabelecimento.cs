﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    public class Estabelecimento : Entidade
    {
        private string _Nome;
        private string _NomeFantasia;
        private string _CNPJ;
        private string _Email;
        private string _Telefone;
        private Categoria _Categoria;

        private Estabelecimento()
        {

        }

        public Estabelecimento(string nome, string nomeFantasia, string cnpj, string email, string telefone, Categoria categoria)
        {
            _Nome = nome;
            _NomeFantasia = nomeFantasia;
            _CNPJ = cnpj;
            _Email = email;
            _Telefone = telefone;
            _Categoria = categoria;
        }
        

        public string Nome
        {
            get
            {
                return _Nome;
            }

            private set
            {
                _Nome = value;
            }
        }

        public string NomeFantasia
        {
            get
            {
                return _NomeFantasia;
            }

            private set
            {
                _NomeFantasia = value;
            }
        }

        public string CNPJ
        {
            get
            {
                return _CNPJ;
            }

            private set
            {
                _CNPJ = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            private set
            {
                _Email = value;
            }
        }

        public string Telefone
        {
            get
            {
                return _Telefone;
            }

            private set
            {
                _Telefone = value;
            }
        }

        public Categoria Categoria
        {
            get
            {
                return _Categoria;
            }

            private set
            {
                _Categoria = value;
            }
        }

    }
}
