namespace Carglass.TI.Domain.Entities
{
    public class Veiculo : Entity
    {
        public int VehicleId { get; set; }
        public int VehicleBrandId { get; set; }
        public int VehicleTypeId { get; set; }

        public string Name { get; set; }
        public int Active { get; set; }
        public string VehicleCode { get; set; }


        public Marca Marca { get; set; }
    }
}
