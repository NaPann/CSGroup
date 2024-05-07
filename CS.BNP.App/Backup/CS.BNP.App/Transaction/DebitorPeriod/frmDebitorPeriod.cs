using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.BNP.App.Transaction.DebitorPeriod
{
    public partial class frmDebitorPeriod : Form
    {
        public frmDebitorPeriod()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        public void DGV()
        {
            using (var db = new Entity.CSBNPEntities())
            {
                var data = db.mas_DebitorBillingPeriod.AsEnumerable().Select((s, inx) => new
                {
                    iNo = inx + 1,
                    ID = s.ID,
                    DebitorPeriodCode = s.DebitorPeriodCode,
                    DebitorDateFrom = s.DebitorDateFrom,
                    DebitorDateTo = s.DebitorDateTo,
                    CountBilling = s.key_DebitorBilling.Count(),
                    DebitorBillingStatus = ((DebitorPeriodStatus)s.DebitorBillingStatus).ToString()
                }).ToList();
                this.gridControl.DataSource = data;
                this.gridControl.ForceInitialize();
            }
        }
        private void frmDebitorPeriod_Load(object sender, EventArgs e)
        {
            DGV();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            frmAddEditDebitorPeriod frm = new frmAddEditDebitorPeriod();
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
            frmAddEditDebitorPeriod frmEdit = new frmAddEditDebitorPeriod();
            frmEdit.iType = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns[0]).ToString());
            frmEdit.BringToFront();
            frmEdit.StartPosition = FormStartPosition.CenterParent;
            frmEdit.ShowDialog();
            DGV();
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gloService.Sure("คุณต้องการลบข้อมูลรายการนี้ ?") == DialogResult.Yes)
            {
                try
                {
                    int _deldata = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns[0]).ToString());
                    using (var db = new Entity.CSBNPEntities())
                    {
                        //key first
                        var _delKey = db.key_DebitorBilling.Where(w => w.DebitorPeriodID == _deldata).ToList();
                        db.key_DebitorBilling.RemoveRange(_delKey);
                        //del key too
                        var del = db.mas_DebitorBillingPeriod.Where(w => w.ID == _deldata).FirstOrDefault();
                        db.mas_DebitorBillingPeriod.Remove(del);
                        db.SaveChanges();
                    }
                    DGV();
                    //gloService.Announce("ลบข้อมูลเรียบร้อย", AnnounceType.Infomation);
                }
                catch (Exception ex)
                {
                    gloService.Announce("จำเป็นลบข้อมูลลูกหนี้ ของช่วงการเบิกจ่ายนี้ก่อน !!" + ex.Message, AnnounceType.Error);
                }
            }
            else return;
        }

        private void gridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "DebitorBillingStatus").ToString() == "Processed")
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = (gridView.FocusedColumn != this.gridView.Columns[7]) 
                    && (gridView.FocusedColumn != this.gridView.Columns[8]);
            }
        }
    }
}
