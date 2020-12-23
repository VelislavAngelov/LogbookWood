namespace LogbookWood.Web.Controllers
{
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using LogbookWood.Data;
    using LogbookWood.Services.Data.Models;
    using LogbookWood.Web.ViewModels.Tickets;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class TicketsController : BaseController
    {
        private readonly IWoodService woodService;
        private readonly IAssortmentService assortmentService;
        private readonly ITicketService ticketService;
        private readonly ApplicationDbContext dbContext;
        private readonly IUnitService unitService;

        public TicketsController(
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
        public IActionResult CreateReceipt()
        {
            var viewModel = new CreateTicketModel();
            viewModel.WoodItems = this.woodService.GetAllWoodsItem();
            viewModel.AssortmentItems = this.assortmentService.GetAllAssortmentsItem();
            viewModel.UnitItems = this.unitService.GetAllUnitItem();
            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public IActionResult CreateReceipt(CreateTicketModel input)
        {

            //return this.Json(input);
            if (!this.ModelState.IsValid)
            {
                input.WoodItems = this.woodService.GetAllWoodsItem();
                input.AssortmentItems = this.assortmentService.GetAllAssortmentsItem();
                input.UnitItems = this.unitService.GetAllUnitItem();

                return this.View(input);
            }

            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            this.ticketService.Create(input, userId);
            return this.Json(input);
            //// TODO: Redirect ListTickets
            return this.Redirect("/IndexUser");
        }

        public IActionResult ListReceipt(string userId)
        {
            var viewModel = new ListReceiptViewModel
            {
                UserId = userId,
                Tickets = this.ticketService.GetAll(userId),
            };
            return this.View(viewModel);
        }
    }
}
