using CrystalDecisions.Web;
using MakeMeUpzz.Dataset;
using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //soal tidak memungkinkan untuk dilakukan Crystal Report
            //CrystalReport report = new CrystalReport();
            //CrystalReportViewer1.ReportSource = report;
            //DataSet data = getData(TransactionHandler.GetTransactions();
            //report.SetDataSource(data);
        }
        //private DataSet getData(List<TransactionHeader> transactionHeaders)
        //{
        //    DataSet data = new DataSet();
        //    var headerTable = data.TransactionHeader;
        //    var detailTable = data.TransactionDetails;

        //    foreach (TransactionHeader t in transactionHeaders)
        //    {
        //        var hrow = headerTable.NewRow();
        //        hrow["TransactionID"] = t.TransactionID;
        //        hrow["UserID"] = t.UserID;
        //        hrow["TransactionDate"] = t.TransactionDate;
        //        hrow["Status"] = t.Status;
        //        headerTable.Rows.Add(hrow);

        //        foreach (TransactionDetail d in t.User)
        //        {
        //            var drow = detailTable.NewRow();
        //            drow["TransactionID"] = d.TransactionID;
        //            drow["MakeupID"] = d.MakeupID;
        //            drow["Quantity"] = d.Quanitity;
        //            detailTable.Rows.Add(drow);
        //        }
        //        return data;
        //    }
        }
    }
}