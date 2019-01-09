using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ted_Shop_System.DTL
{
    public class OrderDetail
    {
        int orderDetailID;

        public int OrderDetailID
        {
            get { return orderDetailID; }
            set { orderDetailID = value; }
        }
        int orderID;

        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
        int productID;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
