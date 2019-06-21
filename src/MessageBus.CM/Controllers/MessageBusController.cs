using System.Web.Http;
using MessageBus.CM.Messaging;
using Sitecore.Framework.Messaging;

namespace MessageBus.CM.Controllers
{
    public class MessageBusController : ApiController
    {
        private readonly IMessageBus<SampleMessageBus> _messageBus;

        public MessageBusController(
            IMessageBus<SampleMessageBus> messageBus)
        {
            _messageBus = messageBus;
        }

        [Route("api/ssc/messagebus")]
        public IHttpActionResult Get()
        {
            _messageBus.SendAsync(new HelloMessage { Text = "Hello from CM!" });

            return Ok("Hello from CM!");
        }
    }
}