namespace LogbookWood.Web.Controllers
{
    using LogbookWood.Services.Data.Models;
    using LogbookWood.Web.ViewModels.Tickets;
    using Microsoft.AspNetCore.Mvc;

    public class TicketsController : BaseController
    {
        private readonly IWoodService woodService;
        private readonly IAssortmentService assortmentService;

        public TicketsController(IWoodService woodService,IAssortmentService assortmentService)
        {
            this.woodService = woodService;
            this.assortmentService = assortmentService;
        }

        public IActionResult CreateReceipt()
        {
            var viewModel = new CreateTicketModel();
            viewModel.WoodItems = this.woodService.GetAllWoodsItem();
            viewModel.AssortmentItems = this.assortmentService.GetAllAssortmentsItem();
            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult CreateReceipt(CreateTicketModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.WoodItems = this.woodService.GetAllWoodsItem();
                input.AssortmentItems = this.assortmentService.GetAllAssortmentsItem();

                return this.View(input);
            }

            // TODO: Redirect ListTickets
            return this.Redirect("/");
        }
    }
}
