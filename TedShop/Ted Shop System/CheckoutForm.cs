using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ted_Shop_System.BO;
using Ted_Shop_System.DTL;
using Ted_Shop_System.DAO;
using System.Data.SqlClient;

namespace Ted_Shop_System
{
    public partial class CheckoutForm : Form
    {
        public CheckoutForm()
        {
            InitializeComponent();
            txtTotalAmount.Text = String.Format("{0:#,#}", LoadTotalAmount());
        }

        public double LoadTotalAmount()
        {
            double totalAmount = 0;
            foreach (Cart c in CartsController.cartList)
            {
                totalAmount += c.Quantity * c.SellPrice;
            }
            return totalAmount;

        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }
            Order order = new Order();
            order.Name = txtCustomerName.Text.Trim();
            order.OrderDate = orderDatePicker.Value;
            order.Total = LoadTotalAmount();
            order.Phone = txtCustomerPhone.Text.Trim();
            order.Address = txtCustomerAddress.Text.Trim();
            bool isOrdered = false;
            if (OrderDAO.InsertNewOrder(order))
            {
                int orderID = OrderDAO.FindOrderID();
                Console.WriteLine("Order ID = " + orderID);
                if (OrderDetailDAO.InsertOrderDetail(GetOrderDetailsDataTable(orderID)))
                {
                    if (ProductDAO.UpdateProductQuantityAfterInsertNewOrder())
                    {
                        MessageBox.Show("An order is added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CartsController.cartList.Clear();
                        Close(); //Close This Form.
                        Application.OpenForms["CartForm"].Close();
                        Application.OpenForms["DetailProductForm"].Close();
                        isOrdered = true;

                    }
                }
                if (isOrdered == false)
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText += "DELETE FROM OrderDetails WHERE OrderID = @id;";
                    sqlCommand.CommandText += "DELETE FROM Orders WHERE OrderID = @id;";
                    sqlCommand.Parameters.AddWithValue("@id", orderID);
                    DatabaseContext.RollBackDataCheckout(sqlCommand);
                    MessageBox.Show("Checkout is failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool ValidateData()
        {
            if (txtCustomerName.Text.Trim() == "")
            {
                MessageBox.Show("Customer Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerName.Focus();
                return false;
            }
            if (txtCustomerAddress.Text.Trim() == "")
            {
                MessageBox.Show("Customer Address is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerAddress.Focus();
                return false;
            }
            if (txtCustomerPhone.Text.Trim() == "")
            {
                MessageBox.Show("Customer Phone is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerPhone.Focus();
                return false;
            }
            if (txtCustomerPhone.Text.Trim() != "")
            {
                Regex r = new Regex("^\\d{10,15}$");
                if (!r.Match(txtCustomerPhone.Text.Trim()).Success)
                {
                    MessageBox.Show("Customer Phone must be numberic and length from 10 - 15 numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerPhone.Focus();
                    return false;
                }
            }
            return true;
        }

        public DataTable GetOrderDetailsDataTable(int OrderID)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("OrderDetailID", typeof(int));
            dt.Columns.Add("OrderID", typeof(int));
            dt.Columns.Add("ProductID", typeof(int));
            dt.Columns.Add("Quantity", typeof(int));
            int OrderDetailID = OrderDetailDAO.CountOrderDetail();
            foreach (Cart c in CartsController.cartList)
            {
                dt.Rows.Add(OrderDetailID + 1, OrderID, c.ProductID, c.Quantity);
            }
            
            return dt;
        }
    }
}
