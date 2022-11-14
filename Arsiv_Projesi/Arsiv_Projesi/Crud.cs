using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsiv_Projesi
{
    class Crud
    {
        public static bool ESG(string sql,SqlCommand command)
        {
            if (DatabaseCon.conn.State==System.Data.ConnectionState.Closed)
            {
                DatabaseCon.conn.Open();
            }

            command.Connection = DatabaseCon.conn;
            command.CommandText = sql;
            command.ExecuteNonQuery();

            try
            {
                return true;
            }
            catch 
            {

                return false;
            }
            finally
            {
                DatabaseCon.conn.Close();
            }
        }

        public static DataTable List(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql,DatabaseCon.conn);
            adapter.Fill(dt);

            return dt;
        }

        
    }
}
