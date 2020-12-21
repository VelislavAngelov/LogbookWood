namespace LogbookWood.Web.ViewModels.Tickets
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public class CreateTicketModel
    {
        public string Wood { get; set; }

        public string Category { get; set; }

        public string Unit { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public double Thickness { get; set; }

        public double Coefficient { get; set; }

        public double TotalVolume { get; set; }

        public double Count { get; set; }

        public string Comment { get; set; }

        public int WoodId { get; set; }

        public string AssortmentId { get; set; }

        public string WoodWarehouseId { get; set; }

        public IEnumerable<SelectListItem> WoodItems { get; set; }

        public IEnumerable<SelectListItem> AssortmentItems { get; set; }

        public IEnumerable<SelectListItem> UnitItems { get; set; }
    }
}
