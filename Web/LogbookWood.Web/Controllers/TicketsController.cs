namespace LogbookWood.Web.Controllers
{
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using LogbookWood.Data;
    using LogbookWood.Services.Data.Models;
    using LogbookWood.Web.ViewModels.Tickets;
    using Microsoft.AspNetCore.Mvc;

    public class TicketsController : BaseController
    {
        private readonly IWoodService woodService;
        private readonly IAssortmentService assortmentService;
        private readonly ITicketService ticketService;
        private readonly ApplicationDbContext dbContext;

        public TicketsController(IWoodService woodService, IAssortmentService assortmentService, ITicketService ticketService, ApplicationDbContext dbContext)
        {
            this.woodService = woodService;
            this.assortmentService = assortmentService;
            this.ticketService = ticketService;
            this.dbContext = dbContext;
        }

        public IActionResult CreateReceipt()
        {
            var viewModel = new CreateTicketModel();
            viewModel.WoodItems = this.woodService.GetAllWoodsItem();
            viewModel.AssortmentItems = this.assortmentService.GetAllAssortmentsItem();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateReceipt(CreateTicketModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.WoodItems = this.woodService.GetAllWoodsItem();
                input.AssortmentItems = this.assortmentService.GetAllAssortmentsItem();

                return this.View(input);
            }

            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var woodWarehouseId = this.dbContext.WoodWarehouses
                .Where(x => x.UserId == userId)
                .ToList()
                .Select(x => x.Id)
                .FirstOrDefault()
                .ToString();

            await this.ticketService.Create(input, userId, woodWarehouseId);
           
            //// return this.Json(input);
            //// TODO: Redirect ListTickets
            return this.Redirect("/");
        }
    }
}
