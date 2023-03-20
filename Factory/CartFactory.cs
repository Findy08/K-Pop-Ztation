using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Factory
{
    public class CartFactory
    {
        public static Cart CreateCart(Customer customer, Album album, int qty)
        {
            Cart cart = new Cart();
            cart.Customer = customer;
            cart.Album = album;
            cart.Qty = qty;
            return cart;
        }
    }
}