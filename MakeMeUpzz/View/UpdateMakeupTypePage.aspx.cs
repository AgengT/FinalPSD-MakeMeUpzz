using MakeMeUpzz.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class UpdateMakeupTypePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UpdateMakeupType_Click(object sender, EventArgs e)
        {
            string name = MakeupTypeName.Text;
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());

            MakeupTypeController.UpdateMakeupType(id, name);
            Response.Redirect("~/View/ManageMakeupPage.aspx");
        }

        protected void ManageMakeup_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageMakeupPage.aspx");
        }
        protected void ManageMakeup_Click2(object sender, EventArgs e)
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