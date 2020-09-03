using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core
{
    /// <summary>
    /// Interface for the writer 
    /// </summary>
    internal interface IEmployeeWriter
    {
        void Write(EmployeeWithAddress employeeWithAddress);
    }
}
