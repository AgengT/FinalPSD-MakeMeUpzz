using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail createTD(int transactionId, int makeupID, int quantity)
        {
            return new TransactionDetail
            {
                TransactionID = transactionId,
                MakeupID = makeupID,
                Quanitity = quantity
            };
        }
    }
}