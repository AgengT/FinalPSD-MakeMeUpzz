using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class OrderMakeupRepository
    {
        private static Database1Entities db = SingletonDatabase.GetInstance();

        public static void InsertOrderMakup(Cart order)
        {
            db.Carts.Add(order);
            db.SaveChanges();
        }
        public static Cart GetLastCart()
        {
            return db.Carts.ToList().LastOrDefault();
        }
    }
}