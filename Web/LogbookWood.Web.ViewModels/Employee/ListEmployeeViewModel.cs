namespace LogbookWood.Web.ViewModels.Employee
{
    using System.Collections.Generic;

    public class ListEmployeeViewModel
    {
        public virtual IEnumerable<ListEmployeeInViewModel> Employee { get; set; }
    }
}
