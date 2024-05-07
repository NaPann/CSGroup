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

namespace CS.BNP.App.Transaction.Debitor
{
    public partial class frmAddEditDebitorTran : Form
    {
        public frmAddEditDebitorTran()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService(); Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        public int iType = 0; //0 == Insert, any(ID)==Edit 
        private byte _saveexit = 0; public int _bpId = 0;
        public DateTime StartDate; public DateTime EndDate; System.Globalization.CultureInfo cul = new System.Globalization.CultureInfo("en-us");
        private void ClearForm()
        {
            BindingControl();
            this.txtTranDebitorCode.Text = "-- สร้างให้อัติโนมัติ --";
            this.cbDebitor.SelectedIndex = 0; this.txtDebitorName.Text = string.Empty;
            this.dtpTransactionDate.Checked = false; this.txtDocumentNo.Text = string.Empty; this.numTransactionSeq.Value = 0;
            this.cbJob.SelectedIndex = 0; this.txtJob.Text = string.Empty; this.txtCarLicense.Text = string.Empty;
            this.txtDriver.Text = string.Empty; this.cbProduct.DataSource = null; this.txtProductName.Text = string.Empty; this.txtCheckedBy.Text = string.Empty;

            this.numTranWeight.Value = 0; this.txtUnit.Text = string.Empty; this.numUnitPrice.Value = 0; this.txtNetAmount.Text = "0.00";
            this.numDiscount.Value = 0; this.txtBeforeVat.Text = "0.00"; this.numVat.Value = 0; this.txtVat.Text = "0.00";
            this.txtTotalAmount.Text = "0.00"; this.lblPO.Text = "0.00";

            //Sale Date
            this.dtpTransactionDate.MinDate = StartDate; this.dtpTransactionDate.MaxDate = EndDate; this.dtpTransactionDate.Checked = false;
        }
        private void BindingControl()
        {
            var data = db.mas_Debtor.OrderBy(o => o.ID).Select(s => new
            {
                val = s.ID,
                txt = s.DebtorName + " : " + s.DebtorCode
            }).ToList();
            data.Insert(0, new { val = 0, txt = "-- เลือกลูกหนี้ --" });
            this.cbDebitor.DataSource = data;
            this.cbDebitor.DisplayMember = "txt";
            this.cbDebitor.ValueMember = "val";

            var dataJob = db.mas_Job.OrderBy(o => o.ID).Select(s => new
            {
                val = s.ID,
                txt = s.JobName + " : " + s.JobCode
            }).ToList();
            dataJob.Insert(0, new { val = 0, txt = "-- เลือกโครงการ --" });
            this.cbJob.DataSource = dataJob;
            this.cbJob.DisplayMember = "txt";
            this.cbJob.ValueMember = "val";

        }
        private void Compute()
        {
            this.txtNetAmount.Text = (this.numTranWeight.Value * this.numUnitPrice.Value).ToString("#,0.00");

            if (!string.IsNullOrWhiteSpace(this.txtNetAmount.Text.Trim()) || (this.txtNetAmount.Text != "0.00"))
            {
                this.txtBeforeVat.Text = (decimal.Parse(this.txtNetAmount.Text.Trim()) - (decimal.Parse(this.txtNetAmount.Text.Trim()) * (this.numDiscount.Value / 100))).ToString("#,0.00");
            }

            this.txtVat.Text = ((this.numVat.Value / 100) * decimal.Parse(this.txtBeforeVat.Text.Trim())).ToString("#,0.00");

            if (!string.IsNullOrWhiteSpace(this.txtBeforeVat.Text.Trim()) || (this.txtBeforeVat.Text != "0.00"))
            {
                if (!string.IsNullOrWhiteSpace(this.txtVat.Text.Trim()))
                {
                    this.txtTotalAmount.Text = (decimal.Parse(this.txtBeforeVat.Text.Trim()) + decimal.Parse(this.txtVat.Text)).ToString("#,0.00");
                }
            }
        }
        private void goSave()
        {
            bool allow = true;
            if (this.cbDebitor.SelectedIndex == 0)
            {
                this.cbDebitor.BackColor = Color.LightCoral;
                allow &= false;
            }
            else
            {
                this.cbDebitor.BackColor = Color.White;
                allow &= true;
            }
            if (!this.dtpTransactionDate.Checked)
            {
                this.lblDTP.BackColor = Color.LightCoral;
                allow &= false;
            }
            else
            {
                this.lblDTP.BackColor = Color.White;
                allow &= true;
            }
            if (this.cbJob.SelectedIndex == 0)
            {
                this.cbJob.BackColor = Color.LightCoral;
                allow &= false;
            }
            else
            {
                this.cbJob.BackColor = Color.White;
                allow &= true;
            }
            if (this.cbProduct.SelectedIndex == 0)
            {
                this.cbProduct.BackColor = Color.LightCoral;
                allow &= false;
            }
            else
            {
                this.cbProduct.BackColor = Color.White;
                allow &= true;
            }
            allow &= gloService.RequireColorTextbox(this.txtDocumentNo);
            allow &= gloService.RequireColorTextbox(this.numTransactionSeq);
            allow &= gloService.RequireColorTextbox(this.txtCarLicense);
            allow &= gloService.RequireColorTextbox(this.txtDriver);
            allow &= gloService.RequireColorTextbox(this.numTranWeight);
            allow &= gloService.RequireColorTextbox(this.numUnitPrice);
            allow &= gloService.RequireColorTextbox(this.txtCheckedBy);

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
                    Entity.tran_Debitor obj;
                    switch (iType)
                    {
                        case 0:
                            obj = new Entity.tran_Debitor();
                            obj.TransactionDebitorCode = gloService.AutoGenerate(GenerateType.TransactionDebitor);
                            obj.BillingPeriodID = _bpId;
                            obj.TransactionDate = this.dtpTransactionDate.Value;
                            obj.TransactionSeq = int.Parse(this.numTransactionSeq.Value.ToString());
                            obj.DocumentNo = this.txtDocumentNo.Text.Trim();
                            obj.IsOutsidePeriod = this.chkOutsidePeriod.Checked;
                            obj.DebitorID = int.Parse(this.cbDebitor.SelectedValue.ToString());
                            obj.JobID = int.Parse(this.cbJob.SelectedValue.ToString());
                            obj.ProductID = int.Parse(this.cbProduct.SelectedValue.ToString());
                            obj.CarLicense = this.txtCarLicense.Text.Trim();
                            obj.Driver = this.txtDriver.Text.Trim();
                            obj.TranWeight = this.numTranWeight.Value;
                            obj.TranSellPrice = this.numUnitPrice.Value;
                            obj.TranDiscount = this.numDiscount.Value;
                            obj.IsVat = this.numVat.Value > 0;
                            obj.TranVat = this.numVat.Value;
                            obj.TotalBeforeVat = decimal.Parse(this.txtBeforeVat.Text.Trim());
                            obj.TotalBeforeDiscount = decimal.Parse(this.txtNetAmount.Text.Trim());
                            obj.TotalAmount = decimal.Parse(this.txtTotalAmount.Text.Trim());
                            obj.IsReceived = false;
                            obj.IsCancel = false;
                            obj.CheckedBy = this.txtCheckedBy.Text.Trim();

                            obj.CreatedBy = Variable.CurrentProfile.username;
                            obj.CreatedDate = DateTime.Now;
                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            db.tran_Debitor.Add(obj);
                            db.SaveChanges();

                            frmViewDebitorTransaction frmParent = Application.OpenForms["frmViewDebitorTransaction"] as frmViewDebitorTransaction;
                            frmParent.DGV();

                            gloService.Announce("บันทึกข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            break;
                        default:
                            obj = db.tran_Debitor.Where(w => w.ID == iType).FirstOrDefault();

                            obj.BillingPeriodID = _bpId;
                            obj.TransactionDate = this.dtpTransactionDate.Value;
                            obj.TransactionSeq = int.Parse(this.numTransactionSeq.Value.ToString());
                            obj.DocumentNo = this.txtDocumentNo.Text.Trim();
                            obj.IsOutsidePeriod = this.chkOutsidePeriod.Checked;
                            obj.DebitorID = int.Parse(this.cbDebitor.SelectedValue.ToString());
                            obj.JobID = int.Parse(this.cbJob.SelectedValue.ToString());
                            obj.ProductID = int.Parse(this.cbProduct.SelectedValue.ToString());
                            obj.CarLicense = this.txtCarLicense.Text.Trim();
                            obj.Driver = this.txtDriver.Text.Trim();
                            obj.TranWeight = this.numTranWeight.Value;
                            obj.TranSellPrice = this.numUnitPrice.Value;
                            obj.TranDiscount = this.numDiscount.Value;
                            obj.IsVat = this.numVat.Value > 0;
                            obj.TranVat = this.numVat.Value;
                            obj.TotalBeforeVat = decimal.Parse(this.txtBeforeVat.Text.Trim());
                            obj.TotalBeforeDiscount = decimal.Parse(this.txtNetAmount.Text.Trim());
                            obj.TotalAmount = decimal.Parse(this.txtTotalAmount.Text.Trim());
                            obj.CheckedBy = this.txtCheckedBy.Text.Trim();

                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            db.SaveChanges();
                            gloService.Announce("แก้ไขข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            this.Close();
                            break;
                    }
                }
                ClearForm();
                this.cbDebitor.Select();
            }
            else
            {
                _saveexit = 0;
                this.btnSave.Select();
                return;
            }
        }
        private void frmAddEditDebitorTran_Load(object sender, EventArgs e)
        {
            ClearForm();
            if (iType > 0)
            {
                var data = db.tran_Debitor.Where(w => w.ID == iType).FirstOrDefault();
                if (data != null)
                {
                    this.txtTranDebitorCode.Text = data.TransactionDebitorCode;
                    this.cbDebitor.SelectedValue = data.DebitorID;
                    this.chkOutsidePeriod.Checked = data.IsOutsidePeriod;

                    this.dtpTransactionDate.Value = data.TransactionDate;
                    this.txtDocumentNo.Text = data.DocumentNo;
                    this.numTransactionSeq.Value = data.TransactionSeq;
                    this.cbJob.SelectedValue = data.JobID;
                    this.txtCarLicense.Text = data.CarLicense;
                    this.txtDriver.Text = data.Driver;
                    this.cbProduct.SelectedValue = data.ProductID;

                    this.numTranWeight.Value = data.TranWeight;
                    this.numUnitPrice.Value = data.TranSellPrice;
                    this.numDiscount.Value = data.TranDiscount;
                    this.numVat.Value = data.TranVat;
                    this.txtCheckedBy.Text = data.CheckedBy;

                    this.btnCancelReceived.Visible = data.IsReceived;
                    this.btnReceived.Visible = !data.IsReceived;
                    this.lblAlreadyReceived.Visible = this.btnCancelReceived.Visible;

                    this.btnSave.Visible = this.btnReceived.Visible; this.btnSaveExit.Visible = this.btnReceived.Visible;
                }
                else
                {
                    gloService.Announce("ไม่สามารถค้นหาข้อมูลได้ .. โปรดตรวจสอบ", AnnounceType.Infomation);
                    this.Close();
                    return;
                }
            }
            else
                this.cbDebitor.Select();
        }
        private void cbJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbJob.SelectedIndex > 0)
            {
                int _jobid = int.Parse(this.cbJob.SelectedValue.ToString());
                db = new Entity.CSBNPEntities();
                var _job = db.mas_Job.Where(w => w.ID == _jobid).FirstOrDefault();
                if (_job == null)
                {
                    gloService.Announce("ไม่พบข้อมูลโครงการ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    this.cbJob.Select();
                }
                else
                {
                    this.txtJob.Text = _job.mas_Debtor.DebtorName + " (" + _job.Budget.ToString("#,0") + " : " + _job.JobDateStart.ToString("dd/MM/yyyy", cul) + ") ";
                    var dataProd = db.mas_JobDetail.Where(w => w.JobID == _jobid).OrderBy(o => o.ID).Select(s => new
                    {
                        val = s.ProductID,
                        txt = s.mas_Product.ProductName + " : " + s.mas_Product.ProductCode
                    }).ToList();
                    dataProd.Insert(0, new { val = 0, txt = "-- เลือกสินค้า --" });
                    this.cbProduct.DataSource = dataProd;
                    this.cbProduct.DisplayMember = "txt";
                    this.cbProduct.ValueMember = "val";
                }
            }
            else
            {
                this.txtJob.Text = string.Empty;
            }
        }
        private void cbDebitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbDebitor.SelectedIndex > 0)
            {
                db = new Entity.CSBNPEntities(); int _debitorrId = int.Parse(this.cbDebitor.SelectedValue.ToString());
                var _debitor = db.mas_Debtor.Where(w => w.ID == _debitorrId).FirstOrDefault();
                if (_debitor == null)
                {
                    gloService.Announce("ไม่พบข้อมูลลูกหนี้ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    this.cbDebitor.Select();
                }
                else
                {
                    this.txtDebitorName.Text = _debitor.DebtorContact + " (" + _debitor.DebtorTel + " : " + _debitor.DebtorAddress + ") ";
                }
            }
            else
            {
                this.txtDebitorName.Text = string.Empty;
            }
        }
        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbProduct.SelectedIndex > 0)
            {
                int _prodId = int.Parse(this.cbProduct.SelectedValue.ToString());
                var _prod = db.mas_Product.Where(w => w.ID == _prodId).FirstOrDefault();
                if (_prod == null)
                {
                    this.txtProductName.Text = string.Empty;
                    this.txtUnit.Text = string.Empty;
                    this.numUnitPrice.Value = 0;
                }
                else
                {
                    this.txtProductName.Text = _prod.ProductName + " (" + _prod.ProductPrice.ToString("#,0.00") + " : " + _prod.ProductUnit + ") ";
                    this.txtUnit.Text = _prod.ProductUnit;
                 //   this.numUnitPrice.Value = _prod.ProductPrice;
                    int _jobId = int.Parse(this.cbJob.SelectedValue.ToString());
                    var _jobDetail = db.mas_JobDetail.Where(w => w.JobID == _jobId && w.ProductID == _prodId).FirstOrDefault();
                    if (_jobDetail == null)
                    {
                        this.lblPO.Text = "0.00";
                    }
                    else
                    {
                        this.lblPO.Text = _jobDetail.JobQuantity.ToString("#,0.00");
                        this.numUnitPrice.Value = _jobDetail.ProductPriceExactly;
                    }
                    //this.numUnitPrice.Value = 0;
                }
            }
            else
            {
                this.txtProductName.Text = string.Empty;
                this.txtUnit.Text = string.Empty;
                this.numUnitPrice.Value = 0;
            }
        }
        private void chkOutsidePeriod_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkOutsidePeriod.Checked)
            {
                this.dtpTransactionDate.MinDate = DateTime.Now.AddYears(-1); this.dtpTransactionDate.MaxDate = DateTime.Now.AddYears(1);
                this.dtpTransactionDate.Checked = false;
            }
            else
            {
                this.dtpTransactionDate.MinDate = StartDate; this.dtpTransactionDate.MaxDate = EndDate; this.dtpTransactionDate.Checked = true;
            }
        }
        private void numVat_ValueChanged(object sender, EventArgs e)
        {
            Compute();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            goSave();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _saveexit = 1;
            goSave();
            if (_saveexit == 1)
                this.Close();
        }

        private void btnReceived_Click(object sender, EventArgs e)
        {
            if (gloService.Sure("คุณต้องการบันทึกการรับชำระหรือไม่") == DialogResult.Yes)
            {
                db = new Entity.CSBNPEntities();
                var rec = db.tran_Debitor.Where(w => w.ID == iType).FirstOrDefault();
                if (rec == null)
                {
                    gloService.Announce("ไม่สามารถปรับปรุงข้อมูลได้ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    this.btnReceived.Select(); return;
                }
                else
                {
                    rec.IsReceived = true;
                    rec.ReceivedBy = Variable.CurrentProfile.username;
                    rec.ReceivedDate = DateTime.Now;

                    rec.IsCancel = false;

                    db.SaveChanges();
                    gloService.Announce("บันทึกการรับชำระ .. เรียบร้อยแล้ว", AnnounceType.Infomation);
                    this.btnReceived.Visible = false;
                    this.lblAlreadyReceived.Visible = !this.btnReceived.Visible; this.btnCancelReceived.Visible = !this.btnReceived.Visible;
                    this.btnSave.Visible = this.btnReceived.Visible; this.btnSaveExit.Visible = this.btnReceived.Visible;
                }
            }
            else this.btnReceived.Select();
        }
        private void btnCancelReceived_Click(object sender, EventArgs e)
        {
            if (gloService.Sure("คุณต้องการยกเลิกการรับชำระหรือไม่") == DialogResult.Yes)
            {
                db = new Entity.CSBNPEntities();
                var cancel = db.tran_Debitor.Where(w => w.ID == iType).FirstOrDefault();
                if (cancel == null)
                {
                    gloService.Announce("ไม่สามารถปรับปรุงข้อมูลได้ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    this.btnReceived.Select(); return;
                }
                else
                {
                    cancel.IsReceived = false;
                    cancel.ReceivedBy = string.Empty;
                    cancel.ReceivedDate = null;

                    cancel.IsCancel = true;
                    cancel.CancelBy = Variable.CurrentProfile.username;
                    cancel.CancelDate = DateTime.Now;
                    db.SaveChanges();

                    gloService.Announce("ยกเลิกการรับชำระ .. เรียบร้อยแล้ว", AnnounceType.Infomation);
                    this.btnReceived.Visible = true;
                    this.lblAlreadyReceived.Visible = !this.btnReceived.Visible; this.btnCancelReceived.Visible = !this.btnReceived.Visible;
                    this.btnSave.Visible = this.btnReceived.Visible; this.btnSaveExit.Visible = this.btnReceived.Visible;

                }
            }
            else this.btnCancelReceived.Select();
        }
    }
}
