using Epicor.Models;

namespace Epicor.DataAccess.Repository.IRepository
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        void Update(Department department);
    }
}
