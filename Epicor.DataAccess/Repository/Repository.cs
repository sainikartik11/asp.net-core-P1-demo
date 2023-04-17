using DatabaseEPICORDb.Data;
using Epicor.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Epicor.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly EpicorDbContext _db;
        public readonly DbSet<T> DbSet;
        public Repository(EpicorDbContext db)
        {
            _db = db;
            DbSet = db.Set<T>();
        }

        public IEnumerable<T> GetAll(string? include = null)
        {
            IQueryable<T> query = DbSet;
            if (include != null)
            {
                foreach (var item in include.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query.Include(item);
                }
            }
            return query;
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void Remove(T entity)
        {
            DbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            DbSet.RemoveRange(entities);
        }

        public T GetfirstOrDefault(Expression<Func<T, bool>>? Filter = null)
        {
            IEnumerable<T> query = DbSet;
            if (Filter != null)
            {
                query = DbSet.Where(Filter);
            }
            return query.FirstOrDefault();
        }
    }
}
