using Npgsql;
using ProductionSystem.DAO.DbAbstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem.DAO.PostgreSQL
{
    public class NpgsqlDbDataAdapter : DbDataAdapter
    {
        private NpgsqlDataAdapter adapter;

        public override DataTable FillDataSet(string query)
        {
            DataTable table = new DataTable();
            adapter = new NpgsqlDataAdapter(query, "Server=localhost;Port=5432;User Id=postgres;Password=187827187;Database=Database2");
            adapter.Fill(table);
            return table;
        }

        public override void UpdateDataSet(DataTable table)
        {
            adapter.Update(table);
        }
    }
}
