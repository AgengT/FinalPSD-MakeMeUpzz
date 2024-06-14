using MakeMeUpzz.Controller;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class TransactionHistoryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(((User)Session["user"]).UserRole == "Admin")
            {
                GridView1.DataSource = TransactionHistoryController.GetAllTransactionHistory();
                GridView1.DataBind();

            }else if(((User)Session["user"]).UserRole == "Customer")
            {
                GridView1.DataSource = TransactionHistoryController.GetUserTransactionHistory(((User)Session["user"]).UserID);
                GridView1.DataBind();
            }
            
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Detail")
            {
                Control source = e.CommandSource as Control;
                GridViewRow gvw = source.NamingContainer as GridViewRow;
                int tempID = Convert.ToInt32(GridView1.DataKeys[gvw.RowIndex].Value);

                Response.Redirect("~/View/TransactionDetailPage.aspx?ID="+tempID);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}