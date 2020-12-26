namespace LogbookWood.Data.Models
{
    public class UnitTicket
    {
        public int Id { get; set; }

        public string TicketId { get; set; }

        public Ticket Ticket { get; set; }

        public string UnitId { get; set; }

        public Unit Unit { get; set; }
    }
}
