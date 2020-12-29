using LogbookWood.Services.Data.Models;
using LogbookWood.Web.ViewModels.Vehicle;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LogbookWood.Web.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehicleService vechicleService;

        public VehicleController(IVehicleService vechicleService)
        {
            this.vechicleService = vechicleService;
        }

        [Authorize]
        public IActionResult CreateVehicle()
        {
            var viewModel = new CreateVehicleViewModel();
            return this.View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public IActionResult CreateVehicle(CreateVehicleViewModel viewModel)
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (!this.ModelState.IsValid)
            {
                this.vechicleService.GetAll(userId);
                return this.View(viewModel);
            }

            this.vechicleService.Create(viewModel, userId);
            return this.Redirect("/Vehicle/ListVehicle");
        }

        [Authorize]
        public IActionResult ListVehicle()
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ListVehicleViewModel viewModel = new ListVehicleViewModel
            {
                ListVehicles = this.vechicleService.GetAll(userId),
            };

            return this.View(viewModel);
        }
    }
}
