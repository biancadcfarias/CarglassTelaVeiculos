using Carglass.TI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carglass.TI.Data.EF
{
    static class StoreDataContextExtensions
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marca>()
               .HasData(

                   new Marca { VehicleBrandId = 1, Name = "Chevrolet", Active = 1 },
                   new Marca { VehicleBrandId = 2, Name = "Toyota", Active = 1 },
                   new Marca { VehicleBrandId = 3, Name = "Audi", Active = 1 },
                   new Marca { VehicleBrandId = 4, Name = "Ford", Active = 1 }
               );



            modelBuilder.Entity<Veiculo>()
                .HasData(

                    new Veiculo { VehicleId = 1,VehicleBrandId = 1,VehicleTypeId = 1 ,Name = "Corsa",  Active=1, VehicleCode = "TEST01"},
                    new Veiculo { VehicleId = 2,VehicleBrandId = 1,VehicleTypeId = 1 ,Name = "Kadett", Active=1, VehicleCode = "TEST01"},
                    new Veiculo { VehicleId = 3,VehicleBrandId = 2,VehicleTypeId = 1 ,Name = "Hillux", Active=1, VehicleCode = "TEST01"},
                    new Veiculo { VehicleId = 4,VehicleBrandId = 2,VehicleTypeId = 1 ,Name = "Corolla",Active=1, VehicleCode = "TEST01"},
                    new Veiculo { VehicleId = 5,VehicleBrandId = 3,VehicleTypeId = 1 ,Name = "A3",Active=1, VehicleCode = "TEST01"},
                    new Veiculo { VehicleId = 6,VehicleBrandId = 3,VehicleTypeId = 1 ,Name = "A4",Active=1, VehicleCode = "TEST01"},
                    new Veiculo { VehicleId = 7,VehicleBrandId = 4,VehicleTypeId = 1 ,Name = "Fiesta", Active=1, VehicleCode = "TEST01"},
                    new Veiculo { VehicleId = 8,VehicleBrandId = 4, VehicleTypeId= 1 ,Name = "Focus",  Active=1, VehicleCode = "TEST01"}
                );
        }

    }
}
