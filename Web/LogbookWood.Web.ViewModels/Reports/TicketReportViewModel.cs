namespace LogbookWood.Web.ViewModels.Reports
{
    using System.Collections.Generic;

    public class TicketReportViewModel
    {
        public IEnumerable<TicketReportInViewModel> TicketReports { get; set; }
    }
}
