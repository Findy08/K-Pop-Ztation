using KpopZtation_GroupB.Model;
using KpopZtation_GroupB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Handler
{
    public class CartHandler
    {
        public static bool CheckOut(int customerId)
        {
            // hapus semua cart customer ini
            List<Cart> cart = GetAllCartByCustomerId(customerId);
            if(cart.Count > 0)
            {
                // insert to transaction history

                // delete all cart from this customer
                CartRepository.RemoveAllCartByCustomer(cart);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static List<Cart> GetAllCartByCustomerId(int customerId)
        {
            return CartRepository.GetAllCartByCustomerId(customerId);
        }

        // add cart
        public static void CreateCart(Customer cust, Album alb, int qty)
        {
            CartRepository.CreateCart(cust, alb, qty);
        }


        // remove individual data in cart
        public static bool RemoveOneCart(int customerId, int albumId)
        {
            return CartRepository.RemoveOneCart(customerId, albumId);
        }

        // find cart by customer id and album id
        public static Cart GetCartByCustomerAndAlbum(int customerId, int albumId)
        {
            return GetCartByCustomerAndAlbum(customerId, albumId);
        }
    }
}