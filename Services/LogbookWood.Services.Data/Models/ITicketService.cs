namespace LogbookWood.Services.Data.Models
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using LogbookWood.Web.ViewModels.Tickets;

    public interface ITicketService
    {
        void Create(CreateTicketModel input, string userId, string woodWarehouseId);

        IEnumerable<ListReceiptInViewModel> GetAll(string woodWarehouseId);
    }
}
