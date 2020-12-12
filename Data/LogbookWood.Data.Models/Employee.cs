using LogbookWood.Data.Common.Models;

namespace LogbookWood.Data.Models
{
    public class Employee : BaseModel<int>
    {
        public string Name { get; set; }

        public string MiddleName { get; set; }

        public string Surname { get; set; }

        public string Position { get; set; }

        public string Phone { get; set; }

        public int WoodWarehouseId { get; set; }

        public WoodWarehouse WoodWarehouse { get; set; }
    }
}
