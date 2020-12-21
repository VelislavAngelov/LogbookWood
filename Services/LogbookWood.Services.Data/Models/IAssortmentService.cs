namespace LogbookWood.Services.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public interface IAssortmentService
    {
        IEnumerable<SelectListItem> GetAllAssortmentsItem();
    }
}
