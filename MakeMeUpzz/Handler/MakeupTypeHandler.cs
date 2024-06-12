using MakeMeUpzz.Factory;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class MakeupTypeHandler
    {
        public static void InsertMakeupType(string name)
        {
            MakeupType makeup = MakeupTypeFactory.CreateMakeupType(GenerateID(), name);
            MakeupTypeRepository.InsertMakeupType(makeup);
        }

        private static int GenerateID()
        {
            Makeup makeup = MakeupTypeRepository.GetLastMakeup();
            if (makeup == null)
            {
                return 1;
            }
            return makeup.MakeupTypeID + 1;
        }
    }
}