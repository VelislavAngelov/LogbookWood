namespace LogbookWood.Services.Data.Models
{
    using System.Collections.Generic;

    using LogbookWood.Web.ViewModels.Reports;

    public interface IReportsService
    {
         IEnumerable<TicketReportInViewModel> CreateReport(string userId);

    }
}
