namespace LogbookWood.Services.Data.Models
{
    using System.Collections.Generic;
    using System.Linq;

    using LogbookWood.Data;
    using LogbookWood.Data.Common.Repositories;
    using LogbookWood.Data.Models;
    using LogbookWood.Web.ViewModels.Processing;

    public class ProcessingService : IProcessingService
    {
        private readonly IRepository<Ticket> ticketRepository;
        private readonly IDeletableEntityRepository<ApplicationUser> userRepository;
        private readonly ApplicationDbContext dbContext;

        public ProcessingService(
            IRepository<Ticket> ticketRepository,
            IDeletableEntityRepository<ApplicationUser> userRepository,
            ApplicationDbContext dbContex)
        {
            this.ticketRepository = ticketRepository;
            this.userRepository = userRepository;
            this.dbContext = dbContex;
        }

        public void Create(ProcessingViewModel input, string userId)
        {
            Ticket ticketOut = new Ticket
            {
                NumberTicket = input.ProcessingInViewModel.NumberProcessing,
                Wood = input.ProcessingOutViewModel.Wood,
                Category = input.ProcessingOutViewModel.Category,
                Unit = input.ProcessingOutViewModel.Unit,
                Coefficient = input.ProcessingOutViewModel.Coefficient,
                TotalVolume = input.ProcessingOutViewModel.TotalVolume,
                Place = "Processing",
                In = false,
                UserId = userId,
            };
            this.dbContext.Tickets.Add(ticketOut);
            this.dbContext.SaveChanges();

            Ticket ticketIn = new Ticket
            {
                NumberTicket = input.ProcessingInViewModel.NumberProcessing,
                Date = input.ProcessingInViewModel.Date,
                Wood = input.ProcessingInViewModel.Wood,
                Category = input.ProcessingInViewModel.Category,
                Unit = input.ProcessingInViewModel.Unit,
                Coefficient = input.ProcessingInViewModel.Coefficient,
                TotalVolume = input.ProcessingInViewModel.TotalVolume,
                Place = "Processing",
                In = true,
                UserId = userId,
            };
            this.dbContext.Tickets.Add(ticketIn);
            this.dbContext.SaveChanges();
        }

        public IEnumerable<ListProcessingInViewModel> GetAllIn(string userId)
        {
            return this.ticketRepository.All()
                .Where(x => x.UserId == userId && x.Place == "Processing" && x.In == true)
                .OrderBy(x => x.NumberTicket)
                .Select(x => new ListProcessingInViewModel
                {
                   NumberProcessing = x.NumberTicket,
                   Wood = x.Wood,
                   Category = x.Category,
                   Date = x.Date.Date,
                   TotalVolume = x.TotalVolume,
                }).ToList();

        }

        public IEnumerable<ListProcessingOutViewModel> GetAllOut(string userId)
        {
            return this.ticketRepository.All()
               .Where(x => x.UserId == userId && x.Place == "Processing" && x.In == false)
               .OrderBy(x => x.NumberTicket)
               .Select(x => new ListProcessingOutViewModel
               {
                   NumberProcessing = x.NumberTicket,
                   Wood = x.Wood,
                   Category = x.Category,
                   Date = x.Date.Date,
                   TotalVolume = x.TotalVolume,
               }).ToList();
        }
    }
}
