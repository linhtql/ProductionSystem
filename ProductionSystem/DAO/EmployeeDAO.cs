using ProductionSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem.DAO
{
    public class EmployeeDAO
    {


        public EmployeeEntity FindById(String id, DatabaseType selectedDatabase)
        {
            DataManager dataManager = new DataManager();

            string query = "SELECT * FROM Employees Where EmployeeId ='" + id+"'";
            DataTable resultTable = dataManager.GetData(selectedDatabase, query);

            if (resultTable != null && resultTable.Rows.Count > 0)
            {
                var result = new EmployeeEntity();

                result.EmployeeId = resultTable.Rows[0]["EmployeeId"].ToString();
                result.EmployeeName = resultTable.Rows[0]["EmployeeName"].ToString();

                return result;
            }

            return null;
        }

        public List<EmployeeEntity> FindAll(DatabaseType selectedDatabase)
        {
            var resultList = new List<EmployeeEntity>();

            DataManager dataManager = new DataManager();

            string query = "SELECT * FROM Employees";
            DataTable resultTable = dataManager.GetData(selectedDatabase, query);

            if (resultTable != null && resultTable.Rows.Count > 0)
            {
                foreach (DataRow row in resultTable.Rows)
                {
                    EmployeeEntity result = new EmployeeEntity();

                    result.EmployeeId = row["EmployeeId"].ToString();
                    result.EmployeeName = row["EmployeeName"].ToString();

                    resultList.Add(result);
                }

                return resultList;
            }

            return resultList;

        }
    }
}
