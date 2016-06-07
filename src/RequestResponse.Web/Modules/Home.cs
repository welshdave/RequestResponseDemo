using Nancy;
using NServiceBus;
using RequestResponse.Contracts;

namespace RequestResponse.Web.Modules
{      
    public class Home : NancyModule
    {
        private readonly IBus _bus;
        public Home(IBus bus)
        {
            _bus = bus;
            Get["/{Name?}"] = SayHello;
        }

        private dynamic SayHello(dynamic args)
        {
            var command = new HelloCommandMessage()
            {
               Name = args.Name.TryParse("Anon")
            };
            var result = _bus.Send("RequestResponse.Server", command)
                .Register(ar =>
                {
                    var response = (HelloResponseMessage) ar.Messages[0];
                    return response.Message;
                }).Result;

            return result;
        }

    }
}