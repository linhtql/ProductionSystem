using ProductionSystem.Convert;
using ProductionSystem.DAO;
using ProductionSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem.Service
{
    public class ProductionService : IProductionService
    {
        public List<Production> FindProductionByEmployeeId(string id, String date)
        {
            DataManager dataManager = new DataManager();
            DatabaseType selectedDatabase = DatabaseType.PostgreSQL;

            var productionEntities = new ProductionDAO().FindProductionById(id, date, selectedDatabase);
            ProductionConvert productionConvert = new ProductionConvert();
            List<Production> productions =productionEntities.Select(productionEntity => productionConvert.toProduction(productionEntity)).ToList();

            return productions;
        }

        public Double GetQualityRate(String employeeId, String date)
        {
            var productionList = FindProductionByEmployeeId(employeeId, date);
            int totalRecord = productionList.Count;
            int recordIsNotQualified = 0;

            if (totalRecord == 0)
            {
                return 0;
            }
            foreach (var item in productionList)
            {
                if (item.IsQualified == 0)
                {
                    recordIsNotQualified++;
                }
            }
            double result = ((totalRecord - recordIsNotQualified) / (double)totalRecord) * 100;
            return Math.Round(result);
        }
    }
}
