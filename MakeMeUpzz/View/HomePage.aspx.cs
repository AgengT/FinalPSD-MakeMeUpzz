using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class Homepage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
            
        }
    }
}