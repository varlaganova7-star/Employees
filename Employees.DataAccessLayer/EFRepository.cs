using Employees.Model;
using System.Collections.Generic;
using System.Linq;

namespace Employees.DataAccessLayer
{
    public class EFRepository : IRepository<Employee>
    {
        public void Create(Employee item)
        {
            using var db = new AppDbContext();
            db.Employees.Add(item);
            db.SaveChanges();
        }

        public List<Employee> ReadAll()
        {
            using var db = new AppDbContext();
            return db.Employees.ToList();
        }

        public Employee ReadById(int id)
        {
            using var db = new AppDbContext();
            return db.Employees.Find(id);
        }

        public void Delete(int id)
        {
            using var db = new AppDbContext();
            var item = db.Employees.Find(id);
            if (item != null)
            {
                db.Employees.Remove(item);
                db.SaveChanges();
            }
        }
    }
}