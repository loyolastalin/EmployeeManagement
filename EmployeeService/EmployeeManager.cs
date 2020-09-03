using EmployeeService.BL;
using EmployeeService.Core;
using EmployeeService.Model;
using System;
using System.Collections.Generic;

namespace EmployeeService
{
    /// <summary>
    /// Employee manager handles all the behavior of the employee management, it follows FACADE pattern
    ///  it hides all the internal subsystem, implemented from the <see cref="IEmployeeManager"/>
    /// </summary>
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeBL _employeeBL;

        public EmployeeManager() : this(new EmployeeBL())
        {

        }

        internal EmployeeManager(IEmployeeBL employeeBL)
        {
            _employeeBL = employeeBL;
        }
        public void Add(Employee employee)
        {
            _employeeBL.Add(employee);
        }

        public Employee Get(int id)
        {
            return _employeeBL.Get(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeBL.GetAll();
        }

        public void Remove(int id)
        {
            _employeeBL.Remove(id);
        }

        void IEmployeeManager.WriteToXml()
        {
            throw new NotImplementedException();
        }
    }
}
