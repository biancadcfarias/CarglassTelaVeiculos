using Carglass.TI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carglass.TI.Data.EF.Maps
{
    class MarcaMap : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder
                 .ToTable("Marca")
                 //.HasKey("Id");
                 .HasKey(x => x.VehicleBrandId);

            builder
                .Property(x => x.Name)
                    .HasColumnName("Name")
                    .HasColumnType("varchar(50)")
                    .IsRequired();

            builder
                .Property(x => x.Active)
                    .HasColumnName("Active")
                    .HasColumnType("int")
                    .IsRequired();

            builder
               .Property(x => x.DataCadastro)
                   .HasColumnName("DataCadastro")
                   .HasColumnType("datetime")
                   .IsRequired();

            builder
              .Property(x => x.DataAlteracao)
                  .HasColumnName("DataAlteracao")
                  .HasColumnType("datetime")
                  .IsRequired();



        }
    }
}
