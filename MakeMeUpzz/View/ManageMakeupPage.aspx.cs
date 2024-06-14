using MakeMeUpzz.Controller;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class ManageMakeupPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Makeup.DataSource = MakeupController.GetAllMakeups();
            Makeup.DataBind();

            MakeupType.DataSource = MakeupTypeController.GetAllMakeups();
            MakeupType.DataBind();

            MakeupBrand.DataSource = MakeupBrandController.GetAllMakeupBrand();
            MakeupBrand.DataBind();
            
        }

        protected void InsertMakeup_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertMakeupPage.aspx");
        }

        protected void InsertMakeupType_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertMakeupTypePage.aspx");
        }

        protected void InsertMakeupBrand_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertMakeupBrandPage.aspx");
        }

     

        protected void Makeup_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = Makeup.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[2].Text);
            Response.Redirect("~/View/UpdateMakeupPage.aspx?id="+id);
            
        }

        protected void Makeup_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = Makeup.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[2].Text);
            MakeupController.DeleteMakeup(id);
            Response.Redirect("~/View/ManageMakeupPage.aspx");
        }

        protected void MakeupBrand_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = MakeupBrand.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[2].Text);
            Response.Redirect("~/View/UpdateMakeupBrandPage.aspx?id=" + id);
        }

        protected void MakeupBrand_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = MakeupBrand.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[2].Text);
            MakeupBrandController.DeleteMakeupBrand(id);
            Response.Redirect("~/View/ManageMakeupPage.aspx");
        }

        protected void MakeupType_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = MakeupType.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[2].Text);
            Response.Redirect("~/View/UpdateMakeupTypePage.aspx?id=" + id);
        }

        protected void MakeupType_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = MakeupType.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[2].Text);
            MakeupTypeController.DeleteMakeupType(id);
            Response.Redirect("~/View/ManageMakeupPage.aspx");
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