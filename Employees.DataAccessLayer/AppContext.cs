using Microsoft.EntityFrameworkCore;
using Employees.Model; 

namespace Employees.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\1\source\repos\Employees\Employees.DataAccessLayer\Database1.mdf;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}