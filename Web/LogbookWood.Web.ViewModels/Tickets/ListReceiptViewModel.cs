using System;
using System.Collections.Generic;
using System.Text;

namespace LogbookWood.Web.ViewModels.Tickets
{
    public class ListReceiptViewModel
    {
       public virtual IEnumerable<ListReceiptInViewModel> Tickets { get; set; }

       public string WoodWarehouseId { get; set; }
    }
}
