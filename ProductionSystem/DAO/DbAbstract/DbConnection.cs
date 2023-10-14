using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem.DAO.DbAbstract
{
    public abstract class DbConnection
    {
        public abstract void Open();
        public abstract void Close();

        public abstract object GetConnection();
    }
}
