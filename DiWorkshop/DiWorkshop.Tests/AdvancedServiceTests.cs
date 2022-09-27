using DiWorkshop.Domain;
using DiWorkshop.Other;
using DiWorkshop.Repos;
using DiWorkshop.Services;
using Microsoft.Extensions.DependencyInjection;
using Shouldly;
using Xunit;

namespace DiWorkshop.Tests
{
    public class AdvancedServiceTests
    {
        private readonly IServiceCollection _servicesCollection;
        private readonly ServiceProvider _serviceProvider;

        public AdvancedServiceTests()
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
        public void AdvancedClassDependency()
        {
            var sut = _serviceProvider.GetService<AdvancedClassDependency>();

            sut.ReturnsTrueForTest().ShouldBeTrue();
        }

        [Fact]
        public void SimilarDependencyService()
        {
            var servicesCollection = new ServiceCollection();

            servicesCollection.AddScoped<ISimilarDependencyService, SimilarDependencyService>();
            servicesCollection.AddScoped<ISimilarRepository, SimilarRepositoryOne>();
            servicesCollection.AddScoped<ISimilarRepository, SimilarRepositoryTwo>();

            var serviceProvider = servicesCollection.BuildServiceProvider();
            var sut = serviceProvider.GetService<ISimilarDependencyService>();
            var services = serviceProvider.GetServices<ISimilarRepository>();


            services.Count().ShouldBe(1);
            services.First().ShouldBeAssignableTo<SimilarRepositoryOne>();
            sut.ReturnsTrueForTest().ShouldBeTrue();
        }

        [Fact]
        public void GenericRepositoryDependencyService()
        {
            var sut = _serviceProvider.GetService<IGenericRepositoryDependencyService>();

            sut.ReturnsTrueForTest().ShouldBeTrue();
        }

        [Fact]
        public void MultiGenericRepositoryDependencyService()
        {
            var sut = _serviceProvider.GetService<IMultiGenericRepositoryDependencyService>();

            sut.ReturnsTrueForTest().ShouldBeTrue();
        }

        [Fact]
        public void TrickyService()
        {
            var sut = _serviceProvider.GetService<ITrickyService<Bird>>();

            sut.ReturnsTrueForTest().ShouldBeTrue();
        }
    }
}
