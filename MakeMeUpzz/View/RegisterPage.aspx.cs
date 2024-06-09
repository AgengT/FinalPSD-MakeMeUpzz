using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class Register : System.Web.UI.Page
    {
        Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private int GenerateId()
        {
            int lastId = (from pr in db.Users select pr.UserID).ToList().LastOrDefault();


            if (lastId == null)
            {
                int count = 10000;
                return count;
            }
            else
            {
                lastId++;
                return lastId;
            }
        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            Database1Entities db = new Database1Entities();

            int id = GenerateId();
            String username = TextBoxUsername.Text;
            String email = TextBoxEmail.Text;
            String gender = RadioButtonGender.SelectedValue;
            String password = TextBoxRegisterPassword.Text;
            String confirmPassword = TextBoxConfirmPassword.Text;
            if(confirmPassword != password)
            {
                LabelErrorConfirmPassword.Text = "Input is invalid";
                LabelErrorConfirmPassword.Visible = true;
            }

            if(username.Count()<5 && username.Count()>15 && username == null)
            {
                LabelErrorUsername.Text = "Username Input is not valid must be between 5 and 15 characters";
            }

            //Kalo ada cara lain bisa ganti ya buat yang validasi email
            /*CultureInfo ci;
            ci = new CultureInfo(".com");
            if (email.EndsWith(email,false,ci)){
                LabelErrorEmail.Text = "Must end with .com";
            }*/

            if(gender == null)
            {
                LabelErrorGender.Text = "Choose a gender";
            }

            DateTime DOB = CalendarRegisterDOB.VisibleDate;

            if(DOB == DateTime.MinValue)
            {
                LabelErrorDOB.Text = "Input your Date of Birth";
                LabelErrorDOB.Visible = true;
            }

            User newUser = UserRepository.newUser(id, username, email, gender, password, DOB);
            db.Users.Add(newUser);
            db.SaveChanges();
        }
    }
}