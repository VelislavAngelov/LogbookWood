using System;
using System.Collections.Generic;
using System.Text;

namespace LogbookWood.Data.Models
{
    public class Assortment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public TreeCategory Category { get; set; }
    }
}