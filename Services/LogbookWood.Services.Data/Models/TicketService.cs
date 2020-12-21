namespace LogbookWood.Services.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using LogbookWood.Data;
    using LogbookWood.Data.Common.Repositories;
    using LogbookWood.Data.Models;
    using LogbookWood.Web.ViewModels.Tickets;

    public class TicketService : ITicketService
    {
        private readonly IRepository<Ticket> ticketRepository;
        private readonly IRepository<WoodWarehouse> woodWarehouseRepository;
        private readonly IDeletableEntityRepository<ApplicationUser> userRepository;
        private readonly ApplicationDbContext dbContext;

        public TicketService(
            IRepository<Ticket> ticketRepository,
            IRepository<WoodWarehouse> woodWarehouseRepository,
            IDeletableEntityRepository<ApplicationUser> userRepository,
            ApplicationDbContext dbContex)
        {
            this.ticketRepository = ticketRepository;
            this.woodWarehouseRepository = woodWarehouseRepository;
            this.userRepository = userRepository;
            this.dbContext = dbContex;
        }

        public void Create(CreateTicketModel input, string userId, string woodWarehouseId)
        {
            var ticket = new Ticket
            {
                WoodWarehouseId = woodWarehouseId,
                Wood = input.Wood,
                Category = input.Category,
                Coefficient = input.Coefficient,
                Width = input.Width,
                Length = input.Length,
                Thickness = input.Thickness,
                Unit = input.Unit,
                TotalVolume = input.TotalVolume * input.Coefficient,
                Count = input.Count,
            };

            this.dbContext.Add(ticket);
            this.dbContext.SaveChanges();
        }

        public IEnumerable<ListReceiptInViewModel> GetAll(string woodWarehouseId)
        {
           return this.ticketRepository.All()
                .OrderByDescending(x => x.Id)
                .Select(x => new ListReceiptInViewModel
                {
                    WoodWarehouseId = x.WoodWarehouseId,
                    Wood = x.Wood,
                    Category = x.Category,
                }).ToList();
        }
    }
}
