namespace LogbookWood.Services.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using LogbookWood.Data;
    using LogbookWood.Data.Common.Repositories;
    using LogbookWood.Data.Models;
    using LogbookWood.Web.ViewModels.WoodWarehouse;

    public class WoodWarehouseService : IWoodWarehouseService
    {
        private readonly ApplicationDbContext dbContext;

        public WoodWarehouseService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(CreateWoodWarehouseViewModel input, string userId)
        {
            var inputModel = new WoodWarehouse
            {
                UserId = userId,
                BULSTST = input.BULSTST,
                Name = input.Name,
                Address = input.Address,
                Phone = input.Phone,
            };

            this.dbContext.WoodWarehouses.Add(inputModel);

            this.dbContext.SaveChanges();
        }
    }
}
