using MessageBusSample.Messaging;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Sitecore.Framework.Messaging;

namespace MessageBusSample.Configuration
{
    public class ServicesConfiguratorCm : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IMessageHandler<HelloMessage>, HelloMessageHandler>();
        }
    }
}
