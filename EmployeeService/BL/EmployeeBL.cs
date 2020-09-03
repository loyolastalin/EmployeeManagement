using EmployeeService.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeService.Model;
using EmployeeService.DAL;

namespace EmployeeService.BL
{
    /// <summary>
    /// Repobonsible for add the employee object business object, inherited from <see cref="IEmployeeBL"/>
    /// </summary>
    internal class EmployeeBL : IEmployeeBL
    {
        private IEmployeeRepository _repository;

        
        public EmployeeBL(): this(new EmployeeRepository())
        {

        }

        /// <summary>
        /// For testing purpose, replace later with IOC container instance management
        /// </summary>
        internal EmployeeBL(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public void Add(Employee employee)
        {
            if(employee ==null)
            {
                throw new ArgumentNullException("Please provovide the valid employee object");
            }

            _repository.Add(employee);
        }

        public Employee Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _repository.GetAll();
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }
    }
}
