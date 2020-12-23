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
        private readonly IDeletableEntityRepository<ApplicationUser> userRepository;
        private readonly ApplicationDbContext dbContext;

        public TicketService(
            IRepository<Ticket> ticketRepository,
            IDeletableEntityRepository<ApplicationUser> userRepository,
            ApplicationDbContext dbContex)
        {
            this.ticketRepository = ticketRepository;
            this.userRepository = userRepository;
            this.dbContext = dbContex;
        }

        public void Create(CreateTicketModel input, string userId)
        {
            var ticket = new Ticket
            {
                NumberTicket=input.NumberTicket,
                Date=DateTime.UtcNow,
                SenderName=input.SenderName,
                SenderBULSTAT=input.SenderBULSTAT,
                SenderWoodWarehouse=input.SenderWoodWarehouse,
                Vehicle=input.Vehicle,
                TrailerPlates=input.TrailerPlates,
                UserId = userId,
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

        public IEnumerable<ListReceiptInViewModel> GetAll(string userId)
        {
           return this.ticketRepository.All()
                .OrderByDescending(x => x.Id)
                .Select(x => new ListReceiptInViewModel
                {
                    UserId = x.UserId,
                    Wood = x.Wood,
                    Category = x.Category,
                }).ToList();
        }

        public string GetUserCompanyName()
        {

            return this.dbContext.Users.Select(x => x.CompanyName).FirstOrDefault();
        }

        public string GetAdress()
        {
            return this.dbContext.Users.Select(x => x.Address).FirstOrDefault();
        }

        public string GetPhone()
        {
            return this.dbContext.Users.Select(x => x.Phone).FirstOrDefault();
        }
    }
}
