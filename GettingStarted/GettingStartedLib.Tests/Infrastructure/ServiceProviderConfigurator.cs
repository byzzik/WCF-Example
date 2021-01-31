namespace GettingStartedLib.Tests.Infrastructure
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    public class ServiceProviderConfigurator
    {
        public static IServiceProvider CreateServiceProvider()
        {
            var services = new ServiceCollection();

            services.AddSingleton<ICalculator, CalculatorService>();

            return services.BuildServiceProvider();
        }
    }
}