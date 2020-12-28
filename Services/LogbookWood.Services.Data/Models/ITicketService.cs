namespace LogbookWood.Services.Data.Models
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using LogbookWood.Web.ViewModels.Tickets;

    public interface ITicketService
    {
        void Create(CreateTicketModel input, string userId);

        void CreateOut(CreateTicketOutModel input, string userId);

        void CreateImp(CreateImportViewModel input, string userId);

        IEnumerable<ListReceiptInViewModel> GetAll(string userId);

        IEnumerable<ListDispatchInViewModel> GetAllOut(string userId);

        IEnumerable<ListImportViewInModel> GetAllImp(string userId);

        string GetUserCompanyName(string userId);

        string GetAdress(string userId);

        string GetPhone(string userId);
    }
}
