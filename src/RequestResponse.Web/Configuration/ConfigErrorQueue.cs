using NServiceBus.Config;
using NServiceBus.Config.ConfigurationSource;

namespace RequestResponse.Web.Configuration
{
    public class ConfigErrorQueue : IProvideConfiguration<MessageForwardingInCaseOfFaultConfig>
    {
        public MessageForwardingInCaseOfFaultConfig GetConfiguration()
        {
            return new MessageForwardingInCaseOfFaultConfig
            {
                ErrorQueue = "weberror"
            };
        }
    }
}