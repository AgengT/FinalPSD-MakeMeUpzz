using MakeMeUpzz.Factory;
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
    public class MakeupBrandController
    {
        public static List<MakeupBrand> GetAllMakeupBrand()
        {
            return MakeupBrandHandler.GetAllMakeupBrand();
        }
        public static void InsertMakeupBrand(string name, int rating)
        {
            MakeupBrandHandler.InsertMakeupBrand(name, rating);
        }

        public static void UpdateMakeupBrand(int id, string name, int rating)
        {
            MakeupBrandHandler.UpdateMakeupBrand(id, name, rating);
        }

        public static void DeleteMakeupBrand(int id)
        {
            MakeupBrandHandler.DeleteMakeupBrand(id);
        }
    }
}