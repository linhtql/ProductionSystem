using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductionSystem.Entity;
using ProductionSystem.Model;

namespace ProductionSystem.Convert
{
    public class EmployeeConvert
    {
        public Employee ToEmployee(EmployeeEntity entity)
        {
            var result = new Employee();
            result.EmployeeId = entity.EmployeeId;
            result.EmployeeName = entity.EmployeeName;
            return result;
        }
    }
}
