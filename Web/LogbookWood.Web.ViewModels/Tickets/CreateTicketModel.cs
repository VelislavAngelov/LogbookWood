using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LogbookWood.Web.ViewModels.Tickets
{
    public class CreateTicketModel
    {
        public string Wood { get; set; }

        public string Category { get; set; }

        public double Unit { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public double Thickness { get; set; }

        public double Coefficient { get; set; }

        public double TotalVolume { get; set; }

        public double Count { get; set; }

        public string Comment { get; set; }

        [Display(Name = "Дървесина")]
        public int WoodId { get; set; }

        public int AssortmentId { get; set; }

       // public IEnumerable<SelectListItem> WoodItems { get; set; }
    }
}
