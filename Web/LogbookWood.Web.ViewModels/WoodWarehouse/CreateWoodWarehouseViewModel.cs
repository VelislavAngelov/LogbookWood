namespace LogbookWood.Web.ViewModels.WoodWarehouse
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CreateWoodWarehouseViewModel
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string BULSTST { get; set; }

        public string Phone { get; set; }

        public string Wood { get; set; }

        public string Category { get; set; }

        public double TotalVolume { get; set; }

        public string UserId { get; set; }
    }
}
