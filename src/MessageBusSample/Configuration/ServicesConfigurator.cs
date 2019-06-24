using MessageBusSample.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace MessageBusSample.Configuration
{
    public class ServicesConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<MessageBusController>();
        }
    }
}
