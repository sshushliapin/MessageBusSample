using MessageBus.CM.Controllers;
using MessageBus.CM.Messaging;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Sitecore.Framework.Messaging;

namespace MessageBus.CM.Configuration
{
    public class ServicesConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IMessageHandler<HelloMessage>, HelloMessageHandler>();
            serviceCollection.AddTransient<MessageBusController>();
        }
    }
}
