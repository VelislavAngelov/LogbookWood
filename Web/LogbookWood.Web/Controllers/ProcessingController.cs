namespace LogbookWood.Web.Controllers
{
    using System.Security.Claims;

    using LogbookWood.Data;
    using LogbookWood.Services.Data.Models;
    using LogbookWood.Web.ViewModels.Processing;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class ProcessingController : Controller
    {
        private readonly IWoodService woodService;
        private readonly IAssortmentService assortmentService;
        private readonly IUnitService unitService;
        private readonly IProcessingService processingService;

        public ProcessingController(
            IWoodService woodService,
            IAssortmentService assortmentService,
            IUnitService unitService,
            IProcessingService processingService)
        {
            this.woodService = woodService;
            this.assortmentService = assortmentService;
            this.unitService = unitService;
            this.processingService = processingService;
        }

        [Authorize]
        public IActionResult CreateProcessing()
        {
            ProcessingViewModel viewModel = new ProcessingViewModel();
            viewModel.ProcessingOutViewModel = new ProcessingOutViewModel();
            viewModel.ProcessingInViewModel = new ProcessingInViewModel();

            viewModel.ProcessingOutViewModel.WoodItems = this.woodService.GetAllWoodsItem();
            viewModel.ProcessingOutViewModel.AssortmentItems = this.assortmentService.GetAllAssortmentsItem();
            viewModel.ProcessingOutViewModel.UnitItems = this.unitService.GetAllUnitItem();

            viewModel.ProcessingInViewModel.WoodItems = this.woodService.GetAllWoodsItem();
            viewModel.ProcessingInViewModel.AssortmentItems = this.assortmentService.GetAllAssortmentsItem();
            viewModel.ProcessingInViewModel.UnitItems = this.unitService.GetAllUnitItem();

            return this.View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public IActionResult CreateProcessing(ProcessingViewModel input)
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (!this.ModelState.IsValid)
            {
                input.ProcessingOutViewModel.WoodItems = this.woodService.GetAllWoodsItem();
                input.ProcessingOutViewModel.AssortmentItems = this.assortmentService.GetAllAssortmentsItem();
                input.ProcessingOutViewModel.UnitItems = this.unitService.GetAllUnitItem();

                input.ProcessingInViewModel.WoodItems = this.woodService.GetAllWoodsItem();
                input.ProcessingInViewModel.AssortmentItems = this.assortmentService.GetAllAssortmentsItem();
                input.ProcessingInViewModel.UnitItems = this.unitService.GetAllUnitItem();

                return this.View(input);
            }
           //// return this.Json(input);
            this.processingService.Create(input, userId);
            return this.Redirect("/Processing/ListProcessing");
        }

        public IActionResult ListProcessing()
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var viewModel = new ListProcessignViewModel()
            {
                ListProcessingInViews = this.processingService.GetAllIn(userId),
                ListProcessingOutViews = this.processingService.GetAllOut(userId),
            };

            return this.View(viewModel);
        }
    }
}
