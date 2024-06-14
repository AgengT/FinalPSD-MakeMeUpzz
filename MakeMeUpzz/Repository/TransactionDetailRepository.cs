using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class TransactionDetailRepository
    {
        private static Database1Entities db = SingletonDatabase.GetInstance();

        public static List<TransactionDetail> GetAllTransactionDetail()
        {
            return db.TransactionDetails.ToList();
        }

        public static List<TransactionDetail> GetTransactionDetail(int transactionID)
        {
            return db.TransactionDetails.Where(x =>  x.TransactionID == transactionID).ToList();
        }
    }
}