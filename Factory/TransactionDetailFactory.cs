using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail CreateTransactionDetail(Cart cart)
        {
            TransactionDetail td = new TransactionDetail();
            td.Album = cart.Album;
            td.Qty = cart.Qty;
            return td;
        }
    }
}