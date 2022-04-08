using Warehouse.Application.Interfaces;

namespace Warehouse.WebApi.Installers
{
    /// <summary>
    /// Extensions methods of installer.
    /// </summary>
    public static class InstallerExtensions
    {
        /// <summary>
        /// Scan all assemblies and add them in DependencyInjection.
        /// </summary>
        /// <param name="services"></param>
        public static void InstallSevicesInAssembly(this IServiceCollection services)
        {
            var configuration = services.BuildServiceProvider().GetRequiredService<IConfiguration>();

            var installers = typeof(Program).Assembly.ExportedTypes.Where(s => typeof(IInstaller).IsAssignableFrom(s)
                 && !s.IsInterface && !s.IsAbstract).Select(Activator.CreateInstance).Cast<IInstaller>().ToList();

            installers.ForEach(installer => installer.InstallServices(services, configuration));

        }
    }
}
