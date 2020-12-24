namespace LogbookWood.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using LogbookWood.Data.Common.Repositories;
    using LogbookWood.Data.Models;
    using Microsoft.AspNetCore.Mvc;

    public class ReportsController : Controller
    {
        private readonly IRepository<Ticket> ticketRepository;

        public ReportsController(IRepository<Ticket> ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        public IActionResult Index()
        {
            return this.View();
        }
    }
}
