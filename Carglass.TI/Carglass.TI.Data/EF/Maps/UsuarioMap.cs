using Carglass.TI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Carglass.TI.Data.EF.Maps
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasColumnType("varchar(50)").IsRequired();
            builder.Property(x => x.Genero).HasColumnType("int").IsRequired();
            builder.Property(x => x.DataAlteracao).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.DataCadastro).HasColumnType("datetime").IsRequired();

            builder.Property(x => x.Email).HasColumnType("varchar(50)").IsRequired();
            builder.Property(x => x.Senha).HasColumnType("nvarchar(50)").IsRequired();



            //.Has(Many | One)
            //.With (Many | One)

            builder
                .HasMany(x => x.Perfis)
                .WithMany(x => x.Usuarios)

                .UsingEntity<Dictionary<string, object>>(
                
                    "UsuarioPerfil",

                    perfil => 
                                perfil
                                    .HasOne<Perfil>()
                                    .WithMany()
                                    .HasForeignKey("PerfilId"),

                    usuario =>
                                usuario
                                    .HasOne<Usuario>()
                                    .WithMany()
                                    .HasForeignKey("UsuarioId")

                );


        }
    }
}
