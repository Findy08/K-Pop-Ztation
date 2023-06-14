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
        // data
        // transaction header
        // transactionId int, transactionDate date, CustomerID int
        // transaction detail
        // transactionId int, albumId int, qty int

        // add data
        public static void CreateTransaction(Customer cust, List<Cart> carts)
        {
            // create transaction detail
            List<TransactionDetail> tdList = new List<TransactionDetail>();
            foreach(Cart cart in carts)
            {
                TransactionDetail td = TransactionDetailFactory.CreateTransactionDetail(cart);
                tdList.Add(td);
                db.TransactionDetails.Add(td);
                db.SaveChanges();
            }
            // create transaction header
            TransactionHeader th = TransactionHeaderFactory.CreateTransactionHeader(DateTime.Now, cust, tdList);
            // insert to db
            db.TransactionHeaders.Add(th);
            db.SaveChanges();
            
        }
        // show data by customer
        // transaction id, transaction date, customer name, album picture, album name, album qty, album price
        public List<TransactionHeader> GetTransactionByCustomer(int customerId)
        {
            return (from th in db.TransactionHeaders where th.CustomerID == customerId select th).ToList();
        }
    }
}