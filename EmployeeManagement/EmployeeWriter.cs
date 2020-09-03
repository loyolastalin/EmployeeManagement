using EmployeeManagement.Core;
using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EmployeeManagement
{
    /// <summary>
    /// Writes the employee object into XML
    /// </summary>
    public class EmployeeWriter : IEmployeeWriter
    {
        public void Write(EmployeeWithAddress employeeWithAddress)
        {
            using (XmlWriter writer = XmlWriter.Create("employees.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Employees");

                writer.WriteStartElement("Employee");

                writer.WriteElementString("ID", employeeWithAddress.Id.ToString());
                writer.WriteElementString("Name", employeeWithAddress.Name);
                writer.WriteElementString("Age", employeeWithAddress.Age.ToString());
                writer.WriteElementString("Designation", employeeWithAddress.Designation.ToString());
                writer.WriteStartElement("Address");
                writer.WriteElementString("DorrNo", employeeWithAddress.EmployeeAddress.DorrNo.ToString());
                writer.WriteElementString("BuildingName", employeeWithAddress.EmployeeAddress.BuildingName.ToString());
                writer.WriteElementString("StreetName", employeeWithAddress.EmployeeAddress.Streetname.ToString());
                writer.WriteElementString("City", employeeWithAddress.EmployeeAddress.City.ToString());
                writer.WriteElementString("Country", employeeWithAddress.EmployeeAddress.Country.ToString());

                writer.WriteEndElement();
                writer.WriteEndElement();
            }


        }
        
    }
}
