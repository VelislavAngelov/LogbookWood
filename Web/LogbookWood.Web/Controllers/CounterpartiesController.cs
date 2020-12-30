namespace LogbookWood.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    public class CounterpartiesController : Controller
    {
        public IActionResult ListCounterparties()
        {
            return this.View();
        }
    }
}
