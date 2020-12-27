namespace LogbookWood.Web.ViewModels.Tickets
{
    using System.Collections.Generic;

    public class ListReceiptViewModel
    {
       public virtual IEnumerable<ListReceiptInViewModel> Tickets { get; set; }
    }
}
