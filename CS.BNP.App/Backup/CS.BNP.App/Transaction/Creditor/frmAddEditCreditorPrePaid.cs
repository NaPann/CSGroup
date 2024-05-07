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
    public partial class frmAddEditCreditorPrePaid : Form
    {
        public frmAddEditCreditorPrePaid()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService(); Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        public int iType = 0; //0 == Insert, any(ID)==Edit 
        private byte _saveexit = 0; public int _bpId = 0;
        private void BindingControl()
        {
            var data = db.mas_Creditor.OrderBy(o => o.ID).Select(s => new
            {
                val = s.ID,
                txt = s.CreditorName + " : " + s.CreditorCode
            }).ToList();
            data.Insert(0, new { val = 0, txt = "-- เลือกเจ้าหนี้ --" });
            this.cbCreditor.DataSource = data;
            this.cbCreditor.DisplayMember = "txt";
            this.cbCreditor.ValueMember = "val";

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
        private void ClearForm()
        {
            BindingControl(); this.cbJob.SelectedIndex = 0;
            this.cbCreditor.SelectedIndex = 0; this.txtCreditorName.Text = string.Empty;
            this.txtBillingAmount.Text = "0.00"; this.numPrePaid.Value = 0; this.lblID.Text = string.Empty;
            this.txtRemark.Text = string.Empty; 
        }
        private void frmAddEditCreditorPrePaid_Load(object sender, EventArgs e)
        {
            ClearForm();
            if (iType > 0)
            {
                var data = db.tran_CreditorPrePaid.Where(w => w.ID == iType).FirstOrDefault();
                if (data != null)
                {
                    this.cbCreditor.SelectedValue = data.CreditorID;
                    this.cbJob.SelectedValue = data.JobID;
                    this.numPrePaid.Value = data.TotalAmount;
                    this.txtRemark.Text = data.Remark;

                    this.cbCreditor.Enabled = false; this.cbJob.Enabled = false;
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
                this.cbCreditor.Enabled = true; this.cbJob.Enabled = true;
                this.cbCreditor.Select();
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
            allow &= gloService.RequireColorTextbox(this.numPrePaid);
          
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

            decimal sumD = decimal.Parse(this.txtBillingAmount.Text.Trim());
            //if (sumD < this.numPrePaid.Value)
            //{
            //    gloService.Announce("ยอดเบิกเงินล่วงหน้า .. เกินกว่ายอดวางบิล", AnnounceType.Warning);
            //    this.numPrePaid.Focus(); this.numPrePaid.Select(0, this.numPrePaid.Value.ToString().Length);
            //    return;
            //}

            //Save
            if (gloService.Sure("คุณต้องการบันทึกข้อมูล ?") == DialogResult.Yes)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    Entity.tran_CreditorPrePaid obj;
                    //if (string.IsNullOrEmpty(this.lblID.Text.Trim()))
                    //{
                    //    try
                    //    {
                    //        iType = int.Parse(this.lblID.Text.Trim());
                    //    }
                    //    catch
                    //    {
                    //    }                    
                    //}
                    switch (iType)
                    {
                        case 0:
                            obj = new Entity.tran_CreditorPrePaid();
                            obj.BillingPeriodID = _bpId;
                            obj.CreditorID = int.Parse(this.cbCreditor.SelectedValue.ToString());
                            obj.TotalAmount = this.numPrePaid.Value;
                            obj.JobID = int.Parse(this.cbJob.SelectedValue.ToString());
                            obj.CreatedBy = Variable.CurrentProfile.username;
                            obj.CreatedDate = DateTime.Now;
                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            obj.Remark = this.txtRemark.Text.Trim();
                            db.tran_CreditorPrePaid.Add(obj);
                            db.SaveChanges();

                            frmViewCreditorPrePaid frmParent = Application.OpenForms["frmViewCreditorPrePaid"] as frmViewCreditorPrePaid;
                            frmParent.DGV();

                           //// gloService.Announce("บันทึกข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            break;
                        default:
                            obj = db.tran_CreditorPrePaid.Where(w => w.ID == iType).FirstOrDefault();

                            obj.BillingPeriodID = _bpId;
                            obj.CreditorID = int.Parse(this.cbCreditor.SelectedValue.ToString());
                            obj.TotalAmount = this.numPrePaid.Value;
                            obj.JobID = int.Parse(this.cbJob.SelectedValue.ToString());
                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            obj.Remark = this.txtRemark.Text.Trim();
                            db.SaveChanges();
                            //gloService.Announce("แก้ไขข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            this.Close();
                            break;
                    }
                }
                ClearForm();
                this.cbCreditor.Select();
            }
            else
            {
                _saveexit = 0;
                this.btnSave.Select();
                return;
            }
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
                }
                this.Compute();
            }
            else
            {
                this.txtCreditorName.Text = string.Empty;
            }
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
                }
                this.Compute();
            }
            else
            {
                this.txtJob.Text = string.Empty;
            }
        }
        private void Compute()
        {
            if (this.cbCreditor.SelectedIndex > 0 && this.cbJob.SelectedIndex > 0)
            {
                int jobId = int.Parse(this.cbJob.SelectedValue.ToString()); int creId = int.Parse(this.cbCreditor.SelectedValue.ToString()); this.lblID.Text = string.Empty;
                try
                {
                    this.txtBillingAmount.Text = db.tran_Creditor.Where(w => w.BillingPeriodID == _bpId
                    && w.CreditorID == creId && w.JobID == jobId).Sum(ss => ss.TotalAmount).ToString("#,0.00");
                }
                catch
                {
                    this.txtBillingAmount.Text = "0.00";
                }

                //try
                //{
                //    var ex = db.tran_CreditorPrePaid.Where(w => w.BillingPeriodID == _bpId
                //    && w.CreditorID == creId && w.JobID == jobId).FirstOrDefault();
                //    this.numPrePaid.Value = ex.TotalAmount;
                //    this.lblID.Text = ex.ID.ToString();
                //}
                //catch
                //{
                //    this.numPrePaid.Value = 0;
                //}
            }
        }

        private void numPrePaid_Enter(object sender, EventArgs e)
        {
            (sender as NumericUpDown).Select(0, (sender as NumericUpDown).Text.Length);
        }

        private void numPrePaid_Leave(object sender, EventArgs e)
        {
            decimal sumD = decimal.Parse(this.txtBillingAmount.Text.Trim());
            //if (sumD < this.numPrePaid.Value)
            //{
            //    gloService.Announce("ยอดเบิกเงินล่วงหน้า .. เกินกว่ายอดวางบิล", AnnounceType.Warning);
            //    this.numPrePaid.Focus(); this.numPrePaid.Select(0, this.numPrePaid.Value.ToString().Length);
            //    return;
            //}
        }
    }
}
