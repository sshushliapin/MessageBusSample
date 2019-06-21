using System;
using MessageBus.CM.Messaging;
using Sitecore.Framework.Messaging;
using Sitecore.Pipelines;

namespace MessageBus.CM.Pipelines.Initialize
{
	public class InitializeSampleMessaging
	{
		private readonly IServiceProvider _serviceProvider;

		public InitializeSampleMessaging(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}

		public void Process(PipelineArgs args)
		{
			_serviceProvider.StartMessageBus<SampleMessageBus>();
		}
	}
}
