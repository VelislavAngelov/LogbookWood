namespace LogbookWood.Data.Models
{
    using System;

    using LogbookWood.Data.Common.Models;

    public class TicketWood : BaseModel<string>
    {
        public TicketWood()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string TicketId { get; set; }

        public virtual Ticket Ticket { get; set; }

        public string WoodId { get; set; }

        public virtual Wood Wood { get; set; }

        public int TotalVolume { get; set; }
    }
}
