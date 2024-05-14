using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStackProcesso.Models;

namespace TechStackProcesso.Maps
{
    public class RespostaMap : IEntityTypeConfiguration<Resposta>
    {
        public void Configure(EntityTypeBuilder<Resposta> builder)
        {
            builder.ToTable("tb_resposta");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("id_resposta");

            builder.Property(p => p.IdColaborador)
                .HasColumnName("id_colaborador")
                .IsRequired();

            builder.Property(e => e.IdAssunto)
                .HasColumnName("id_assunto")
                .IsRequired();

            builder.Property(p => p.IdNivelConhecimento)
                .HasColumnName("id_nivelconhecimento")
                .IsRequired();

            builder.Property(p => p.DataPreenchimento)
                .HasColumnName("din_preenchimentoresposta")
                .IsRequired();

        }
    }
}
