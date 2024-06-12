using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using MakeMeUpzz.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class MakeupController
    {
        public static List<Makeup> GetAllMakeups()
        {
            return MakeupHandler.GetAllMakeups();
        }

        public static void DeleteMakeup(int id)
        {
            MakeupHandler.DeleteMakeup(id);
        }

        public static void InsertMakeup(string name, int price, int weight, int typeID, int brandID)
        {
            MakeupHandler.InsertMakeup(name, price, weight, typeID, brandID);
        }

        public static void UpdateMakeup(int id, string name, int price, int weight, int typeID, int brandID)
        {
            MakeupHandler.UpdateMakeup(id, name, price, weight, typeID, brandID);
        }
    }
}