using Epicor.Models;

namespace Epicor.DataAccess.Repository.IRepository
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        void Update(Employee employee);
    }
}
