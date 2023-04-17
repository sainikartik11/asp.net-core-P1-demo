using System.Linq.Expressions;

namespace Epicor.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(string? include = null);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        T GetfirstOrDefault(Expression<Func<T, bool>>? Filter = null);
    }
}
