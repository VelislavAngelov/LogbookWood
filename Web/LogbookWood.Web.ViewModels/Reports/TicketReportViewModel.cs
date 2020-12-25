using System;
using System.Collections.Generic;
using System.Text;

namespace LogbookWood.Web.ViewModels.Reports
{
    public class TicketReportViewModel
    {
        public virtual IEnumerable<TicketReportInViewModel> TicketReports { get; set; }
    }
}
