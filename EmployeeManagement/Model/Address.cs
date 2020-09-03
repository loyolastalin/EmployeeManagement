using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    /// <summary>
    /// Holds the address entities
    /// </summary>
    public class Address
    {
        public int DorrNo { get; set; }
        public string BuildingName { get; set; }

        public string Streetname { get; set; }

        public string City { get; set; }
        public string Country { get; set; }
    }
}
