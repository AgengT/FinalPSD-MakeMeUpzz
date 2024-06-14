using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class TransactionHistoryController
    {
        public static List<TransactionHeader> GetAllTransactionHistory()
        {
            return TransactionHistoryHandler.GetAllTransactionHistory();
        }

        public static List<TransactionHeader> GetUserTransactionHistory(int userID)
        {
            return TransactionHistoryHandler.GetUserTransactionHistory(userID);
        }
    }
}