using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ted_Shop_System.DAO
{
    public class DatabaseContext
    {
        public static DataTable GetDataTable(SqlCommand sqlCommand)
        {
            SqlConnection conn = null;
            SqlDataAdapter da = null;
            DataTable dt = null;
            string strConnect = ConfigurationManager.ConnectionStrings["Ted_Shop_System.Properties.Settings.TedShopConnectionString"].ToString();
            try
            {
                conn = new SqlConnection(strConnect);
                da = new SqlDataAdapter();
                sqlCommand.Connection = conn;
                da.SelectCommand = sqlCommand;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return dt;
        }

        public static void RollBackDataCheckout(SqlCommand sqlCommand)
        {
            SqlConnection conn = null;
            SqlTransaction sqlTransaction = null;
            string strConnect = ConfigurationManager.ConnectionStrings["Ted_Shop_System.Properties.Settings.TedShopConnectionString"].ToString();
            try
            {
                conn = new SqlConnection(strConnect);
                conn.Open();
                sqlTransaction = conn.BeginTransaction();
                sqlCommand.Connection = conn;
                sqlCommand.Transaction = sqlTransaction;
                sqlCommand.ExecuteNonQuery();
                sqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                try
                {
                    sqlTransaction.Rollback();
                }
                catch (Exception exRollBack)
                {
                    Console.WriteLine("Error: " + exRollBack.Message);
                }
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
