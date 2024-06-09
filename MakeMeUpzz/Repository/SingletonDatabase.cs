using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class SingletonDatabase
    {
        private static Database1Entities db = null;

        private SingletonDatabase()
        {

        }
        public static Database1Entities GetInstance()
        {
            if(db == null)
            {
                db = new Database1Entities();
            }
            return db;
        }
    }
}