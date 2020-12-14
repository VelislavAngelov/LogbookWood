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

        public Ticket Ticket { get; set; }

        public string WoodId { get; set; }

        public Wood Wood { get; set; }
    }
}
