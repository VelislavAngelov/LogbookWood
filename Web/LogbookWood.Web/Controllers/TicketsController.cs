using LogbookWood.Web.ViewModels.Tickets;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogbookWood.Web.Controllers
{
    public class TicketsController : BaseController
    {
        public IActionResult CreateReceipt()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult CreateReceipt(CreateTicketModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            // TODO: Redirect ListTickets
            return this.Redirect("/");
        }
    }
}
