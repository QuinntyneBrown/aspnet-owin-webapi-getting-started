using Owin;
using System.Web.Http;
using static Microsoft.Owin.Hosting.WebApp;
using static System.Console;
using static Chloe.Core.ApiConfiguration;

namespace Chloe.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9006/";
            Start<Startup>(url: baseAddress);
            ReadLine();
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            Register(config);
            app.UseWebApi(config);
        }
    }
}
