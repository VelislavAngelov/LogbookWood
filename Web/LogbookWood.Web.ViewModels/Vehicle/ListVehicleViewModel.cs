namespace LogbookWood.Web.ViewModels.Vehicle
{
    using System.Collections.Generic;

    public class ListVehicleViewModel
    {
        public virtual IEnumerable<ListVehicleInViewModel> ListVehicles { get; set; }
    }
}
