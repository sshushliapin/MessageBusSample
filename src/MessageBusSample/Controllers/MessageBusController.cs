using System.Configuration;
using System.Web.Http;
using MessageBusSample.Messaging;
using Sitecore.Framework.Messaging;

namespace MessageBusSample.Controllers
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
            var role = ConfigurationManager.AppSettings["role:define"];
            var message = $"Hello from {role}!";
            _messageBus.SendAsync(new HelloMessage { Text = message });
            return Ok(message);
        }
    }
}