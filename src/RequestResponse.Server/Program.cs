using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace RequestResponse.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "RequestResponseDemo.Server";
            var busConfig = new BusConfiguration();
            busConfig.EndpointName("RequestResponse.Server");
            busConfig.UseSerialization<JsonSerializer>();
            busConfig.UsePersistence<InMemoryPersistence>();
            busConfig.EnableInstallers();

            using (var bus = Bus.Create(busConfig).Start())
            {
                Console.WriteLine("Press any key to stop server...");
                Console.ReadKey();
            }
        }
    }
}
