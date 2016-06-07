using NServiceBus;
using RequestResponse.Contracts;

namespace RequestResponse.Server.Handlers
{
    public class HelloCommandMessageHandler : IHandleMessages<HelloCommandMessage>
    {
        private readonly IBus _bus;

        public HelloCommandMessageHandler(IBus bus)
        {
            _bus = bus;
        }
        public void Handle(HelloCommandMessage message)
        {
            var response = new HelloResponseMessage()
            {
                Message = $"Hello {message.Name}"
            };

            _bus.Reply(response);
        }
    }
}
