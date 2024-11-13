
using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(prop => prop.Endereco)
                .HasMaxLength(255);
            builder.Property(prop => prop.Documento)
                .HasMaxLength(255);
            builder.Property(prop => prop.Bairro)
                .HasMaxLength(255);
            builder.HasOne(prop => prop.Cidade)
                .WithMany()
                .HasConstraintName("FK_Cidade");
        }
    }
}
