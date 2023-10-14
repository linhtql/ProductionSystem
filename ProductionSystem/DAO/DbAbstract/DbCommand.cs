using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem.DAO.DbAbstract
{
    public abstract class DbCommand
    {
        public abstract void SetConnection(DbConnection connection);
        public abstract void SetQuery(string query);
        public abstract void Execute();
    }
}
