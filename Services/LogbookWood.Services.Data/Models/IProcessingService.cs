namespace LogbookWood.Services.Data.Models
{
    using System.Collections.Generic;

    using LogbookWood.Web.ViewModels.Processing;

    public interface IProcessingService
    {
        void Create(ProcessingViewModel input, string userId);

        public IEnumerable<ListProcessingInViewModel> GetAllIn(string userId);

        public IEnumerable<ListProcessingOutViewModel> GetAllOut(string userId);
    }
}
