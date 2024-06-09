using MakeMeUpzz.Factory;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class UserRepository
    {   

        public static User newUser(int id, String username, String email, String gender, String password, DateTime DOB)
        {
            Database1Entities db1 = new Database1Entities();
            User createUser=User_Factory.CreateUser(id, username, email, gender, password, DOB);
            return createUser;
        }

        //public List<User> GetUsers(){}


    }
}