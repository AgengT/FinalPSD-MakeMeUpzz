using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class UserController
    {
        public static void Register(string username, string email, string gender, string password, string confirmPassword, DateTime dob)
        {
            string errors = "";
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || !password.All(char.IsLetterOrDigit) || confirmPassword != password)
            {
                errors += "confirm|Input is invalid ,";
            }
            if (string.IsNullOrEmpty(gender))
            {
                errors += "gender|Select one ,";
            }
            if (string.IsNullOrEmpty(username) || username.Length < 5 || username.Length > 15)
            {
                errors += "username|Username Input is not valid must be between 5 and 15 characters ,";
            }
            if (!string.IsNullOrEmpty(username) && UserHandler.CheckUsername(username))
            {
                errors += "username|Username already exist ,";
            }

            if(dob == null || dob == DateTime.Parse("01/01/0001"))
            {
                errors += "DOB|DOB is empty ,";
            }
            if (string.IsNullOrEmpty(email) || !email.EndsWith(".com")){
                errors += "email|Email must end with .com ,";
            }

            if (errors != "")
            {
                throw new ArgumentException(errors.Substring(0, errors.Length - 1));
            }
            UserHandler.Register(username, email, gender, password, dob);
        }

        public static List<User> GetAllUser()
        {
            return UserHandler.GetAllUser();
        }
    }
}