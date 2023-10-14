using ProductionSystem.Convert;
using ProductionSystem.DAO;
using ProductionSystem.Entity;
using ProductionSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem.Service
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> FindAll()
        {
            DataManager dataManager = new DataManager();
            DatabaseType selectedDatabase = DatabaseType.SqlServer;

            var employeeEntities = new EmployeeDAO().FindAll(selectedDatabase);

            EmployeeConvert employeeConvert = new EmployeeConvert();
            List<Employee> employees = employeeEntities.Select(employeeEntity => employeeConvert.ToEmployee(employeeEntity)).ToList();

            return employees;
        }

        public Employee FindById(string id)
        {
            DataManager dataManager = new DataManager();
            DatabaseType selectedDatabase = DatabaseType.SqlServer;

            EmployeeDAO employeeDAO = new EmployeeDAO();
            var employee = employeeDAO.FindById(id, selectedDatabase);
            if (employee == null)
            {
                return null;
            }
            var result = new EmployeeConvert().ToEmployee(employee);

            return result;
        }
    }
}
