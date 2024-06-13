using MakeMeUpzz.Controller;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User.DataSource = UserController.GetAllUser();
            User.DataBind();

            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }

            if (Request.Cookies["user_cookie"] != null)
            {
                Database1Entities db = new Database1Entities();
                var userId = Request.Cookies["user_cookie"].Value;
                User user = db.Users.Where(U => U.Username == userId).FirstOrDefault();


                if (user == null)
                {
                   Response.Redirect("~/View/LoginPage.aspx");
                }

                Session["user"] = user;
            }

            User currUser = (User)Session["user"];

            if (currUser.UserRole == "admin")
            {
                Button5.Visible = true;
                Button6.Visible = true;
                Button7.Visible = true;
                Button8.Visible = true;
                Button9.Visible = true;
            }
            else
            {
                Button1.Visible = true;
                Button2.Visible = true;
                Button3.Visible = true;
                Button4.Visible = true;
            }
        }

        protected void ManageMakeup_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageMakeupPage.aspx");
        }

        protected void OrderMakeupClick(object sender, EventArgs e)
        {
            Response.Redirect("~/View/OrderMakeupPage.aspx");
        }

        protected void HistoryClick(object sender, EventArgs e)
        {
            Response.Redirect("~/View/HistoryPage.aspx");
        }

        protected void ProfileClick(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ProfilePage.aspx");
        }

        protected void LogoutClick(object sender, EventArgs e)
        {
            Session["user"] = null;
            HttpCookie cookie = new HttpCookie("user_cookie");
            cookie.Expires = DateTime.Now.AddHours(-1);
            Response.Cookies.Add(cookie);
            Response.Redirect("~/View/LoginPage.aspx");
        }

        protected void ManageMakeupClick2(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageMakeupPage.aspx");
        }

        protected void OrderQueueClick(object sender, EventArgs e)
        {
            Response.Redirect("~/View/HandleTransactionPage.aspx");
        }

        protected void TransactionReportClick(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewTransactionReportPage.aspx");
        }

    }
}