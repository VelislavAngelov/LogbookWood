namespace LogbookWood.Web.Tests
{
    using System.Net;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc.Testing;
    using Xunit;

    public class WebTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> server;

        public WebTests(WebApplicationFactory<Startup> server)
        {
            this.server = server;
        }

        [Fact(Skip = "Example test. Disabled for CI.")]
        public async Task IndexPageShouldReturnStatusCode200WithTitle()
        {
            System.Net.Http.HttpClient client = this.server.CreateClient();
            System.Net.Http.HttpResponseMessage response = await client.GetAsync("/");
            response.EnsureSuccessStatusCode();
            string responseContent = await response.Content.ReadAsStringAsync();
            Assert.Contains("<title>", responseContent);
        }

        [Fact(Skip = "Example test. Disabled for CI.")]
        public async Task AccountManagePageRequiresAuthorization()
        {
            System.Net.Http.HttpClient client = this.server.CreateClient(new WebApplicationFactoryClientOptions { AllowAutoRedirect = false });
            System.Net.Http.HttpResponseMessage response = await client.GetAsync("Identity/Account/Manage");
            Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
        }
    }
}
