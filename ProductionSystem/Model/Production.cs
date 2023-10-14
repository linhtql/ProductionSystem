using ProductionSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem.Model
{
    public class Production
    {
        public String ProductId { get; set; }
        public String ProductName { get; set; }
        public DateOnly ProductionDate { get; set; }
        public int IsQualified { get; set; }
        public String ProdctionLine { get; set; }
        public Employee ResponsibleEmployee { get; set; }
        public override string ToString()
        {
            var qualified = IsQualified == 1 ? "Qualified" : "Not Qualified";
            return ProductId + " -  " + ProductName + " -  " + ProductionDate + " -  " + qualified + " -  " + ProdctionLine + " - " + ResponsibleEmployee;
        }
    }
}
