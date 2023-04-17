using DatabaseEPICORDb.Data;
using Epicor.DataAccess.Repository.IRepository;
using Epicor.Models;

namespace Epicor.DataAccess.Repository
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        private readonly EpicorDbContext _db;
        public DepartmentRepository(EpicorDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Department department)
        {
            _db.Departments.Update(department);
        }
    }
}
