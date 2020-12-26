namespace LogbookWood.Data.Models
{
    using System;
    using System.Collections.Generic;

    using LogbookWood.Data.Common.Models;

    public class Unit : BaseModel<string>
    {
        public Unit()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Tickets = new HashSet<UnitTicket>();
        }

        public string Name { get; set; }

        public double Coefficient { get; set; }

        public virtual ICollection<UnitTicket> Tickets { get; set; }
    }
}
