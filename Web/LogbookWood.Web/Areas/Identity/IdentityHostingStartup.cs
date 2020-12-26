using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(LogbookWood.Web.Areas.Identity.IdentityHostingStartup))]

namespace LogbookWood.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}