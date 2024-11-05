
using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(prop => prop.Senha)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(prop => prop.Login)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(prop => prop.Email)
                .HasMaxLength(255);

            builder.Property(prop => prop.DataCadastro);

            builder.Property(prop => prop.DataLogin);

            builder.Property(prop => prop.Ativo);
        }
    }
}
