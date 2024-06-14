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
            string errors = "";
            if(string.IsNullOrEmpty(name) || name.Length < 1 || name.Length > 99)
            {
                errors += "name Input is not valid must be between 1 and 99 characters";
            }
            if(rating < 1 || rating > 100)
            {
                errors += "rating must be between 0-100";
            }

            MakeupBrandHandler.InsertMakeupBrand(name, rating);
        }

        public static void UpdateMakeupBrand(int id, string name, int rating)
        {
            string errors = "";
            if (string.IsNullOrEmpty(name) || name.Length < 1 || name.Length > 99)
            {
                errors += "name Input is not valid must be between 1 and 99 characters";
            }
            if (rating < 1 || rating > 100)
            {
                errors += "rating must be between 0-100";
            }

            MakeupBrandHandler.UpdateMakeupBrand(id, name, rating);
        }

        public static void DeleteMakeupBrand(int id)
        {
            MakeupBrandHandler.DeleteMakeupBrand(id);
        }
    }
}