using KpopZtation_GroupB.Model;
using KpopZtation_GroupB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Handler
{
    public class TransactionHandler
    {
        public static List<object> GetTransactionByCustomer(int customerId)
        {
            return TransactionRepository.GetTransactionByCustomer(customerId);
        }
    }
}