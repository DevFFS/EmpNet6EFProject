using Microsoft.EntityFrameworkCore;
using WebApiCoreWithEF.Models;

namespace WebApiCoreWithEF.Context
{
    
    public class CompanyContext : DbContext

    {
        public CompanyContext(DbContextOptions options) : base(options)

        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
