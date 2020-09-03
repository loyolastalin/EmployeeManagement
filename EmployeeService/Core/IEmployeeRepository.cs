using EmployeeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService.Core
{
    /// <summary>
    /// Interface for employee repository, this decouple the persitance storage from the upstream system
    /// </summary>
    internal interface IEmployeeRepository
    {
        void Add(Employee employee);
        void Remove(int id);
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
    }
}
