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
    public partial class frmViewCreditorTransaction : Form
    {
        public frmViewCreditorTransaction()
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
            data.Insert(0, new { val = 0, txt = "-- เลือกช่วงเวลาการตั้งเบิกเจ้าหนีี้ --" });
            this.cbBillingPeriod.DataSource = data;
            this.cbBillingPeriod.DisplayMember = "txt";
            this.cbBillingPeriod.ValueMember = "val";
        }
        private void frmViewCreditorTransaction_Load(object sender, EventArgs e)
        {
            ClearForm();
            this.cbBillingPeriod.Select();
        }
        public void DGV()
        {
            if (this.cbBillingPeriod.SelectedIndex > 0)
            {
                db = new Entity.CSBNPEntities();
                ControlBTN(true);
                int _condition = int.Parse(this.cbBillingPeriod.SelectedValue.ToString());
                var data = db.tran_Creditor.Where(w=>w.BillingPeriodID == _condition).AsEnumerable().Select((s, inx) => new
                {
                    iNo = inx + 1,
                    ID = s.ID,
                    BillingPeriodID = s.BillingPeriodID,
                    BillingPeriodCode = s.tran_BillingPeriod.BillingPeriodCode,
                    BillingDate = s.BillingDate,
                    TranUnitQuantity = s.TranUnitQuantity,
                    TransactionCreditorCode = s.TransactionCreditorCode,
                    TransactionDate = s.TransactionDate,
                    TransactionSeq = s.TransactionSeq,
                    DocumentNo = s.DocumentNo,
                    IsOutsidePeriod = s.IsOutsidePeriod,
                    CreditorID = s.CreditorID,
                    CreditorName = s.mas_Creditor.CreditorName,
                    JobID = s.JobID,
                    JobName = s.mas_Job.JobName,
                    ProductID = s.ProductID,
                    ProductName = s.mas_Product.ProductName,
                    ProductCode = s.mas_Product.ProductCode,
                    CarLicense = s.CarLicense,
                    Driver = s.Driver,
                    TranWeight = s.TranWeight,
                    TranBuyPrice = s .TranBuyPrice,
                    TranDiscount = s.TranDiscount,
                    IsVat = s.IsVat,
                    TranVat = s.TranVat,
                    TotalAmount = s.TotalAmount,
                    IsPaid = s.IsPaid,
                    TranUnit = s.TranUnit 
                }).ToList();
                this.gridControl.DataSource = data;
                this.gridControl.ForceInitialize();

                this.btnConfirmPaid.Visible = this.gridView.RowCount > 0;
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
            frmAddEditCreditorTran frm = new frmAddEditCreditorTran();
            int _bpId = int.Parse(this.cbBillingPeriod.SelectedValue.ToString());
            var _bp = db.tran_BillingPeriod.Where(w => w.ID == _bpId).FirstOrDefault();
            frm.StartDate = _bp.BillingDateFrom; frm.EndDate = _bp.BillingDateTo; frm._bpId = _bpId;
			int _bfInx = gridView.GetSelectedRows().FirstOrDefault();
			frm.BringToFront();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
			gridView.FocusedRowHandle = _bfInx;
		}

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmAddEditCreditorTran frmEdit = new frmAddEditCreditorTran();
			int _bfInx = gridView.GetSelectedRows().FirstOrDefault();
			frmEdit.iType = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns[0]).ToString());
            int _bpId = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["BillingPeriodID"]).ToString());
            var _bp = db.tran_BillingPeriod.Where(w => w.ID == _bpId).FirstOrDefault();
            frmEdit.StartDate = _bp.BillingDateFrom; frmEdit.EndDate = _bp.BillingDateTo; frmEdit._bpId = _bpId;
            frmEdit.BringToFront();
            frmEdit.StartPosition = FormStartPosition.CenterParent;
            frmEdit.ShowDialog();
            DGV();
			gridView.FocusedRowHandle = _bfInx;
		}

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gloService.Sure("คุณต้องการลบข้อมูลรายการนี้ ?") == DialogResult.Yes)
            {
                int _deldata = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns[0]).ToString());
				int _bfInx = gridView.GetSelectedRows().FirstOrDefault();
				using (var db = new Entity.CSBNPEntities())
                {
                    var data = db.tran_Creditor.Where(w => w.ID == _deldata).FirstOrDefault();
                    if (data != null)
                    {
                        //Mill
                        var delServiice = db.tran_CreditorService.Where(w => w.TranCreditorID == _deldata).FirstOrDefault();
                        if (delServiice != null)
                        {
                            //RollBack Amount
                            var roll = db.tran_CreditorMillPrePaid.Where(w => w.CreditorServiceID == delServiice.CreditorServiceID && w.JobID == data.JobID).FirstOrDefault();
                            if (roll != null)
                            {
                                roll.PaidAmount -= delServiice.TotalAmount;
                            }
                            //
                            db.tran_CreditorService.Remove(delServiice);
                        }
                    }
                    var del = db.tran_Creditor.Where(w => w.ID == _deldata).FirstOrDefault();
                    db.tran_Creditor.Remove(del);
                    db.SaveChanges();
                }
                DGV();
				gridView.FocusedRowHandle = _bfInx;
				//gloService.Announce("ลบข้อมูลเรียบร้อย", AnnounceType.Infomation);
			}
            else return;
        }

     
        private void CheckEditPaid_Click(object sender, EventArgs e)
        {
            if (gloService.Sure("คุณต้องการบันทึกการชำระข้อมูลรายการนี้ ?") == DialogResult.Yes)
            {
                int _PaidData = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns[0]).ToString());
                db = new Entity.CSBNPEntities();
                var paid = db.tran_Creditor.Where(w => w.ID == _PaidData).FirstOrDefault();
                if (paid == null)
                {
                    gloService.Announce("ไม่สามารถปรับปรุงข้อมูลได้ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    return;
                }
                else
                {
					int _bfInx = gridView.GetSelectedRows().FirstOrDefault();
					paid.IsPaid = true;
                    paid.PaidBy = Variable.CurrentProfile.username;
                    paid.PaidDate = DateTime.Now;
                    paid.IsCancel = false;
                    db.SaveChanges();
                    DGV();
                    gloService.Announce("บันทึกการชำระ .. เรียบร้อยแล้ว", AnnounceType.Infomation);
					gridView.FocusedRowHandle = _bfInx;
				}
            }
            else return;
        }

        private void gridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "IsPaid").ToString() == "True")
            {
                e.Cancel = (gridView.FocusedColumn != this.gridView.Columns[21]) && (gridView.FocusedColumn != this.gridView.Columns[22]);
            }
            else
            {
                e.Cancel = (gridView.FocusedColumn != this.gridView.Columns[21]) && (gridView.FocusedColumn != this.gridView.Columns[22]) && (gridView.FocusedColumn != this.gridView.Columns[20]);
            }
        }

        private void btnConfirmPaid_Click(object sender, EventArgs e)
        {
            if (this.gridView.RowCount > 0)
            {
                if (gloService.Sure("คุณต้องการบันทึกการชำระเจ้าหนี้ทั้งหมด ?") == DialogResult.Yes)
                {
                    int _bpId = int.Parse(this.cbBillingPeriod.SelectedValue.ToString());
                    db = new Entity.CSBNPEntities();
                    var paid = db.tran_Creditor.Where(w => w.BillingPeriodID == _bpId).ToList();
                    if (paid == null)
                    {
                        gloService.Announce("ไม่สามารถบันทึกข้อมูลได้ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                        return;
                    }
                    else
                    {
						int _bfInx = gridView.GetSelectedRows().FirstOrDefault();
						paid.ForEach(fe => fe.IsPaid = true);
                        paid.ForEach(fe => fe.PaidBy = Variable.CurrentProfile.username);
                        paid.ForEach(fe => fe.PaidDate = DateTime.Now);
                        paid.ForEach(fe => fe.IsCancel = false);
                        db.SaveChanges();
                        DGV();
						gridView.FocusedRowHandle = _bfInx;
						gloService.Announce("บันทึกการชำระ .. เรียบร้อยแล้ว", AnnounceType.Infomation);
                    }
                }
                else return;
            }
            else
            {
                gloService.Announce("ไม่มีข้อมูล .. โปรดตรวจสอบ !!", AnnounceType.Warning);
            }
        }
    }
}
