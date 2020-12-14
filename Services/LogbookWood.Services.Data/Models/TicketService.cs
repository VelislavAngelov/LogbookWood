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

        public async Task Create(CreateTicketModel input)
        {
            var ticket = new Ticket
            {
                Wood = input.WoodId.ToString(),
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
                Wood = input.WoodId.ToString(),
                Category = input.Category,
                Unit = input.Unit,
                Coefficient = input.Coefficient,
                TotalVolume = input.TotalVolume,

            };

            await this.ticketRepository.AddAsync(ticket);
            await this.woodWarehouseRepository.AddAsync(ticketReceipt);
            await this.ticketRepository.SaveChangesAsync();
            await this.woodWarehouseRepository.SaveChangesAsync();
        }
    }
}
