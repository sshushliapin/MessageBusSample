using System.Threading.Tasks;
using Sitecore.Abstractions;
using Sitecore.Framework.Messaging;

namespace MessageBus.CM.Messaging
{
    public class HelloMessageHandler : IMessageHandler<HelloMessage>
    {
        private readonly BaseLog _logger;

        public HelloMessageHandler(BaseLog logger)
        {
            _logger = logger;
        }

        public Task Handle(
            HelloMessage message,
            IMessageReceiveContext receiveContext,
            IMessageReplyContext replyContext)
        {
            _logger.Info($"[MessageBusSample]: Message received: '{message.Text}'", this);
            return Task.CompletedTask;
        }
    }
}