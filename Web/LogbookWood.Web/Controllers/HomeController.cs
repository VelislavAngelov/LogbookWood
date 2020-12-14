namespace LogbookWood.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using LogbookWood.Data;
    using LogbookWood.Web.ViewModels;
    using LogbookWood.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                AssortmmentCount = this.dbContext.Woods.Count(),
                WoodCount = 0,
                TicketCount = 0,
            };

            return this.View();
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
