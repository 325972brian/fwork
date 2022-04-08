using System.Linq.Expressions;

namespace Warehouse.Application.Interfaces
{
    /// <summary>
    /// Repository interface.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Get the rows number of selected table with condition async.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>int</returns>
        Task<int> GetCountByConditionAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Get the rows number of selected table async.
        /// </summary>
        /// <returns>int</returns>
        Task<int> GetCountAsync();

        /// <summary>
        /// Get the selected row of table by selected field Queryable.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        IQueryable<TEntity> FindByConditionQueryable(Expression<Func<TEntity, bool>> expression);

        /// <summary>
        /// Get the all rows of selected table Queryable.
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> FindAllQueryable();

        /// <summary>
        /// Get the selected row of table by id async.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TEntity of selected object</returns>
        Task<TEntity> GetByIdAsync(int id);

        /// <summary>
        /// Get all rows of selected table with condition async.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>IEnumerable</returns>
        Task<IEnumerable<TEntity>> GetAllByConditionAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Get all rows of selected table async.
        /// </summary>
        /// <returns>IEnumerable</returns>
        Task<IEnumerable<TEntity>> GetAllAsync();

        /// <summary>
        /// Add new row to the selected table async.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task AddNewObjectAsync(TEntity entity, CancellationToken cancellationToken);

        /// <summary>
        /// Add new rows to the selected table async. 
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task AddNewListAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken);

        /// <summary>
        /// Update the selected row of the table async. 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task UpdateObjectAsync(TEntity entity, CancellationToken cancellationToken);

        /// <summary>
        /// Delete the selected row of the table async.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task DeleteObjectAsync(TEntity entity, CancellationToken cancellationToken);

        /// <summary>
        /// Delete the selected rows of the table async.
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task DeleteListAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken);
    }
}
