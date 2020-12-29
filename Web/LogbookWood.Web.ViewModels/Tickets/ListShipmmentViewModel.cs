namespace LogbookWood.Web.ViewModels.Tickets
{
    using System.Collections.Generic;

    public class ListShipmmentViewModel
    {
        public virtual IEnumerable<ListShipmmentInViewModel> ListShipmments { get; set; }
    }
}
