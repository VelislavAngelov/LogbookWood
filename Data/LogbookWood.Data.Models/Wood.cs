namespace LogbookWood.Data.Models
{
    using System;
    using System.Collections.Generic;

    using LogbookWood.Data.Common.Models;

    public class Wood : BaseModel<string>
    {
        public Wood()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Ticket = new HashSet<TicketWood>();
        }

        public string Name { get; set; }

        public TreeSpecies Type { get; set; }

        public ICollection<TicketWood> Ticket { get; set; }
    }
}
