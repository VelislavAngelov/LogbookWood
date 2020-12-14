namespace LogbookWood.Web.ViewModels.Tickets
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public class CreateTicketModel
    {
        public string Wood { get; set; }

        public string Category { get; set; }

        [Display(Name = "Мерна единица")]
        public double Unit { get; set; }

        [Display(Name = "Дъжина")]
        public double Length { get; set; }

        [Display(Name = "Ширина")]
        public double Width { get; set; }

        [Display(Name = "Дебелина")]
        public double Thickness { get; set; }

        [Display(Name = "Коефициент")]
        public double Coefficient { get; set; }

        [Display(Name = "Общо обем")]
        public double TotalVolume { get; set; }

        [Display(Name = "Бр.")]
        public double Count { get; set; }

        [Display(Name = "Коментар")]
        public string Comment { get; set; }

        [Display(Name = "Дървесина")]
        public int WoodId { get; set; }

        [Display(Name = "Aсортимент")]
        public string AssortmentId { get; set; }

        public string WoodWarehouseId { get; set; }

        public IEnumerable<SelectListItem> WoodItems { get; set; }

        public IEnumerable<SelectListItem> AssortmentItems { get; set; }
    }
}
