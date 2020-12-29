using System;
using System.Collections.Generic;
using System.Text;

namespace LogbookWood.Web.ViewModels.Vehicle
{
    public class ListVehicleViewModel
    {
        public virtual IEnumerable<ListVehicleInViewModel> ListVehicles { get; set; }
    }
}
