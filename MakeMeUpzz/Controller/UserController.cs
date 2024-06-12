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
        public static void Register(string username, string email, string gender, string password, DateTime DOB)
        {
            //string errors = "";
            //if (confirmPassword != password)
            //{
            //    errors += "confirm|Input is invalid,";
            //}
            //if (string.IsNullOrEmpty(gender))
            //{
            //    errors += "gender|Input is invalid,";
            //}
            //if (errors != "")
            //{
            //    throw new Exception(errors.Substring(0, errors.Length - 1));
            //}


            //if (confirmPassword != password)
            //{
            //    LabelErrorConfirmPassword.Text = "Input is invalid";
            //    LabelErrorConfirmPassword.Visible = true;
            //}

            //if (username.Count() < 5 && username.Count() > 15 && username == null)
            //{
            //    LabelErrorUsername.Text = "Username Input is not valid must be between 5 and 15 characters";
            //}

            ////Kalo ada cara lain bisa ganti ya buat yang validasi email
            ///*CultureInfo ci;
            //ci = new CultureInfo(".com");
            //if (email.EndsWith(email,false,ci)){
            //    LabelErrorEmail.Text = "Must end with .com";
            //}*/

            //if (gender == null)
            //{
            //    LabelErrorGender.Text = "Choose a gender";
            //}

            //DateTime DOB = CalendarRegisterDOB.VisibleDate;

            //if (DOB == DateTime.MinValue)
            //{
            //    LabelErrorDOB.Text = "Input your Date of Birth";
            //    LabelErrorDOB.Visible = true;
            //}

            //user newuser = userrepository.newuser(id, username, email, gender, password, dob);
            //db.users.add(newuser);
            //db.savechanges();
            UserHandler.Register(username, email, gender, password, DOB);
        }

        public static List<User> GetAllUser()
        {
            return UserHandler.GetAllUser();
        }
    }
}