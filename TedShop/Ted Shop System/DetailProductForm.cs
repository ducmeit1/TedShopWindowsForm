using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ted_Shop_System.DTL;
using Ted_Shop_System.BO;

namespace Ted_Shop_System
{
    public partial class DetailProductForm : Form
    {
        public DetailProductForm(Product product)
        {
            InitializeComponent();
            displayProductDetail(product);
        }

        public void displayProductDetail(Product product)
        {
            if (product != null)
            {
                pictureBoxProduct.Load(Application.StartupPath + "\\Images\\" + product.ProductID + ".gif");
                txtProductID.Text = String.Format("{0}", product.ProductID);
                txtProduceCountry.Text = product.Country;
                txtProductName.Text = product.Name;
                txtSellPrice.Text = String.Format("{0:#,#}", product.SellPrice);
                txtUseGuild.Text = product.Guide;
                txtDescription.Text = product.Description;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm();
            if (!CartsController.AddItemToCart(int.Parse(txtProductID.Text)))
            {
                MessageBox.Show("This item is stock out!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cartForm.LoadDataFromDataTable();
                cartForm.ShowDialog();
            }
        }


    }
}
