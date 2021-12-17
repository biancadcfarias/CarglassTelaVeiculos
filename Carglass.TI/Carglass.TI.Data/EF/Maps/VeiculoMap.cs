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
    class VeiculoMap : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder
                  .ToTable("Veiculo")
                  //.HasKey("Id");
                  .HasKey(x => x.VehicleId);
            
            builder
                .Property(x => x.VehicleBrandId)
                    .HasColumnType("int")
                    .IsRequired();

            builder
                .Property(x => x.VehicleTypeId)
                    .HasColumnType("int")
                    .IsRequired();

            builder
                .Property(x => x.Name)
                    .HasColumnName("Nome")
                    .HasColumnType("varchar(100)")
                    .IsRequired();

            builder
                .Property(x => x.Active)
                    .HasColumnType("int")
                    .IsRequired();

            builder
                .Property(x => x.VehicleCode)
                    .HasColumnType("varchar(50)")
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


            builder
                .HasOne(x => x.Marca)
                .WithMany(x => x.Veiculos)
                .HasForeignKey(x => x.VehicleTypeId)
                .OnDelete(DeleteBehavior.ClientNoAction);


        }
    }
}
