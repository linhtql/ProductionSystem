using ProductionSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem.Service
{
    public interface IProductionService
    {
        public List<Production> FindProductionByEmployeeId(String employeeId, String date);
        public Double GetQualityRate(String employeeId, String date);
    }
}
