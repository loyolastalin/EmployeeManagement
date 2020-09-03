using EmployeeManagement.Core;
using EmployeeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //EmployeeManager employeeManager = new EmployeeManager();
            //employeeManager.Add(new EmployeeService.Model.Employee() { Id = 1, Name = "ewer", Age = 23, Designation = "ewwqe" });
            //employeeManager.Add(new EmployeeService.Model.Employee() { Id = 2, Name = "ewer", Age = 23, Designation = "ewwqe" });
            //employeeManager.Add(new EmployeeService.Model.Employee() { Id = 3, Name = "ewer", Age = 23, Designation = "ewwqe" });
            //employeeManager.Remove(3);
            //var x  = employeeManager.GetAll().ToList();

            IEmployeeTarget target = new EmployeeTarget();

            target.Add(new Model.EmployeeWithAddress()
            {
                Id = 1,
                Name = "asdasd",
                Age = 23,
                Designation = "Manag34",

                EmployeeAddress = new Model.Address() { DorrNo = 23, BuildingName = "sdf", City = "sdfsdf", Streetname = "asdad", Country = "sdfsdf" }
            });

            target.Add(new Model.EmployeeWithAddress()
            {
                Id = 2,
                Name = "asdasd",
                Age = 23,
                Designation = "Manag34",

                EmployeeAddress = new Model.Address() { DorrNo = 23, BuildingName = "sdf", City = "sdfsdf", Streetname = "asdad", Country = "sdfsdf" }
            });

            target.Add(new Model.EmployeeWithAddress()
            {
                Id = 3,
                Name = "asdasd",
                Age = 23,
                Designation = "Manag34",

                EmployeeAddress = new Model.Address() { DorrNo = 23, BuildingName = "sdf", City = "sdfsdf", Streetname = "asdad", Country = "sdfsdf" }
            });

            target.Remove(2);

            var list = target.GetAll().ToList();

            target.Write(target.Get(1));
        }
    }
}
