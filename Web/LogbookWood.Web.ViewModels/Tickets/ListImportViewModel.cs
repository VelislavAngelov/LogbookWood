using System;
using System.Collections.Generic;
using System.Text;

namespace LogbookWood.Web.ViewModels.Tickets
{
    public class ListImportViewModel
    {
        public virtual IEnumerable<ListImportViewInModel> Tickets { get; set; }
    }
}
