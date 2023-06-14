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
        public static int InsertTransaction(TransactionHeader transaction)
        {
            if (TransactionRepository.CreateTransaction(transaction) == true)
            {
                foreach (TransactionDetail detailTransaction in transaction.TransactionDetails)
                {
                    detailTransaction.Album.AlbumStock -= detailTransaction.Qty;
                }
                return transaction.TransactionDetails.Count;
            }
            return 0;
        }
    }
}