using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStackProcesso.Models;

namespace TechStackProcesso.Maps
{
    public class AreaConhecimentoMap : IEntityTypeConfiguration<AreaConhecimento>
    {
        public void Configure(EntityTypeBuilder<AreaConhecimento> builder)
        {
            builder.ToTable("tb_areaconhecimento");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("id_areaconhecimento");

            builder.Property(p => p.IdTechStack)
                .HasColumnName("id_techstack")
                .IsRequired();

            builder.Property(e => e.IdTipoConhecimento)
                .HasColumnName("id_tpconhecimento")
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasColumnName("dsc_areaconhecimento")
                .HasMaxLength(100)
                .IsRequired();

        }
    }
}
