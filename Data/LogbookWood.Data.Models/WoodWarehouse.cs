using System.Collections.Generic;

using LogbookWood.Data.Common.Models;

namespace LogbookWood.Data.Models
{
    public class WoodWarehouse : BaseModel<int>
    {
        public WoodWarehouse()
        {
            this.Tickets = new HashSet<Ticket>();
            this.Counterparties = new HashSet<Counterparties>();
            this.Employees = new HashSet<Employee>();
            this.Vehicles = new HashSet<Vehicle>();
        }

        public string Wood { get; set; }

        public string Category { get; set; }

        public double Unit { get; set; }

        public double Coefficient { get; set; }

        public double TotalVolume { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

        public ICollection<Counterparties> Counterparties { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
