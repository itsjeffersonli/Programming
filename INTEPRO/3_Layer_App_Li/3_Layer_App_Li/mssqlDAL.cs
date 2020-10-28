using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Intepro.DataAccess
{
    class MssqlDAL
    {
        private const string ConnectionString =
             @"Server= csb-intepro.tcs.com.ph;" + "Database=OTI004_000011907436_3Layer;UID=000011907436;PWD=wL4uL5fZ"; private SqlConnection cn = new SqlConnection(ConnectionString);
        private SqlCommand cmd;

        public void Open()
        {
            cn.Open();
        }
        public void Close()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }
        public void SetSql(string CommandText)
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = CommandText;
        }
        public void AddParameter(string ParamName, object ParamValue)
        {
            cmd.Parameters.AddWithValue(ParamName, ParamValue);
        }
        public void ClearParameters()
        {
            cmd.Parameters.Clear();
        }
        public void Execute()
        {
            cmd.ExecuteNonQuery();
        }
        public DataTable GetData()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
