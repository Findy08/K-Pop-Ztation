using KpopZtation_GroupB.Factory;
using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Repository
{
    public class CartRepository
    {
        private static KpopZtationDatabaseEntities db = DatabaseSingleton.GetInstance();
        
        // show cart
        public static List<Cart> GetAllCartByCustomerId(int customerId)
        {
            return (from ca in db.Carts where ca.CustomerID == customerId select ca).ToList();
        }

        // add cart
        public static void CreateCart(Customer cust, Album alb, int qty)
        {
            Cart cart = CartFactory.CreateCart(cust, alb, qty);
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        // remove all cart by customer
        public static bool RemoveAllCartByCustomer(List<Cart> cartList)
        {
            if(cartList != null)
            {
                db.Carts.RemoveRange(cartList);
                db.SaveChanges();
                return true;
            }
            return false;
            
        }

        // remove individual data in cart
        public static bool RemoveOneCart(int customerId, int albumId)
        {
            Cart cart = GetCartByCustomerAndAlbum(customerId, albumId);
            if(cart != null)
            {
                db.Carts.Remove(cart);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        // find cart by customer id and album id
        public static Cart GetCartByCustomerAndAlbum(int customerId, int albumId)
        {
            return (from ca in db.Carts where ca.AlbumID == albumId && ca.CustomerID == customerId select ca).FirstOrDefault();
        }
    }
}