using System.Linq.Expressions;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Warehouse.Application.Interfaces;

namespace Warehouse.Infrastructure.Repositories
{
    /// <summary>
    /// Repository class implementation of IRepository
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Dependency of DbContext.
        /// </summary>
        //public DbContext Context { get ; }
        private readonly DbContext _context;

        /// <summary>
        /// Dependency of Microsoft logger.
        /// </summary>
        private readonly ILogger _logger;

        public Repository(DbContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Get the rows number of selected table with condition async.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>int</returns>
        public Task<int> GetCountByConditionAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                //return Context.Set<TEntity>().CountAsync(predicate);
                return _context.Set<TEntity>().CountAsync(predicate);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Repository of {typeof(TEntity)} by GetCountByConditionAsync");
                throw ex.InnerException;
            }
        }

        /// <summary>
        /// Get the rows number of selected table async.
        /// </summary>
        /// <returns></returns>
        public Task<int> GetCountAsync()
        {
            try
            {
                //return Context.Set<TEntity>().CountAsync();
                return _context.Set<TEntity>().CountAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Repository of {typeof(TEntity)} by GetCountAsync");
                throw ex.InnerException;
            }
        }

        /// <summary>
        /// Get the selected row of table by selected field Queryable.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public IQueryable<TEntity> FindByConditionQueryable(Expression<Func<TEntity, bool>> expression)
        {
            try
            {
                //return Context.Set<TEntity>().Where(expression).AsNoTracking();
                return _context.Set<TEntity>().Where(expression).AsNoTracking();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Repository of {typeof(TEntity)} by FindByConditionQueryable");
                throw ex.InnerException;
            }
        }

        /// <summary>
        /// Get the all rows of selected table Queryable.
        /// </summary>
        /// <returns></returns>
        public IQueryable<TEntity> FindAllQueryable()
        {
            try
            {
                //return Context.Set<TEntity>().AsNoTracking();
                return _context.Set<TEntity>().AsNoTracking();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Repository of {typeof(TEntity)} by FindAllQueryable");
                throw ex.InnerException;
            }
        }

        /// <summary>
        /// Get the selected row of table by id async.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TEntity of selected object</returns>
        public async Task<TEntity> GetByIdAsync(int id)
        {
            try
            {
                //return await Context.Set<TEntity>().FindAsync(id);
                return await _context.Set<TEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Repository of {typeof(TEntity)} by GetByIdAsync {id}");
                throw ex.InnerException;
            }
        }

        /// <summary>
        /// Get all rows of selected table with condition async.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>IEnumerable</returns>
        public async Task<IEnumerable<TEntity>> GetAllByConditionAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                //return await Context.Set<TEntity>().Where(predicate).ToListAsync();
                return await _context.Set<TEntity>().Where(predicate).ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Repository of {typeof(TEntity)} by GetAllByConditionAsync");
                throw ex.InnerException;
            }

        }

        /// <summary>
        /// Get all rows of selected table async.
        /// </summary>
        /// <returns>IEnumerable</returns>
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            try
            {
                //return await Context.Set<TEntity>().ToListAsync();
                return await _context.Set<TEntity>().ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Repository of {typeof(TEntity)} by GetAllAsync");
                throw ex.InnerException;
            }
        }

        /// <summary>
        /// Add new row to the selected table async.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task AddNewObjectAsync(TEntity entity, CancellationToken cancellationToken)
        {
            try
            {
                // await Context.AddAsync(entity);
                //await Context.Set<TEntity>().AddAsync(entity);
                //await Context.SaveChangesAsync();

                await _context.Set<TEntity>().AddAsync(entity);
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Repository of {typeof(TEntity)} by AddNewObjectAsync");
                throw ex.InnerException;
            }
        }

        /// <summary>
        /// Add new rows to the selected table async. 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public async Task AddNewListAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken)
        {
            try
            {
                //await Context.Set<TEntity>().AddRangeAsync(entities);
                //await Context.SaveChangesAsync();

                await _context.Set<TEntity>().AddRangeAsync(entities);
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Repository of {typeof(TEntity)} by AddNewListAsync");
                throw ex.InnerException;
            }
        }

        /// <summary>
        /// Update the selected row of the table async. 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Task UpdateObjectAsync(TEntity entity, CancellationToken cancellationToken)
        {
            try
            {
                // In case AsNoTracking is used
                //Context.Entry(entity).State = EntityState.Modified;
                //return Context.SaveChangesAsync();

                _context.Entry(entity).State = EntityState.Modified;
                return _context.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Repository of {typeof(TEntity)} by UpdateObjectAsync");
                throw ex.InnerException;
            }
        }

        /// <summary>
        /// Delete the selected row of the table async.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Task DeleteObjectAsync(TEntity entity, CancellationToken cancellationToken)
        {
            try
            {
                //Context.Set<TEntity>().Remove(entity);
                //return Context.SaveChangesAsync();

                _context.Set<TEntity>().Remove(entity);
                return _context.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Repository of {typeof(TEntity)} by DeleteObjectAsync");
                throw ex.InnerException;
            }
        }

        /// <summary>
        /// Delete the selected rows of the table async.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public Task DeleteListAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken)
        {
            try
            {
                //Context.Set<TEntity>().RemoveRange(entities);
                //return Context.SaveChangesAsync();

                _context.Set<TEntity>().RemoveRange(entities);
                return _context.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Repository of {typeof(TEntity)} by DeleteListAsync");
                throw ex.InnerException;
            }
        }
    }
}
