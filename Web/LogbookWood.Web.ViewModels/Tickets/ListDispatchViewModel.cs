namespace LogbookWood.Web.ViewModels.Tickets
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ListDispatchViewModel
    {
        public virtual IEnumerable<ListDispatchInViewModel> Tickets { get; set; }
    }
}
