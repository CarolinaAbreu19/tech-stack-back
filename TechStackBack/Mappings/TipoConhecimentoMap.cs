using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStackProcesso.Models;

namespace TechStackProcesso.Maps
{
    public class TipoConhecimentoMap : IEntityTypeConfiguration<TipoConhecimento>
    {
        public void Configure(EntityTypeBuilder<TipoConhecimento> builder)
        {
            builder.ToTable("tb_tpconhecimento");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("id_tpconhecimento");

            builder.Property(p => p.Descricao)
                .HasColumnName("dsc_tpconhecimento")
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}
