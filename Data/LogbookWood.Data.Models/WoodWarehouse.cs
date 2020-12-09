namespace LogbookWood.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class WoodWarehouse
    {
        public WoodWarehouse()
        {
            this.Tickets = new HashSet<Tickets>();
            this.Counterparties = new HashSet<Counterparties>();
            this.Employees = new HashSet<Employee>();
            this.Vehicles = new HashSet<Vehicle>();
        }

        public int Id { get; set; }

        public string Wood { get; set; }

        public string Category { get; set; }

        public double Unit { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public double Thickness { get; set; }

        public double Coefficient { get; set; }

        public double TotalVolume { get; set; }

        public double Count { get; set; }

        public int UserId { get; set; }

        public ApplicationUser User { get; set; }

        public ICollection<Tickets> Tickets { get; set; }

        public ICollection<Counterparties> Counterparties { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
