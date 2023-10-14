using ProductionSystem.Entity;
using ProductionSystem.Model;
using ProductionSystem.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem.Convert
{
    public class ProductionConvert
    {
        public Production toProduction(ProductionEntity entity)
        {
            var result = new Production();
            result.ProductId = entity.ProductId;
            result.ProductName = entity.ProductName;
            result.ProductionDate = entity.ProductionDate;  
            result.ProdctionLine = entity.ProdctionLine;    
            result.IsQualified = entity.IsQualified;
            
            result.ResponsibleEmployee = new EmployeeService().FindById(entity.ResponsibleEmployee);

            return result;
        }
    }
}
