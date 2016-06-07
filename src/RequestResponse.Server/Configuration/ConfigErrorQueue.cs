using NServiceBus.Config;
using NServiceBus.Config.ConfigurationSource;

namespace RequestResponse.Server.Configuration
{
    class ConfigErrorQueue : IProvideConfiguration<MessageForwardingInCaseOfFaultConfig>
    {
        public MessageForwardingInCaseOfFaultConfig GetConfiguration()
        {
            return new MessageForwardingInCaseOfFaultConfig
            {
                ErrorQueue = "servererror"
            };
        }    
    }
}
