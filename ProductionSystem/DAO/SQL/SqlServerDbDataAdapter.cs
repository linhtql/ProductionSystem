using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductionSystem.DAO.DbAbstract;

namespace ProductionSystem.DAO.SQL
{
    public class SqlServerDbDataAdapter : DbDataAdapter
    {
        private SqlDataAdapter adapter;
        public override DataTable FillDataSet(string query)
        {
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(query, "Data Source=DESKTOP-4QBB7GD;Initial Catalog=Database1;User ID=sa;Password=68686868");
            adapter.Fill(table);
            return table;
        }

        public override void UpdateDataSet(DataTable table)
        {
            adapter.Update(table);
        }
    }
}
