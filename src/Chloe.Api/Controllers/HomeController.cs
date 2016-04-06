using System.Web.Http;

namespace Chloe.Api.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("get")]
        public IHttpActionResult Get() => Ok("Hello World!");
    }
}
