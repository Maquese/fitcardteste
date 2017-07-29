using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class TelefoneException : Exception
    {
        public TelefoneException() : base("Telefone obrigatório")
        {

        }
    }
}
