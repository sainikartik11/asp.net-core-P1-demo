using DatabaseEPICORDb.Data;
using Epicor.DataAccess.Repository.IRepository;

namespace Epicor.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EpicorDbContext _db;
        public IEmployeeRepository EmployeeRepository { get; private set; }
        public IDepartmentRepository DepartmentRepository { get; private set; }

        public UnitOfWork(EpicorDbContext db)
        {
            _db = db;
            EmployeeRepository = new EmployeeRepository(_db);
            DepartmentRepository = new DepartmentRepository(_db);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
