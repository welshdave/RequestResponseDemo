using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using NServiceBus;

namespace RequestResponse.Web
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            var busConfig = new BusConfiguration();
            busConfig.EndpointName("RequestResponse.Web");
            busConfig.UseSerialization<JsonSerializer>();
            busConfig.UsePersistence<InMemoryPersistence>();
            busConfig.EnableInstallers();

            var bus = Bus.Create(busConfig).Start();

            container.Register(bus);

        }
    }
}