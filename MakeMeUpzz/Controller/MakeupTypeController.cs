using MakeMeUpzz.Factory;
using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using MakeMeUpzz.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class MakeupTypeController
    {
        public static List<MakeupType> GetAllMakeups()
        {
            return MakeupTypeHandler.GetAllMakeupType();
        }
        public static void InsertMakeupType(string name)
        {
            string errors = "";
            if(string.IsNullOrEmpty(name) || name.Length < 1 || name.Length > 99)
            {
                errors += "name is not valid must be between 1 and 99 characters";
            }

            MakeupTypeHandler.InsertMakeupType(name);
        }

        public static void UpdateMakeupType(int id, string name)
        {
            string errors = "";
            if (string.IsNullOrEmpty(name) || name.Length < 1 || name.Length > 99)
            {
                errors += "name is not valid must be between 1 and 99 characters";
            }

            MakeupTypeHandler.UpdateMakeupType(id, name);
        }

        public static void DeleteMakeupType(int id)
        {
            MakeupTypeHandler.DeleteMakeupType(id);
        }
    }
}