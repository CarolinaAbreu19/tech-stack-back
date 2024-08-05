using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStackProcesso.Models;

namespace TechStackProcesso.Maps
{
    public class AssuntoMap: IEntityTypeConfiguration<Assunto>
    {        
        public void Configure(EntityTypeBuilder<Assunto> builder)
        {
            builder.ToTable("tb_assunto");

            builder.HasKey(a => a.Id); 

            builder.Property(a => a.Id)
                .HasColumnName("id_assunto")
                .IsRequired();
            
            builder.Property(a => a.IdRelevancia)
                .HasColumnName("id_relevancia")
                .IsRequired();

            builder.Property(a => a.IdAreaConhecimento)
                .HasColumnName("id_areaconhecimento")
                .IsRequired();

            builder.Property(a => a.Descricao)
                .HasColumnName("dsc_assunto")
                .HasMaxLength(100)
                .IsRequired();

            builder.HasOne(e => e.AreaConhecimento)
               .WithMany(t => t.Assuntos)
               .HasForeignKey(e => e.IdAreaConhecimento);

            builder.HasOne(a => a.Relevancia)
                .WithMany(r => r.Assuntos)
                .HasForeignKey(a => a.IdRelevancia);
        }
    }
}
