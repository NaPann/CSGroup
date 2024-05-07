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

namespace CS.BNP.App.Transaction.DebitorPeriod
{
    public partial class frmAddEditDebitorPeriod : Form
    {
        public frmAddEditDebitorPeriod()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        public int iType = 0; //0 == Insert, any(ID)==Edit 
        public DataTable dt;
        private void ClearForm()
        {
            this.txtDebitorPeriodCode.Text = string.Empty;
            this.dtpStartDate.Value = DateTime.Now; /*this.dtpEndDate.MinDate = DateTime.Now.AddYears(-10);*/
            this.dtpEndDate.Value = DateTime.Now;

            this.dt = new DataTable();
            this.dt.Columns.Add(new DataColumn("ID", typeof(System.Int32)));
            this.dt.Columns.Add(new DataColumn("TXT", typeof(System.String)));
            this.dt.AcceptChanges();

            using (var db = new Entity.CSBNPEntities())
            {
                var bp = db.tran_BillingPeriod
                    .OrderBy(o => o.ID).ToList();
                foreach (var item in bp)
                {
                    this.chkBillingPeriod.Items.Add(item.BillingPeriodCode + ":" 
                        + item.BillingDateFrom.ToString("dd/MM/yyyy") + "-" 
                        + item.BillingDateTo.ToString("dd/MM/yyyy"));
                }
            }

        }
        private void goSave()
        {
            bool allow = true;
            allow &= gloService.RequireColorTextbox(this.txtDebitorPeriodCode);

            foreach (var item in this.chkBillingPeriod.CheckedItems)
            {
                allow &= true;
            }

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
                    Entity.mas_DebitorBillingPeriod obj;
                    var bp = db.tran_BillingPeriod.ToList();
                    switch (iType)
                    {
                        case 0:
                            obj = new Entity.mas_DebitorBillingPeriod();
                            obj.DebitorPeriodCode = this.txtDebitorPeriodCode.Text.Trim();
                            obj.DebitorDateFrom = this.dtpStartDate.Value;
                            obj.DebitorDateTo = this.dtpEndDate.Value;

                            obj.CreatedBy = Variable.CurrentProfile.username;
                            obj.CreatedDate = DateTime.Now;
                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            obj.DebitorBillingStatus = (int)DebitorPeriodStatus.New;
                            db.mas_DebitorBillingPeriod.Add(obj);
                            db.SaveChanges();

                            //findbyText
                            foreach (var item in this.chkBillingPeriod.CheckedItems)
                            {
                                Entity.key_DebitorBilling k = new Entity.key_DebitorBilling();
                                k.DebitorPeriodID = obj.ID;
                                try
                                {
                                    var upBP = bp.Where(w => w.BillingPeriodCode == item.ToString().Trim().Split(':')[0]).FirstOrDefault();
                                    if (upBP != null)
                                    {                                        
                                        k.BillingPeriodID = upBP.ID;
                                        //upBP.BillingStatus = (int)BillingPeriodStatus.Processed;
                                    }
                                    else
                                    {
                                        gloService.Announce("ไม่สามารถค้นหาข้อมูลช่วงเวลาเจ้าหนี้ได้ .. โปรดตรวจสอบ", AnnounceType.Infomation);
                                        return;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception(ex.Message);
                                }
                                db.key_DebitorBilling.Add(k);
                            }
                            db.SaveChanges();
                            frmDebitorPeriod frmParent = Application.OpenForms["frmDebitorPeriod"] as frmDebitorPeriod;
                            frmParent.DGV();

                           // gloService.Announce("บันทึกข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            break;
                        default:
                            obj = db.mas_DebitorBillingPeriod.Where(w => w.ID == iType).FirstOrDefault();
                            obj.DebitorPeriodCode = this.txtDebitorPeriodCode.Text.Trim();
                            obj.DebitorDateFrom = this.dtpStartDate.Value;
                            obj.DebitorDateTo = this.dtpEndDate.Value;
                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            db.SaveChanges();

                            //del
                            var delKey = db.key_DebitorBilling.Where(w => w.DebitorPeriodID == iType).ToList();
                            db.key_DebitorBilling.RemoveRange(delKey);
                            db.SaveChanges();

                            //findbyText
                            foreach (var item in this.chkBillingPeriod.CheckedItems)
                            {
                                Entity.key_DebitorBilling k = new Entity.key_DebitorBilling();
                                k.DebitorPeriodID = obj.ID;
                                try
                                {
                                    var upBP = bp.Where(w => w.BillingPeriodCode == item.ToString().Trim().Split(':')[0]).FirstOrDefault();
                                    if (upBP != null)
                                    {
                                        k.BillingPeriodID = upBP.ID;
                                        upBP.BillingStatus = (int)BillingPeriodStatus.Processed;
                                    }
                                    else
                                    {
                                        gloService.Announce("ไม่สามารถค้นหาข้อมูลช่วงเวลาเจ้าหนี้ได้ .. โปรดตรวจสอบ", AnnounceType.Infomation);
                                        return;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception(ex.Message);
                                }
                                db.key_DebitorBilling.Add(k);
                            }
                            db.SaveChanges();

                            //gloService.Announce("แก้ไขข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            this.Close();
                            break;
                    }
                }
                ClearForm();
                this.txtDebitorPeriodCode.Select();
            }
            else
            {
                _saveexit = 0;
                this.btnSave.Select();
                return;
            }
        }

        private byte _saveexit = 0;
        private void frmAddEditDebitorPeriod_Load(object sender, EventArgs e)
        {
            ClearForm();
            if (iType > 0)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    var _data = db.mas_DebitorBillingPeriod.Where(w => w.ID == iType).FirstOrDefault();
                    if (_data != null)
                    {
                        this.txtDebitorPeriodCode.Text = _data.DebitorPeriodCode;
                        this.dtpStartDate.Value = _data.DebitorDateFrom;
                        this.dtpEndDate.Value = _data.DebitorDateTo;

                        var bp = db.key_DebitorBilling.Where(w => w.DebitorPeriodID == iType).ToList();
                        foreach (var itemBP in bp)
                        {
                            for (int i = 0; i < this.chkBillingPeriod.Items.Count; i++)
                            {
                                if (this.chkBillingPeriod.Items[i].ToString().Trim().Contains(itemBP.tran_BillingPeriod.BillingPeriodCode))
                                {
                                    this.chkBillingPeriod.SetItemChecked(i, true);
                                    break;
                                }
                            }
                        }                       
                        this.txtDebitorPeriodCode.Enabled = false; this.dtpStartDate.Select();
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
                this.txtDebitorPeriodCode.Select();
        }

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
            //try
            //{
            //    this.dtpEndDate.MinDate = this.dtpStartDate.Value.AddDays(-1);
            //}
            //catch
            //{
            //    this.dtpEndDate.MinDate = this.dtpStartDate.Value.AddYears(-10);
            //}


        }
    }
}
