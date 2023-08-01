using System.Linq.Expressions;

namespace food_recipes_api.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(Guid Id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
    }
}
