using EmployeeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService.Core
{
    /// <summary>
    /// Interface for the employee manager
    /// </summary>
    public interface IEmployeeManager
    {
        void Add(Employee employee);
        void Remove(int id);
        IEnumerable<Employee> GetAll();
        Employee Get(int id);

        void WriteToXml();
    }
}
