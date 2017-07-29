using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class EmailException : Exception
    {
        public EmailException() : base("Email inválido")
        {

        }
    }
}
