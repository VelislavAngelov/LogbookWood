using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogbookWood.Services.Data.Models
{
    public interface IAssortmentService
    {
        IEnumerable<SelectListItem> GetAllAssortmentsItem();
    }
}
