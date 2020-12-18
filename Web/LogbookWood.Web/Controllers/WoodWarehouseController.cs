namespace LogbookWood.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using LogbookWood.Services.Data.Models;
    using LogbookWood.Web.ViewModels.WoodWarehouse;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class WoodWarehouseController : BaseController
    {
        private readonly IWoodWarehouseService warehouseService;

        public WoodWarehouseController(IWoodWarehouseService warehouseService)
        {
            this.warehouseService = warehouseService;
        }

        public IActionResult IndexWoodWarehouse()
        {
            return this.View();
        }

        [Authorize]
        public IActionResult CreateWoodWarehouse()
        {
            var view = new CreateWoodWarehouseViewModel();

            return this.View(view);
        }

        [Authorize]
        [HttpPost]
        public IActionResult CreateWoodWarehouse(CreateWoodWarehouseViewModel viewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(viewModel);
            }

            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            //// return this.Json(viewModel);
            this.warehouseService.Create(viewModel, userId);

            return this.Redirect("/WoodWarehouse/IndexWoodWarehouse");
        }
    }
}
