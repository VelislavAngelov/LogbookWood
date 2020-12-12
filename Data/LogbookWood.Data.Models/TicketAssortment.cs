namespace LogbookWood.Data.Models
{
    public class TicketAssortment
    {
        public int Id { get; set; }

        public int TicketId { get; set; }

        public Ticket Ticket { get; set; }

        public int AssortmentId { get; set; }

        public Assortment Assortment { get; set; }
    }
}
