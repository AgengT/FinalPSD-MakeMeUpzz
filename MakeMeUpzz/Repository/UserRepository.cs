using MakeMeUpzz.Factory;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class UserRepository
    {   
        private static Database1Entities db = SingletonDatabase.GetInstance();
        public static void newUser(User user)
        {
            db.Users.Add(user);
            try
            {
                db.SaveChanges();

            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }

            
        }

        public static List<User> GetAllUser()
        {
            return db.Users.ToList();
        }

        

        public static User GetLastMakeup()
        {
            return db.Users.ToList().LastOrDefault();
        }

    }
}