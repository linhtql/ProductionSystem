using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem.DAO.DbAbstract
{
    public abstract class DbDataAdapter
    {
        public abstract DataTable FillDataSet(string query);
        public abstract void UpdateDataSet(DataTable table);
    }
}
