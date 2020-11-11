using Microsoft.Extensions.DependencyInjection;
using RealProxyPerformanceTest.Interface;
using RealProxyPerformanceTest.Services;
using System;

namespace RealProxyPerformanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetService<App>().Run();
            Console.ReadLine();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            //var config = LoadConfiguration();
            services.AddTransient<ITaxCalculator, BasicTaxCalculator>();

            services.AddTransient<App>();

            return services;
        }

        // do not need configuration now
        //public static IConfiguration LoadConfiguration()
        //{
        //    var environmentName =
        //        Environment.GetEnvironmentVariable("CORE_ENVIRONMENT");
        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        //        .AddJsonFile($"appsettings.{environmentName}.json", optional: true, reloadOnChange: true);
        //    return builder.Build();
        //}
    }
}
