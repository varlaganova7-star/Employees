using System.Collections.Generic;
using Employees.DataAccessLayer;
using Employees.Model;

namespace Employees.BusinessLogic
{
    public class EmployeeService
    {
        private readonly IRepository<Employee> _repository;

        public EmployeeService(IRepository<Employee> repository)
        {
            _repository = repository;
        }

        public List<Employee> GetAll()
        {
            return _repository.ReadAll();
        }

        public Employee GetById(int id)
        {
            return _repository.ReadById(id);
        }

        public void Add(Employee employee)
        {
            if (string.IsNullOrWhiteSpace(employee.FirstName) ||
                string.IsNullOrWhiteSpace(employee.LastName) ||
                string.IsNullOrWhiteSpace(employee.Position))
            {
                throw new System.ArgumentException("Все поля сотрудника должны быть заполнены!");
            }

            _repository.Create(employee);
        }

        public void Remove(int id)
        {
            _repository.Delete(id);
        }
    }
}