using LogbookWood.Data.Common.Repositories;
using LogbookWood.Data.Models;
using LogbookWood.Web.ViewModels.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogbookWood.Services.Data.Models
{
    public class ReportsService : IReportsService
    {
        private readonly IRepository<Ticket> ticketRepository;

        public ReportsService(IRepository<Ticket> ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        public virtual IEnumerable<TicketReportInViewModel> CreateReport(string userId)
        {

            var obj = this.ticketRepository.All().Where(x => x.UserId == userId)
                .Select(x => new TicketReportInViewModel
                {
                    Wood = x.Wood,
                    Category = x.Category,
                    TotalVolume = x.TotalVolume,
                }).ToList();

            return obj;
        }
    }
}
