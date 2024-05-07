using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CS.BNP.App.Reports.TransactionCreditor
{
    public partial class rptReportingCreditior : DevExpress.XtraReports.UI.XtraReport
    {
        public rptReportingCreditior()
        {
            InitializeComponent();
        }
        double result = 0; double totalAmt = 0; double prepaid = 0;
        private void xrTableCell1_SummaryReset(object sender, EventArgs e)
        {
            totalAmt = 0; prepaid = 0;
        }

        private void xrTableCell1_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = totalAmt - prepaid;
            e.Handled = true;
           
        }

        private void xrTableCell1_SummaryRowChanged(object sender, EventArgs e)
        {
            totalAmt += Convert.ToDouble(GetCurrentColumnValue("TotalAmount"));
            prepaid = Convert.ToDouble(GetCurrentColumnValue("PrepaidTotalAmount"));
        }

        private void xrLabel2_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = ((totalAmt - prepaid) > 0 ? "บวก" : "ลบ");           
            e.Handled = true;
        }

        private void xrLabel2_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
           

        }

        private void xrTableCell1_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            if (Convert.ToDecimal(((XRTableCell)sender).Text) < 0)
            {
                ((XRTableCell)sender).BackColor = Color.Red;
                ((XRTableCell)sender).ForeColor = Color.White;
            }
        }
    }
}
