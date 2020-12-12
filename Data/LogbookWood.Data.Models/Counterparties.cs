﻿using LogbookWood.Data.Common.Models;

namespace LogbookWood.Data.Models
{
    public class Counterparties : BaseModel<int>
    {
        public string ClientName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string BUSTAT { get; set; }

        public int WoodWarehouseId { get; set; }

        public WoodWarehouse WoodWarehouse { get; set; }
    }
}
