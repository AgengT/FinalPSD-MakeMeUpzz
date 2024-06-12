using MakeMeUpzz.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class InsertMakeupPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ManageMakeup_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageMakeupPage.aspx");
        }

        protected void InsertMakeup_Click(object sender, EventArgs e)
        {
            string name = MakeupName.Text;
            int price = Convert.ToInt32(MakeupPrice.Text);
            int weight = Convert.ToInt32(MakeupWeight.Text);
            int typeId = Convert.ToInt32(MakeupTypeID.Text);
            int brandId = Convert.ToInt32(MakeupBrandID.Text);

            MakeupController.InsertMakeup(name, price, weight, typeId, brandId);
            Response.Redirect("~/View/ManageMakeupPage.aspx");
        }

        protected void ManageMakeup_Click3(object sender, EventArgs e)
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