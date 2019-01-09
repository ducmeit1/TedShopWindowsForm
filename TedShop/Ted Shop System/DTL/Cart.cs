using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ted_Shop_System.DTL
{
    public class Cart
    {
        int productID;
        string name;
        string country;
        double sellPrice;
        int quantity;

        public int ProductID
        {
            get
            {
                return productID;
            }

            set
            {
                productID = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public double SellPrice
        {
            get
            {
                return sellPrice;
            }

            set
            {
                sellPrice = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
    }
}
