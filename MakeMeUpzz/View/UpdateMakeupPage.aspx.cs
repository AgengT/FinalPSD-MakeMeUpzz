using MakeMeUpzz.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class UpdateMakeupPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UpdateMakeup_Click(object sender, EventArgs e)
        {
            string name = MakeupName.Text;
            int price = Convert.ToInt32(MakeupPrice.Text);
            int weight = Convert.ToInt32(MakeupWeight.Text);
            int typeId = Convert.ToInt32(MakeupTypeID.Text);
            int brandId = Convert.ToInt32(MakeupBrandID.Text);
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());

            MakeupController.UpdateMakeup(id, name, price, weight, typeId, brandId);
        }

        protected void ManageMakeup_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageMakeupPage.aspx");
        }
    }
}