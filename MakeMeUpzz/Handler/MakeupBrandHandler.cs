using MakeMeUpzz.Factory;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class MakeupBrandHandler
    {
        public static void InsertMakeupBrand(string name, int rating)
        {
            MakeupBrand makeup = MakeupBrandFactory.CreateMakeupBrand(GenerateID(), name, rating);
            MakeupBrandRepository.InsertMakeupBrand(makeup);
        }

        private static int GenerateID()
        {
            MakeupBrand makeup = MakeupBrandRepository.GetLastMakeup();
            if (makeup == null)
            {
                return 1;
            }
            return makeup.MakeupBrandID + 1;
        }
        public static List<MakeupBrand> GetAllMakeupBrand()
        {
            return MakeupBrandRepository.GetAllMakeupBrand();
        }

        public static void UpdateMakeupBrand(int id, string name, int rating)
        {
            MakeupBrandRepository.UpdateMakeupBrand(id, name, rating);
        }

        public static void DeleteMakeupBrand(int id)
        {
            MakeupBrandRepository.GetMakeupBrandById(id);
            List<Makeup> list = MakeupRepository.GetForMakeupTypeID(id);

            foreach (Makeup x in list)
            {
                MakeupRepository.DeleteMakeup(x.MakeupID);
            }
            MakeupBrandRepository.DeleteMakeupBrand(id);

        }
    }
}