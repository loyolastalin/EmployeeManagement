using EmployeeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService.Core
{
    /// <summary>
    /// Interface for defining Employee context to store employee object and it's behavior
    /// </summary>
    internal interface IEmployeeContext
    {
        void Add(Employee employee);
        void Remove(int id);
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
        void SaveChanges();

    }
}
