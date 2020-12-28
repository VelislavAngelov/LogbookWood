namespace LogbookWood.Services.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using LogbookWood.Data.Models;
    using LogbookWood.Web.ViewModels.Processing;

    public interface IProcessingService
    {
        void Create(ProcessingViewModel input, string userId);

        public IEnumerable<ListProcessingInViewModel> GetAllIn(string userId);

        public IEnumerable<ListProcessingOutViewModel> GetAllOut(string userId);

    }
}
