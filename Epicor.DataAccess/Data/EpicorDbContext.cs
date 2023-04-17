using Epicor.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DatabaseEPICORDb.Data
{
    public class EpicorDbContext : IdentityDbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public EpicorDbContext(DbContextOptions<EpicorDbContext> options) : base(options)
        {

        }
    }
}
