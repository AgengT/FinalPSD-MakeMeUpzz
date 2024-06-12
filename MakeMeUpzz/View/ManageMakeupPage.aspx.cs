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

        protected void MakeupType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}