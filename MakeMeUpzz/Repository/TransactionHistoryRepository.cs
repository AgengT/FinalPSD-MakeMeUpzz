using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class TransactionHistoryRepository
    {
        private static Database1Entities db = SingletonDatabase.GetInstance();

        public static List<TransactionHeader> GetAllTransactionHistory()
        {
            return db.TransactionHeaders.ToList();
        }

        public static List<TransactionHeader> GetUserTransactionHistory(int userID)
        {
            return db.TransactionHeaders.Where( x=> x.UserID == userID).ToList();
        }

    }
}