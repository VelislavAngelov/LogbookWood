namespace LogbookWood.Web.ViewModels.Tickets
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public class CreateShipmentViewModel
    {
        [Required]
        public string NumberTicket { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public string Place { get; set; }

        public string Wood { get; set; }

        public string Category { get; set; }

        public string Unit { get; set; }

        [Range(0.40, 1)]
        public double Coefficient { get; set; }

        [Range(0.01, 1000)]
        public double TotalVolume { get; set; }

        public string Comment { get; set; }

        public bool In { get; set; }

        public string UserId { get; set; }

        public IEnumerable<SelectListItem> WoodItems { get; set; }

        public IEnumerable<SelectListItem> AssortmentItems { get; set; }

        public IEnumerable<SelectListItem> UnitItems { get; set; }
    }
}
