namespace LogbookWood.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Tickets
    {
        public Tickets()
        {
            this.Woods = new HashSet<Woods>();
            this.Assortments = new HashSet<Assortment>();
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

        public virtual ICollection<Woods> Woods { get; set; }

        public virtual ICollection<Assortment> Assortments { get; set; }

        public int WoodWarehouseId { get; set; }

        public WoodWarehouse WoodWarehouse { get; set; }
    }
}
