namespace LogbookWood.Data.Models
{
    using System.Collections.Generic;

    using LogbookWood.Data.Common.Models;

    public class Wood : BaseModel<int>
    {
        public Wood()
        {
            this.Ticket = new HashSet<TicketWood>();
        }

        public string Name { get; set; }

        public TreeSpecies Type { get; set; }

        public ICollection<TicketWood> Ticket { get; set; }
    }
}
