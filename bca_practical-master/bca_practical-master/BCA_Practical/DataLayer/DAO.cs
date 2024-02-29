using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace BCA_Practicals
{

    public static class DAO
    {
        static DAO()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public static string connectionStr = WebConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionStr);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            return con;

        }
        public static int IUD(string sql, SqlParameter[] param, CommandType cmdType)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = cmdType;
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                return cmd.ExecuteNonQuery();

            }
        }
        public static DataTable GetTable(string sql, SqlParameter[] param, CommandType cmdType)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = cmdType;
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;

            }
        }

        public static DataSet GetDataSet(string sql, SqlParameter[] param, CommandType cmdType)
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = cmdType;
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;

            }
        }

        public static DataTable GetTableWithTVP(string sql, SqlParameter[] param, CommandType cmdType, DataSet ds, List<string> paramName)
        {
            DataTable dt = new DataTable();
            SqlParameter sqlPara;
            int i = 0;
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = cmdType;
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                foreach (DataTable dtable in ds.Tables)
                {
                    sqlPara = new SqlParameter();
                    sqlPara.ParameterName = paramName[i];
                    sqlPara.SqlDbType = SqlDbType.Structured;
                    sqlPara.Value = dtable;
                    cmd.Parameters.Add(sqlPara);
                    i++;
                }


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;

            }
        }

    }
}
