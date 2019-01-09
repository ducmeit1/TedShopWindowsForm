using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Ted_Shop_System.DTL;
using Ted_Shop_System.DAO;

namespace Ted_Shop_System
{
    public partial class TedShopSystemForm : Form
    {

        public TedShopSystemForm()
        {
            InitializeComponent();
        }

        private void toolStripOrder_Click(object sender, EventArgs e)
        {
            ShowListProductPanel();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowListProductPanel();
        }

        private void ShowListProductPanel()
        {
            if (listProductPanel.Visible == false)
            {
                listProductPanel.Visible = true;
                deliveryPanel.Visible = false;
                reportPanel.Visible = false;
            }
        }

        private void GetAllProductTypeName()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT ProductTypeID, ProductTypeName FROM ProductTypes");
            cbbProductType.DataSource = DatabaseContext.GetDataTable(sqlCommand);
            cbbProductType.ValueMember = "ProductTypeName";
            cbbProductType.DisplayMember = "ProductTypeName";
            cbbProductType.SelectedIndex = 0;
        }

        private void cbbProductType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbProductType.Text != null)
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT p.Name, p.Country, p.SellPrice FROM Products p, ProductTypes p1 WHERE p1.ProductTypeName = @p AND p1.ProductTypeID = p.ProductTypeID");
                sqlCommand.Parameters.AddWithValue("@p", cbbProductType.Text);
                dataGridViewProducts.DataSource = DatabaseContext.GetDataTable(sqlCommand);
                dataGridViewProducts.Columns["SellPrice"].DefaultCellStyle.Format = "#,#";
                lblListOfProducts.Text = "List of Products: " + dataGridViewProducts.Rows.Count;
                dataGridViewProducts.ClearSelection();
                btnDetail.Enabled = false;
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            string productName = dataGridViewProducts.CurrentRow.Cells["Name"].Value.ToString();
            Product p = new ProductDAO().GetProductInformationByName(productName);
            if (p != null)
            {
                DetailProductForm dpf = new DetailProductForm(p);
                dpf.ShowDialog(this);
            }
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDetail.Enabled = true;
        }

        private void toolStripDelivery_Click(object sender, EventArgs e)
        {
            ShowDeliveryPanel();
        }

        public void ShowDeliveryPanel()
        {
            if (deliveryPanel.Visible == false)
            {
                listProductPanel.Visible = false;
                deliveryPanel.Visible = true;
                reportPanel.Visible = false;
            }
        }

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDeliveryPanel();
        }

        private void LoadDeliveryOrderWattingForDelivering()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT OrderID, OrderDate, Name, Total FROM Orders WHERE DeliverDate IS NULL AND StaffID IS NULL");
            deliveryDataGridView.DataSource = DatabaseContext.GetDataTable(sqlCommand);
            deliveryDataGridView.Columns["Total"].DefaultCellStyle.Format = "#,#";
            deliveryDataGridView.Columns["OrderDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            deliveryDataGridView.ClearSelection();
        }

        private void LoadStaffData()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT StaffID, Name FROM Staffs WHERE IsManager = @im");
            sqlCommand.Parameters.AddWithValue("@im", 1);
            cbbStaffName.DataSource = DatabaseContext.GetDataTable(sqlCommand);
            cbbStaffName.ValueMember = "StaffID";
            cbbStaffName.DisplayMember = "Name";
            cbbStaffName.SelectedIndex = 0;
        }

        private void deliveryPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (deliveryPanel.Visible == true)
            {
                LoadDeliveryOrderWattingForDelivering();
                LoadStaffData();
            }
        }

        private void listProductPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (listProductPanel.Visible == true)
            {
                GetAllProductTypeName();
            }
        }

        private void btnCancelDeliver_Click(object sender, EventArgs e)
        {
            deliveryDataGridView.ClearSelection();
            btnDeliver.Enabled = false;
            btnCancelDeliver.Enabled = false;
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            int orderID = int.Parse(deliveryDataGridView.CurrentRow.Cells["OrderID"].Value.ToString());
            DateTime deliverDate = deliverDateTimePicker.Value;
            int staffID = int.Parse(cbbStaffName.SelectedValue.ToString());
            if (OrderDAO.UpdateDeliveryInformation(orderID, staffID, deliverDate))
            {
                deliveryDataGridView.Rows.RemoveAt(deliveryDataGridView.CurrentRow.Index);
                MessageBox.Show("This order is delivered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDeliver.Enabled = false;
                btnCancelDeliver.Enabled = false;
            }
            else
            {
                MessageBox.Show("Delivery failed! Please contact to Administrator.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deliveryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeliver.Enabled = true;
            btnCancelDeliver.Enabled = true;
        }

        private void deliveryDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblListOfOrderWaitingForDelivering.Text = "List of Order Waiting For Delivering: " + deliveryDataGridView.Rows.Count;
        }

        private void toolStripReport_Click(object sender, EventArgs e)
        {
            ShowReportPanel();
        }

        private void ShowReportPanel()
        {
            if (reportPanel.Visible == false)
            {
                soldProductsDataGridView.ClearSelection();
                reportPanel.Visible = true;
                deliveryPanel.Visible = false;
                listProductPanel.Visible = false;
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowReportPanel();
        }

        private void reportSelectDateTimeCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime startDate = reportSelectDateTimeCalendar.SelectionStart.Date;
            DateTime endDate = reportSelectDateTimeCalendar.SelectionEnd.Date;
            SqlCommand sqlCommand = new SqlCommand("SELECT p.Name, p.Price, p.SellPrice, od.Quantity, (p.SellPrice * od.Quantity) - (p.Price * od.Quantity) AS Benifit, o.DeliverDate "
                                                 + "FROM Products p, OrderDetails od, Orders o "
                                                 + "WHERE p.ProductID = od.ProductID AND o.OrderID = od.OrderID AND o.DeliverDate IS NOT NULL "
                                                 + "AND o.DeliverDate >= @sd AND o.DeliverDate <= @ed");
            sqlCommand.Parameters.AddWithValue("@sd", startDate);
            sqlCommand.Parameters.AddWithValue("@ed", endDate);
            soldProductsDataGridView.DataSource = DatabaseContext.GetDataTable(sqlCommand);
            soldProductsDataGridView.Columns["Price"].DefaultCellStyle.Format = "#,#";
            soldProductsDataGridView.Columns["SellPrice"].DefaultCellStyle.Format = "#,#";
            soldProductsDataGridView.Columns["Benifit"].DefaultCellStyle.Format = "#,#";
            soldProductsDataGridView.Columns["DeliverDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            soldProductsDataGridView.ClearSelection();
        }

        private void soldProductsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            DataTable dt = (DataTable)soldProductsDataGridView.DataSource;
            if (dt.Rows.Count > 0)
            {
                lblAmountReport.Text = String.Format("{0:#,#}", dt.Compute("SUM(Benifit)", ""));
            } else
            {
                lblAmountReport.Text = "0";
            }
        }
    }
}
