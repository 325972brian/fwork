using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Warehouse.Application.Interfaces
{
    /// <summary>
    /// Installer interface of dependency injection.
    /// This is assembly marker is used for scanning.
    /// </summary>
    public interface IInstaller
    {
        /// <summary>
        /// Installer services of AdminReg webapi.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        void InstallServices(IServiceCollection services, IConfiguration configuration);
    }
}
