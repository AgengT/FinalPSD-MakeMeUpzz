using MakeMeUpzz.Factory;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class MakeupHandler
    {
        public static List<Makeup> GetAllMakeups()
        {
            return MakeupRepository.GetAllMakeups();
        }

        public static void DeleteMakeup(int id)
        {
            MakeupRepository.DeleteMakeup(id);
        }

        public static void InsertMakeup(string name, int price, int weight, int typeID, int brandID)
        {
            Makeup makeup = MakeupFactory.CreateMakeup(GenerateID(), name, price, weight, typeID, brandID);
            MakeupRepository.InsertMakeup(makeup);
        }

        public static void UpdateMakeup(int id, string name, int price, int weight, int typeID, int brandID)
        {

            MakeupRepository.UpdateMakeup(id, name, price, weight, typeID, brandID);
        }

        private static int GenerateID()
        {
            Makeup makeup = MakeupRepository.GetLastMakeup();
            if (makeup == null)
            {
                return 1;
            }
            return makeup.MakeupID + 1;
        }
    }
}