using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader CreateTransactionHeader(DateTime date, Customer customer)
        {
            TransactionHeader th = new TransactionHeader();
            th.TransactionDate = date;
            th.Customer = customer;
            return th;

        }
    }
}