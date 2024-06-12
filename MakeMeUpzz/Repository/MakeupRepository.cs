using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class MakeupRepository
    {
        private static Database1Entities db = SingletonDatabase.GetInstance();
        public static List<Makeup> GetAllMakeups()
        {
            return db.Makeups.ToList();
        }

        public static Makeup GetMakeupById(int id)
        {
            return db.Makeups.Find(id);
        }

        public static void DeleteMakeup(int id)
        {
            Makeup makeup = GetMakeupById(id);
            db.Makeups.Remove(makeup);
            db.SaveChanges();
        }

        public static void InsertMakeup(Makeup makeup)
        {
            db.Makeups.Add(makeup);
            db.SaveChanges();
        }

        public static void UpdateMakeup(int id, string name, int price, int weight, int typeID, int brandID)
        {
            Makeup updateMakeup = db.Makeups.Find(id);
            updateMakeup.MakeupName = name;
            updateMakeup.MakeupPrice = price;
            updateMakeup.MakeupWeight = weight;
            updateMakeup.MakeupTypeID = typeID;
            updateMakeup.MakeupBrandID = brandID;
            db.SaveChanges();
        }

        public static Makeup GetLastMakeup()
        {
            return db.Makeups.ToList().LastOrDefault();
        }
    }

}