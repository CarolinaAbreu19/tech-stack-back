using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStackProcesso.Models;

namespace TechStackProcesso.Maps
{
    public class NivelConhecimentoMap : IEntityTypeConfiguration<NivelConhecimento>
    {
        public void Configure(EntityTypeBuilder<NivelConhecimento> builder)
        {
            builder.ToTable("tb_nivelconhecimento");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("id_nivelconhecimento");

            builder.Property(p => p.Descricao)
                .HasColumnName("dsc_nivelconhecimento")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(p => p.Valor)
                .HasColumnName("valor_nivelconhecimento")
                .IsRequired();
        }
    }
}
