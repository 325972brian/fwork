using Warehouse.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Warehouse.Application.Interfaces;


namespace Warehouse.Infrastructure
{
    /// <summary>
    /// Warehouse database context
    /// </summary>
    public class WarehouseDbContext : DbContext, IWarehouseDbContext
    {
        /// <summary>
        /// Constructor of warehouse DbContext .
        /// </summary>
        /// <param name="options"></param>
        public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options) : base(options) { }

        /// <summary>
        /// Communication table.
        /// </summary>
        public DbSet<CommunicationEntity> Comminucations { get; set; }

        /// <summary>
        /// Initialize the data in database table.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(WarehouseDbContext).Assembly);
        }
    }
}
