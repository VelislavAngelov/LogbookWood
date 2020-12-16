namespace LogbookWood.Data.Models
{
    using System;
    using System.Collections.Generic;

    using LogbookWood.Data.Common.Models;

    public class WoodWarehouse : BaseModel<string>
    {
        public WoodWarehouse()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Counterparties = new HashSet<Counterparties>();
            this.Employees = new HashSet<Employee>();
            this.Vehicles = new HashSet<Vehicle>();
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public string BULSTST { get; set; }

        public string Phone { get; set; }

        public string Wood { get; set; }

        public string Category { get; set; }

        public double TotalVolume { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string TicketId { get; set; }

        public Ticket Tickets { get; set; }

        public ICollection<Counterparties> Counterparties { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
