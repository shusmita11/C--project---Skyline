using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyline
{
    
    static class DataAccess
    {
        static string conString = @"Data Source=DESKTOP-TSEM9H4\SQLEXPRESS;Initial Catalog=SKYLINE_DB;Integrated Security=True";

        public static void ExecuteData(string query, out string err)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                con.Close();
                err = "";
            }
            catch(Exception ex)
            {
                err = ex.Message;
            }
        }

        public static DataTable GetData(string query, out string err)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = new DataTable();
                dt = ds.Tables[0];

                con.Close();
                err = "";
                return dt;
            }
            catch(Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
    }
}
