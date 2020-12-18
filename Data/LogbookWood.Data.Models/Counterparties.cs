namespace LogbookWood.Data.Models
{
    using System;

    using LogbookWood.Data.Common.Models;

    public class Counterparties : BaseModel<string>
    {
        public Counterparties()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string ClientName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string BUSTAT { get; set; }

        public string WoodWarehouseId { get; set; }

        public virtual WoodWarehouse WoodWarehouse { get; set; }
    }
}
