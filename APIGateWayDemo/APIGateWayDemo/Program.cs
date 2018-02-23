using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace APIGateWayDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            IWebHostBuilder builder = new WebHostBuilder();

            return builder.ConfigureServices(service =>
            {
                service.AddSingleton(builder);

            })
             .ConfigureAppConfiguration(conbuilder =>
             {
                 conbuilder.AddJsonFile("configuration.json");
             })
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
        }
    }
}
