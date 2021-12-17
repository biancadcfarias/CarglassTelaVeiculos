using Carglass.TI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Carglass.TI.Data.EF.Maps
{
    public class PerfilMap : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder.ToTable("Perfil");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasColumnType("varchar(50)").IsRequired();
            builder.Property(x => x.DataAlteracao).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.DataCadastro).HasColumnType("datetime").IsRequired();
        }
    }
}
