namespace LogbookWood.Data.Models
{
    using System;

    using LogbookWood.Data.Common.Models;

    public class TicketAssortment : BaseModel<string>
    {
        public TicketAssortment()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string TicketId { get; set; }

        public Ticket Ticket { get; set; }

        public string AssortmentId { get; set; }

        public Assortment Assortment { get; set; }
    }
}
