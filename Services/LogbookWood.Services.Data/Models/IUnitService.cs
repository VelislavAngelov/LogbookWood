namespace LogbookWood.Services.Data.Models
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public interface IUnitService
    {
        IEnumerable<SelectListItem> GetAllUnitItem();

        IEnumerable<SelectListItem> GetAllUnitCategoryItem();
    }
}
