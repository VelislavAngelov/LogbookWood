namespace LogbookWood.Services.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using LogbookWood.Data.Common.Repositories;
    using LogbookWood.Data.Models;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class AssortmentService : IAssortmentService
    {
        public readonly IRepository<Assortment> assortmentRepository;

        public AssortmentService(IRepository<Assortment> assortmentRepository)
        {
            this.assortmentRepository = assortmentRepository;
        }

        public IEnumerable<SelectListItem> GetAllAssortmentsItem()
        {
            return this.assortmentRepository.All()
                .Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Name,
                }).OrderBy(x => x.Text).ToList();
        }
    }
}
