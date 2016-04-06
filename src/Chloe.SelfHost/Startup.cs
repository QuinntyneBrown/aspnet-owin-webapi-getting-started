using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(Chloe.SelfHost.Startup))]

namespace Chloe.SelfHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            Chloe.Api.ApiConfiguration.Register(config);
            app.UseWebApi(config);
        }
    }
}
