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
        public int iJob = 0;
        public List<CreditorMill> modelMill;
        private void BindingControl()
        {
            var data = db.mas_CreditorMill.OrderBy(o => o.ID).Select(s => new
            {
                val = s.ID,
                txt = s.CreditorMillName + " : " + s.CreditorMillCode
            }).ToList();
            data.Insert(0, new { val = 0, txt = "-- เลือกโรงโม่ --" });
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
                    var dataMill = db.tran_CreditorMill.Where(w => w.TranCreditorID == iType).FirstOrDefault();
                    if (dataMill == null)
                    {
                        this.cbCreditorMill.Enabled = true;
                        this.cbCreditorMill.Select();
                    }
                    else
                    {
                        this.cbCreditorMill.SelectedValue = dataMill.CreditorMillID;
                        this.txtJobCode.Text = data.mas_Job.JobCode;
                        this.txtJob.Text = data.mas_Job.mas_Debtor.DebtorName + " (" + data.mas_Job.Budget.ToString("#,0") + " : " + data.mas_Job.JobDateStart.ToString("dd/MM/yyyy", Variable.cul) + ") ";
                        this.numTotalAmount.Value = dataMill.NetAmount;
                        this.numVat.Value = dataMill.VatInt; this.txtVat.Text = dataMill.VatAmount.ToString("#.00");
                        this.txtRemark.Text = dataMill.Remark;
                        this.lblEX.Text = dataMill.TotalAmount.ToString("#.00");
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
                if (modelMill != null)
                {
                    if (modelMill.Count() > 0)
                    {
                        this.cbCreditorMill.SelectedValue = modelMill[0].creditormilll_id;
                        this.numTotalAmount.Value = modelMill[0].net_amount;
                        this.numVat.Value = modelMill[0].vat_int; this.txtVat.Text = modelMill[0].vat_amount.ToString("#.00");
                        this.txtRemark.Text = modelMill[0].remark;
                        this.cbCreditorMill.Enabled = true;
                        this.cbCreditorMill.Select();
                    }
                    else
                    {
                        this.cbCreditorMill.Enabled = true;
                        this.cbCreditorMill.Select();
                    }
                }
            }
        }

        private void cbCreditorMill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbCreditorMill.SelectedIndex > 0)
            {
                db = new Entity.CSBNPEntities(); int _creditorId = int.Parse(this.cbCreditorMill.SelectedValue.ToString());
                var _creditor = db.mas_CreditorMill.Where(w => w.ID == _creditorId).FirstOrDefault();
                if (_creditor == null)
                {
                    gloService.Announce("ไม่พบข้อมูลโรงโม่ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    this.cbCreditorMill.Select();
                }
                else
                {
                    this.txtCreditorMillName.Text = _creditor.CreditorMillContact + " (" + _creditor.CreditorMillTel + " : " + _creditor.CreditorMillAddress + ") ";
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

            if (gloService.Sure("คุณต้องการบันทึกข้อมูลโรงโม่") == DialogResult.Yes)
            {
                if (modelMill != null)
                    modelMill.Clear();
                else
                    modelMill = new List<CreditorMill>();
                var obj = new CreditorMill();
                obj.creditormilll_id = int.Parse(this.cbCreditorMill.SelectedValue.ToString());
                obj.tran_id = iType;
                obj.is_vat = this.numVat.Value > 0;
                obj.vat_int = this.numVat.Value;
                obj.vat_amount = (this.numVat.Value / 100) * this.numTotalAmount.Value;
                obj.total_amount = ((this.numVat.Value / 100) * this.numTotalAmount.Value) + this.numTotalAmount.Value;
                obj.net_amount = this.numTotalAmount.Value;
                obj.remark = this.txtRemark.Text.Trim();
                if (!string.IsNullOrEmpty(this.lblEX.Text.Trim()))
                    obj.exAmount = decimal.Parse(this.lblEX.Text.Trim());
                modelMill.Add(obj);
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
            this.txtVat.Text = ((this.numVat.Value / 100) * this.numTotalAmount.Value).ToString("#,0.00");
        }

        private void numTotalAmount_ValueChanged(object sender, EventArgs e)
        {
            this.Compute();
        }
    }
}
