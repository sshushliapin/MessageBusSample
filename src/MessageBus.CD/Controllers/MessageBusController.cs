using System.Web.Http;

namespace MessageBus.CD.Controllers
{
    public class MessageBusController : ApiController
    {
        [Route("api/ssc/messagebus")]
        public IHttpActionResult Get()
        {
            return Ok("Hello from CD!");
        }
    }
}