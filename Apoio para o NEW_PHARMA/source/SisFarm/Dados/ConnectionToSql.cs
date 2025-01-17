using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Dados
{
    public class ConnectionToSql
    {
        private readonly string ConnectionString;
        public ConnectionToSql()
        {
            ConnectionString = "Data Source=GHDSE-PC8\\MSSQLSERVERT;Initial Catalog=SistemaFarmaceutico;Integrated Security=True;Trust Server Certificate=True";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
