namespace LogbookWood.Web.ViewModels.Processing
{
    using System.Collections.Generic;

    public class ListProcessignViewModel
    {
        public virtual IEnumerable<ListProcessingInViewModel> ListProcessingInViews { get; set; }

        public virtual IEnumerable<ListProcessingOutViewModel> ListProcessingOutViews { get; set; }
    }
}
