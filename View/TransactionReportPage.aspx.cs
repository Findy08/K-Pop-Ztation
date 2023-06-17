using KpopZtation_GroupB.Dataset;
using KpopZtation_GroupB.Handler;
using KpopZtation_GroupB.Model;
using KpopZtation_GroupB.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation_GroupB.View
{
    public partial class TransactionReportPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            KPopZtationReport report = new KPopZtationReport();
            CrystalReportViewer1.ReportSource = report;
            KpopZtationDataSet data = getData(TransactionHandler.GetAllTransaction());
            report.SetDataSource(data);
        }

        private KpopZtationDataSet getData(List<TransactionHeader> transactionHeader)
        {
            KpopZtationDataSet data = new KpopZtationDataSet();
            var headerTable = data.TransactionHeader;
            var detailTable = data.TransactionDetail;

           
            foreach (TransactionHeader th in transactionHeader)
            {
                var hrow = headerTable.NewRow();
                hrow["TransactionID"] = th.TransactionID;
                hrow["CustomerID"] = th.CustomerID;
                hrow["TransactionDate"] = th.TransactionDate;
                headerTable.Rows.Add(hrow);


                foreach (TransactionDetail td in th.TransactionDetails)
                {
                    var drow = detailTable.NewRow();
                    drow["TransactionID"] = td.TransactionID;
                    drow["AlbumID"] = td.AlbumID;
                    drow["AlbumName"] = td.Album.AlbumName;
                    drow["Qty"] = td.Qty;
                    drow["AlbumPrice"] = td.Album.AlbumPrice;
                    detailTable.Rows.Add(drow);
                }
            }
            return data;
        }
    }
}