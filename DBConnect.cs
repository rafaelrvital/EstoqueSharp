using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueSharp
{
    internal class DBConnect
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public string myConnection()
        {
            return @"";
        }

        public DataTable GetTable(string qry)
        {
            cn.ConnectionString = myConnection();
            cmd = new SqlCommand(qry, cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
