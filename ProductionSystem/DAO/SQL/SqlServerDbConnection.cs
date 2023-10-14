using Microsoft.Extensions.Configuration;
using ProductionSystem.DAO.DbAbstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem.DAO.SQL
{
    public class SqlServerDbConnection : DbConnection
    {
        private SqlConnection connection;
        public override void Close()
        {
            connection.Close();
        }

        public override object GetConnection()
        {
            return connection;
        }

        public override void Open()
        {
            connection = new SqlConnection("Data Source=DESKTOP-4QBB7GD;Initial Catalog=Database1;User ID=sa;Password=68686868");
            connection.Open();
        }
    }
}
