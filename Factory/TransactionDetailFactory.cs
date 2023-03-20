using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail CreateTransactionDetail(TransactionHeader transactionHeader, Album album, int qty)
        {
            TransactionDetail td = new TransactionDetail();
            td.TransactionHeader = transactionHeader;
            td.Album = album;
            td.Qty = qty;
            return td;
        }
    }
}