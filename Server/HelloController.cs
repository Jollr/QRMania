using System.Web.Http;

namespace Server
{
    public class HelloController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Hello() => Ok("<html><body>test</body></html>");
    }
}