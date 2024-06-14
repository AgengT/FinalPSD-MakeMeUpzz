using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class OrderMakeupFactory
    {
        public static Cart CreateOrderMakeup(int cartId, int userId, int makeupId, int quantity) 
        {
            return new Cart
            {
                CartID = cartId,
                MakeupID = makeupId,
                Quantity = quantity,
                UserID = userId,
            };
        }

        internal static Cart CreateOrderMakeup(int v, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}