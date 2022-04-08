using MediatR;
using System.Reflection;
using Warehouse.Application.Interfaces;
using Warehouse.Infrastructure.Repositories;
using Warehouse.Application.Services.Communication.Queries.GetCommunications;

namespace Warehouse.WebApi.Installers
{
    /// <summary>
    /// Communication installer for DependencyInjection.test
    /// </summary>
    public class CommunicationInstaller : IInstaller
    {
        /// <summary>
        /// Add communication to dependencyInjection.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            // Register MediatR to the contener of dependency injection
            //services.AddMediatR(typeof(GetCommunicationQueryHandler).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(GetCommunicationsQueryHandler).GetTypeInfo().Assembly);

            // Register the repository to the contener of dependency injection
            services.AddScoped(typeof(ICommunicationRepository), typeof(CommunicationRepository));
        }
    }
}
