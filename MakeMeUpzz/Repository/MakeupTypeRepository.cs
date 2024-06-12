using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class MakeupTypeRepository
    {
        public static List<MakeupType> GetAllMakeupType()
        {
            return db.MakeupTypes.ToList();
        }
        private static Database1Entities db = SingletonDatabase.GetInstance();
        public static void InsertMakeupType(MakeupType makeup)
        {
            db.MakeupTypes.Add(makeup);
            db.SaveChanges();
        }

        public static MakeupType GetLastMakeup()
        {
            return db.MakeupTypes.ToList().LastOrDefault();
        }

        public static void UpdateMakeupType(int id, string name)
        {
            MakeupType updateMakeupType = db.MakeupTypes.Find(id);
            updateMakeupType.MakeupTypeName = name;
            db.SaveChanges();
        }

        public static MakeupType GetMakeupTypeById(int id)
        {
            return db.MakeupTypes.Find(id);
        }
        public static void DeleteMakeupType(int id)
        {
            MakeupType makeup = GetMakeupTypeById(id);
            db.MakeupTypes.Remove(makeup);
            db.SaveChanges();
        }
    }
}