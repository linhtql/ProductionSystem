
using Npgsql;
using ProductionSystem.DAO.DbAbstract;

namespace ProductionSystem.DAO.PostgreSQL
{
    public class NpgsqlDbCommand : DbCommand
    {
        private NpgsqlCommand command;

        public override void SetConnection(DbConnection connection)
        {
            command = new NpgsqlCommand();
            command.Connection = (NpgsqlConnection)connection.GetConnection();
        }

        public override void SetQuery(string query)
        {
            command.CommandText = query;
        }

        public override void Execute()
        {
            command.ExecuteNonQuery();
        }
    }
}
