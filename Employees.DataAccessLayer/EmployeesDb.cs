using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.DataAccessLayer
{
    internal class EmployeesDb
    {
        interface IRepository<T>
        {
            void Create(T item);
            List<T> ReadAll();
            T ReadById(int id);
            void Delete(int id);
        }
    }
}
