namespace LogbookWood.Data.Models
{
    public class Counterparties
    {
        public int Id { get; set; }

        public string ClientName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string BUSTAT { get; set; }

        public int WoodWarehouseId { get; set; }

        public WoodWarehouse WoodWarehouse { get; set; }
    }
}
