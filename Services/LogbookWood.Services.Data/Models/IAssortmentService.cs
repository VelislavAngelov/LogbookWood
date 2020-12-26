namespace LogbookWood.Services.Data.Models
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public interface IAssortmentService
    {
        IEnumerable<SelectListItem> GetAllAssortmentsItem();
    }
}
