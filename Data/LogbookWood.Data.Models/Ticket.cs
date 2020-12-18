namespace LogbookWood.Data.Models
{
    using System;
    using System.Collections.Generic;

    using LogbookWood.Data.Common.Models;

    public class Ticket : BaseModel<string>
    {
        public Ticket()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Woods = new HashSet<TicketWood>();
            this.Assortments = new HashSet<TicketAssortment>();
        }

        public string Wood { get; set; }

        public string Category { get; set; }

        public double Unit { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public double Thickness { get; set; }

        public double Coefficient { get; set; }

        public double TotalVolume { get; set; }

        public double Count { get; set; }

        public string Comment { get; set; }

        public string WoodWarehouseId { get; set; }

        public virtual WoodWarehouse WoodWarehouse { get; set; }

        public virtual ICollection<TicketWood> Woods { get; set; }

        public virtual ICollection<TicketAssortment> Assortments { get; set; }
    }
}
