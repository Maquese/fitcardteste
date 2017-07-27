using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Contexto
{
    public class UnidadeDeTrabalho : IUnidadeDeTrabalho
    {
        private ContextoBanco _Contexto;

        public ContextoBanco Contexto
        {
            get
            {
               if(_Contexto == null)
                {
                    _Contexto = new ContextoBanco();
                }
                return _Contexto;
            }
        }

        public void Salvar()
        {
            Contexto.SaveChanges();
        }
    }
}
