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
    public partial class frmViewDebitorCreditor : Form
    {
        public frmViewDebitorCreditor()
        {
            InitializeComponent();
        }
        Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        Services.GlobalService gloService = new Services.GlobalService();
        System.Globalization.CultureInfo cul = new System.Globalization.CultureInfo("en-us");
        private void ClearForm()
        {
            BindingControl();
            this.cbDebitorPeriod.SelectedIndex = 0;
        }
        private void BindingControl()
        {
            var _tmp = db.mas_DebitorBillingPeriod.ToList();
            var data = _tmp.OrderBy(o => o.ID).Select(s => new
            {
                val = s.ID,
                txt = s.DebitorPeriodCode + " : " + s.DebitorDateFrom.ToString("dd.MM.yyyy", cul) + " - " + s.DebitorDateTo.ToString("dd.MM.yyyy", cul)
            }).ToList();
            data.Insert(0, new { val = 0, txt = "-- เลือกช่วงเวลาการตั้งเบิกลูกหนี้ --" });
            this.cbDebitorPeriod.DataSource = data;
            this.cbDebitorPeriod.DisplayMember = "txt";
            this.cbDebitorPeriod.ValueMember = "val";
        }
        public void DGV()
        {
            if (this.cbDebitorPeriod.SelectedIndex > 0)
            {
                ControlBTN(true);
                db = new Entity.CSBNPEntities();
                int _condition = int.Parse(this.cbDebitorPeriod.SelectedValue.ToString());
                var data = db.tran_DebitorRec.Where(w=>w.DebitorPeriodID == _condition).AsEnumerable().Select((s, inx) => new
                {
                    iNo = inx + 1,
                    ID = s.ID,
                    DebitorPeriodID = s.DebitorPeriodID,
                    DebitorPeriodCode = s.mas_DebitorBillingPeriod.DebitorPeriodCode,
                    TransactionDebitorCode = s.TransactionDebitorCode,
                    TransactionDate = s.TransactionDate,
                    DebitorID = s.DebitorID,
                    DebitorName = s.mas_Debtor.DebtorName,
                    IsReceived = s.IsReceived,
                    CheckedBy = s.CheckedBy,
                    TotalAmount = s.TotalAmountByBill
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
            this.btnAddData.Visible = this.cbDebitorPeriod.SelectedIndex > 0;
            DGV();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            frmAddEditDebitorCreditor frm = new frmAddEditDebitorCreditor();
            int _bpId = int.Parse(this.cbDebitorPeriod.SelectedValue.ToString());
            var _bp = db.tran_BillingPeriod.Where(w => w.ID == _bpId).FirstOrDefault();
            frm.dpId = _bpId;

            frm.BringToFront();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void frmViewDebitorCreditor_Load(object sender, EventArgs e)
        {
            ClearForm();
            this.cbDebitorPeriod.Select();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmAddEditDebitorCreditor frmEdit = new frmAddEditDebitorCreditor();
            frmEdit.iType = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns[0]).ToString());
            int _bpId = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["DebitorPeriodID"]).ToString());
            var _bp = db.tran_BillingPeriod.Where(w => w.ID == _bpId).FirstOrDefault();
            frmEdit.dpId = _bpId;
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
                    var del = db.tran_DebitorRecDetail.Where(w => w.MasterID == _deldata).ToList();
                    db.tran_DebitorRecDetail.RemoveRange(del);
                    db.SaveChanges();
                    var _d = db.tran_DebitorRec.Where(w => w.ID == _deldata).FirstOrDefault();
                    db.tran_DebitorRec.Remove(_d);
                    db.SaveChanges();
                }
                DGV();
                //gloService.Announce("ลบข้อมูลเรียบร้อย", AnnounceType.Infomation);
            }
            else return;
        }

        private void CheckEditPaid_Click(object sender, EventArgs e)
        {
            if (gloService.Sure("คุณต้องการบันทึกการรับชำระข้อมูลรายการนี้ ?") == DialogResult.Yes)
            {
                int _RecData = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns[0]).ToString());
                db = new Entity.CSBNPEntities();
                var paid = db.tran_DebitorRec.Where(w => w.ID == _RecData).FirstOrDefault();
                if (paid == null)
                {
                    gloService.Announce("ไม่สามารถปรับปรุงข้อมูลได้ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    return;
                }
                else
                {
                    paid.IsReceived = true;
                    paid.ReceivedBy = Variable.CurrentProfile.username;
                    paid.ReceivedDate = DateTime.Now;
                    paid.IsCancel = false;
                    db.SaveChanges();
                    DGV();
                    //gloService.Announce("บันทึกการรับชำระ .. เรียบร้อยแล้ว", AnnounceType.Infomation);
                }
            }
            else return;
        }

        private void gridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "IsReceived").ToString() == "True")
            {
                e.Cancel = (gridView.FocusedColumn != this.gridView.Columns[9]) && (gridView.FocusedColumn != this.gridView.Columns[10]);
            }
            else
            {
                e.Cancel = (gridView.FocusedColumn != this.gridView.Columns[7]) && (gridView.FocusedColumn != this.gridView.Columns[9]) && (gridView.FocusedColumn != this.gridView.Columns[10]);
            }
        }
    }
}
