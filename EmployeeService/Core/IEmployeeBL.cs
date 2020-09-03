using EmployeeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService.Core
{
    /// <summary>
    /// Interface for defining the employyee object, holds all the business logic
    /// </summary>
    public interface IEmployeeBL
    {
        void Add(Employee employee);
        void Remove(int id);
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
    }
}
