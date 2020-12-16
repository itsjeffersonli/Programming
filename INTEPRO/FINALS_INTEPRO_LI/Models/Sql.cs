using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace SqlDataAccess
{
    public class Sql
    {
        private const string ConnectionString = @"Server=DESKTOP-A1M8536\SQLEXPRESS;" + "Database=INTEPROFINALS; UID=Jeff;PWD=asd040215";
        private SqlConnection cn = new SqlConnection(ConnectionString);
        private SqlCommand cmd;


        public void Open()
        {
            if (cn.State == ConnectionState.Closed)
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
        public void clear()
        {
            cmd.Parameters.Clear();
        }
        public void Execute()
        {
            cmd.ExecuteNonQuery();
        }
        public DataTable getdata()
        {
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = cmd;
            DataTable dt = new DataTable();
            DA.Fill(dt);
            return dt;
        }

        public SqlDataReader GetReader()
        {
            return cmd.ExecuteReader();
        }
    }
}