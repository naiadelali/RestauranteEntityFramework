using RestauranteEntity.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteEntity.Infra.Data
{
    public class TipoConfiguracao: EntityTypeConfiguration<Tipo>
    {
        public TipoConfiguracao()
        {
            HasKey(t => t.TipoId);

            Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
