using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Factory
{
    public class TransactionFactory
    {

        public static TransactionHeader CreateTransactionHeader(Customer cust)
        {
            TransactionHeader th = new TransactionHeader();
            th.TransactionDate = DateTime.Now;
            th.Customer = cust;
            return th;
        }

        public static TransactionDetail CreateTransactionDetail(TransactionHeader th, Album album, int qty)
        {
            TransactionDetail td = new TransactionDetail();
            td.TransactionHeader = th;
            td.Album = album;
            td.Qty = qty;
            return td;
        }
    }

}