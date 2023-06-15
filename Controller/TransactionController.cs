using KpopZtation_GroupB.Handler;
using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Controller
{
    public class TransactionController
    {
        public static List<object> GetTransactionByCustomer(int customerId)
        {
            return TransactionHandler.GetTransactionByCustomer(customerId);
        }
    }
}