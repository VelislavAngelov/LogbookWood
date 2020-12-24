namespace LogbookWood.Services.Data.Models
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using LogbookWood.Web.ViewModels.Tickets;

    public interface ITicketService
    {
        void Create(CreateTicketModel input, string userId);

        IEnumerable<ListReceiptInViewModel> GetAll(string userId);

        string GetUserCompanyName(string userId);

        string GetAdress(string userId);

        string GetPhone(string userId);
    }
}
