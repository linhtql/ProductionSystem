using Npgsql;
using ProductionSystem.DAO.DbAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem.DAO.PostgreSQL
{
    public class NpgsqlDbConnection : DbConnection
    {
        private NpgsqlConnection connection;

        public override void Open()
        {
            connection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=187827187;Database=Database2");
            connection.Open();
        }

        public override void Close()
        {
            connection.Close();
        }

        public override object GetConnection()
        {
            return connection;
        }
    }
}
