using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductionSystem.Model
{
    public class Employee
    {
        public String EmployeeId { get; set; }
        public String EmployeeName { get; set; }

        public override string ToString()
        {
            return "[" + EmployeeId + " -  " + EmployeeName + "]";
        }
    }
}
