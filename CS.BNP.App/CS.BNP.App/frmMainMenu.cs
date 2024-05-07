using CS.BNP.App.EmployeeSecurity;
using CS.BNP.App.Services;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.BNP.App
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService(); 
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            this.statusStrip1.Items[1].Text = Services.Variable.CurrentProfile.username;
            this.lblVersion.Text = Variable.AppVersion;
            SetAuthorization();
            CheckMill();
        }
        public void CheckMill()
        {            
            using (var db = new Entity.CSBNPEntities())
            {
                var check = db.tran_CreditorMillPrePaid.Where(w => (w.TotalAmount - w.PaidAmount) < 0).ToList();
                foreach (var item in check)
                {
                    // Show a sample alert window.
                    AlertInfo info = new AlertInfo("", item.mas_Creditor.CreditorName + " เงินวางงาน "+ item.mas_Job.JobName +" = <b>" + (item.TotalAmount - item.PaidAmount).ToString("#,00") + "</b>", true);
                    alertControl1.Show(this, info);
                }
            }
        }
        public void SetAuthorization()
        {
            this.navSecurity.Visible = Variable.CurrentProfile.is_security;
            this.navSetting.Visible = Variable.CurrentProfile.is_systemsetup;
            this.navTransaction.Visible = Variable.CurrentProfile.is_transection;
            this.navSummary.Visible = Variable.CurrentProfile.is_report;
            this.navAdmin.Visible = Variable.CurrentProfile.is_admin;

            this.navItemTask.Visible = Variable.CurrentProfile.is_admin;
            this.navItemVS.Visible = Variable.CurrentProfile.is_admin;
            this.navItemVSBase.Visible = Variable.CurrentProfile.is_admin;

            this.navItemApproval.Visible = Variable.CurrentProfile.is_admin;
            this.navItemHistory.Visible = Variable.CurrentProfile.is_admin;

        }

        private void navItemEmployee_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            EmployeeSecurity.frmEmployee frm = new frmEmployee();
            MenuClicked(frm);
        }

        private void MenuClicked(Form frm)
        {
            AG:
            foreach (var item in Application.OpenForms)
            {
                if ((item as Form).Name  != "frmLogin" && (item as Form).Name != "frmMainMenu")
                {
                    (item as Form).Close();
                    goto AG;
                }
            }
            // Set the Parent Form of the Child window.
            frm.MdiParent = this;
            // Display the new form.
            frm.Show();
            frm.BringToFront();
        }
        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._logout == 0)
            {
                if (XtraMessageBox.Show("คุณต้องการออกจากโปรแกรม", "คำถาม", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmLogin frm = Application.OpenForms["frmLogin"] as frmLogin;
                    frm.Close();
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
                e.Cancel = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.statusStrip1.Items[0].Text = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy");
        }
        private void navItemExit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Close();
        }
        private byte _logout = 0;
        private void navItemLogOut_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (gloService.Sure("คุณต้องการเปลี่ยนผู้ใช้งานหริอไม่ ?") == DialogResult.Yes)
            {
                this._logout = 1;
                frmLogin frm = new frmLogin();
                frm.BringToFront();
                frm.Show();

                this.SendToBack(); this.Hide();
            }
            else return;
        }

        private void navItemProduct_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SystemSetup.Products.frmViewProduct frm = new SystemSetup.Products.frmViewProduct();
            MenuClicked(frm);
        }

        private void navItemDebtor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SystemSetup.Debtor.frmViewDebtor frm = new SystemSetup.Debtor.frmViewDebtor();
            MenuClicked(frm);
        }

        private void navItemCreditor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SystemSetup.Creditor.frmViewCreditor frm = new SystemSetup.Creditor.frmViewCreditor();
            MenuClicked(frm);
        }

        private void navItemTask_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SystemSetup.Job.frmViewJob frm = new SystemSetup.Job.frmViewJob();
            MenuClicked(frm);
        }

        private void navItemBillingPeriod_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Transaction.frmBillngPeriod frm = new Transaction.frmBillngPeriod();
            MenuClicked(frm);
        }

        private void navItemTranCreditor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Transaction.Creditor.frmViewCreditorTransaction frm = new Transaction.Creditor.frmViewCreditorTransaction();
            MenuClicked(frm);
        }

        private void navItemSummartCreditor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Reports.TransactionCreditor.frmCreditorViewer frm = new Reports.TransactionCreditor.frmCreditorViewer();
            MenuClicked(frm);
        }

        private void navItemSummaryDebitor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Reports.TransactionDebitor.frmDebitorViewer frm = new Reports.TransactionDebitor.frmDebitorViewer();
            MenuClicked(frm);
        }

        private void navItemTranDebitor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Transaction.Debitor.frmViewDebitorCreditor frm = new Transaction.Debitor.frmViewDebitorCreditor();
            MenuClicked(frm);
        }

        private void navItemCreditorReport_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Reports.TransactionCreditor.frmSummaryPaid frm = new Reports.TransactionCreditor.frmSummaryPaid();
            MenuClicked(frm);
        }

        private void navItemPre_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Transaction.Creditor.frmViewCreditorPrePaid frm = new Transaction.Creditor.frmViewCreditorPrePaid();
            MenuClicked(frm);
        }

        private void navItemDebitorReport_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Reports.TransactionDebitor.frmSummaryCompare frm = new Reports.TransactionDebitor.frmSummaryCompare();
            MenuClicked(frm);
        }

        private void navItemChangePassword_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            EmployeeSecurity.frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
            if (Variable.chPass == 1)
            {
                Variable.chPass = 0;
                this._logout = 1;
                frmLogin frmX = Application.OpenForms["frmLogin"] as frmLogin;
                frmX.BringToFront();
                frmX.Show();

                this.SendToBack(); this.Hide();
            }
        }

        private void navItemDebitorPeriod_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Transaction.DebitorPeriod.frmDebitorPeriod frm = new Transaction.DebitorPeriod.frmDebitorPeriod();
            MenuClicked(frm);
        }

        private void navItemBuyVat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Reports.TransactionCreditor.frmBuyVatCond frm = new Reports.TransactionCreditor.frmBuyVatCond();
            MenuClicked(frm);
        }

        private void navItemLetter_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Reports.Letter.frmLetterCond frm = new Reports.Letter.frmLetterCond();
            MenuClicked(frm);
        }

        private void navItemVS_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Reports.VS.frmVSCond frm = new Reports.VS.frmVSCond();
            MenuClicked(frm);
        }

        private void navItemApproval_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            EmployeeSecurity.frmViewApproval frm = new frmViewApproval();
            MenuClicked(frm);
        }

        private void navItemHistory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmViewHistory frm = new frmViewHistory();
            MenuClicked(frm);
        }

        private void navItemVSBase_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Reports.VS.frmBaseVSCond frm = new Reports.VS.frmBaseVSCond();
            MenuClicked(frm);
        }

        private void navItemCreditorMill_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //SystemSetup.StoneMill.frnViewCreditorMill frm = new SystemSetup.StoneMill.frnViewCreditorMill();
            //MenuClicked(frm);
        }

        private void navItemMillPre_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Transaction.Creditor.frmViewCreditorMillPrePaid frm = new Transaction.Creditor.frmViewCreditorMillPrePaid();
            MenuClicked(frm);
        }

        private void navItemMillVat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Reports.Mills.frmMillVat frm = new Reports.Mills.frmMillVat();
            MenuClicked(frm);
        }

        private void navItemTramMillRpt_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Reports.Mills.frmMillPrePaidCond frm = new Reports.Mills.frmMillPrePaidCond();
            MenuClicked(frm);
        }

        private void navItemMillConsolidate_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Reports.Mills.frmMillConsolidate frm = new Reports.Mills.frmMillConsolidate();
            MenuClicked(frm);
        }
    }
}
