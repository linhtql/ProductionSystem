using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem.Entity
{
    public class ProductionEntity
    {
        public String ProductId { get; set; }
        public String ProductName { get; set; }
        public DateOnly ProductionDate { get; set; }
        public int IsQualified { get; set; }
        public String ProdctionLine { get; set; }
        public String ResponsibleEmployee { get; set; }
    }
}
