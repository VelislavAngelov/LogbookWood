namespace LogbookWood.Data.Models
{
    using System;

    using LogbookWood.Data.Common.Models;

    public class Employee : BaseModel<string>
    {
        public Employee()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Name { get; set; }

        public string MiddleName { get; set; }

        public string Surname { get; set; }

        public string Position { get; set; }

        public string Phone { get; set; }

        public int WoodWarehouseId { get; set; }

        public WoodWarehouse WoodWarehouse { get; set; }
    }
}
