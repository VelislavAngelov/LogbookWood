namespace LogbookWood.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class UserController : Controller
    {
        public IActionResult IndexUser()
        {
            return this.View();
        }
    }
}
