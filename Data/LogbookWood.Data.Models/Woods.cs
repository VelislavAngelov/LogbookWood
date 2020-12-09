using System;
using System.Collections.Generic;
using System.Text;

namespace LogbookWood.Data.Models
{
    public class Woods
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public TreeSpecies Type { get; set; }

        public int TicketsId { get; set; }

        public Tickets Tickets { get; set; }
    }
}
