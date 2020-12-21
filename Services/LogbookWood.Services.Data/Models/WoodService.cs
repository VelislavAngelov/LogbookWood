namespace LogbookWood.Services.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using LogbookWood.Data;
    using LogbookWood.Data.Common.Repositories;
    using LogbookWood.Data.Models;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class WoodService : IWoodService
    {
        private readonly IRepository<Wood> woodRepository;

        public WoodService(IRepository<Wood> woodRepository)
        {
            this.woodRepository = woodRepository;
        }

        public IEnumerable<SelectListItem> GetAllWoodsItem()
        {
            return this.woodRepository.AllAsNoTracking()
                .Select(x => new SelectListItem
                {
                    Value = x.Name,
                    Text = x.Name,
                })
                .OrderBy(x => x.Text)
                .ToList();
        }
    }
}
