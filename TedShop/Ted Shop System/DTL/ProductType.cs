using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ted_Shop_System.DTL
{
    public class ProductType
    {
        int productTypeID;

        public int ProductTypeID
        {
            get { return productTypeID; }
            set { productTypeID = value; }
        }
        string productTypeName;

        public string ProductTypeName
        {
            get { return productTypeName; }
            set { productTypeName = value; }
        }
    }
}
