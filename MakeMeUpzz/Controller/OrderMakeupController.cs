using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class OrderMakeupController
    {
        public static void CreateCart(int userId, int makeupId, int quantity)
        {
            string errors = "";
            if(quantity < 1)
            {
                errors += "Quantity must be bigger than 0";
            }

            OrderMakeupHandler.CreateCart(userId, makeupId, quantity);
        }

    }
}