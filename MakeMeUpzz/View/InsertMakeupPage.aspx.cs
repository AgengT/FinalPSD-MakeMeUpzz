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
        }
    }
}