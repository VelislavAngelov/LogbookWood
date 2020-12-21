using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogbookWood.Services.Data.Models
{
    public interface IUnitService
    {
        IEnumerable<SelectListItem> GetAllUnitItem();

        IEnumerable<SelectListItem> GetAllUnitCategoryItem();
    }
}
