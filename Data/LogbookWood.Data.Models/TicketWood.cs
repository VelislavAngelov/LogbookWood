namespace LogbookWood.Data.Models
{
    public class TicketWood
    {
        public int Id { get; set; }

        public int TicketId { get; set; }

        public Ticket Ticket { get; set; }

        public int WoodId { get; set; }

        public Wood Wood { get; set; }
    }
}
