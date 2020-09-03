using EmployeeManagement.Core;
using EmployeeManagement.DAL;
using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    /// <summary>
    /// Calls the Adaptor and gets all the functionality.
    /// This class behaves as a Facade
    /// </summary>
    public class EmployeeTarget : IEmployeeTarget
    {
        private readonly IEmployeeAdaptorRepository _employeeAdaptorRepository;
        private readonly IEmployeeWriter _iEmployeeWriter;
        public EmployeeTarget():this(new EmployeeAdaptorRepository(), new EmployeeWriter())
        {
                
        }

        internal EmployeeTarget(IEmployeeAdaptorRepository employeeAdaptorRepository, IEmployeeWriter iEmployeeWriter)
        {
            _employeeAdaptorRepository = employeeAdaptorRepository;
            _iEmployeeWriter = iEmployeeWriter;
        }
        public void Add(EmployeeWithAddress employee)
        {
            _employeeAdaptorRepository.Add(employee);
        }

        public void Remove(int id)
        {
            _employeeAdaptorRepository.Remove(id);
        }

        public List<EmployeeWithAddress> GetAll()
        {
            return _employeeAdaptorRepository.GetAll();
        }

        public void Write(EmployeeWithAddress employeeWithAddress)
        {
            _iEmployeeWriter.Write(employeeWithAddress);
        }

        public EmployeeWithAddress Get(int id)
        {
            return _employeeAdaptorRepository.Get(id);
        }
    }
}
