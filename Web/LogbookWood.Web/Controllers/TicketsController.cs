namespace LogbookWood.Web.Controllers
{
    using System.Threading.Tasks;

    using LogbookWood.Services.Data.Models;
    using LogbookWood.Web.ViewModels.Tickets;
    using Microsoft.AspNetCore.Mvc;

    public class TicketsController : BaseController
    {
        private readonly IWoodService woodService;
        private readonly IAssortmentService assortmentService;
        private readonly ITicketService ticketService;

        public TicketsController(IWoodService woodService, IAssortmentService assortmentService, ITicketService ticketService)
        {
            this.woodService = woodService;
            this.assortmentService = assortmentService;
            this.ticketService = ticketService;
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

            await this.ticketService.Create(input);
           
            //// return this.Json(input);
            //// TODO: Redirect ListTickets
            return this.Redirect("/");
        }
    }
}
