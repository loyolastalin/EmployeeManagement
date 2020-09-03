using EmployeeManagement.Core;
using EmployeeManagement.Model;
using EmployeeService;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.DAL
{
    /// <summary>
    /// This addaptor uses the 3rdparty library and adds the addess into the object
    /// This class inhetited from <see cref="IEmployeeAdaptorRepository"/>
    /// TODO: Need to use the Unitof Work pattern here, asif i have done in the Employee service
    /// </summary>
    public class EmployeeAdaptorRepository : IEmployeeAdaptorRepository
    {
        private Dictionary<int, Address> _employeeList;

        private EmployeeManager _manager;
        public EmployeeAdaptorRepository()
        {
            _employeeList = new Dictionary<int, Address>();
            _manager = new EmployeeManager();

        }

        public void Add(EmployeeWithAddress employee)
        {
            _manager.Add(new EmployeeService.Model.Employee() { Id = employee.Id, Name = employee.Name, Age = employee.Age, Designation = employee.Designation });

            _employeeList.Add(employee.Id, employee.EmployeeAddress);
        }

        public void Remove(int id)
        {
            // TODO : Both should be added into a single transaction 
            _manager.Remove(id);
            if (_employeeList.ContainsKey(id))
            {
                _employeeList.Remove(id);
            }

        }

        public List<EmployeeWithAddress> GetAll()
        {
            // TODO: Needs to add defensive progrm here, when the item not found in the employeelist the code fails
            List<EmployeeWithAddress> employee = new List<EmployeeWithAddress>();
            _manager.GetAll().ToList().ForEach(item => employee.Add(new EmployeeWithAddress()
            {
                Age = item.Age,
                Designation = item.Designation,
                Id = item.Id,
                Name = item.Name,
                EmployeeAddress = _employeeList[item.Id]
            }));
            return employee;
        }

        public EmployeeWithAddress Get(int id)
        {
            var item = _manager.Get(id);
            return new EmployeeWithAddress()
            {
                Age = item.Age,
                Designation = item.Designation,
                Id = item.Id,
                Name = item.Name,
                EmployeeAddress = _employeeList[id]
            };
        }
    }
}
