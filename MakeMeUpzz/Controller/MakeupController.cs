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
            string errors = "";
            if (string.IsNullOrEmpty(name) || name.Length < 1 || name.Length > 99)
            {
                errors += "name|Username Input is not valid must be between 1 and 99 characters ,";
            }
            if (price <= 1)
            {
                errors += "price|Price must be more than 1 ,";
            }
            if(weight >= 1500)
            {
                errors += "weight|Weight must be less than 1500 ,";
            }
            if(typeID.Equals(null) || typeID <= 0 )
            {
                errors += "typeID|Input invalid ,";
            }
            if(brandID.Equals(null) || brandID <= 0)
            {
                errors += "brandID|Input invalid ,";
            }

            if (errors != "")
            {
                throw new ArgumentException(errors.Substring(0, errors.Length - 1));
            }
            MakeupHandler.InsertMakeup(name, price, weight, typeID, brandID);
        }

        public static void UpdateMakeup(int id, string name, int price, int weight, int typeID, int brandID)
        {
            string errors = "";

            if (string.IsNullOrEmpty(name) || name.Length < 1 || name.Length > 99)
            {
                errors += "name|Username Input is not valid must be between 1 and 99 characters ,";
            }
            if (price <= 1)
            {
                errors += "price|Price must be more than 1 ,";
            }
            if(weight > 1500)
            {
                errors += "Weight cannot be greater than 1500 grams";
            }
            if (typeID.Equals(null))
            {
                errors += "typeID|Input invalid ,";
            }
            if (brandID.Equals(null))
            {
                errors += "brandID|Input invalid ,";
            }
            MakeupHandler.UpdateMakeup(id, name, price, weight, typeID, brandID);
        }
    }
}