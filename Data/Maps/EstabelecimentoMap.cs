using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Maps
{
    public class EstabelecimentoMap : EntityTypeConfiguration<Estabelecimento>
    {
        public EstabelecimentoMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Nome).IsRequired();
            Property(x => x.Cnpj).IsRequired().HasMaxLength(14).IsFixedLength();

        }
    }
}
