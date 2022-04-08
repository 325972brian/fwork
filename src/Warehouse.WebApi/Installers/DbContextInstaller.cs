using Warehouse.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Warehouse.Application.Interfaces;

namespace Warehouse.WebApi.Installers
{
    public class DbContextInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WarehouseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("WarehouseDatabase")));
            //services.AddScoped<IWarehouseDbContext>(provider => provider.GetService<WarehouseDbContext>());
        }
    }
}
