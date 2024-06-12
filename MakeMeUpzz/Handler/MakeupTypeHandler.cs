using MakeMeUpzz.Factory;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using MakeMeUpzz.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class MakeupTypeHandler
    {
        public static List<MakeupType> GetAllMakeupType()
        {
            return MakeupTypeRepository.GetAllMakeupType();
        }
        public static void InsertMakeupType(string name)
        {
            MakeupType makeup = MakeupTypeFactory.CreateMakeupType(GenerateID(), name);
            MakeupTypeRepository.InsertMakeupType(makeup);
        }

        private static int GenerateID()
        {
            MakeupType makeup = MakeupTypeRepository.GetLastMakeup();
            if (makeup == null)
            {
                return 1;
            }
            return makeup.MakeupTypeID + 1;
        }

        public static void UpdateMakeupType(int id, string name)
        {
            MakeupTypeRepository.UpdateMakeupType(id, name);
        }

        public static void DeleteMakeupType(int id)
        {
            MakeupTypeRepository.GetMakeupTypeById(id);
            List<Makeup> list = MakeupRepository.GetForMakeupTypeID(id);

            foreach(Makeup x in list)
            {
                MakeupRepository.DeleteMakeup(x.MakeupID);
            }
            MakeupTypeRepository.DeleteMakeupType(id);
           
        }
    }
}