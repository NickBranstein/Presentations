using DiWorkshop.Other;
using DiWorkshop.Repos;
using DiWorkshop.Services;
using Microsoft.Extensions.DependencyInjection;
using Shouldly;
using Xunit;

namespace DiWorkshop.Tests
{
    public class SimpleServiceTests
    {
        private readonly IServiceCollection _servicesCollection;
        private readonly ServiceProvider _serviceProvider;

        public SimpleServiceTests()
        {
            _servicesCollection = new ServiceCollection();
            
            ConfigureServices();

            _serviceProvider = _servicesCollection.BuildServiceProvider();
        }

        private void ConfigureServices()
        {
            //
            // fix tests here
            //
        }

        [Fact]
        public void EmptyService()
        {
            var sut = _serviceProvider.GetService<IEmptyService>();

            sut.ReturnsTrueForTest().ShouldBeTrue();
        }

        [Fact]
        public void SingleDependencyService()
        {
            var sut = _serviceProvider.GetService<ISingleDependencyService>();

            sut.ReturnsTrueForTest().ShouldBeTrue();
        }

        [Fact]
        public void SingleDependencyMultiLayerService()
        {
            var sut = _serviceProvider.GetService<ISingleDependencyMultiLayerService>();

            sut.ReturnsTrueForTest().ShouldBeTrue();
        }

        [Fact]
        public void MultiDependencyService()
        {
            var sut = _serviceProvider.GetService<IMultiDependencyService>();

            sut.ReturnsTrueForTest().ShouldBeTrue();
        }
    }
}