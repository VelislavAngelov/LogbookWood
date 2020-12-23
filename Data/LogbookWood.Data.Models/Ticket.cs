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
            this.Units = new HashSet<UnitTicket>();
        }

        public string NumberTicket { get; set; }

        public DateTime Date { get; set; }

        public string SenderName { get; set; }

        public string SenderBULSTAT { get; set; }

        public string SenderWoodWarehouse { get; set; }

        public string Vehicle { get; set; }

        public string TrailerPlates { get; set; }

        public string Driver { get; set; }

        public string Wood { get; set; }

        public string Category { get; set; }

        public string Unit { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public double Thickness { get; set; }

        public double Coefficient { get; set; }

        public double TotalVolume { get; set; }

        public double Count { get; set; }

        public string Comment { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<TicketWood> Woods { get; set; }

        public virtual ICollection<TicketAssortment> Assortments { get; set; }

        public virtual ICollection<UnitTicket> Units { get; set; }
    }
}
