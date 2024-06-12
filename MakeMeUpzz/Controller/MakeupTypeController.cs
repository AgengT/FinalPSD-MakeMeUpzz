using MakeMeUpzz.Factory;
using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class MakeupTypeController
    {
        public static void InsertMakeupType(string name)
        {
            MakeupTypeRepository.InsertMakeupType(name);
        }
    }
}