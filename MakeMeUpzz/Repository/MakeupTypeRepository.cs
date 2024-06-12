using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class MakeupTypeRepository
    {
        private static Database1Entities db = SingletonDatabase.GetInstance();
        public static void InsertMakeupType(MakeupType makeup)
        {
            db.MakeupTypes.Add(makeup);
            db.SaveChanges();
        }

        public static Makeup GetLastMakeup()
        {
            return db.Makeups.ToList().LastOrDefault();
        }
    }
}