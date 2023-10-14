using ProductionSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem.Service
{
    public interface IEmployeeService
    {
        public Employee FindById(String id);
        public List<Employee> FindAll();
    }
}
