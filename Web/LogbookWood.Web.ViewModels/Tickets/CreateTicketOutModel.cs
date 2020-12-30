namespace LogbookWood.Web.ViewModels.Tickets
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public class CreateTicketOutModel
    {
        [Required]
        public string NumberTicket { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public string ClientDescription { get; set; }

        [Required]
        public string ClientAddress { get; set; }

        public string ClientBULSTAT { get; set; }

        public string WoodWarehouseOutside { get; set; }

        public string Vehicle { get; set; }

        public string TrailerPlates { get; set; }

        public string Driver { get; set; }

        public string Wood { get; set; }

        public string Category { get; set; }

        public string Unit { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public double Thickness { get; set; }

        [Range(0.40, 1)]
        public double Coefficient { get; set; }

        [Range(0.01, 1000)]
        public double TotalVolume { get; set; }

        public double Count { get; set; }

        public string Comment { get; set; }

        public string WoodId { get; set; }

        public bool In { get; set; }

        public string AssortmentId { get; set; }

        public string UserId { get; set; }

        public IEnumerable<SelectListItem> WoodItems { get; set; }

        public IEnumerable<SelectListItem> AssortmentItems { get; set; }

        public IEnumerable<SelectListItem> UnitItems { get; set; }
    }
}
