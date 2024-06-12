using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            Database1Entities db = new Database1Entities();

            //Authentication or Autentikasi
            String username = LabelUsername.Text;
            String password = LabelPassword.Text;
            bool isRememberMe = CheckBoxRememberMe.Checked;

            User user = db.Users.Where(u => u.Username == username && u.UserPassword == password).FirstOrDefault();

            if (user == null)
            {
                LabelError.Text = "User Not Found";
                return;
            }

            //if (isRememberMe)
            //{
            //    HttpCookie cookie = new HttpCookie("user_cookie");
            //    cookie.Value = user.Username;
            //    cookie.Expires = DateTime.Now.AddHours(1);
            //    Response.Cookies.Add(cookie);
            //}

            //Session["user"] = user;
            //Session["password"] = password;

            Response.Redirect("~/View/Homepage.aspx");
        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/RegisterPage.aspx");
        }

    }
}