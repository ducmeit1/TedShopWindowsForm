using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ted_Shop_System.DTL
{
    public class Product
    {
        int productID;
        int productTypeID;
        string name;
        string description;
        string guide;
        string country;
        double price;
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

        public int ProductTypeID
        {
            get
            {
                return productTypeID;
            }

            set
            {
                productTypeID = value;
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

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string Guide
        {
            get
            {
                return guide;
            }

            set
            {
                guide = value;
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

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
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
