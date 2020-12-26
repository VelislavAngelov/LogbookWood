namespace LogbookWood.Services.Data.Models
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public interface IWoodService
    {
        IEnumerable<SelectListItem> GetAllWoodsItem();
    }
}
