using EmployeeService.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeService.Model;

namespace EmployeeService.DAL
{
    /// <summary>
    /// Decouple the Persistence storage from the BL, interacts with the EmployeeContext persitence storage<see cref="EmployeeContext"/>
    /// </summary>
    internal class EmployeeRepository : IEmployeeRepository
    {
        private readonly IEmployeeContext _context;
        
        public EmployeeRepository() : this(new EmployeeContext()) 
        {

        }

        /// <summary>
        /// this is for testing purpose, we can remove this when we implement IOC framework like Unit framework
        /// </summary>
        internal EmployeeRepository(IEmployeeContext context)
        {
            _context = context;
        }
        public void Add(Employee employee)
        {
            _context.Add(employee);
        }

        public Employee Get(int id)
        {
            return _context.Get(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.GetAll();
        }

        public void Remove(int id)
        {
            _context.Remove(id);
        }
    }
}
