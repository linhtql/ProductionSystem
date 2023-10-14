using ProductionSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem.DAO
{
    public class ProductionDAO
    {
        public List<ProductionEntity> FindProductionById(String EmployeeId, String date,  DatabaseType selectedDatabase)
        {
            var resultList = new List<ProductionEntity>();
            DataManager dataManager = new DataManager();

            string query = "SELECT * FROM Production Where ResponsibleEmployee = '" + EmployeeId + "' and ProductionDate = '" + date + "'";
            DataTable resultTable = dataManager.GetData(selectedDatabase, query);

            if (resultTable != null && resultTable.Rows.Count > 0)
            {
                foreach (DataRow row in resultTable.Rows)
                {
                    ProductionEntity result = new ProductionEntity();

                    result.ProductId = row["ProductId"].ToString();
                    result.ProductName = row["ProductName"].ToString();
                    result.ProductionDate = DateOnly.FromDateTime(DateTime.Parse(row["ProductionDate"].ToString()));
                    result.IsQualified = int.Parse(row["IsQualified"].ToString());
                    result.ProdctionLine = row["ProductionLine"].ToString();
                    result.ResponsibleEmployee = row["ResponsibleEmployee"].ToString();

                    resultList.Add(result);
                }

                return resultList;
            }

            return resultList;
        }
    }
}
