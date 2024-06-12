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
            MakeupTypeHandler.InsertMakeupType(name);
        }

        public static void UpdateMakeupType(int id, string name)
        {
            MakeupTypeHandler.UpdateMakeupType(id, name);
        }

        public static void DeleteMakeupType(int id)
        {
            MakeupTypeHandler.DeleteMakeupType(id);
        }
    }
}