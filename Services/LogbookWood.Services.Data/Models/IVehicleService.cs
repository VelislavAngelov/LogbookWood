namespace LogbookWood.Services.Data.Models
{
    using System.Collections.Generic;

    using LogbookWood.Web.ViewModels.Vehicle;

    public interface IVehicleService
    {
        void Create(CreateVehicleViewModel input, string userId);

        IEnumerable<ListVehicleInViewModel> GetAll(string userId);
    }
}
