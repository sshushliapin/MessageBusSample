using System.Threading.Tasks;
using Sitecore.Framework.Messaging;

namespace MessageBus.CM.Messaging
{
    public class HelloMessageHandler : IMessageHandler<HelloMessage>
    {
        public Task Handle(
            HelloMessage message,
            IMessageReceiveContext receiveContext,
            IMessageReplyContext replyContext)
        {
            throw new System.NotImplementedException();
        }
    }
}