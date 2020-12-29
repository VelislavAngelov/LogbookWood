namespace LogbookWood.Web.Controllers
{
    using System.Security.Claims;

    using LogbookWood.Data.Common.Repositories;
    using LogbookWood.Data.Models;
    using LogbookWood.Services.Data.Models;
    using LogbookWood.Web.ViewModels.Reports;
    using Microsoft.AspNetCore.Mvc;

    public class ReportsController : Controller
    {
        private readonly IReportsService reportsService;

        public ReportsController(IReportsService reportsService)
        {
            this.reportsService = reportsService;
        }

        public IActionResult Index()
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            TicketReportViewModel viewModel = new TicketReportViewModel
            {
                TicketReports = this.reportsService.CreateReport(userId),
            };

            return this.View(viewModel);
        }
    }
}
