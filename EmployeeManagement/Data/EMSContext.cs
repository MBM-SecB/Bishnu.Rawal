using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data
{
    public class EMSContext : DbContext
    {
        public EMSContext()
        {            
        }
        public EMSContext(DbContextOptions<EMSContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}