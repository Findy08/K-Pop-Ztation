using KpopZtation_GroupB.Handler;
using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Controller
{
    public class CartController
    {
        public static String validateCart(int qty, int albumStock)
        {
            String response = "";
            // validate qty
            if(qty == -1)
            {
                response = "Quantity must be filled";
            }
            else if(qty > albumStock)
            {
                response = "Quantity cant be more than the stock album";
            }
            return response;
        }

        public static void AddItemToCart(Customer cust, Album alb, int qty)
        {
            CartHandler.CreateCart(cust, alb, qty);
        }

        public static bool CheckOut(int customerId)
        {
            return CartHandler.CheckOut(customerId);
        }

        public static List<object> GetAllCartByCustomerId(int customerId)
        {
            return CartHandler.GetAllCartByCustomerId(customerId);
        }

        // remove individual data in cart
        public static bool RemoveOneCart(int customerId, int albumId)
        {
            return CartHandler.RemoveOneCart(customerId, albumId);
        }

        // find cart by customer id and album id
        public static Cart GetCartByCustomerAndAlbum(int customerId, int albumId)
        {
            return CartHandler.GetCartByCustomerAndAlbum(customerId, albumId);
        }
    }
}