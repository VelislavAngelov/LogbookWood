namespace LogbookWood.Data.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string RegistrationNumber { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int WoodWarehouseId { get; set; }

        public WoodWarehouse WoodWarehouse { get; set; }
    }
}
