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
        Database1Entities db = SingletonDatabase.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            
            string username = TextBoxUsername.Text;
            string email = TextBoxEmail.Text;
            string gender = RadioButtonGender.SelectedValue;
            string password = TextBoxRegisterPassword.Text;
            string confirmPassword = TextBoxConfirmPassword.Text;
            DateTime DOB = CalendarRegisterDOB.SelectedDate;

            UserController.Register(username, email, gender, password, DOB);

            //try
            //{
            //    User user = UserController.Register(username, email, gender, password, confirmPassword, DOB);
            //}
            //catch (Exception ex)
            //{
            //    List<string> errors = ex.Message.Split(',').ToList();

            //    foreach (string error in errors)
            //    {
            //        string msg = error.Substring(error.IndexOf("|") + 1);
            //        string code = error.Substring(0, error.IndexOf("|"));
            //        switch (code)
            //        {
            //            case "confirm":
            //                LabelErrorConfirmPassword.Text += msg;
            //                break;
            //            case "email":
            //                LabelErrorEmail.Text = msg;
            //                break;
            //            case "username":
            //                LabelErrorUsername.Text = msg;
            //                break;
            //            case "gender":
            //                LabelErrorGender.Text = msg;
            //                break;
            //            case "DOB":
            //                LabelErrorDOB.Text = msg;
            //                break;
                           
            //        }
            //    }

            //}
            Response.Redirect("~/View/Homepage.aspx");
        }
    }
}