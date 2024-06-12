using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class MakeupBrandRepository
    {
        private static Database1Entities db = SingletonDatabase.GetInstance();
        public static List<MakeupBrand> GetAllMakeupBrand()
        {
            return db.MakeupBrands.ToList();
        }
        public static void InsertMakeupBrand(MakeupBrand makeup)
        {
            db.MakeupBrands.Add(makeup);
            db.SaveChanges();
        }

        public static MakeupBrand GetLastMakeup()
        {
            return db.MakeupBrands.ToList().LastOrDefault();
        }

        public static void UpdateMakeupBrand(int id, string name, int rating)
        {
            MakeupBrand updateMakeupBrand = db.MakeupBrands.Find(id);
            updateMakeupBrand.MakeupBrandName = name;
            updateMakeupBrand.MakeupBrandRating = rating;
            db.SaveChanges();
        }

        public static MakeupBrand GetMakeupBrandById(int id)
        {
            return db.MakeupBrands.Find(id);
        }
        public static void DeleteMakeupBrand(int id)
        {
            MakeupBrand makeup = GetMakeupBrandById(id);
            db.MakeupBrands.Remove(makeup);
            db.SaveChanges();
        }
    }
}