using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core
{
    /// <summary>
    /// Interface for employee target
    /// </summary>
    public interface IEmployeeTarget
    {
        void Add(EmployeeWithAddress employee);
        void Remove(int id);

        List<EmployeeWithAddress> GetAll();

        EmployeeWithAddress Get(int id);

        void Write(EmployeeWithAddress employeeWithAddress);
    }
}
