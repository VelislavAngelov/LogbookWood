namespace LogbookWood.Web.ViewModels.Tickets
{
    using System.Collections.Generic;

    public class ListImportViewModel
    {
        public virtual IEnumerable<ListImportViewInModel> Tickets { get; set; }
    }
}
