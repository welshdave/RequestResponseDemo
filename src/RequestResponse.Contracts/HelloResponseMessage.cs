using NServiceBus;

namespace RequestResponse.Contracts
{
    public class HelloResponseMessage : IMessage
    {
        public string Message { get; set; }
    }
}
