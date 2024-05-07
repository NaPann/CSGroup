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
    public partial class frmAddEditCreditorMillPrePaid : Form
    {
        public frmAddEditCreditorMillPrePaid()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService(); Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        public int iType = 0; //0 == Insert, any(ID)==Edit 
        private byte _saveexit = 0;
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
            this.cbCreditorMill.SelectedIndex = 0; this.txtCreditorMillName.Text = string.Empty;
            this.txtBillingAmount.Text = "0.00"; this.numPrePaid.Value = 0; this.lblID.Text = string.Empty;
            this.txtRemark.Text = string.Empty;
        }
        private void frmAddEditCreditorMillPrePaid_Load(object sender, EventArgs e)
        {
            ClearForm();
            if (iType > 0)
            {
                var data = db.tran_CreditorMillPrePaid.Where(w => w.ID == iType).FirstOrDefault();
                if (data != null)
                {
                    this.cbCreditorMill.SelectedValue = data.CreditorMillID;
                    this.cbJob.SelectedValue = data.JobID;
                    this.numPrePaid.Value = data.TotalAmount;
                    this.txtRemark.Text = data.Remark;

                    this.cbCreditorMill.Enabled = false; this.cbJob.Enabled = false;
                    this.numPrePaid.Select();
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
                this.cbCreditorMill.Enabled = true; this.cbJob.Enabled = true;
                this.cbCreditorMill.Select();
            }
        }
        private void goSave()
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
                    Entity.tran_CreditorMillPrePaid obj;
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
                            obj = new Entity.tran_CreditorMillPrePaid();
                            obj.CreditorMillID = int.Parse(this.cbCreditorMill.SelectedValue.ToString());
                            obj.TotalAmount = this.numPrePaid.Value;
                            obj.JobID = int.Parse(this.cbJob.SelectedValue.ToString());
                            obj.CreatedBy = Variable.CurrentProfile.username;
                            obj.CreatedDate = DateTime.Now;
                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            obj.Remark = this.txtRemark.Text.Trim();
                            db.tran_CreditorMillPrePaid.Add(obj);
                            db.SaveChanges();

                            frmViewCreditorMillPrePaid frmParent = Application.OpenForms["frmViewCreditorMillPrePaid"] as frmViewCreditorMillPrePaid;
                            frmParent.DGV();

                            //// gloService.Announce("บันทึกข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            break;
                        default:
                            obj = db.tran_CreditorMillPrePaid.Where(w => w.ID == iType).FirstOrDefault();

                            obj.CreditorMillID = int.Parse(this.cbCreditorMill.SelectedValue.ToString());
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
                this.cbCreditorMill.Select();
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
                this.Compute();
            }
            else
            {
                this.txtCreditorMillName.Text = string.Empty;
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
            if (this.cbCreditorMill.SelectedIndex > 0 && this.cbJob.SelectedIndex > 0)
            {
                int jobId = int.Parse(this.cbJob.SelectedValue.ToString()); int creId = int.Parse(this.cbCreditorMill.SelectedValue.ToString()); this.lblID.Text = string.Empty;
                try
                {
                    this.txtBillingAmount.Text = db.tran_CreditorMill.Where(w => w.CreditorMillID == creId && w.tran_Creditor.JobID == jobId).Sum(ss => ss.TotalAmount).ToString("#,0.00");
                }
                catch
                {
                    this.txtBillingAmount.Text = "0.00";
                }
            }
        }

        private void numPrePaid_Enter(object sender, EventArgs e)
        {
            (sender as NumericUpDown).Select(0, (sender as NumericUpDown).Text.Length);
        }
    }
}
