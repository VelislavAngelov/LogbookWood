namespace LogbookWood.Services.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using LogbookWood.Data.Common.Repositories;
    using LogbookWood.Data.Models;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class UnitService : IUnitService
    {
        private readonly IRepository<Unit> unitRepository;

        public UnitService(IRepository<Unit> unitRepository)
        {
            this.unitRepository = unitRepository;
        }

        public IEnumerable<SelectListItem> GetAllUnitItem()
        {
            return this.unitRepository.All().Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Name,
            }).OrderBy(x => x.Text).ToList();
            throw new NotImplementedException();
        }

        public IEnumerable<SelectListItem> GetAllUnitCategoryItem()
        {
            return null;
        }
    }
}
