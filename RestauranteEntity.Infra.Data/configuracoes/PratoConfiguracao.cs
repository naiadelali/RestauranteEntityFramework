using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RestauranteEntity.Dominio.Model;
using System.Data.Entity.ModelConfiguration;

namespace RestauranteEntity.Infra.Data
{
    public class PratoConfiguracao: EntityTypeConfiguration<Prato>
    {
        public PratoConfiguracao()
        {
            HasKey(p => p.PratoId);

            Property(p => p.Nome)
                .HasMaxLength(150)
                .IsRequired();

            Property(p => p.Descricao)
                .HasMaxLength(250)
                .IsRequired();

            HasRequired(p => p.Tipo)
                .WithMany()
                .HasForeignKey(p => p.TipoId);
        }
    }
}
