namespace LogbookWood.Services.Data.Models
{
    using System.Threading.Tasks;

    using LogbookWood.Web.ViewModels.Tickets;

    public interface ITicketService
    {
        Task Create(CreateTicketModel input);
    }
}
