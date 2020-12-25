using LogbookWood.Web.ViewModels.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogbookWood.Services.Data.Models
{
    public interface IReportsService
    {
        public IEnumerable<TicketReportInViewModel> CreateReport(string userId);
    }
}
