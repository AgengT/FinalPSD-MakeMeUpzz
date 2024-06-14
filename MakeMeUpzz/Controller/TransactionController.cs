using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class TransactionController
    {
        public static List<TransactionDetail> GetAllTransactionDetail()
        {
            return TransactionDetailHandler.GetAllTransactionDetail();
        }


    }
}