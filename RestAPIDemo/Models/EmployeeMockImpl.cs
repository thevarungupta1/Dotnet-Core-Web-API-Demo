using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPIDemo.Models
{
    public class EmployeeMockImpl : IEmployeeRepository
    {
        private static List<Employee> employees;

        public EmployeeMockImpl()
        {
            employees = new List<Employee>();
            employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Mark", Email = "m@gmail.com" });
            employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Paul", Email = "p@gmail.com" });
            employees.Add(new Employee() { Id = Guid.NewGuid(), Name = "Watson", Email = "w@gmail.com" });
        }

        public Employee AddEmployee(Employee newEmployee)
        {
            newEmployee.Id = Guid.NewGuid();
            employees.Add(newEmployee);
            return new Employee();
        }

        public void DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(Guid id)
        {
            return employees.FirstOrDefault(emp => emp.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
