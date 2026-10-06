using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.DataAccessLayer
{
    public static class DbConfig
    {
        public const string ConnectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=EmployeesDB;Integrated Security=True;TrustServerCertificate=True;";
    }
}