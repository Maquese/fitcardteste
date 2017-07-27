using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    public class Categoria : Entidade
    {
        private string _Nome;

        private Categoria()
        {

        }

        public Categoria(string nome)
        {
            _Nome = nome;
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
    }
}
