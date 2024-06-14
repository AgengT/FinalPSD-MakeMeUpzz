using MakeMeUpzz.Factory;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MakeMeUpzz.Handler
{
    public class OrderMakeupHandler
    {
        public static void CreateCart(int userID, int makeupID, int quantity)
        {
            Cart newCart = OrderMakeupFactory.CreateOrderMakeup(GenerateID(), userID,makeupID, quantity);
            OrderMakeupRepository.InsertOrderMakup(newCart);
        }

        private static int GenerateID()
        {
            Cart newCart = OrderMakeupRepository.GetLastCart();
            if (newCart == null)
            {
                return 1;
            }
            return newCart.CartID + 1;
        }
    }
}