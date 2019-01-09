using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ted_Shop_System.DTL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using Ted_Shop_System.BO;

namespace Ted_Shop_System.DAO
{
    public class ProductDAO
    {
        public Product GetProductInformationByName(string productName)
        {
            Product p = null;
            SqlConnection conn = null;
            SqlDataReader dr = null;
            string strConnect = ConfigurationManager.ConnectionStrings["Ted_Shop_System.Properties.Settings.TedShopConnectionString"].ToString();
            try
            {
                conn = new SqlConnection(strConnect);
                SqlCommand sqlCommand = new SqlCommand("SELECT ProductID, ProductTypeID, Name, Description, Guide, Country, Price, SellPrice, Quantity FROM Products WHERE Name = @n");
                sqlCommand.Parameters.AddWithValue("@n", productName);
                sqlCommand.Connection = conn;
                conn.Open();
                dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.Read())
                {
                    p = new Product();
                    p.ProductID = int.Parse(dr["ProductID"].ToString());
                    p.ProductTypeID = int.Parse(dr["ProductTypeID"].ToString());
                    p.Name = dr["Name"].ToString();
                    p.Description = dr["Description"].ToString();
                    p.Guide = dr["Guide"].ToString();
                    p.Country = dr["Country"].ToString();
                    p.Price = double.Parse(dr["Price"].ToString());
                    p.SellPrice = double.Parse(dr["SellPrice"].ToString());
                    p.Quantity = int.Parse(dr["Quantity"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return p;
        }

        public Product GetProductInformationByID(int productID)
        {
            Product p = null;
            SqlConnection conn = null;
            SqlDataReader dr = null;
            string strConnect = ConfigurationManager.ConnectionStrings["Ted_Shop_System.Properties.Settings.TedShopConnectionString"].ToString();
            try
            {
                conn = new SqlConnection(strConnect);
                SqlCommand sqlCommand = new SqlCommand("SELECT ProductID, Name, Country, SellPrice, Quantity FROM Products WHERE ProductID = @id");
                sqlCommand.Parameters.AddWithValue("@id", productID);
                sqlCommand.Connection = conn;
                conn.Open();
                dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.Read())
                {
                    p = new Product();
                    p.ProductID = int.Parse(dr["ProductID"].ToString());
                    p.Name = dr["Name"].ToString();
                    p.Country = dr["Country"].ToString();
                    p.SellPrice = double.Parse(dr["SellPrice"].ToString());
                    p.Quantity = int.Parse(dr["Quantity"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return p;
        }

        public static int GetQuantityOfProduct(int productID)
        {
            string strConnect = ConfigurationManager.ConnectionStrings["Ted_Shop_System.Properties.Settings.TedShopConnectionString"].ToString();
            SqlConnection conn = null;
            SqlDataReader dr = null;
            try
            {
                conn = new SqlConnection(strConnect);
                SqlCommand sqlCommand = new SqlCommand("SELECT Quantity FROM Products WHERE ProductID = @pi");
                sqlCommand.Parameters.AddWithValue("@pi", productID);
                sqlCommand.Connection = conn;
                conn.Open();
                dr = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.Read())
                {
                    return int.Parse(dr["Quantity"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
            return 0;
        }

        public static bool UpdateProductQuantityAfterInsertNewOrder()
        {
            string strConnect = ConfigurationManager.ConnectionStrings["Ted_Shop_System.Properties.Settings.TedShopConnectionString"].ToString();
            SqlConnection conn = null;
            SqlTransaction sqlTransaction = null;
            try
            {
                conn = new SqlConnection(strConnect);
                conn.Open();
                sqlTransaction = conn.BeginTransaction();
                SqlCommand sqlCommand = new SqlCommand();
                for (int i = 0; i < CartsController.cartList.Count; i++)
                {
                    Cart c = CartsController.cartList[i];
                    int currentProductQuantity = GetQuantityOfProduct(c.ProductID);
                    sqlCommand.CommandText += String.Format("UPDATE Products SET Quantity = @q{0} WHERE ProductID = @pi{0};", i);
                    sqlCommand.Parameters.AddWithValue(String.Format("@q{0}", i), currentProductQuantity - c.Quantity);
                    sqlCommand.Parameters.AddWithValue(String.Format("@pi{0}", i), c.ProductID);        
                }
                Console.WriteLine(sqlCommand.CommandText);
                sqlCommand.Connection = conn;
                sqlCommand.Transaction = sqlTransaction;
                sqlCommand.ExecuteNonQuery();
                sqlTransaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                try
                {
                    sqlTransaction.Rollback();
                } catch (Exception exRollback)
                {
                    Console.WriteLine("Error: " + exRollback.Message);
                }
                Console.WriteLine("Error ProductDAO: " + ex.Message);
                return false;
            } finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
