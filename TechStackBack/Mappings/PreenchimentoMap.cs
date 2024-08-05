using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStackProcesso.Models;

namespace TechStackProcesso.Maps
{
    public class PreenchimentoMap : IEntityTypeConfiguration<Preenchimento>
    {
        public void Configure(EntityTypeBuilder<Preenchimento> builder)
        {
            builder.ToTable("tb_preenchimento");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("id_preenchimento");

            builder.Property(p => p.IdColaborador)
                .HasColumnName("id_colaborador")
                .IsRequired();

            builder.Property(e => e.IdTechStack)
                .HasColumnName("id_techstack")
                .IsRequired();

            builder.Property(p => p.DataInicio)
                .HasColumnName("din_inicio")
                .IsRequired();

            builder.Property(p => p.DataFinalizacao)
                .HasColumnName("din_finalizacao");

            builder.HasOne(p => p.Colaborador)
                .WithMany(a => a.Preenchimentos)
                .HasForeignKey(p => p.IdColaborador);

            builder.HasOne(p => p.TechStack)
                .WithMany(t => t.Preenchimentos)
                .HasForeignKey(p => p.IdTechStack);

        }
    }
}
