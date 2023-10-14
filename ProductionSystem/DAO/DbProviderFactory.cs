using ProductionSystem.DAO.DbAbstract;
using ProductionSystem.DAO.PostgreSQL;
using ProductionSystem.DAO.SQL;

namespace ProductionSystem.DAO
{
    public static class DbProviderFactory
    {
        public static DbConnection CreateConnection(DatabaseType type)
        {
            switch (type)
            {
                case DatabaseType.SqlServer:
                    return new SqlServerDbConnection();
                case DatabaseType.PostgreSQL:
                    return new NpgsqlDbConnection();
                default:
                    throw new NotSupportedException("Database type not supported");
            }
        }

        public static DbCommand CreateCommand(DatabaseType type)
        {
            switch (type)
            {
                case DatabaseType.SqlServer:
                    return new SqlServerDbCommand();
                case DatabaseType.PostgreSQL:
                    return new NpgsqlDbCommand();
                default:
                    throw new NotSupportedException("Database type not supported");
            }
        }

        public static DbDataAdapter CreateDataAdapter(DatabaseType type)
        {
            switch (type)
            {
                case DatabaseType.SqlServer:
                    return new SqlServerDbDataAdapter();
                case DatabaseType.PostgreSQL:
                    return new NpgsqlDbDataAdapter();
                default:
                    throw new NotSupportedException("Database type not supported");
            }
        }
    }
}
