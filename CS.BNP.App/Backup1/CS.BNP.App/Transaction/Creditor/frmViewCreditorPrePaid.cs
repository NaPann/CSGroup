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
    public partial class frmViewCreditorPrePaid : Form
    {
        public frmViewCreditorPrePaid()
        {
            InitializeComponent();
        }
        Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        Services.GlobalService gloService = new Services.GlobalService();
        private void ClearForm()
        {
            BindingControl();
            this.cbBillingPeriod.SelectedIndex = 0;
        }
        private void BindingControl()
        {
            var _tmp = db.tran_BillingPeriod.ToList();
            var data = _tmp.OrderBy(o => o.ID).Select(s => new
            {
                val = s.ID,
                txt = s.BillingPeriodCode + " : " + s.BillingDateFrom.ToString("dd.MM.yyyy", Variable.cul) + " - " + s.BillingDateTo.ToString("dd.MM.yyyy", Variable.cul)
            }).ToList();
            data.Insert(0, new { val = 0, txt = "-- เลือกช่วงเวลาการตั้งเบิกจ่าย --" });
            this.cbBillingPeriod.DataSource = data;
            this.cbBillingPeriod.DisplayMember = "txt";
            this.cbBillingPeriod.ValueMember = "val";
        }
        public void DGV()
        {
            if (this.cbBillingPeriod.SelectedIndex > 0)
            {
                db = new Entity.CSBNPEntities();
                ControlBTN(true);
                int _condition = int.Parse(this.cbBillingPeriod.SelectedValue.ToString());
                var data = db.tran_CreditorPrePaid.Where(w => w.BillingPeriodID == _condition).AsEnumerable().Select((s, inx) => new
                {
                    iNo = inx + 1,
                    ID = s.ID,
                    BillingPeriodID = s.BillingPeriodID,
                    BillingPeriodCode = s.tran_BillingPeriod.BillingPeriodCode,
                    CreditorID = s.CreditorID,
                    CreditorName = s.mas_Creditor.CreditorName,
                    JobID = s.JobID,
                    JobName = s.mas_Job.JobName,
                    TotalAmount = s.TotalAmount,
                }).ToList();
                this.gridControl.DataSource = data;
                this.gridControl.ForceInitialize();
            }
            else
            {
                ControlBTN(false);
            }
        }
        private void ControlBTN(bool v)
        {
            this.btnAddData.Visible = v;
        }
        private void frmViewCreditorPrePaid_Load(object sender, EventArgs e)
        {
            ClearForm();
            this.cbBillingPeriod.Select();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            frmAddEditCreditorPrePaid frm = new frmAddEditCreditorPrePaid();
            int _bpId = int.Parse(this.cbBillingPeriod.SelectedValue.ToString());
            var _bp = db.tran_BillingPeriod.Where(w => w.ID == _bpId).FirstOrDefault();
            frm._bpId = _bpId;
            frm.BringToFront();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbBillingPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnAddData.Visible = this.cbBillingPeriod.SelectedIndex > 0;
            DGV();
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmAddEditCreditorPrePaid frmEdit = new frmAddEditCreditorPrePaid();
            frmEdit.iType = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns[0]).ToString());
            int _bpId = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["BillingPeriodID"]).ToString());
            frmEdit._bpId = _bpId;
            frmEdit.BringToFront();
            frmEdit.StartPosition = FormStartPosition.CenterParent;
            frmEdit.ShowDialog();
            DGV();
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gloService.Sure("คุณต้องการลบข้อมูลรายการนี้ ?") == DialogResult.Yes)
            {
                int _deldata = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns[0]).ToString());
                using (var db = new Entity.CSBNPEntities())
                {
                    var del = db.tran_CreditorPrePaid.Where(w => w.ID == _deldata).FirstOrDefault();
                    db.tran_CreditorPrePaid.Remove(del);
                    db.SaveChanges();
                }
                DGV();
                //gloService.Announce("ลบข้อมูลเรียบร้อย", AnnounceType.Infomation);
            }
            else return;
        }

       
    }
}
