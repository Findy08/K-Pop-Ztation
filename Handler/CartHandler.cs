using KpopZtation_GroupB.Factory;
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
            Customer customer = CustomerHandler.GetCustomerById(customerId);
            // hapus semua cart customer ini
            List<Cart> cart = CartRepository.GetAllCartByCustomerIdPure(customerId);
            if(cart.Count > 0)
            {
                List<TransactionDetail> td = new List<TransactionDetail>();
                foreach(Cart c in cart)
                {
                    // ubah jadi transaction detail
                    TransactionDetail temp = new TransactionDetail();
                    temp.AlbumID = c.AlbumID;
                    temp.Qty = c.Qty;

                    td.Append(temp);
                }
                TransactionHeader transaction = TransactionHeaderFactory.CreateTransactionHeader(DateTime.Now, customer, td);
                // insert to transaction history
                TransactionHandler.InsertTransaction(transaction);
                // delete all cart from this customer
                CartRepository.RemoveAllCartByCustomer(cart);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static List<object> GetAllCartByCustomerId(int customerId)
        {
            return CartRepository.GetAllCartByCustomerId(customerId);
        }

        // add cart
        public static void CreateCart(Customer cust, Album alb, int qty)
        {
            // search by cust and alb first
            Cart item = GetCartByCustomerAndAlbum(cust.CustomerID, alb.AlbumID);
            // if exist, add the qty to the item
            if(item != null)
            {
                // update the cart qty
                CartRepository.UpdateCartQuantity(item, qty);
            }
            else
            {
                // if not exist, create new item to cart
                CartRepository.CreateCart(cust, alb, qty);
            }
            
        }


        // remove individual data in cart
        public static bool RemoveOneCart(int customerId, int albumId)
        {
            return CartRepository.RemoveOneCart(customerId, albumId);
        }

        // find cart by customer id and album id
        public static Cart GetCartByCustomerAndAlbum(int customerId, int albumId)
        {
            return CartRepository.GetCartByCustomerAndAlbum(customerId, albumId);
        }
    }
}