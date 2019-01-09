using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ted_Shop_System.DTL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Ted_Shop_System.DAO
{
    public class OrderDAO
    {
        public static bool InsertNewOrder(Order o)
        {
            string strConnect = ConfigurationManager.ConnectionStrings["Ted_Shop_System.Properties.Settings.TedShopConnectionString"].ToString();
            SqlConnection conn = null;
            SqlTransaction sqlTransaction = null;
            try
            {
                conn = new SqlConnection(strConnect);
                conn.Open();
                sqlTransaction = conn.BeginTransaction();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Orders (OrderDate, Name, Address, Phone, Total) VALUES (@od, @n, @a, @p, @t)", conn, sqlTransaction);
                sqlCommand.Parameters.AddWithValue("@od", o.OrderDate);
                sqlCommand.Parameters.AddWithValue("@n", o.Name);
                sqlCommand.Parameters.AddWithValue("@a", o.Address);
                sqlCommand.Parameters.AddWithValue("@p", o.Phone);
                sqlCommand.Parameters.AddWithValue("@t", o.Total);
                sqlCommand.ExecuteNonQuery();
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
                    Console.WriteLine("Error OrderDAO: " + exRollback.Message);
                }
                Console.WriteLine("Error OrderDAO: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public static int FindOrderID()
        {
            SqlConnection conn = null;
            SqlDataReader dr = null;
            string strConnect = ConfigurationManager.ConnectionStrings["Ted_Shop_System.Properties.Settings.TedShopConnectionString"].ToString();
            try
            {
                conn = new SqlConnection(strConnect);
                SqlCommand sqlCommand = new SqlCommand("SELECT IDENT_CURRENT('Orders') AS OrderID", conn);
                conn.Open();
                dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.Read())
                {
                    return int.Parse(dr["OrderID"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            } finally
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

        public static bool UpdateDeliveryInformation(int orderID, int staffID, DateTime deliverDate)
        {
            string strConnect = ConfigurationManager.ConnectionStrings["Ted_Shop_System.Properties.Settings.TedShopConnectionString"].ToString();
            SqlConnection conn = null;
            SqlTransaction sqlTransaction = null;
            try
            {
                conn = new SqlConnection(strConnect);
                conn.Open();
                sqlTransaction = conn.BeginTransaction();
                SqlCommand sqlCommand = new SqlCommand("UPDATE Orders SET StaffID = @si, DeliverDate = @dd WHERE OrderID = @oi", conn, sqlTransaction);
                sqlCommand.Parameters.AddWithValue("@si", staffID);
                sqlCommand.Parameters.AddWithValue("@dd", deliverDate);
                sqlCommand.Parameters.AddWithValue("@oi", orderID);
                sqlCommand.ExecuteNonQuery();
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
                    Console.WriteLine("Error OrderDAO: " + exRollback.Message);
                }
                Console.WriteLine("Error OrderDAO: " + ex.Message);
                return false;
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
