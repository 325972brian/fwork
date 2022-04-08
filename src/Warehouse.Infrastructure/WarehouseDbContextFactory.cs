using Microsoft.EntityFrameworkCore;

namespace Warehouse.Infrastructure
{
    public class WarehouseDbContextFactory : DesignTimeDbContextFactoryBase<WarehouseDbContext>
    {
        protected override WarehouseDbContext CreateNewInstance(DbContextOptions<WarehouseDbContext> options)
        {
            return new WarehouseDbContext(options);
        }
    }
}
