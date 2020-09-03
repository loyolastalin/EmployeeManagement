using EmployeeService.Core;
using System;
using System.Collections.Generic;
using EmployeeService.Model;
using System.Linq;

namespace EmployeeService.DAL
{
    /// <summary>
    /// Responsible for storing all the employee objects and ensure emplooyee Id is unique
    /// Implemented with the Unitofwork Pattern
    /// Inherited from <see cref="IEmployeeContext"/>
    /// </summary>
    internal class EmployeeContext : IEmployeeContext
    {
        private readonly List<Employee> EmployeeList;

        public EmployeeContext()
        {
            EmployeeList = new List<Employee>();
        }
        public void Add(Employee employee)
        {
            var alredyExits = EmployeeList.FirstOrDefault(emp => emp.Id == employee.Id);
            if (alredyExits != null)
            {
                throw new ArgumentException(string.Format("Employee already exists {0}, please add another employee.", employee.Id));
            }
            EmployeeList.Add(employee);
        }

        public Employee Get(int id)
        {
            return EmployeeList.FirstOrDefault(emp => emp.Id == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return EmployeeList;
        }

        public void Remove(int id)
        {
            var alredyExitsEmployee = EmployeeList.FirstOrDefault(emp => emp.Id == id);
            if (alredyExitsEmployee == null)
            {
                throw new ArgumentException(string.Format("Employee already exists {0}, please add another employee.", alredyExitsEmployee.Id));
            }
            EmployeeList.Remove(alredyExitsEmployee);
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
