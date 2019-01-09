using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ted_Shop_System.DTL;
using Ted_Shop_System.DAO;

namespace Ted_Shop_System.BO
{
    public class CartsController
    {
        public static List<Cart> cartList = new List<Cart>();

        public List<Cart> CartList
        {
            get
            {
                return cartList;
            }

            set
            {
                cartList = value;
            }
        }

        public static bool AddItemToCart(int productID)
        {
            Cart c1 = cartList.Find(x => x.ProductID == productID);
            Product p = new ProductDAO().GetProductInformationByID(productID);
            if (p.Quantity == 0) return false;
            if (c1 != null && c1.Quantity < p.Quantity) c1.Quantity++;
            else if (c1 != null && c1.Quantity >= p.Quantity) return false;
            else
            {
                Cart c = new Cart();
                c.ProductID = p.ProductID;
                c.Name = p.Name;
                c.Country = p.Country;
                c.SellPrice = p.SellPrice;
                c.Quantity = 1;
                cartList.Add(c);
            }
            return true;
        }

        public static bool RemoveItemFromCart(int productID)
        {
            Cart c1 = cartList.Find(x => x.ProductID == productID);
            if (c1 != null)
            {
                c1.Quantity = c1.Quantity - 1;
                if (c1.Quantity <= 0)
                {
                    cartList.Remove(c1);
                    return false;
                }
            }
            return true;
        }
    }
}
