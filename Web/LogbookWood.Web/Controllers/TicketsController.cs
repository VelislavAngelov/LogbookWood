﻿namespace LogbookWood.Web.Controllers
{
    using System.Security.Claims;

    using LogbookWood.Data;
    using LogbookWood.Services.Data.Models;
    using LogbookWood.Web.ViewModels.Tickets;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class TicketsController : Controller
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
            CreateTicketModel viewModel = new CreateTicketModel();
            viewModel.WoodItems = this.woodService.GetAllWoodsItem();
            viewModel.AssortmentItems = this.assortmentService.GetAllAssortmentsItem();
            viewModel.UnitItems = this.unitService.GetAllUnitItem();
            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public IActionResult CreateReceipt(CreateTicketModel input)
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ////return this.Json(input);
            if (!this.ModelState.IsValid)
            {
                input.WoodItems = this.woodService.GetAllWoodsItem();
                input.AssortmentItems = this.assortmentService.GetAllAssortmentsItem();
                input.UnitItems = this.unitService.GetAllUnitItem();
                this.ticketService.GetUserCompanyName(userId);
                this.ticketService.GetAdress(userId);
                this.ticketService.GetAdress(userId);

                return this.View(input);
            }

            this.ticketService.Create(input, userId);
            //// TODO: Redirect ListReceipt
            return this.Redirect("/Tickets/ListReceipt");
        }

        [Authorize]
        public IActionResult ListReceipt()
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            ListReceiptViewModel viewModel = new ListReceiptViewModel
            {
                Tickets = this.ticketService.GetAll(userId),
            };
            //// return this.Json(viewModel);
            return this.View(viewModel);
        }

        [Authorize]
        public IActionResult CreateDispatch()
        {
            CreateTicketOutModel viewModel = new CreateTicketOutModel();
            viewModel.WoodItems = this.woodService.GetAllWoodsItem();
            viewModel.AssortmentItems = this.assortmentService.GetAllAssortmentsItem();
            viewModel.UnitItems = this.unitService.GetAllUnitItem();
            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public IActionResult CreateDispatch(CreateTicketOutModel input)
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (!this.ModelState.IsValid)
            {
                input.WoodItems = this.woodService.GetAllWoodsItem();
                input.AssortmentItems = this.assortmentService.GetAllAssortmentsItem();
                input.UnitItems = this.unitService.GetAllUnitItem();
                this.ticketService.GetUserCompanyName(userId);
                this.ticketService.GetAdress(userId);
                this.ticketService.GetAdress(userId);

                return this.View(input);
            }
          ////  return this.Json(input);
            this.ticketService.CreateOut(input, userId);
            return this.Redirect("/Tickets/ListDispatch");
        }

        public IActionResult ListDispatch()
        {
            return this.View();
        }
    }
}
