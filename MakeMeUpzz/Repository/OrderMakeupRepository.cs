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
        public static List<Cart> GetCartsByUserID(int userID)
        {
            return db.Carts.Where(x => x.UserID == userID).ToList();
        }
        public static void saveTransactionHeader(TransactionHeader transactionHeader)
        {
            db.TransactionHeaders.Add(transactionHeader);
            db.SaveChanges();
        }

        public static void saveTransactionDetail(TransactionDetail transactionDetail)
        {
            db.TransactionDetails.Add(transactionDetail);
            db.SaveChanges();
        }

        public static void removeCart(Cart cart)
        {
            db.Carts.Remove(cart);
            db.SaveChanges();
        }
    }
}