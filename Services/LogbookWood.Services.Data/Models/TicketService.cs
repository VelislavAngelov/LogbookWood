namespace LogbookWood.Services.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using LogbookWood.Data.Common.Repositories;
    using LogbookWood.Data.Models;
    using LogbookWood.Web.ViewModels.Tickets;

    public class TicketService : ITicketService
    {
        private readonly IRepository<Ticket> ticketRepository;
        private readonly IRepository<WoodWarehouse> woodWarehouseRepository;
        private readonly IDeletableEntityRepository<ApplicationUser> userRepository;

        public TicketService(
            IRepository<Ticket> ticketRepository,
            IRepository<WoodWarehouse> woodWarehouseRepository,
            IDeletableEntityRepository<ApplicationUser> userRepository)
        {
            this.ticketRepository = ticketRepository;
            this.woodWarehouseRepository = woodWarehouseRepository;
            this.userRepository = userRepository;
        }

        public async Task Create(CreateTicketModel input, string userId, string woodWarehouseId)
        {
            var ticket = new Ticket
            {
                WoodWarehouseId = input.WoodWarehouseId,
                Wood = input.Wood,
                Category = input.Category,
                Coefficient = input.Coefficient,
                Width = input.Width,
                Length = input.Length,
                Thickness = input.Thickness,
                Unit = input.Unit,
                TotalVolume = input.TotalVolume,
                Count = input.Count,
            };
            var ticketReceipt = new WoodWarehouse
            {
                UserId = userId,
                Wood = input.Wood,
                Category = input.Category,
                TotalVolume = input.TotalVolume,
            };

            await this.ticketRepository.AddAsync(ticket);
            await this.woodWarehouseRepository.AddAsync(ticketReceipt);
            await this.ticketRepository.SaveChangesAsync();
            await this.woodWarehouseRepository.SaveChangesAsync();
        }
    }
}
