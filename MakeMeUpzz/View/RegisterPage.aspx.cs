using MakeMeUpzz.Controller;
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
            DateTime DOB = CalendarRegisterDOB.SelectedDate;

            try
            {
                User user = UserController.Register(username, email, gender, password, confirmPassword, DOB);
            }
            catch (Exception ex)
            {
                List<string> errors = ex.Message.Split(',').ToList();

                foreach (string error in errors)
                {
                    string msg = error.Substring(error.IndexOf("|") + 1);
                    string code = error.Substring(0, error.IndexOf("|"));
                    switch (code)
                    {
                        case "confirm":
                            LabelErrorConfirmPassword.Text += msg;
                            break;
                        case "email":
                            LabelErrorEmail.Text = msg;
                            break;
                        case "username":
                            LabelErrorUsername.Text = msg;
                            break;
                        case "gender":
                            LabelErrorGender.Text = msg;
                            break;
                        case "DOB":
                            LabelErrorDOB.Text = msg;
                            break;
                           
                    }
                }

            }


        }
    }
}