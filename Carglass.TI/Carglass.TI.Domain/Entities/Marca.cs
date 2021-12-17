using System.Collections.Generic;

namespace Carglass.TI.Domain.Entities
{
    public class Marca : Entity
    {
        public int VehicleBrandId { get; set; }
       
        public string Name { get; set; }
        public int Active { get; set; }


        public IEnumerable<Veiculo> Veiculos { get; set; }
    }
}
