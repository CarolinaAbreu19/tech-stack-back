using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStackProcesso.Models;

namespace TechStackProcesso.Maps
{
    public class TipoPerfilColaboradorMap : IEntityTypeConfiguration<TipoPerfilColaborador>
    {
        public void Configure(EntityTypeBuilder<TipoPerfilColaborador> builder)
        {
            builder.ToTable("tb_tpperfilcolaborador");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("id_tpperfilcolaborador");

            builder.Property(p => p.Descricao)
                .HasColumnName("dsc_tpperfilcolaborador")
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}
