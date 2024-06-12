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
        }

        protected void MakeupBrand_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void MakeupBrand_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void MakeupType_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void MakeupType_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void MakeupType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}