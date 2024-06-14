using MakeMeUpzz.Controller;
using MakeMeUpzz.Factory;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
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

                int tempMakeupID = Convert.ToInt32(GridView1.DataKeys[gvw.RowIndex].Value);

                int rowIndex = gvw.RowIndex;

                GridViewRow row = GridView1.Rows[rowIndex];

                TextBox quantityTextBox = (TextBox)row.FindControl("QuantityTextBox");

                int quantity;
                int.TryParse(quantityTextBox.Text, out quantity);

                OrderMakeupController.CreateCart(currUser.UserID, tempMakeupID, quantity);

            }


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CheckOutBtn_Click(object sender, EventArgs e)
        {
            TransactionHeader transactionHeader = TransactionHeaderFactory.createTH(1, (((User)Session["user"]).UserID), DateTime.Now, "unhandled");
            List<Cart> carts = OrderMakeupRepository.GetCartsByUserID((((User)Session["user"]).UserID));
            OrderMakeupRepository.saveTransactionHeader(transactionHeader);
            foreach (Cart c in carts)
            {
                TransactionDetail detail = TransactionDetailFactory.createTD(transactionHeader.TransactionID,c.MakeupID,c.Quantity);
                OrderMakeupRepository.saveTransactionDetail(detail);
                OrderMakeupRepository.removeCart(c);
            }
        }
    }
}