using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : ApiController
    {
        // GET api/helloworld
        public string Get()
        {
            return "Hello World";
        }
    }
}