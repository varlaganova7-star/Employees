using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Data.SqlClient;
using Employees.Model;

namespace Employees.DataAccessLayer
{
    public class DapperRepository : IRepository<Employee>
    {
        private readonly string _connectionString;

        public DapperRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public void Create(Employee item)
        {
            using var db = CreateConnection();
            db.Execute(
                @"INSERT INTO Employees (FirstName, LastName, Position)
                  VALUES (@FirstName, @LastName, @Position)", item);
        }

        public List<Employee> ReadAll()
        {
            using var db = CreateConnection();
            return db.Query<Employee>("SELECT * FROM Employees").ToList();
        }

        public Employee ReadById(int id)
        {
            using var db = CreateConnection();
            return db.QueryFirstOrDefault<Employee>(
                "SELECT * FROM Employees WHERE Id = @Id", new { Id = id });
        }

        public void Delete(int id)
        {
            using var db = CreateConnection();
            db.Execute("DELETE FROM Employees WHERE Id = @Id", new { Id = id });
        }
    }
}