using KpopZtation_GroupB.Factory;
using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Repository
{
    public class TransactionRepository
    {
        private static KpopZtationDatabaseEntities db = DatabaseSingleton.GetInstance();
        

        // add data
        public static bool CreateTransaction(TransactionHeader transaction)
        {
            
            if(transaction != null)
            {
                db.TransactionHeaders.Add(transaction);
                db.SaveChanges();
                return true;
            }
            return false;
            
        }
        // show data by customer
        // transaction id, transaction date, customer name, album picture, album name, album qty, album price
        public List<TransactionHeader> GetTransactionByCustomer(int customerId)
        {
            return (from th in db.TransactionHeaders where th.CustomerID == customerId select th).ToList();
        }
    }
}