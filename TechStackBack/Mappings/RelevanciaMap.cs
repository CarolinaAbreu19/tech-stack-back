using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStackProcesso.Models;

namespace TechStackProcesso.Maps
{
    public class RelevanciaMap : IEntityTypeConfiguration<Relevancia>
    {
        public void Configure(EntityTypeBuilder<Relevancia> builder)
        {
            builder.ToTable("tb_relevancia");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("id_relevancia");

            builder.Property(p => p.Descricao)
                .HasColumnName("dsc_relevancia")
                .HasMaxLength(10)
                .IsRequired();
        }
    }
}
