namespace GettingStartedLib.Tests.Fixtures
{
    using System;
    using Infrastructure;
    using Microsoft.Extensions.DependencyInjection;

    public class ServiceFixture
    {
        private readonly IServiceProvider _serviceProvider = ServiceProviderConfigurator.CreateServiceProvider();

        public ICalculator CalculatorService
            => _serviceProvider.GetRequiredService<ICalculator>();
    }
}