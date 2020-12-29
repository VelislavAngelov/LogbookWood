namespace LogbookWood.Services.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
            Ticket ticket = new Ticket
            {
                NumberTicket = input.NumberTicket,
                Date = DateTime.UtcNow,
                ClientDescription = input.ClientDescription,
                ClientBULSTAT = input.ClientBULSTAT,
                WoodWarehouseOutside = input.WoodWarehouseOutside,
                Vehicle = input.Vehicle,
                TrailerPlates = input.TrailerPlates,
                Driver = input.Driver,
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
                In = true,
            };

            this.dbContext.Tickets.Add(ticket);
            this.dbContext.SaveChanges();
        }

        public void CreateOut(CreateTicketOutModel input, string userId)
        {
            Ticket ticket = new Ticket
            {
                NumberTicket = input.NumberTicket,
                Date = DateTime.Now,
                ClientDescription = input.ClientDescription,
                ClientAddress = input.ClientAddress,
                ClientBULSTAT = input.ClientBULSTAT,
                WoodWarehouseOutside = input.WoodWarehouseOutside,
                Vehicle = input.Vehicle,
                TrailerPlates = input.TrailerPlates,
                Driver = input.Driver,
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
                In = false,
            };

            this.dbContext.Tickets.Add(ticket);
            this.dbContext.SaveChanges();
        }

        public void CreateImp(CreateImportViewModel input, string userId)
        {
            Ticket ticket = new Ticket
            {
                NumberTicket = input.NumberTicket,
                Date = DateTime.Now,
                ClientDescription = input.ClientDescription,
                Place = "Import",
                Vehicle = input.Vehicle,
                Driver = input.Driver,
                Wood = input.Wood,
                Category = input.Category,
                Coefficient = input.Coefficient,
                Unit = input.Unit,
                TotalVolume = input.TotalVolume,
                In = true,
                UserId = userId,
            };

            this.dbContext.Tickets.Add(ticket);
            this.dbContext.SaveChanges();
        }

        public void CreateShipm(CreateShipmentViewModel input, string userId)
        {
            Ticket ticket = new Ticket
            {
                NumberTicket = input.NumberTicket,
                Date = DateTime.Now,
                Place = "Shipment",
                Wood = input.Wood,
                Category = input.Category,
                Coefficient = input.Coefficient,
                Unit = input.Unit,
                TotalVolume = input.TotalVolume,
                Comment = input.Comment,
                In = false,
                UserId = userId,
            };

            this.dbContext.Tickets.Add(ticket);
            this.dbContext.SaveChanges();
        }

        public IEnumerable<ListReceiptInViewModel> GetAll(string userId)
        {
            return this.ticketRepository.All().Where(x => x.UserId == userId && x.In == true && x.Place == null && x.Place != "Import")
                 .OrderByDescending(x => x.Date)
                 .Select(x => new ListReceiptInViewModel
                 {
                     NumberTicket = x.NumberTicket,
                     ClientDescription = x.ClientDescription,
                     Date = x.Date,
                     Comment = x.Comment,
                 }).ToList();
        }

        public IEnumerable<ListDispatchInViewModel> GetAllOut(string userId)
        {
            return this.ticketRepository.All().Where(x => x.UserId == userId && x.In == false && x.Place == null && x.Place != "Shipment")
                 .OrderByDescending(x => x.Date)
                 .Select(x => new ListDispatchInViewModel
                 {
                     NumberTicket = x.NumberTicket,
                     ClientDescription = x.ClientDescription,
                     Date = x.Date,
                     Comment = x.Comment,
                 }).ToList();
        }

        public IEnumerable<ListImportViewInModel> GetAllImp(string userId)
        {
            return this.ticketRepository.All().Where(x => x.UserId == userId && x.Place == "Import").
                OrderBy(x => x.Date)
                .Select(x => new ListImportViewInModel
                {
                    NumberTicket = x.NumberTicket,
                    ClientDescription = x.ClientDescription,
                    Date = x.Date,
                    Comment = x.Comment,
                }).ToList();
        }

        public IEnumerable<ListShipmmentInViewModel> GetAllShipm(string userId)
        {
            return this.ticketRepository.All().Where(x => x.UserId == userId && x.Place == "Shipment").
                OrderBy(x => x.Date)
                .Select(x => new ListShipmmentInViewModel
                {
                    NumberTicket = x.NumberTicket,
                    Date = x.Date,
                    Wood = x.Wood,
                    Category = x.Category,
                    TotalVolume = x.TotalVolume,
                    Comment = x.Comment,
                }).ToList();
        }


        public string GetUserCompanyName(string userId)
        {
            return this.dbContext.Users
                .Where(x => x.Id == userId)
                .Select(x => x.CompanyName)
                .ToList()
                .FirstOrDefault()
                .ToString();
        }

        public string GetAdress(string userId)
        {
            return this.dbContext.Users
                .Where(x => x.Id == userId)
                .Select(x => x.Address)
                .ToList().FirstOrDefault()
                .ToString();
        }

        public string GetPhone(string userId)
        {
            return this.dbContext.Users
                .Where(x => x.Id == userId)
                .Select(x => x.Phone)
                .ToList().FirstOrDefault()
                .ToString();
        }

    }
}
