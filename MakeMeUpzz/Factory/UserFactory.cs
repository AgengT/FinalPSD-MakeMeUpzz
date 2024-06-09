using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class User_Factory
    {   
        public static User CreateUser (int id, String username, String email, String gender, String password, DateTime DOB)
        {
            User newUser = new User()
            {
                UserID = id,
                Username = username,
                UserEmail = email,
                UserPassword = password,
                UserDOB = DOB
            };
            return newUser;
        }

    }
}