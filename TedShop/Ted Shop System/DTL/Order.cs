using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ted_Shop_System.DTL
{
    public class Order
    {
        int orderID;

        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
        DateTime orderDate;

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        int staffID;

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }
        DateTime deliverDate;

        public DateTime DeliverDate
        {
            get { return deliverDate; }
            set { deliverDate = value; }
        }
    }
}
