using Microsoft.Extensions.Logging;
using Warehouse.Domain.Entities;
using Warehouse.Application.Interfaces;

namespace Warehouse.Infrastructure.Repositories
{
    /// <summary>
    /// Communication repositiry.
    /// </summary>
    public class CommunicationRepository : Repository<CommunicationEntity>, ICommunicationRepository
    {
        /// <summary>
        /// Dependency of DbContext.
        /// </summary>
        public new WarehouseDbContext Context { get; }

        public new ILogger<CommunicationRepository> Logger { get; }

        /// <summary>
        /// CommunicationRepository constructor. 
        /// </summary>
        /// <param name="context"></param>
        public CommunicationRepository(WarehouseDbContext context, ILogger<CommunicationRepository> logger) : base(context, logger)
        {
            Context = context;
            Logger = logger;
        }
    }
}
