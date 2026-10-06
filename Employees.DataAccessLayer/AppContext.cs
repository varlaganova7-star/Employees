using Microsoft.EntityFrameworkCore;
using Employees.Model;


namespace Employees.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbConfig.ConnectionString);
        }
    }
}