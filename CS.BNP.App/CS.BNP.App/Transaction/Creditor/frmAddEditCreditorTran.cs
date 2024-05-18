using CS.BNP.App.Models;
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

namespace CS.BNP.App.Transaction.Creditor
{
    public partial class frmAddEditCreditorTran : Form
    {
        public frmAddEditCreditorTran()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService(); Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        public int iType = 0; //0 == Insert, any(ID)==Edit 
        private byte _saveexit = 0; public int _bpId = 0; private byte atFirst = 0;
        public DateTime StartDate; public DateTime EndDate; 
        private void ClearForm()
        {
            if (atFirst == 0)
            {
                BindingControl();
                this.txtTranCreditorCode.Text = "-- สร้างให้อัติโนมัติ --"; /*this.dtpBillingDate.Value = DateTime.Now;*/
                this.txtCreditorName.Text = string.Empty;
                this.dtpTransactionDate.Checked = false; this.txtDocumentNo.Text = string.Empty; this.numTransactionSeq.Value = 1;
                this.cbJob.SelectedIndex = 0; this.txtJob.Text = string.Empty; this.txtCarLicense.Text = string.Empty;
                this.txtDriver.Text = string.Empty; this.cbProduct.DataSource = null; this.txtProductName.Text = string.Empty;

                this.numTranWeight.Value = 0; this.txtUnit.Text = string.Empty; /*this.numUnitPrice.Value = 0;*/ this.txtNetAmount.Text = "0.00";
                this.numDiscount.Value = 0; this.txtBeforeVat.Text = "0.00"; this.numVat.Value = 0; this.txtVat.Text = "0.00"; this.numUnit.Value = 1;
                this.txtTotalAmount.Text = "0.00"; this.lblPO.Text = "0.00"; this.txtAtVat.Text = "0.00";

                //Sale Date
                this.dtpTransactionDate.MinDate = StartDate; this.dtpTransactionDate.MaxDate = EndDate; this.dtpTransactionDate.Checked = false;
            }
            else
            {
                this.txtTranCreditorCode.Text = "-- สร้างให้อัติโนมัติ --";
                this.numTransactionSeq.Value = 1; this.numUnit.Value = 1; this.txtDocumentNo.Text = string.Empty;
                this.txtCarLicense.Text = string.Empty;
                this.txtDriver.Text = string.Empty;

                this.numTranWeight.Value = 0; /*this.txtUnit.Text = string.Empty; this.numUnitPrice.Value = 0;*/ this.txtNetAmount.Text = "0.00";
                this.numDiscount.Value = 0; this.txtBeforeVat.Text = "0.00"; this.numVat.Value = 0; this.txtVat.Text = "0.00";
                this.txtTotalAmount.Text = "0.00"; this.lblPO.Text = "0.00";

                CalPO();
            }
        }
        private void BindingControl()
        {
            var dataJob = db.mas_Job.Where(w=>w.IsApprove).OrderBy(o => o.ID).Select(s => new
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
            decimal _net = 0; decimal _vat = 0; decimal _atVat = 0; decimal _total = 0;
            _net = this.numTranWeight.Value * this.numUnitPrice.Value;
            _vat = (this.numVat.Value / 100) * _net;
            this.txtVat.Text = (_vat).ToString("#,0.00");
            this.txtNetAmount.Text = _net.ToString("#,0.00");
            if (!string.IsNullOrWhiteSpace(this.txtNetAmount.Text.Trim()) || (this.txtNetAmount.Text != "0.00"))
            {
                this.txtBeforeVat.Text = (_net + _vat).ToString("#,0.00");
            }
            if (!string.IsNullOrWhiteSpace(this.txtBeforeVat.Text.Trim()) || (this.txtBeforeVat.Text != "0.00"))
            {
                _atVat = ((this.numDiscount.Value / 100) *  _net);
                this.txtAtVat.Text = _atVat.ToString("(#,0.00)");
                if (!string.IsNullOrWhiteSpace(this.txtAtVat.Text.Trim()))
                {
                    this.txtTotalAmount.Text = ((_net + _vat) -_atVat).ToString("#,0.00");
                }
            }
        }
        private void goSave()
        {
            bool allow = true;
            if (this.cbCreditor.SelectedIndex == 0)
            {
                this.cbCreditor.BackColor = Color.LightCoral;
                allow &= false;
            }
            else
            {
                this.cbCreditor.BackColor = Color.White;
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
            allow &= gloService.RequireColorTextbox(this.txtUnit);
            allow &= gloService.RequireColorTextbox(this.numTranWeight);
            allow &= gloService.RequireColorTextbox(this.numUnitPrice);
            allow &= gloService.RequireColorTextbox(this.numUnit);

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
                    Entity.tran_Creditor obj;
                    switch (iType)
                    {
                        case 0:
                            obj = new Entity.tran_Creditor();
                            obj.TransactionCreditorCode = gloService.AutoGenerate(GenerateType.TransactionCreditor);
                            obj.BillingPeriodID = _bpId;
                            obj.BillingDate = this.dtpBillingDate.Value;
                            obj.TransactionDate = this.dtpTransactionDate.Value;
                            obj.TransactionSeq = int.Parse(this.numTransactionSeq.Value.ToString());
                            obj.TranUnitQuantity = int.Parse(this.numUnit.Value.ToString());
                            obj.DocumentNo = this.txtDocumentNo.Text.Trim();
                            obj.IsOutsidePeriod = this.chkOutsidePeriod.Checked;
                            obj.CreditorID = int.Parse(this.cbCreditor.SelectedValue.ToString());
                            obj.JobID = int.Parse(this.cbJob.SelectedValue.ToString());
                            obj.ProductID = int.Parse(this.cbProduct.SelectedValue.ToString());
                            obj.CarLicense = this.txtCarLicense.Text.Trim();
                            obj.Driver = this.txtDriver.Text.Trim();
                            obj.TranWeight = this.numTranWeight.Value;
                            obj.TranBuyPrice = this.numUnitPrice.Value;
                            obj.TranDiscount = this.numDiscount.Value;
                            obj.IsVat = this.numVat.Value > 0;
                            obj.TranVat = this.numVat.Value;
                            obj.TotalBeforeVat = decimal.Parse(this.txtBeforeVat.Text.Trim());
                            obj.TotalBeforeDiscount = decimal.Parse(this.txtNetAmount.Text.Trim());
                            obj.TotalAmount = decimal.Parse(this.txtTotalAmount.Text.Trim());
                            obj.IsPaid = false;
                            obj.IsCancel = false;
                            obj.IsUsed = false;
                            obj.TranUnit = this.txtUnit.Text.Trim();

                            obj.CreatedBy = Variable.CurrentProfile.username;
                            obj.CreatedDate = DateTime.Now;
                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            db.tran_Creditor.Add(obj);
                            db.SaveChanges();

                            //Creditor Mill
                            if (modelService != null)
                            {
                                if (modelService.Count() > 0)
                                {
                                    int _creId = modelService[0].creditorService_id; // Service
                                    var dataService = db.mas_Creditor.Where(w => w.ID == _creId).FirstOrDefault();
                                    var objMill = new Entity.tran_CreditorService();
                                    objMill.CreditorServiceID = dataService.ID;
                                    objMill.CreditorServiceCode = dataService.CreditorCode;
                                    objMill.CreditorServiceName = dataService.CreditorName;

                                    objMill.ProductServiceID = modelService[0].productService_id;

                                    objMill.IsVat = modelService[0].is_vat;
                                    objMill.VatAmount = modelService[0].vat_amount;
                                    objMill.VatInt = modelService[0].vat_int;

                                    objMill.IsAtVat = modelService[0].is_atvat;
                                    objMill.AtVatAmount = modelService[0].atvat_amount;
                                    objMill.AtVatInt = modelService[0].atvat_int;

                                    objMill.NetAmount = modelService[0].net_amount;
                                    objMill.TotalAmount = modelService[0].total_amount;
                                    objMill.TranCreditorID = obj.ID;
                                    objMill.Remark = modelService[0].remark;
                                    db.tran_CreditorService.Add(objMill);

                                    //Reduce Mill Advance
                                    int _jodId = int.Parse(this.cbJob.SelectedValue.ToString()); int _creIdMill = int.Parse(this.cbCreditor.SelectedValue.ToString());
                                    var reduce = db.tran_CreditorMillPrePaid.Where(w => w.CreditorServiceID == _creIdMill
                                    && w.JobID == _jodId).FirstOrDefault();
                                    if (reduce != null)
                                    {
                                        reduce.PaidAmount = db.tran_Creditor.Where(w => w.CreditorID == _creIdMill && w.JobID == _jodId).Sum(ss => ss.TotalAmount);
                                    }
                                    //
                                    db.SaveChanges();
                                }
                            }
                          

                            frmViewCreditorTransaction frmParent = Application.OpenForms["frmViewCreditorTransaction"] as frmViewCreditorTransaction;
                            frmParent.DGV();

                            //gloService.Announce("บันทึกข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            break;
                        default:
                            obj = db.tran_Creditor.Where(w => w.ID == iType).FirstOrDefault();

                            obj.BillingPeriodID = _bpId;
                            obj.BillingDate = this.dtpBillingDate.Value;
                            obj.TransactionDate = this.dtpTransactionDate.Value;
                            obj.TransactionSeq = int.Parse(this.numTransactionSeq.Value.ToString());
                            obj.TranUnitQuantity = int.Parse(this.numUnit.Value.ToString());
                            obj.DocumentNo = this.txtDocumentNo.Text.Trim();
                            obj.IsOutsidePeriod = this.chkOutsidePeriod.Checked;
                            obj.CreditorID = int.Parse(this.cbCreditor.SelectedValue.ToString());
                            obj.JobID = int.Parse(this.cbJob.SelectedValue.ToString());
                            obj.ProductID = int.Parse(this.cbProduct.SelectedValue.ToString());
                            obj.CarLicense = this.txtCarLicense.Text.Trim();
                            obj.Driver = this.txtDriver.Text.Trim();
                            obj.TranWeight = this.numTranWeight.Value;
                            obj.TranBuyPrice = this.numUnitPrice.Value;
                            obj.TranDiscount = this.numDiscount.Value;
                            obj.IsVat = this.numVat.Value > 0;
                            obj.TranVat = this.numVat.Value;
                            obj.TotalBeforeVat = decimal.Parse(this.txtBeforeVat.Text.Trim());
                            obj.TotalBeforeDiscount = decimal.Parse(this.txtNetAmount.Text.Trim());
                            obj.TotalAmount = decimal.Parse(this.txtTotalAmount.Text.Trim());
                            obj.IsUsed = false;

                            obj.TranUnit = this.txtUnit.Text.Trim();

                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            db.SaveChanges();

                            //Creditor Mill
                            if (modelService != null)
                            {
                                if (modelService.Count() > 0)
                                {
                                    int _creId = modelService[0].creditorService_id;
                                    var dataService = db.mas_Creditor.Where(w => w.ID == _creId).FirstOrDefault();

                                    if (modelService[0].id > 0)
                                    {
                                        var _creSerId = modelService[0].id;
                                        var objMill = db.tran_CreditorService.Where(w => w.ID == _creSerId).FirstOrDefault();
                                        objMill.CreditorServiceID = dataService.ID;
                                        objMill.CreditorServiceCode = dataService.CreditorCode;
                                        objMill.CreditorServiceName = dataService.CreditorName;
                                        objMill.ProductServiceID = modelService[0].productService_id;
                                        objMill.IsVat = modelService[0].is_vat;
                                        objMill.VatAmount = modelService[0].vat_amount;
                                        objMill.VatInt = modelService[0].vat_int;

                                        objMill.IsAtVat = modelService[0].is_atvat;
                                        objMill.AtVatAmount = modelService[0].atvat_amount;
                                        objMill.AtVatInt = modelService[0].atvat_int;

                                        objMill.NetAmount = modelService[0].net_amount;
                                        objMill.TotalAmount = modelService[0].total_amount;
                                        objMill.TranCreditorID = obj.ID;
                                        objMill.Remark = modelService[0].remark;

                                        //Reduce Mill Advance
                                        int _jodId = int.Parse(this.cbJob.SelectedValue.ToString()); int _creIdMill = int.Parse(this.cbCreditor.SelectedValue.ToString());
                                        var reduce = db.tran_CreditorMillPrePaid.Where(w => w.CreditorServiceID == _creIdMill
                                        && w.JobID == _jodId).FirstOrDefault();
                                        if (reduce != null)
                                        {
                                            reduce.PaidAmount = db.tran_Creditor.Where(w => w.CreditorID == _creIdMill && w.JobID == _jodId).Sum(ss => ss.TotalAmount);
                                        }
                                        //
                                    }
                                    else
                                    {
                                        //new 
                                        var objMill = new Entity.tran_CreditorService();
                                        objMill.CreditorServiceID = dataService.ID;
                                        objMill.CreditorServiceCode = dataService.CreditorCode;
                                        objMill.CreditorServiceName = dataService.CreditorName;
                                        objMill.ProductServiceID = modelService[0].productService_id;
                                        objMill.IsVat = modelService[0].is_vat;
                                        objMill.VatAmount = modelService[0].vat_amount;
                                        objMill.VatInt = modelService[0].vat_int;

                                        objMill.IsAtVat = modelService[0].is_atvat;
                                        objMill.AtVatAmount = modelService[0].atvat_amount;
                                        objMill.AtVatInt = modelService[0].atvat_int;

                                        objMill.NetAmount = modelService[0].net_amount;
                                        objMill.TotalAmount = modelService[0].total_amount;
                                        objMill.TranCreditorID = obj.ID;
                                        objMill.Remark = modelService[0].remark;
                                        db.tran_CreditorService.Add(objMill);

                                        //Reduce Mill Advance
                                        int _jodId = int.Parse(this.cbJob.SelectedValue.ToString()); int _creIdMill = int.Parse(this.cbCreditor.SelectedValue.ToString());
                                        var reduce = db.tran_CreditorMillPrePaid.Where(w => w.CreditorServiceID == _creIdMill
                                        && w.JobID == _jodId).FirstOrDefault();
                                        if (reduce != null)
                                        {
                                            reduce.PaidAmount = db.tran_Creditor.Where(w => w.CreditorID == _creIdMill && w.JobID == _jodId).Sum(ss => ss.TotalAmount);
                                        }

                                    }

                                    db.SaveChanges();
                                }
                            }
                            ////gloService.Announce("แก้ไขข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            this.Close();
                            break;
                    }
                }
                ClearForm();
                this.cbCreditor.Select();

                //Run Form
                frmMainMenu frmM = Application.OpenForms["frmMainMenu"] as frmMainMenu;
                if (frmM != null)
                {
                    frmM.CheckMill();
                }

            }
            else
            {
                _saveexit = 0;
                this.btnSave.Select();
                return;
            }
        }
        private bool _forceVis = false;
        private void frmAddEditCreditorTran_Load(object sender, EventArgs e)
        {
            ClearForm(); this.atFirst = 1;
            if (iType > 0)
            {
                var data = db.tran_Creditor.Where(w => w.ID == iType).FirstOrDefault();
                if (data != null)
                {
                    this.txtTranCreditorCode.Text = data.TransactionCreditorCode;
                    
                    this.chkOutsidePeriod.Checked = data.IsOutsidePeriod;

                    this.dtpBillingDate.Value = data.BillingDate; 
                    this.dtpTransactionDate.Value = data.TransactionDate; this.dtpTransactionDate.Checked = !data.IsOutsidePeriod;
                    this.txtDocumentNo.Text = data.DocumentNo;
                    this.numTransactionSeq.Value = data.TransactionSeq;
                    this.numUnit.Value = data.TranUnitQuantity;
                    this.cbJob.SelectedValue = data.JobID;
                    this.txtCarLicense.Text = data.CarLicense;
                    this.txtDriver.Text = data.Driver;
                    this.cbProduct.SelectedValue = data.ProductID;
                    this.cbCreditor.SelectedValue = data.CreditorID;
                    this.numTranWeight.Value = data.TranWeight;
                    this.numUnitPrice.Value = data.TranBuyPrice;
                    this.numDiscount.Value = data.TranDiscount;
                    this.numVat.Value = data.TranVat;

                    this.txtUnit.Text = data.TranUnit;

                    this.btnCancelPaid.Visible = data.IsPaid;
                    this.btnPaid.Visible = !data.IsPaid;
                    this.lblAlreadyPaid.Visible = this.btnCancelPaid.Visible;

                    var dataService = db.tran_CreditorService.Where(w => w.TranCreditorID == iType).FirstOrDefault();
                    if (dataService != null)
                    {
                        modelService = new List<CreditorService>();
                        var objMill = new CreditorService();
                        objMill.creditorService_id = dataService.CreditorServiceID;
                        objMill.id  = dataService.ID;
                        objMill.tran_id = dataService.TranCreditorID;
                        objMill.is_vat = dataService.IsVat;
                        objMill.net_amount = dataService.NetAmount;
                        objMill.remark = dataService.Remark;
                        objMill.total_amount = dataService.TotalAmount;
                        objMill.vat_int = dataService.VatInt;
                        objMill.vat_amount = dataService.VatAmount;
                        objMill.exAmount = dataService.TotalAmount;
                        objMill.productService_id = dataService.ProductServiceID;
                        modelService.Add(objMill);

                        if (modelService != null)
                            this.lblMill.Visible = modelService.Count() > 0;

                    }

                    if (!this._forceVis)
                    {
                        this.btnSave.Visible = this.btnPaid.Visible; this.btnSaveExit.Visible = this.btnPaid.Visible;
                    }
                }
                else
                {
                    gloService.Announce("ไม่สามารถค้นหาข้อมูลได้ .. โปรดตรวจสอบ", AnnounceType.Infomation);
                    this.Close();
                    return;
                }
            }
            else
                this.cbCreditor.Select();
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
                    this.txtJob.Text = _job.mas_Debtor.DebtorName + " (" + _job.Budget.ToString("#,0") + " : " + _job.JobDateStart.ToString("dd/MM/yyyy", Variable.cul) + ") ";
                    var dataProd = db.mas_JobDetail.Where(w => w.JobID == _jobid && !w.mas_Product.IsService).OrderBy(o => o.ID).Select(s => new
                    {
                        val = s.ProductID,
                        txt = s.mas_Product.ProductName + " : " + s.mas_Product.ProductCode
                    }).ToList();


                    //New
                    var dataProdCre = db.mas_JobCreditor.Where(w => w.JobID == _jobid).OrderBy(o => o.ID).Select(s => new
                    {
                        val = s.ProductID,
                        txt = s.mas_Product.ProductName + " : " + s.mas_Product.ProductCode
                    }).ToList();

                    dataProd.Insert(0, new { val = 0, txt = "-- เลือกสินค้า --" });
                    this.cbProduct.DataSource = dataProd;
                    this.cbProduct.DisplayMember = "txt";
                    this.cbProduct.ValueMember = "val";

                    var dataCre = db.mas_JobCreditor.Where(w => w.JobID == _jobid).OrderBy(o => o.ID).Select(s => new
                    {
                        val = s.CreditorID,
                        txt = s.mas_Creditor.CreditorName + " : " + s.mas_Creditor.CreditorCode
                    }).ToList();
                    dataCre.Insert(0, new { val = 0, txt = "-- เลือกเจ้าหนี้ --" });
                    this.cbCreditor.DataSource = dataCre;
                    this.cbCreditor.DisplayMember = "txt";
                    this.cbCreditor.ValueMember = "val";
                }
            }
            else
            {
                this.txtJob.Text = string.Empty;
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

                    CalPO();
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

        private void CalPO()
        {
            if (this.cbProduct.SelectedIndex > 0)
            {
                int _prodId = int.Parse(this.cbProduct.SelectedValue.ToString());
                int _jobId = int.Parse(this.cbJob.SelectedValue.ToString());
                var _jobDetail = db.mas_JobDetail.Where(w => w.JobID == _jobId && w.ProductID == _prodId).FirstOrDefault();
                if (_jobDetail == null)
                {
                    this.lblPO.Text = "0.00";
                }
                else
                {

                    decimal _used;
                    try
                    {
                        //_used = db.tran_Creditor.Where(w => w.BillingPeriodID == _bpId && w.ProductID == _prodId).Sum(ss => ss.TranWeight);
                        _used = db.tran_Creditor.Where(w => w.ProductID == _prodId && w.JobID == _jobId).Sum(ss => ss.TranWeight);
                    }
                    catch
                    {
                        _used = 0;
                    }
                    decimal _dis = _jobDetail.JobQuantity - _used; this.lblPO.Text = _dis.ToString("#,0.00");
                    if (_dis <= 0)
                    {
                        this.btnSave.Visible = false; this.btnSaveExit.Visible = false; this._forceVis = true;
                        gloService.Announce("ยอด PO มีค่าติดลบหรือเท่ากับ 0 .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    }
                    else
                    {
                        this.btnSave.Visible = true; this.btnSaveExit.Visible = true; this._forceVis = false;
                    }
                }
            }
        }

        private void cbCreditor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbCreditor.SelectedIndex > 0)
            {
                db = new Entity.CSBNPEntities(); int _creditorId = int.Parse(this.cbCreditor.SelectedValue.ToString());
                var _creditor = db.mas_Creditor.Where(w => w.ID == _creditorId).FirstOrDefault();
                if (_creditor == null)
                {
                    gloService.Announce("ไม่พบข้อมูลเจ้าหนี้ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    this.cbCreditor.Select();
                }
                else
                {
                    this.txtCreditorName.Text = _creditor.CreditorContact + " (" + _creditor.CreditorTel + " : " + _creditor.CreditorAddress + ") ";
                    if (this.cbCreditor.SelectedIndex > 0)
                    {
                        try
                        {
                            int _jobId = int.Parse(this.cbJob.SelectedValue.ToString()); int _prodId = int.Parse(this.cbProduct.SelectedValue.ToString());
                            //From Crdeitor New
                            var _setPrice = db.mas_JobCreditor.Where(w => w.CreditorID == _creditorId && w.JobID == _jobId && w.ProductID == _prodId).FirstOrDefault();
                            if (_setPrice == null)
                            {
                                gloService.Announce("ไม่พบราคาขายของเจ้าหนี้รายนี้ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                                this.cbProduct.SelectedIndex = 0; this.cbCreditor.SelectedIndex = 0;
                                return;
                            }
                            this.numUnitPrice.Value = (_setPrice == null ? 0 : _setPrice.ProductSellPrice);
                        }
                        catch
                        {

                        }
                      
                    }
                }
            }
            else
            {
                this.txtCreditorName.Text = string.Empty;
            }
        }
        private void chkOutsidePeriod_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkOutsidePeriod.Checked)
            {
                this.dtpTransactionDate.MinDate = DateTime.Now.AddYears(-999); this.dtpTransactionDate.MaxDate = DateTime.Now.AddYears(1);
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
        private void numUnitPrice_ValueChanged(object sender, EventArgs e)
        {
            Compute();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void btnPaid_Click(object sender, EventArgs e)
        {
            if (gloService.Sure("คุณต้องการบันทึกการชำระหรือไม่") == DialogResult.Yes)
            {
                db = new Entity.CSBNPEntities();
                var paid = db.tran_Creditor.Where(w => w.ID == iType).FirstOrDefault();
                if (paid == null)
                {
                    gloService.Announce("ไม่สามารถปรับปรุงข้อมูลได้ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    this.btnPaid.Select(); return;
                }
                else
                {
                    paid.IsPaid = true;
                    paid.PaidBy = Variable.CurrentProfile.username;
                    paid.PaidDate = DateTime.Now;

                    paid.IsCancel = false;

                    db.SaveChanges();
                    gloService.Announce("บันทึกการชำระ .. เรียบร้อยแล้ว", AnnounceType.Infomation);
                    this.btnPaid.Visible = false;
                    this.lblAlreadyPaid.Visible = !this.btnPaid.Visible; this.btnCancelPaid.Visible = !this.btnPaid.Visible;
                    this.btnSave.Visible = this.btnPaid.Visible; this.btnSaveExit.Visible = this.btnPaid.Visible;
                }
            }
            else this.btnPaid.Select();
        }
        private void btnCancelPaid_Click(object sender, EventArgs e)
        {
            if (gloService.Sure("คุณต้องการยกเลิกการชำระหรือไม่") == DialogResult.Yes)
            {
                db = new Entity.CSBNPEntities();
                var cancel = db.tran_Creditor.Where(w => w.ID == iType).FirstOrDefault();
                if (cancel == null)
                {
                    gloService.Announce("ไม่สามารถปรับปรุงข้อมูลได้ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    this.btnPaid.Select(); return;
                }
                else
                {
                    cancel.IsPaid = false;
                    cancel.PaidBy = string.Empty;
                    cancel.PaidDate = null;

                    cancel.IsCancel = true;
                    cancel.CancelBy = Variable.CurrentProfile.username;
                    cancel.CancelDate = DateTime.Now;
                    db.SaveChanges();

                    gloService.Announce("ยกเลิกการชำระ .. เรียบร้อยแล้ว", AnnounceType.Infomation);
                    this.btnPaid.Visible = true;
                    this.lblAlreadyPaid.Visible = !this.btnPaid.Visible; this.btnCancelPaid.Visible = !this.btnPaid.Visible;
                    this.btnSave.Visible = this.btnPaid.Visible; this.btnSaveExit.Visible = this.btnPaid.Visible;

                }
            }
            else this.btnCancelPaid.Select();
        }

        private void numTranWeight_Enter(object sender, EventArgs e)
        {
            (sender as NumericUpDown).Select(0, (sender as NumericUpDown).Text.Length);
        }

        public List<CreditorService> modelService;
        private void btnAddCreditorMill_Click(object sender, EventArgs e)
        {
            if ((this.cbJob.SelectedIndex > 0) && (this.numTranWeight.Value > 0))
            {
                frmAddEditCreditorMill frmMill = new frmAddEditCreditorMill();
                frmMill.iType = iType;
                frmMill.iJob = int.Parse(this.cbJob.SelectedValue.ToString());
                frmMill.iWeight = this.numTranWeight.Value;
                frmMill.modelService = modelService;
                frmMill.ShowDialog();

                modelService = frmMill.modelService;
            
                if (modelService != null)
                    this.lblMill.Visible = modelService.Count() > 0;
            }
            else
            {
                gloService.Announce("กรุณาเลือกโครงการ และน้ำหนักก่อนที่จะบันทึกการขนส่งเท่านั้น !!", AnnounceType.Warning);
                this.cbJob.Select(); return;
            }
        }
    }

  
}
