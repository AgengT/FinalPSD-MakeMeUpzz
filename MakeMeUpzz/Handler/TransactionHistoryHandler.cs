using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class TransactionHistoryHandler
    {
        public static List<TransactionHeader> GetAllTransactionHistory()
        {
            return TransactionHistoryRepository.GetAllTransactionHistory();
        }

        public static List<TransactionHeader> GetUserTransactionHistory(int userID)
        {
            return TransactionHistoryRepository.GetUserTransactionHistory(userID);
        }

    }
}