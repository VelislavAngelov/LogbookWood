namespace LogbookWood.Data.Models
{
    using System;
    using System.Collections.Generic;

    using LogbookWood.Data.Common.Models;

    public class Assortment : BaseModel<string>
    {
        public Assortment()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Ticket = new HashSet<TicketAssortment>();
        }

        public string Name { get; set; }

        public TreeCategory Category { get; set; }

        public ICollection<TicketAssortment> Ticket { get; set; }
    }
}
