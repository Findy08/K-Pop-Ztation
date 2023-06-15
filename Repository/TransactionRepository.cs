using KpopZtation_GroupB.Factory;
using KpopZtation_GroupB.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KpopZtation_GroupB.Repository
{
    public class TransactionRepository
    {
        private static KpopDatabaseEntities db = DatabaseSingleton.GetInstance();
        

        // add data
        public static TransactionHeader CreateTransactionHeader(Customer cust)
        {
            TransactionHeader th = TransactionFactory.CreateTransactionHeader(cust);
            db.TransactionHeaders.Add(th);
            db.SaveChanges();
            return th;
        }

        public static void CreateTransactionDetail(TransactionHeader th, Album album, int qty)
        {
            TransactionDetail td = TransactionFactory.CreateTransactionDetail(th, album, qty);
            td.TransactionID = th.TransactionID;
            td.AlbumID = album.AlbumID;
            db.TransactionDetails.Add(td);
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