using CS.BNP.App.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.BNP.App.Transaction
{
    public partial class frmAddEditBillingPeriod : Form
    {
        public frmAddEditBillingPeriod()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        public int iType = 0; //0 == Insert, any(ID)==Edit 
        private void ClearForm()
        {
            this.txtBillngPeriodCode.Text = string.Empty;
            this.dtpStartDate.Value = DateTime.Now; this.dtpEndDate.MinDate = DateTime.MinValue;
            this.dtpEndDate.Value = DateTime.Now; 
        }
        private void goSave()
        {
            bool allow = true;
            allow &= gloService.RequireColorTextbox(this.txtBillngPeriodCode);

            if (!allow)
            {
                this.panelWarning.Visible = true;
                _saveexit = 0;
                return;
            }
            else
            {
                this.panelWarning.Visible = false;
                _saveexit = 1;
            }

            //Save
            if (gloService.Sure("คุณต้องการบันทึกข้อมูล ?") == DialogResult.Yes)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    Entity.tran_BillingPeriod obj;
                    switch (iType)
                    {
                        case 0:
                            obj = new Entity.tran_BillingPeriod();
                            obj.BillingPeriodCode = this.txtBillngPeriodCode.Text.Trim();
                            obj.BillingDateFrom = this.dtpStartDate.Value;
                            obj.BillingDateTo = this.dtpEndDate.Value;
                           
                            obj.CreatedBy = Variable.CurrentProfile.username;
                            obj.CreatedDate = DateTime.Now;
                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            obj.BillingStatus = (int)BillingPeriodStatus.New;
                            db.tran_BillingPeriod.Add(obj);
                            db.SaveChanges();

                            frmBillngPeriod frmParent = Application.OpenForms["frmBillngPeriod"] as frmBillngPeriod;
                            frmParent.DGV();

                           // gloService.Announce("บันทึกข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            break;
                        default:
                            obj = db.tran_BillingPeriod.Where(w => w.ID == iType).FirstOrDefault();
                            obj.BillingPeriodCode = this.txtBillngPeriodCode.Text.Trim();
                            obj.BillingDateFrom = this.dtpStartDate.Value;
                            obj.BillingDateTo = this.dtpEndDate.Value;
                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            db.SaveChanges();
                            //gloService.Announce("แก้ไขข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            this.Close();
                            break;
                    }
                }
                ClearForm();
                this.txtBillngPeriodCode.Select();
            }
            else
            {
                _saveexit = 0;
                this.btnSave.Select();
                return;
            }
        }

        private byte _saveexit = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            goSave();
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            _saveexit = 1;
            goSave();
            if (_saveexit == 1)
                this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            this.dtpEndDate.MinDate = this.dtpStartDate.Value.AddDays(1); 
        }

        private void frmAddEditBillingPeriod_Load(object sender, EventArgs e)
        {
            ClearForm();
            if (iType > 0)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    var _data = db.tran_BillingPeriod.Where(w => w.ID == iType).FirstOrDefault();
                    if (_data != null)
                    {
                        this.txtBillngPeriodCode.Text = _data.BillingPeriodCode;
                        this.dtpStartDate.Value = _data.BillingDateFrom;
                        this.dtpEndDate.Value = _data.BillingDateTo;
                        this.txtBillngPeriodCode.Enabled = false; this.dtpStartDate.Select();
                    }
                    else
                    {
                        gloService.Announce("ไม่สามารถค้นหาข้อมูลได้ .. โปรดตรวจสอบ", AnnounceType.Infomation);
                        this.Close();
                        return;
                    }
                }
            }
            else
                this.txtBillngPeriodCode.Select();
        }
    }
}
