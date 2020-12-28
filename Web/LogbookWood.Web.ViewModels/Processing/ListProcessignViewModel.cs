using System;
using System.Collections.Generic;
using System.Text;

namespace LogbookWood.Web.ViewModels.Processing
{
    public class ListProcessignViewModel
    {
        public virtual IEnumerable<ListProcessingInViewModel> ListProcessingInViews { get; set; }

        public virtual IEnumerable<ListProcessingOutViewModel> ListProcessingOutViews { get; set; }
    }
}
