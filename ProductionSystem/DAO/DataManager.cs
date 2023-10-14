using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductionSystem.DAO.DbAbstract;

namespace ProductionSystem.DAO
{
    public class DataManager
    {
        public DataTable GetData(DatabaseType dbType, string query)
        {
            DbConnection connection = DbProviderFactory.CreateConnection(dbType);
            connection.Open();

            DbDataAdapter adapter = DbProviderFactory.CreateDataAdapter(dbType);
            DataTable table = adapter.FillDataSet(query);

            connection.Close();
            return table;
        }

        public void UpdateData(DatabaseType dbType, DataTable table)
        {
            DbDataAdapter adapter = DbProviderFactory.CreateDataAdapter(dbType);
            adapter.UpdateDataSet(table);
        }
    }
}
