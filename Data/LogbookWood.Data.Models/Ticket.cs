namespace LogbookWood.Data.Models
{
    using System.Collections.Generic;

    using LogbookWood.Data.Common.Models;

    public class Ticket : BaseModel<int>
    {
        public Ticket()
        {
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

        public int WoodWarehouseId { get; set; }

        public WoodWarehouse WoodWarehouse { get; set; }

        public virtual ICollection<TicketWood> Woods { get; set; }

        public virtual ICollection<TicketAssortment> Assortments { get; set; }
    }
}
