using MakeMeUpzz.Controller;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
            LabelErrorName.Text = "";
            LabelErrorPrice.Text = "";
            LabelErrorWeight.Text = "";
            LabelErrorTypeID.Text = "";
            LabelErrorBrandID.Text = "";
            LabelError.Text = "";
        }

        protected void ManageMakeup_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageMakeupPage.aspx");
        }

        protected void InsertMakeup_Click(object sender, EventArgs e)
        {

            try
            {
                string name = MakeupName.Text;
                int price = Convert.ToInt32(MakeupPrice.Text);
                int weight = Convert.ToInt32(MakeupWeight.Text);
                int typeId = Convert.ToInt32(MakeupTypeID.Text);
                int brandId = Convert.ToInt32(MakeupBrandID.Text);

                MakeupController.InsertMakeup(name, price, weight, typeId, brandId);
                Response.Redirect("~/View/ManageMakeupPage.aspx");
            }
            catch (ArgumentException ex)
            {
                List<string> errors = ex.Message.Split(',').ToList();

                foreach (string error in errors)
                {
                    string msg = error.Substring(error.IndexOf("|") + 1);
                    string code = error.Substring(0, error.IndexOf("|"));
                    switch (code)
                    {
                        case "name":
                            LabelErrorName.Text += msg;
                            break;
                        case "price":
                            LabelErrorPrice.Text += msg;
                            break;
                        case "weight":
                            LabelErrorWeight.Text += msg;
                            break;
                        case "typeID":
                            LabelErrorTypeID.Text += msg;
                            break;
                        case "brandID":
                            LabelErrorBrandID.Text += msg;
                            break;
                    }
                }
            }
            catch (FormatException ex)
            {
                LabelError.Text = ex.Message;
            }
            catch (DbUpdateException ex)
            {
                LabelError.Text = ex.InnerException.Message;
            }
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