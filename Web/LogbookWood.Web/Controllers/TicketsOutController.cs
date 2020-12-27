using LogbookWood.Data;
using LogbookWood.Services.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogbookWood.Web.Controllers
{
    public class TicketsOutController : Controller
    {
        private readonly IWoodService woodService;
        private readonly IAssortmentService assortmentService;
        private readonly ITicketService ticketService;
        private readonly ApplicationDbContext dbContext;
        private readonly IUnitService unitService;

        public TicketsOutController(
            IWoodService woodService,
            IAssortmentService assortmentService,
            ITicketService ticketService,
            ApplicationDbContext dbContext,
            IUnitService unitService)
        {
            this.woodService = woodService;
            this.assortmentService = assortmentService;
            this.ticketService = ticketService;
            this.dbContext = dbContext;
            this.unitService = unitService;
        }

        [Authorize]
        public IActionResult CreateDispatch()
        {
            return this.View();
        }
    }
}
