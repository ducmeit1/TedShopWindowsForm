using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ted_Shop_System.BO;
using Ted_Shop_System.DTL;

namespace Ted_Shop_System
{
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
        }

        public void LoadDataFromDataTable()
        {
            cartDataGridView.DataSource = GetDataFromCartList();
            DataGridViewButtonColumn addToCartBtn = new DataGridViewButtonColumn();
            addToCartBtn.Text = "Add to cart";
            addToCartBtn.HeaderText = "Add";
            addToCartBtn.Name = "Add";
            addToCartBtn.UseColumnTextForButtonValue = true;
            cartDataGridView.Columns.Insert(0, addToCartBtn);
            DataGridViewButtonColumn removeFromCartBtn = new DataGridViewButtonColumn();
            removeFromCartBtn.Text = "Remove from cart";
            removeFromCartBtn.HeaderText = "Remove";
            removeFromCartBtn.Name = "Remove";
            removeFromCartBtn.UseColumnTextForButtonValue = true;
            cartDataGridView.Columns.Insert(6, removeFromCartBtn);
            cartDataGridView.Columns["SellPrice"].DefaultCellStyle.Format = "#,#";
        }

        public DataTable GetDataFromCartList()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Country", typeof(string));
            dt.Columns.Add("SellPrice", typeof(double));
            dt.Columns.Add("Quantity", typeof(int));

            foreach (Cart c in CartsController.cartList)
            {
                dt.Rows.Add(c.ProductID, c.Name, c.Country, c.SellPrice, c.Quantity);
            }
            return dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cartDataGridView.Columns["Add"].Index)
            {
                int productID = int.Parse(cartDataGridView.CurrentRow.Cells["ProductID"].Value.ToString());
                if (CartsController.AddItemToCart(productID))
                {
                    cartDataGridView.CurrentRow.Cells["Quantity"].Value = CartsController.cartList.Find(x => x.ProductID == productID).Quantity;
                }
                else
                {
                    MessageBox.Show("This item is not enough quantity to buy!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (e.ColumnIndex == cartDataGridView.Columns["Remove"].Index)
            {
                int productID = int.Parse(cartDataGridView.CurrentRow.Cells["ProductID"].Value.ToString());
                if (CartsController.RemoveItemFromCart(productID))
                {
                    cartDataGridView.CurrentRow.Cells["Quantity"].Value = CartsController.cartList.Find(x => x.ProductID == productID).Quantity;
                }
                else
                {
                    cartDataGridView.Rows.RemoveAt(cartDataGridView.CurrentRow.Index);
                }
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (CartsController.cartList.Count > 0)
            {
                CheckoutForm checkoutForm = new CheckoutForm();
                checkoutForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Your cart is empty! You can't checkout.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
