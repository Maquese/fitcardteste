using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    public class Entidade
    {
        private Guid _Id;

        public Entidade()
        {
            _Id = Guid.NewGuid();
        }

        public Guid Id
        {
            get
            {
                return _Id;
            }
            private set
            {
                _Id = value;
            }
        }
    }
}
