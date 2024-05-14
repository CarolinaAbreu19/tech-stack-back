using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStackProcesso.Models;

namespace TechStackProcesso.Maps
{
    public class TechStackMap : IEntityTypeConfiguration<TechStack>
    {
        public void Configure(EntityTypeBuilder<TechStack> builder)
        {
            builder.ToTable("tb_techstack");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("id_techstack");

            builder.Property(p => p.Nome)
                .HasColumnName("nom_techstack")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.Descricao)
                .HasColumnName("dsc_techstack")
                .HasMaxLength(2000);

            builder.Property(p => p.DataCriacao)
                .HasColumnName("din_criacaotechstack")
                .IsRequired();

        }
    }
}
