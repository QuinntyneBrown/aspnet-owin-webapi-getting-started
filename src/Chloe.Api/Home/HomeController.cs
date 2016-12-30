using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Chloe.Api.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("get")]
        [ResponseType(typeof(string))]
        public IHttpActionResult Get() => Ok("Hello World!");
    }
}
