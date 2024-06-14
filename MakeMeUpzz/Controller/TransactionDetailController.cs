using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class TransactionDetailController
    {
        public static List<TransactionDetail> GetAllTransactionDetail()
        {
            return TransactionDetailHandler.GetAllTransactionDetail();        
        }
        public static List<TransactionDetail> GetTransactionDetail(int transactionID)
        {
            return TransactionDetailHandler.GetTransactionDetail(transactionID);
        }
    }
}