using DatabaseEPICORDb.Data;
using Epicor.DataAccess.Repository.IRepository;
using Epicor.Models;

namespace Epicor.DataAccess.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly EpicorDbContext _db;
        public EmployeeRepository(EpicorDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Employee employee)
        {
            _db.Employees.Update(employee);
        }
    }
}
