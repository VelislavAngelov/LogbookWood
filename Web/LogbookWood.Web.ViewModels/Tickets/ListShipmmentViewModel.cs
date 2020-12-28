using System;
using System.Collections.Generic;
using System.Text;

namespace LogbookWood.Web.ViewModels.Tickets
{
    public class ListShipmmentViewModel
    {
        public virtual IEnumerable<ListShipmmentInViewModel> ListShipmments { get; set; }
    }
}
