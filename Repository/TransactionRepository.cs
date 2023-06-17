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
        public static List<object> GetTransactionByCustomer(int customerId)
        {
            var result = (from th in db.TransactionHeaders
                          join td in db.TransactionDetails on th.TransactionID equals td.TransactionID
                          join c in db.Customers on th.CustomerID equals c.CustomerID
                          join al in db.Albums on td.AlbumID equals al.AlbumID
                          where th.CustomerID == customerId 
                          select new { th.TransactionID, th.TransactionDate, c.CustomerName, al.AlbumImage, al.AlbumName, td.Qty, al.AlbumPrice}).ToList();
            return result.Cast<object>().ToList();

        }

        public static List<TransactionHeader> GetAllTransaction()
        {
            return db.TransactionHeaders.ToList();
        }
    }
}