using NServiceBus;

namespace RequestResponse.Contracts
{
    public class HelloCommandMessage : IMessage
    {
        public string Name { get; set; }
    }
}
