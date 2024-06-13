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
    public partial class OrderMakeupPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = MakeupController.GetAllMakeups();
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Order")
            {
                User currUser = (User)Session["user"];
                Control source = e.CommandSource as Control;
                GridViewRow gvw = source.NamingContainer as GridViewRow;

                // Get the MakeupID from the DataKeys
                int tempMakeupID = Convert.ToInt32(GridView1.DataKeys[gvw.RowIndex].Value);

                // Get the row index from the NamingContainer
                int rowIndex = gvw.RowIndex;

                // Retrieve the GridViewRow
                GridViewRow row = GridView1.Rows[rowIndex];

                // Find the TextBox control in the row
                TextBox quantityTextBox = (TextBox)row.FindControl("QuantityTextBox");

                // Get the quantity value
                int quantity;
                int.TryParse(quantityTextBox.Text, out quantity);

                // Create the cart
                OrderMakeupController.CreateCart(currUser.UserID, tempMakeupID, quantity);

            }


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}