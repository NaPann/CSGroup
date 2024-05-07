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
    public partial class frmViewDebitorTransaction : Form
    {
        public frmViewDebitorTransaction()
        {
            InitializeComponent();
        }
        Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        Services.GlobalService gloService = new Services.GlobalService();
        System.Globalization.CultureInfo cul = new System.Globalization.CultureInfo("en-us");
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
                txt = s.BillingPeriodCode + " : " + s.BillingDateFrom.ToString("dd.MM.yyyy", cul) + " - " + s.BillingDateTo.ToString("dd.MM.yyyy", cul)
            }).ToList();
            data.Insert(0, new { val = 0, txt = "-- เลือกช่วงเวลาการตั้งเบิกจ่าย --" });
            this.cbBillingPeriod.DataSource = data;
            this.cbBillingPeriod.DisplayMember = "txt";
            this.cbBillingPeriod.ValueMember = "val";
        }
        private void frmViewDebitorTransaction_Load(object sender, EventArgs e)
        {
            ClearForm();
            this.cbBillingPeriod.Select();
        }
        public void DGV()
        {
            if (this.cbBillingPeriod.SelectedIndex > 0)
            {
                ControlBTN(true);
                int _condition = int.Parse(this.cbBillingPeriod.SelectedValue.ToString());
                var data = db.tran_Debitor.AsEnumerable().Select((s, inx) => new
                {
                    iNo = inx + 1,
                    ID = s.ID,
                    BillingPeriodID = s.BillingPeriodID,
                    BillingPeriodCode = s.tran_BillingPeriod.BillingPeriodCode,
                    TransactionDebitorCode = s.TransactionDebitorCode,
                    TransactionDate = s.TransactionDate,
                    TransactionSeq = s.TransactionSeq,
                    DocumentNo = s.DocumentNo,
                    IsOutsidePeriod = s.IsOutsidePeriod,
                    DebitorID = s.DebitorID,
                    DebitorName = s.mas_Debtor.DebtorName,
                    JobID = s.JobID,
                    JobName = s.mas_Job.JobName,
                    ProductID = s.ProductID,
                    ProductName = s.mas_Product.ProductName,
                    ProductCode = s.mas_Product.ProductCode,
                    CarLicense = s.CarLicense,
                    Driver = s.Driver,
                    TranWeight = s.TranWeight,
                    TranSellPrice = s.TranSellPrice,
                    TranDiscount = s.TranDiscount,
                    IsVat = s.IsVat,
                    TranVat = s.TranVat,
                    TotalAmount = s.TotalAmount,
                    IsReceived = s.IsReceived
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

        private void cbBillingPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnAddData.Visible = this.cbBillingPeriod.SelectedIndex > 0;
            DGV();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            frmAddEditDebitorTran frm = new frmAddEditDebitorTran();
            int _bpId = int.Parse(this.cbBillingPeriod.SelectedValue.ToString());
            var _bp = db.tran_BillingPeriod.Where(w => w.ID == _bpId).FirstOrDefault();
            frm.StartDate = _bp.BillingDateFrom; frm.EndDate = _bp.BillingDateTo; frm._bpId = _bpId;

            frm.BringToFront();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmAddEditDebitorTran frmEdit = new frmAddEditDebitorTran();
            frmEdit.iType = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns[0]).ToString());
            int _bpId = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["BillingPeriodID"]).ToString());
            var _bp = db.tran_BillingPeriod.Where(w => w.ID == _bpId).FirstOrDefault();
            frmEdit.StartDate = _bp.BillingDateFrom; frmEdit.EndDate = _bp.BillingDateTo; frmEdit._bpId = _bpId;
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
                    var del = db.tran_Debitor.Where(w => w.ID == _deldata).FirstOrDefault();
                    db.tran_Debitor.Remove(del);
                    db.SaveChanges();
                }
                DGV();
                gloService.Announce("ลบข้อมูลเรียบร้อย", AnnounceType.Infomation);
            }
            else return;
        }

        private void CheckEditPaid_Click(object sender, EventArgs e)
        {
            if (gloService.Sure("คุณต้องการบันทึกการรับชำระข้อมูลรายการนี้ ?") == DialogResult.Yes)
            {
                int _RecData = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns[0]).ToString());
                db = new Entity.CSBNPEntities();
                var rec = db.tran_Debitor.Where(w => w.ID == _RecData).FirstOrDefault();
                if (rec == null)
                {
                    gloService.Announce("ไม่สามารถปรับปรุงข้อมูลได้ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    return;
                }
                else
                {
                    rec.IsReceived = true;
                    rec.ReceivedBy = Variable.CurrentProfile.username;
                    rec.ReceivedDate = DateTime.Now;
                    rec.IsCancel = false;
                    db.SaveChanges();
                    DGV();
                    gloService.Announce("บันทึกการรับชำระ .. เรียบร้อยแล้ว", AnnounceType.Infomation);
                }
            }
            else return;
        }

        private void gridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "IsReceived").ToString() == "True")
            {
                e.Cancel = (gridView.FocusedColumn != this.gridView.Columns[19]) && (gridView.FocusedColumn != this.gridView.Columns[20]);
            }
            else
            {
                e.Cancel = (gridView.FocusedColumn != this.gridView.Columns[19]) && (gridView.FocusedColumn != this.gridView.Columns[20]) && (gridView.FocusedColumn != this.gridView.Columns[17]);
            }
        }
    }
}
