namespace Epicor.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository EmployeeRepository { get; }
        IDepartmentRepository DepartmentRepository { get; }

        void Save();
    }
}
