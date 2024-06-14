using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class MakeupBrandFactory
    {
        public static MakeupBrand CreateMakeupBrand(int id, string name, int rating)
        {
            return new MakeupBrand
            {
                MakeupBrandID = id,
                MakeupBrandName = name,
                MakeupBrandRating = rating
            };
        }
    }
}