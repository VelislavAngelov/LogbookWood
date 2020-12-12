namespace LogbookWood.Data.Models
{
    using System.Collections.Generic;

    public class Assortment
    {
        public Assortment()
        {
            this.Ticket = new HashSet<TicketAssortment>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public TreeCategory Category { get; set; }

        public ICollection<TicketAssortment> Ticket { get; set; }
    }
}
