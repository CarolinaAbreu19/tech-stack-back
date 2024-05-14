using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStackProcesso.Models;

namespace TechStackProcesso.Maps
{
    public class ColaboradorMap : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder.ToTable("tb_colaborador");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("id_colaborador");

            builder.Property(p => p.IdPerfilColaborador)
                .HasColumnName("id_tpperfilcolaborador")
                .IsRequired();

            builder.Property(e => e.Nome)
                .HasColumnName("nom_colaborador")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Email)
                .HasColumnName("emailcolaborador")
                .HasMaxLength(100)
                .IsRequired();

        }
    }
}
