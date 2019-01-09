using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Ted_Shop_System.DAO
{
    public class OrderDetailDAO
    {
        public static bool InsertOrderDetail(DataTable dt)
        {
            string strConnect = ConfigurationManager.ConnectionStrings["Ted_Shop_System.Properties.Settings.TedShopConnectionString"].ToString();
            SqlConnection conn = null;
            SqlTransaction sqlTransaction = null;
            SqlBulkCopy bulkCopy = null;
            try
            {
                conn = new SqlConnection(strConnect);
                conn.Open();
                sqlTransaction = conn.BeginTransaction();
                bulkCopy = new SqlBulkCopy(conn, SqlBulkCopyOptions.Default, sqlTransaction);
                bulkCopy.DestinationTableName = "OrderDetails";
                bulkCopy.WriteToServer(dt);
                sqlTransaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                try
                {
                    sqlTransaction.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine("Error OrderDetailDAO: " + exRollback.Message);
                }
                Console.WriteLine("Error OrderDetailDAO: " + ex.Message);
            }
            finally
            {
                if (bulkCopy != null)
                {
                    bulkCopy.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return false;
        }

        public static int CountOrderDetail()
        {
            SqlConnection conn = null;
            SqlDataReader dr = null;
            string strConnect = ConfigurationManager.ConnectionStrings["Ted_Shop_System.Properties.Settings.TedShopConnectionString"].ToString();
            try
            {
                conn = new SqlConnection(strConnect);
                SqlCommand sqlCommand = new SqlCommand("SELECT IDENT_CURRENT('OrderDetails') AS OrderDetailID", conn);
                conn.Open();
                dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.Read())
                {
                    return int.Parse(dr["OrderDetailID"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return -1;
        }
    }
}
