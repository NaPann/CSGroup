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
    public partial class frmAddEditCreditorMill : Form
    {
        public frmAddEditCreditorMill()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService(); Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        public int iType = 0; //0 == Insert, any(ID)==Edit 
        public int iJob = 0; public decimal iWeight = 0; public int iID = 0;
        public List<CreditorService> modelService;
        private void BindingControl()
        {
            var data = db.mas_JobCreditor.Where(w=>w.JobID == iJob).OrderBy(o => o.ID).Select(s => new
            {
                val = s.CreditorID,
                txt = s.mas_Creditor.CreditorName + " : " + s.mas_Creditor.CreditorCode
            }).ToList();
            data.Insert(0, new { val = 0, txt = "-- เลือกผู้ขนสินค้า --" });
            this.cbCreditorMill.DataSource = data;
            this.cbCreditorMill.DisplayMember = "txt";
            this.cbCreditorMill.ValueMember = "val";

            var dataJob = db.mas_Job.Where(w => w.ID == iJob && w.IsApprove).FirstOrDefault();
            if (dataJob == null)
            {
                gloService.Announce("ไม่สามารถค้นหาข้อมูลโครงการได้ .. โปรดตรวจสอบ", AnnounceType.Infomation);
                this.Close();
                return;
            }
            else
            {
                this.txtJobCode.Text = dataJob.JobCode;
                this.txtJob.Text = dataJob.mas_Debtor.DebtorName + " (" + dataJob.Budget.ToString("#,0") + " : " + dataJob.JobDateStart.ToString("dd/MM/yyyy", Variable.cul) + ") ";
            }
        }
        private void ClearForm()
        {
            BindingControl();
            this.cbCreditorMill.SelectedIndex = 0; this.txtCreditorMillName.Text = string.Empty;
            this.numVat.Value = 0; this.numTotalAmount.Value = 0; this.lblID.Text = string.Empty;
            this.txtRemark.Text = string.Empty; this.txtVat.Text = string.Empty;
        }
        private void frmAddEditCreditorMill_Load(object sender, EventArgs e)
        {
            ClearForm();
            if (iType > 0)
            {
                var data = db.tran_Creditor.Where(w => w.ID == iType).FirstOrDefault();
                if (data != null)
                {
                    var dataService = db.tran_CreditorService.Where(w => w.TranCreditorID == iType).FirstOrDefault();
                    if (dataService == null)
                    {
                        this.cbCreditorMill.Enabled = true;
                        this.numTranWeight.Value = iWeight;
                        this.cbCreditorMill.Select();
                    }
                    else
                    {
                        this.cbCreditorMill.SelectedValue = dataService.CreditorServiceID;
                        this.txtJobCode.Text = data.mas_Job.JobCode;
                        this.txtJob.Text = data.mas_Job.mas_Debtor.DebtorName + " (" + data.mas_Job.Budget.ToString("#,0") + " : " + data.mas_Job.JobDateStart.ToString("dd/MM/yyyy", Variable.cul) + ") ";
                        this.numTotalAmount.Value = dataService.NetAmount;

                        this.numVat.Value = dataService.VatInt; this.txtVat.Text = dataService.VatAmount.ToString("#.00");
                        this.numAtVat.Value = dataService.AtVatInt; this.txtAtVat.Text = dataService.AtVatAmount.ToString("#.00");

                        this.txtRemark.Text = dataService.Remark;
                        this.numTranWeight.Value = iWeight;
                        this.cbProductService.SelectedValue = dataService.ProductServiceID;

                        iID = dataService.ID;

                        this.lblEX.Text = dataService.TotalAmount.ToString("#.00");
                        this.cbCreditorMill.Select();
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
            {
                if (modelService != null)
                {
                    if (modelService.Count() > 0)
                    {
                        this.cbCreditorMill.SelectedValue = modelService[0].creditorService_id;
                        this.numTotalAmount.Value = modelService[0].net_amount;
                        this.numVat.Value = modelService[0].vat_int; this.txtVat.Text = modelService[0].vat_amount.ToString("#.00");
                        this.numAtVat.Value = modelService[0].atvat_int; this.txtAtVat.Text = modelService[0].atvat_amount.ToString("#.00");
                        this.txtRemark.Text = modelService[0].remark; this.numTranWeight.Value = iWeight;

                        this.cbProductService.SelectedValue = modelService[0].productService_id;

                        this.cbCreditorMill.Enabled = true;
                        this.cbCreditorMill.Select();
                    }
                    else
                    {
                        this.numTranWeight.Value = iWeight;
                        this.cbCreditorMill.Enabled = true;
                        this.cbCreditorMill.Select();
                    }
                }
                else
                {
                    this.numTranWeight.Value = iWeight;
                }
            }
        }

        private void cbCreditorMill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbCreditorMill.SelectedIndex > 0)
            {
                db = new Entity.CSBNPEntities(); int _creditorId = int.Parse(this.cbCreditorMill.SelectedValue.ToString());
                var _creditor = db.mas_Creditor.Where(w => w.ID == _creditorId).FirstOrDefault();
                if (_creditor == null)
                {
                    gloService.Announce("ไม่พบข้อมูลเจ้าหนี้ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    this.cbCreditorMill.Select();
                }
                else
                {
                    this.txtCreditorMillName.Text = _creditor.CreditorContact + " (" + _creditor.CreditorTel + " : " + _creditor.CreditorAddress + ") ";

                    //getProductService
                    var dataProdSer = db.mas_JobCreditor.Where(w => w.JobID == iJob && w.mas_Product.IsService).OrderBy(o => o.ID).Select(s => new
                    {
                        val = s.ProductID,
                        txt = s.mas_Product.ProductName + " : " + s.mas_Product.ProductCode
                    }).ToList();

                    dataProdSer.Insert(0, new { val = 0, txt = "-- เลือกการขนส่ง --" });
                    this.cbProductService.DataSource = dataProdSer;
                    this.cbProductService.DisplayMember = "txt";
                    this.cbProductService.ValueMember = "val";

                    ////getPrice
                    //this.txtPrice.Text = 
                }
            }
            else
            {
                this.txtCreditorMillName.Text = string.Empty;
            }
        }

        private void numTotalAmount_Enter(object sender, EventArgs e)
        {
            (sender as NumericUpDown).Select(0, (sender as NumericUpDown).Text.Length);
        }

        private void numTotalAmount_Leave(object sender, EventArgs e)
        {

        }
        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            bool allow = true;
            if (this.cbCreditorMill.SelectedIndex == 0)
            {
                this.cbCreditorMill.BackColor = Color.LightCoral;
                allow &= false;
            }
            else
            {
                this.cbCreditorMill.BackColor = Color.White;
                allow &= true;
            }
            allow &= gloService.RequireColorTextbox(this.numTotalAmount);

            if (!allow)
            {
                this.panelWarning.Visible = true;
                return;
            }
            else
            {
                this.panelWarning.Visible = false;
            }

            if (gloService.Sure("คุณต้องการบันทึกข้อมูลการขนส่ง") == DialogResult.Yes)
            {
                if (modelService != null)
                    modelService.Clear();
                else
                    modelService = new List<CreditorService>();
                var obj = new CreditorService();

                obj.id = iID;

                obj.creditorService_id = int.Parse(this.cbCreditorMill.SelectedValue.ToString());
                obj.productService_id = int.Parse(this.cbProductService.SelectedValue.ToString());
                obj.tran_id = iType;

                obj.is_vat = this.numVat.Value > 0;
                obj.vat_int = this.numVat.Value;
                obj.vat_amount = (this.numVat.Value / 100) * (this.numPrice.Value * this.numTranWeight.Value);

                obj.is_atvat = this.numAtVat.Value > 0;
                obj.atvat_int = this.numAtVat.Value;
                obj.atvat_amount = (this.numAtVat.Value / 100) * (this.numPrice.Value * this.numTranWeight.Value);

                obj.total_amount = ((this.numTranWeight.Value * this.numPrice.Value) - (string.IsNullOrWhiteSpace(this.txtAtVat.Text.Trim()) ? 0 : decimal.Parse(this.txtAtVat.Text.Trim()))) + (string.IsNullOrWhiteSpace(this.txtVat.Text.Trim()) ? 0 : decimal.Parse(this.txtVat.Text.Trim()));
                obj.net_amount = (this.numPrice.Value * this.numTranWeight.Value);
                obj.remark = this.txtRemark.Text.Trim();
                if (!string.IsNullOrEmpty(this.lblEX.Text.Trim()))
                    obj.exAmount = decimal.Parse(this.lblEX.Text.Trim());
                modelService.Add(obj);
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numVat_ValueChanged(object sender, EventArgs e)
        {
            this.Compute();
        }

        private void Compute()
        {
           // this.lblTotal.Text = (this.numTranWeight.Value * this.numPrice.Value).ToString();
            this.txtVat.Text = ((this.numVat.Value / 100) * (this.numTranWeight.Value * this.numPrice.Value)).ToString("#,0.00");
            this.txtAtVat.Text = ((this.numAtVat.Value / 100) * (this.numTranWeight.Value * this.numPrice.Value)).ToString("#,0.00");
            this.numTotalAmount.Value = ((this.numTranWeight.Value * this.numPrice.Value) - (string.IsNullOrWhiteSpace(this.txtAtVat.Text.Trim()) ? 0 : decimal.Parse(this.txtAtVat.Text.Trim()))) + (string.IsNullOrWhiteSpace(this.txtVat.Text.Trim()) ? 0 : decimal.Parse(this.txtVat.Text.Trim())) 
            ;
        }

        private void numTotalAmount_ValueChanged(object sender, EventArgs e)
        {
            this.Compute();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            if ( iType == 0)
            {
                gloService.Announce("ไม่พบข้อมูลการบันทึกการขนส่ง .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                this.cbCreditorMill.Select(); return;
            }
            else
            {
                var exMill = db.tran_CreditorService.Where(w => w.TranCreditorID == iType).FirstOrDefault();
                if (exMill == null)
                {
                    gloService.Announce("ไม่พบข้อมูลการบันทึกการขนส่ง .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    this.cbCreditorMill.Select(); return;
                }
            }

            if (gloService.Sure("คุณต้องการลบข้อมูลการขนส่ง") == DialogResult.Yes)
            {
                if (modelService != null)
                    modelService.Clear();
                else
                    modelService = new List<CreditorService>();
                var exObjMill = db.tran_CreditorService.Where(w => w.TranCreditorID == iType).FirstOrDefault();
                if (exObjMill != null)
                {
                    db.tran_CreditorService.Remove(exObjMill);
                    db.SaveChanges();
                    if (!string.IsNullOrWhiteSpace(this.lblEX.Text.Trim()))
                    {
                        //Reduce Mill Advance
                        int _jodId = iJob;
                        var reduce = db.tran_CreditorMillPrePaid.Where(w => w.CreditorServiceID == exObjMill.CreditorServiceID
                        && w.JobID == _jodId).FirstOrDefault();
                        if (reduce != null)
                        {
                            //roll back first
                            reduce.PaidAmount = reduce.PaidAmount - decimal.Parse(this.lblEX.Text.Trim());
                        }
                        //
                        db.SaveChanges();
                    }
                }
                this.Close();
            }
        }

        private void cbProductService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbProductService.SelectedIndex > 0)
            {
                db = new Entity.CSBNPEntities(); int _creditorId = int.Parse(this.cbCreditorMill.SelectedValue.ToString()); int _prodId = int.Parse(this.cbProductService.SelectedValue.ToString());
                var _setPrice = db.mas_JobCreditor.Where(w => w.CreditorID == _creditorId && w.JobID == iJob && w.ProductID == _prodId).FirstOrDefault();
                if (_setPrice == null)
                {
                    gloService.Announce("ไม่พบราคาขายของเจ้าหนี้รายนี้ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    this.cbProductService.SelectedIndex = 0; this.cbProductService.SelectedIndex = 0;
                    return;
                }
                this.numPrice.Value = (_setPrice == null ? 0 : _setPrice.ProductSellPrice);
                this.Compute();
            }
            else
            {
                this.cbProductService.Select();
            }
        }

        private void numAtVat_ValueChanged(object sender, EventArgs e)
        {
            this.Compute();
        }
    }
}
