
using System.Data.SqlClient;
using ProductionSystem.DAO.DbAbstract;

namespace ProductionSystem.DAO.SQL
{
    public class SqlServerDbCommand : DbCommand
    {
        private SqlCommand command;
        public override void Execute()
        {
            command.ExecuteNonQuery();
        }

        public override void SetConnection(DbConnection connection)
        {
            command = new SqlCommand();
            command.Connection = (SqlConnection)connection.GetConnection();
        }

        public override void SetQuery(string query)
        {
            command.CommandText = query;
        }
    }
}
