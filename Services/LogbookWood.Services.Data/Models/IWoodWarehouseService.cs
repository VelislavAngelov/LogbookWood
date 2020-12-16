namespace LogbookWood.Services.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using LogbookWood.Web.ViewModels.WoodWarehouse;

    public interface IWoodWarehouseService
    {
        void Create(CreateWoodWarehouseViewModel input, string userId);
    }
}
