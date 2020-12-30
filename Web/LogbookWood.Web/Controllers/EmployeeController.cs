namespace LogbookWood.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    public class EmployeeController : Controller
    {
        public IActionResult CreateEmployee()
        {
            return this.View();
        }

        public IActionResult ListEmployee()
        {
            return this.View();
        }
    }
}
