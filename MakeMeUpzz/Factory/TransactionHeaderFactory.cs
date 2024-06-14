using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader createTH(int transactionID, int userId, DateTime transactionDate, string status)
        {
            return new TransactionHeader
            {
                TransactionID = transactionID,
                UserID = userId,
                TransactionDate = transactionDate,
                Status = status
            };
        }
    }
}