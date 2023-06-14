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
    }
}