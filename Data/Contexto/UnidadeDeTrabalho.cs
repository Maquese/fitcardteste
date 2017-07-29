using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
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

            var t = Contexto.Database.BeginTransaction();
            try
            {
                Contexto.SaveChanges();       
                t.Commit();

            }
            catch (DbEntityValidationException e)
            {
                t.Rollback();
                foreach (var item in Contexto.ChangeTracker.Entries())
                {
                    item.State = EntityState.Detached;
                }
                throw new Exception(e.EntityValidationErrors.Last().ValidationErrors.First().ErrorMessage);
                
                
               
            }
            catch (Exception e)
            {

                t.Rollback();
                throw e;
            }
        }
    }
}
