using EmployeeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    /// <summary>
    /// Inherits the porperties from the existing class <see cref="Employee"/> 
    /// Note: We can also use extention method, but i am using inheritance 
    /// </summary>
    public class EmployeeWithAddress : Employee
    {
        public Address EmployeeAddress { get; set; }
    }
}
