using MakeMeUpzz.Factory;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using MakeMeUpzz.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MakeMeUpzz.Handler
{
    public class UserHandler
    {
        public static List<User> GetAllUser()
        {
            return UserRepository.GetAllUser();
        }

        public static void Register(string username, string email, string gender, string password, DateTime DOB)
        {
            User user = UserFactory.CreateUser(GenerateID(), username, email, gender, password, DOB);
            UserRepository.newUser(user);
        }

        public static int GenerateID()
        {
            User user= UserRepository.GetLastMakeup();
            if (user == null)
            {
                return 1;
            }
            return user.UserID + 1;
        }

        public static bool CheckUsername(string username)
        {
            User user = UserRepository.GetUserByUsername(username);
            return user != null;
        }
    }
}