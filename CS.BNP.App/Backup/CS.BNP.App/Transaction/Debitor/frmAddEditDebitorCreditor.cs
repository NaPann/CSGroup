using CS.BNP.App.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS.BNP.App.Transaction.Debitor
{
    public partial class frmAddEditDebitorCreditor : Form
    {
        public frmAddEditDebitorCreditor()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        public int iType = 0;
        public int dpId = 0;
        private int[] bpId; Entity.CSBNPEntities db = new Entity.CSBNPEntities();
        private void ClearForm()
        {
            this.txtTransactionDebitorCode.Text = "-- สร้างให้อัติโนมัติ --";
            this.dtpTransactionDate.Value = DateTime.Now; this.dtpTransactionDate.Checked = false;
            this.dtpCheckedDate.Value = DateTime.Now; this.dtpCheckedDate.Checked = false;
            BindingControl(); this.cbDebitor.SelectedIndex = 0; this.txtDocNo.Text = string.Empty;
            this.lblTransactionCreditorID.Text = string.Empty; this.lblDetailID.Text = string.Empty;

            this.dt = new DataTable(); buildDataTable();
            this.gridControlCreditor.DataSource = this.dt;
            this.gridControlCreditor.ForceInitialize();
            this.btnAdd.Text = "เพิ่ม";
        }
        private void BindingControl()
        {
            using (var db = new Entity.CSBNPEntities())
            {
                bpId = db.key_DebitorBilling.Where(w => w.DebitorPeriodID == dpId).Select(s => s.BillingPeriodID).ToArray();
                var data = db.tran_Creditor.Where(w=> bpId.Contains(w.BillingPeriodID)).OrderBy(o => o.ID).Select(s => new
                {
                    val = s.mas_Job.DebtorID,
                    txt = s.mas_Job.mas_Debtor.DebtorName + " : " + s.mas_Job.mas_Debtor.DebtorCode
                }).Distinct().ToList();
                data.Insert(0, new { val = 0, txt = "-- เลือกลูกหนี้ --" });
                this.cbDebitor.DataSource = data;
                this.cbDebitor.DisplayMember = "txt";
                this.cbDebitor.ValueMember = "val";                        
            }
        }
        private void goSave()
        {
            bool allow = true;
            allow &= gloService.RequireColorControl(this.dtpTransactionDate);
            if (this.cbDebitor.SelectedIndex == 0)
            {
                this.cbDebitor.BackColor = Color.LightCoral;
                allow &= false;
            }
            else
            {
                this.cbDebitor.BackColor = Color.White;
                allow &= true;
            }
            //allow &= gloService.RequireColorTextbox(this.txtCheckedBy);
            //allow &= gloService.RequireColorControl(this.dtpCheckedDate);

            //Detail
            if (this.gridViewCreditor.RowCount == 0)
            {
                this.gridViewCreditor.Appearance.Empty.BackColor = Color.LightCoral;
                allow &= false;
            }
            else
            {
                this.gridViewCreditor.Appearance.Empty.BackColor = Color.White; allow &= true;
            }

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
                    Entity.tran_DebitorRec obj; Entity.tran_DebitorRecDetail objDetail;
                    using (DbContextTransaction trans = db.Database.BeginTransaction())
                    {
                        switch (iType)
                        {
                            case 0:
                                obj = new Entity.tran_DebitorRec();
                                obj.TransactionDebitorCode = gloService.AutoGenerate(GenerateType.TransactionDebitor);
                                obj.DebitorPeriodID = dpId;
                                obj.DebitorID = int.Parse(this.cbDebitor.SelectedValue.ToString());
                                obj.TransactionDate = this.dtpTransactionDate.Value;
                                obj.CheckedBy = this.txtCheckedBy.Text.Trim();
                                if (this.dtpCheckedDate.Checked) {
                                    obj.CheckedDate = this.dtpCheckedDate.Value;
                                }
                                obj.TotalAmount = decimal.Parse(this.txtAmount.Text.Trim());
                                obj.TotalAmountByBill = decimal.Parse(this.txtTotalAmount.Text.Trim());                         
                                obj.IsVat = this.numVat.Value > 0;
                                obj.TranVat = this.numVat.Value;
                                obj.TotalBeforeVat = decimal.Parse(this.txtBeforeVat.Text.Trim());
                                obj.TranDiscount = this.numDiscount.Value;
                                obj.CreatedBy = Variable.CurrentProfile.username;
                                obj.CreatedDate = DateTime.Now;
                                obj.UpdatedBy = Variable.CurrentProfile.username;
                                obj.UpdatedDate = DateTime.Now;
                                obj.JobID = int.Parse(this.cbJob.SelectedValue.ToString());
                                obj.IsReceived = false;
                                obj.IsCancel = false;
                                db.tran_DebitorRec.Add(obj);
                                db.SaveChanges();

                                for (int i = 0; i < this.gridViewCreditor.DataRowCount; i++)
                                {
                                    objDetail = new Entity.tran_DebitorRecDetail();
                                    objDetail.MasterID = obj.ID;
                                    objDetail.TransactionCreditorID = int.Parse(this.gridViewCreditor.GetRowCellValue(i, "TransactionCreditorID").ToString());
                                    objDetail.TranSellPrice = decimal.Parse(this.gridViewCreditor.GetRowCellValue(i, "ProductPriceExactly").ToString());
                                    objDetail.TotalAmount  = decimal.Parse(this.gridViewCreditor.GetRowCellValue(i, "TotalAmount").ToString());
                                    objDetail.DocNo = this.txtDocNo.Text.Trim();
                                    db.tran_DebitorRecDetail.Add(objDetail);

                                    //var TrCr = db.tran_Creditor.Where(w => w.ID == objDetail.TransactionCreditorID).FirstOrDefault();
                                    //if (TrCr != null)
                                    //{
                                    //    TrCr.IsUsed = true;
                                    //}
                                }
                                db.SaveChanges();
                                trans.Commit();

                                frmViewDebitorCreditor frmParent = Application.OpenForms["frmViewDebitorCreditor"] as frmViewDebitorCreditor;
                                frmParent.DGV();
                          
                               // gloService.Announce("บันทึกข้อมูลเรียบร้อย", AnnounceType.Infomation);
                                break;
                            default:
                                obj = db.tran_DebitorRec.Where(w => w.ID == iType).FirstOrDefault();
                                obj.TransactionDate = this.dtpTransactionDate.Value;
                                obj.CheckedBy = this.txtCheckedBy.Text.Trim();
                                if (this.dtpCheckedDate.Checked)
                                {
                                    obj.CheckedDate = this.dtpCheckedDate.Value;
                                }
                                obj.TotalAmount = decimal.Parse(this.txtAmount.Text.Trim());
                                obj.DebitorID = int.Parse(this.cbDebitor.SelectedValue.ToString());
                                obj.JobID = int.Parse(this.cbJob.SelectedValue.ToString());
                                obj.UpdatedBy = Variable.CurrentProfile.username;
                                obj.UpdatedDate = DateTime.Now;
                                obj.TotalAmountByBill = decimal.Parse(this.txtTotalAmount.Text.Trim());
                                obj.IsVat = this.numVat.Value > 0;
                                obj.TranVat = this.numVat.Value;
                                obj.TotalBeforeVat = decimal.Parse(this.txtBeforeVat.Text.Trim());
                                obj.TranDiscount = this.numDiscount.Value;
                                db.SaveChanges();

                                for (int i = 0; i < this.gridViewCreditor.DataRowCount; i++)
                                {
                                    if (int.Parse(this.gridViewCreditor.GetRowCellValue(i, "ID").ToString()) == 0)
                                    {
                                        objDetail = new Entity.tran_DebitorRecDetail();
                                        objDetail.MasterID = obj.ID;
                                        objDetail.TransactionCreditorID = int.Parse(this.gridViewCreditor.GetRowCellValue(i, "TransactionCreditorID").ToString());
                                        objDetail.TranSellPrice = decimal.Parse(this.gridViewCreditor.GetRowCellValue(i, "ProductPriceExactly").ToString());
                                        objDetail.TotalAmount = decimal.Parse(this.gridViewCreditor.GetRowCellValue(i, "TotalAmount").ToString());
                                        objDetail.DocNo = this.gridViewCreditor.GetRowCellValue(i, "DocNo").ToString();
                                        db.tran_DebitorRecDetail.Add(objDetail);

                                        var TrCr = db.tran_Creditor.Where(w => w.ID == objDetail.TransactionCreditorID).FirstOrDefault();
                                        if (TrCr != null)
                                        {
                                            TrCr.IsUsed = true;
                                        }
                                    }
                                    else
                                    {
                                        var _id = int.Parse(this.gridViewCreditor.GetRowCellValue(i, "ID").ToString());
                                        var _up = db.tran_DebitorRecDetail.Where(w => w.ID == _id).FirstOrDefault();
                                        _up.TranSellPrice = decimal.Parse(this.gridViewCreditor.GetRowCellValue(i, "ProductPriceExactly").ToString());
                                        _up.TotalAmount = decimal.Parse(this.gridViewCreditor.GetRowCellValue(i, "TotalAmount").ToString());
                                        _up.DocNo = this.gridViewCreditor.GetRowCellValue(i, "DocNo").ToString();
                                    }
                                }
                                db.SaveChanges();
                                trans.Commit();

                                //gloService.Announce("แก้ไขข้อมูลเรียบร้อย", AnnounceType.Infomation);
                                this.Close();
                                break;
                        }
                    }
                }
                ClearForm();
                this.dtpTransactionDate.Select();
            }
            else
            {
                _saveexit = 0;
                this.btnSave.Select();
                return;
            }
        }
        private byte _saveexit = 0;
        private DataTable dt; 
        private void buildDataTable()
        {
            dt.Columns.Add(new DataColumn("iNo", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("ID", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("TransactionCreditorID", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("TransactionDate", typeof(System.DateTime)));
            dt.Columns.Add(new DataColumn("ProductID", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("ProductCode", typeof(System.String)));
            dt.Columns.Add(new DataColumn("ProductName", typeof(System.String)));
            dt.Columns.Add(new DataColumn("JobQuantity", typeof(System.Decimal)));
            dt.Columns.Add(new DataColumn("ProductPriceExactly", typeof(System.Decimal)));
            dt.Columns.Add(new DataColumn("TotalAmount", typeof(System.Decimal)));
            dt.Columns.Add(new DataColumn("DocNo", typeof(System.String)));
            dt.AcceptChanges();
        }
        private void frmAddEditDebitorCreditor_Load(object sender, EventArgs e)
        {
            ClearForm();
            if (iType > 0)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    var _data = db.tran_DebitorRec.Where(w => w.ID == iType).FirstOrDefault();
                    if (_data != null)
                    {
                        this.txtTransactionDebitorCode.Text = _data.TransactionDebitorCode;
                        this.dtpTransactionDate.Value = _data.TransactionDate;
                        if (_data.CheckedDate.HasValue)
                        {
                            this.dtpCheckedDate.Value = _data.CheckedDate.Value;
                        }                        
                        this.txtCheckedBy.Text = _data.CheckedBy;
                        this.cbDebitor.SelectedValue = _data.DebitorID;
                        this.cbJob.SelectedValue = _data.JobID;
                        this.btnCancelReceived.Visible = _data.IsReceived;
                        this.btnReceived.Visible = !_data.IsReceived;
                        this.lblAlreadyReceived.Visible = this.btnCancelReceived.Visible;

                        this.btnSave.Visible = this.btnReceived.Visible; this.btnSaveExit.Visible = this.btnReceived.Visible;

                        var _detail = db.tran_DebitorRecDetail.Where(w => w.MasterID == _data.ID).OrderBy(o => o.ID).AsEnumerable().Select((s, inx) => new
                        {
                            iNo = inx + 1,
                            ID = s.ID,
                            TransactionCreditorID = s.TransactionCreditorID,
                            TransactionDate = s.tran_Creditor.TransactionDate,
                            ProductID = s.tran_Creditor.ProductID,
                            ProductCode = s.tran_Creditor.mas_Product.ProductCode,
                            ProductName = s.tran_Creditor.mas_Product.ProductName,
                            JobQuantity = s.tran_Creditor.TranWeight,
                            ProductPriceExactly = s.TranSellPrice,
                            TotalAmount = s.TotalAmount,
                            DocNo = s.DocNo
                        }).ToList();
                        foreach (var item in _detail)
                        {
                            this.dt.Rows.Add(item.iNo, item.ID, item.TransactionCreditorID, item.TransactionDate,item.ProductID, item.ProductCode, item.ProductName, item.JobQuantity, item.ProductPriceExactly, item.TotalAmount, item.DocNo);
                        }
                        this.dt.AcceptChanges();
                        this.gridControlCreditor.DataSource = this.dt;
                        this.gridControlCreditor.ForceInitialize();

                        this.numDiscount.Value = _data.TranDiscount;
                        this.numVat.Value = _data.TranVat;
                        this.txtAmount.Text = _data.TotalAmount.ToString("#,0.00");
                        this.txtBeforeVat.Text = _data.TotalBeforeVat.ToString("#,0.00");
                        this.txtTotalAmount.Text = _data.TotalAmountByBill.ToString("#,0.00");

                        this.txtTransactionDebitorCode.Enabled = false; this.dtpTransactionDate.Select(); 
                    }
                    else
                    {
                        gloService.Announce("ไม่สามารถค้นหาข้อมูลได้ .. โปรดตรวจสอบ", AnnounceType.Infomation);
                        this.Close();
                        return;
                    }
                }
            }
            else
                this.dtpTransactionDate.Select();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool allow = true;
            allow &= gloService.RequireColorTextbox(this.txtDocNo);
            if (this.cbTranCreditor.SelectedIndex == 0)
            {
                this.cbTranCreditor.BackColor = Color.LightCoral;
                allow &= false;
            }
            else
            {
                this.cbTranCreditor.BackColor = Color.White;
                allow &= true;
            }
            allow &= gloService.RequireColorTextbox(this.numSellPrice);
         
            if (!allow)
            {
                gloService.Announce("กรุณากรอกข้อมูลให้ครบเพื่อเพิ่มรายการ !!", AnnounceType.Warning);
                this.cbTranCreditor.Select();
                return;
            }

            //Dup
            int _ex = 0;
            int tranId = int.Parse(this.cbTranCreditor.SelectedValue.ToString());
            _ex = dt.Select("TransactionCreditorID = '" + tranId + "'").Count();

            if (!string.IsNullOrWhiteSpace(this.lblTransactionCreditorID.Text.Trim()))
            {
                if ((int.Parse(this.lblTransactionCreditorID.Text.Trim()) == tranId) && (_ex == 1))
                {
                    _ex = 99;
                }
            }

            if (_ex == 0)
            {
                var tran = db.tran_Creditor.Where(w => w.ID == tranId).FirstOrDefault();
                this.dt.Rows.Add(this.gridViewCreditor.RowCount + 1, 0,
                                 int.Parse(this.cbTranCreditor.SelectedValue.ToString()),
                                 tran.TransactionDate,
                               tran.ProductID,
                               tran.mas_Product.ProductCode,
                               tran.mas_Product.ProductName,
                               decimal.Parse(this.txtJobQuantity.Text.Trim()), this.numSellPrice.Value, decimal.Parse(this.txtJobQuantity.Text.Trim()) * this.numSellPrice.Value,
                               this.txtDocNo.Text.Trim());
                this.dt.AcceptChanges();
                this.gridControlCreditor.DataSource = dt;

                this.numSellPrice.Value = 0; this.txtJobQuantity.Text = string.Empty;
                this.cbTranCreditor.SelectedIndex = 0; this.cbTranCreditor.Select();
            }
            else if (_ex == 99)
            {
                for (int i = 0; i < this.dt.Rows.Count; i++)
                {
                    if (this.lblTransactionCreditorID.Text.Trim() == this.dt.Rows[i]["TransactionCreditorID"].ToString())
                    {
                        this.dt.Rows[i]["ProductPriceExactly"] = this.numSellPrice.Value; ;
                        this.dt.Rows[i]["TotalAmount"] = this.numSellPrice.Value * decimal.Parse(this.txtJobQuantity.Text.Trim());
                        this.dt.Rows[i]["DocNo"] = this.txtDocNo.Text.Trim();
                        this.dt.AcceptChanges();
                        this.gridControlCreditor.DataSource = dt;

                        this.numSellPrice.Value = 0; this.txtJobQuantity.Text = string.Empty; this.txtDocNo.Text = string.Empty;
                        this.cbTranCreditor.Enabled = true; this.cbTranCreditor.SelectedIndex = 0; this.btnAdd.Text = "เพิ่ม";
                        this.txtDocNo.Select();
                        break;
                    }
                }
            }
            else
            {
                gloService.Announce("คุณได้เลือกรายการนี้ไปแล้ว !!", AnnounceType.Warning);
                this.cbTranCreditor.Select();
                return;
            }

            for (int i = 0; i < this.dt.Rows.Count; i++)
            {
                dt.Rows[i][0] = i + 1;
            }
            this.dt.AcceptChanges();
            this.gridControlCreditor.DataSource = dt;

            Compute();
        }
        private void Compute()
        {
            decimal _sum = 0; decimal _vat = 0; decimal _atVat = 0;
            for (int i = 0; i < this.dt.Rows.Count; i++)
            {
                _sum += decimal.Parse(this.dt.Rows[i]["TotalAmount"].ToString().Trim());
            }
            this.txtAmount.Text = _sum.ToString("#,0.00");
            _vat = (this.numVat.Value / 100) * _sum; this.txtVat.Text = _vat.ToString("#,0.00");
            this.txtBeforeVat.Text = (_sum +_vat).ToString("#,0.00");
          
            _atVat = ((this.numDiscount.Value / 100) * _sum); this.txtAtVat.Text = _atVat.ToString("(#,0.00)");
            this.txtTotalAmount.Text = ((_vat + _sum) - _atVat).ToString("#,0.00");
        }

        private void btnEditDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.lblDetailID.Text = this.gridViewCreditor.GetRowCellValue(this.gridViewCreditor.FocusedRowHandle, gridViewCreditor.Columns["ID"]).ToString();
            this.lblTransactionCreditorID.Text = this.gridViewCreditor.GetRowCellValue(this.gridViewCreditor.FocusedRowHandle, gridViewCreditor.Columns["TransactionCreditorID"]).ToString();
            this.cbTranCreditor.SelectedValue = int.Parse(this.gridViewCreditor.GetRowCellValue(this.gridViewCreditor.FocusedRowHandle, gridViewCreditor.Columns["TransactionCreditorID"]).ToString());
            this.numSellPrice.Text = this.gridViewCreditor.GetRowCellValue(this.gridViewCreditor.FocusedRowHandle, gridViewCreditor.Columns["ProductPriceExactly"]).ToString();
            this.txtJobQuantity.Text = this.gridViewCreditor.GetRowCellValue(this.gridViewCreditor.FocusedRowHandle, gridViewCreditor.Columns["JobQuantity"]).ToString();
            this.txtDocNo.Text = this.gridViewCreditor.GetRowCellValue(this.gridViewCreditor.FocusedRowHandle, gridViewCreditor.Columns["DocNo"]).ToString();
            this.cbTranCreditor.Enabled = false; this.btnAdd.Text = "ปรับปรุง";
            this.numSellPrice.Select();
        }
        private void btnDeleteDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gloService.Sure("คุณต้องการลบข้อมูลรายการนี้ ?") == DialogResult.Yes)
            {
                int _deldata = int.Parse(this.gridViewCreditor.GetRowCellValue(this.gridViewCreditor.FocusedRowHandle, gridViewCreditor.Columns[0]).ToString());
                if (_deldata == 0)
                {
                    this.dt.Rows.RemoveAt(this.gridViewCreditor.GetDataSourceRowIndex(this.gridViewCreditor.FocusedRowHandle)); this.dt.AcceptChanges();
                    this.gridControlCreditor.DataSource = this.dt;
                }
                else
                {
                    this.dt.Rows.RemoveAt(this.gridViewCreditor.GetDataSourceRowIndex(this.gridViewCreditor.FocusedRowHandle));
                    using (var db = new Entity.CSBNPEntities())
                    {
                        var del = db.tran_DebitorRecDetail.Where(w => w.ID == _deldata).FirstOrDefault();
                        db.tran_DebitorRecDetail.Remove(del);
                        db.SaveChanges();
                    }
                    this.dt.AcceptChanges();
                    this.gridControlCreditor.DataSource = this.dt;
                    this.gridControlCreditor.ForceInitialize();
                }
                Compute();
                //gloService.Announce("ลบข้อมูลเรียบร้อย", AnnounceType.Infomation);
            }
            else return;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                goSave();
            }
            catch (Exception ex)
            {
                gloService.Announce("Something went wrong : " + ex.InnerException.InnerException.Message, AnnounceType.Error);
                return;
            }
        }
        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            try
            {
                _saveexit = 1;
                goSave();
                if (_saveexit == 1)
                    this.Close();
            }
            catch (Exception ex)
            {
                gloService.Announce("Something went wrong : " + ex.Message, AnnounceType.Error);
                return;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbDebitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbDebitor.SelectedIndex > 0)
            {
                db = new Entity.CSBNPEntities(); int _debitorrId = int.Parse(this.cbDebitor.SelectedValue.ToString());
                var _debitor = db.mas_Debtor.Where(w => w.ID == _debitorrId).FirstOrDefault();
                if (_debitor == null)
                {
                    gloService.Announce("ไม่พบข้อมูลลูกหนี้ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    this.cbDebitor.Select();
                }
                else
                {
                    this.txtDebitorName.Text = _debitor.DebtorContact + " (" + _debitor.DebtorTel + " : " + _debitor.DebtorAddress + ") ";

                    //Job
                    int[] dataJob = db.mas_JobCreditor.Where(w => w.mas_Job.DebtorID == _debitorrId).Select(s => s.JobID).ToArray();
                    var dataJ = db.mas_Job.Where(w => w.DebtorID == _debitorrId).OrderBy(o => o.ID).Select(s => new
                    {
                        val = s.ID,
                        txt = s.JobName + "-" + s.JobCode
                    }).Distinct().ToList();
                    dataJ.Insert(0, new { val = 0, txt = "-- เลือกโครงการ --" });
                    this.cbJob.DataSource = dataJ;
                    this.cbJob.DisplayMember = "txt";
                    this.cbJob.ValueMember = "val";

                    ////How many Creditor for the Debitor
                    //int[] dataCre = db.mas_JobCreditor.Where(w => w.mas_Job.DebtorID == _debitorrId).Select(s => s.CreditorID).ToArray();
                    //var dataTC = db.tran_Creditor.Where(w => bpId.Contains(w.BillingPeriodID) && dataCre.Contains(w.CreditorID)).OrderBy(o => o.ID).Select(s => new
                    //{
                    //    val = s.ID,
                    //    txt = s.mas_Creditor.CreditorName + " : " + s.DocumentNo + "-" + s.mas_Job.JobName
                    //}).Distinct().ToList();
                    //dataTC.Insert(0, new { val = 0, txt = "-- เลือกรายการเจ้าหนี้ --" });
                    //this.cbTranCreditor.DataSource = dataTC;
                    //this.cbTranCreditor.DisplayMember = "txt";
                    //this.cbTranCreditor.ValueMember = "val";
                }
            }
            else
            {
                this.txtDebitorName.Text = string.Empty;
                this.cbJob.DataSource = null; this.cbTranCreditor.DataSource = null;
            }
        }
        private void cbTranCreditor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbTranCreditor.SelectedIndex > 0)
            {
                db = new Entity.CSBNPEntities(); int _Id = int.Parse(this.cbTranCreditor.SelectedValue.ToString());
                var _tran = db.tran_Creditor.Where(w => w.ID == _Id).FirstOrDefault();
                if (_tran == null)
                {
                    gloService.Announce("ไม่พบข้อมูลรายการเจ้าหนี้ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    this.cbTranCreditor.Select();
                }
                else
                {
                    int _prodId = _tran.ProductID;
                    this.txtJobQuantity.Text = _tran.TranWeight.ToString("#,0.00");
                    try
                    {
                        this.numSellPrice.Value = db.mas_JobDetail.Where(w => w.ProductID == _tran.ProductID && w.JobID == _tran.JobID).FirstOrDefault().ProductPriceExactly;
                    }
                    catch 
                    {
                        this.numSellPrice.Value = 0;
                    }
                }
            }
            else
            {
                this.numSellPrice.Value = 0;
                this.txtJobQuantity.Text = string.Empty;
            }
        }
        private void numDiscount_ValueChanged(object sender, EventArgs e)
        {
            Compute();
        }
        private void btnReceived_Click(object sender, EventArgs e)
        {
            if (gloService.Sure("คุณต้องการบันทึกการรับชำระหรือไม่") == DialogResult.Yes)
            {
                db = new Entity.CSBNPEntities();
                var rec = db.tran_DebitorRec.Where(w => w.ID == iType).FirstOrDefault();
                if (rec == null)
                {
                    gloService.Announce("ไม่สามารถปรับปรุงข้อมูลได้ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    this.btnReceived.Select(); return;
                }
                else
                {
                    rec.IsReceived = true;
                    rec.ReceivedBy = Variable.CurrentProfile.username;
                    rec.ReceivedDate = DateTime.Now;

                    rec.IsCancel = false;

                    db.SaveChanges();
                    gloService.Announce("บันทึกการรับชำระ .. เรียบร้อยแล้ว", AnnounceType.Infomation);
                    this.btnReceived.Visible = false;
                    this.lblAlreadyReceived.Visible = !this.btnReceived.Visible; this.btnCancelReceived.Visible = !this.btnReceived.Visible;
                    this.btnSave.Visible = this.btnReceived.Visible; this.btnSaveExit.Visible = this.btnReceived.Visible;
                }
            }
            else this.btnReceived.Select();
        }
        private void btnCancelReceived_Click(object sender, EventArgs e)
        {
            if (gloService.Sure("คุณต้องการยกเลิกการรับชำระหรือไม่") == DialogResult.Yes)
            {
                db = new Entity.CSBNPEntities();
                var cancel = db.tran_DebitorRec.Where(w => w.ID == iType).FirstOrDefault();
                if (cancel == null)
                {
                    gloService.Announce("ไม่สามารถปรับปรุงข้อมูลได้ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    this.btnReceived.Select(); return;
                }
                else
                {
                    cancel.IsReceived = false;
                    cancel.ReceivedBy = string.Empty;
                    cancel.ReceivedDate = null;

                    cancel.IsCancel = true;
                    cancel.CancelBy = Variable.CurrentProfile.username;
                    cancel.CancelDate = DateTime.Now;
                    db.SaveChanges();

                    gloService.Announce("ยกเลิกการรับชำระ .. เรียบร้อยแล้ว", AnnounceType.Infomation);
                    this.btnReceived.Visible = true;
                    this.lblAlreadyReceived.Visible = !this.btnReceived.Visible; this.btnCancelReceived.Visible = !this.btnReceived.Visible;
                    this.btnSave.Visible = this.btnReceived.Visible; this.btnSaveExit.Visible = this.btnReceived.Visible;

                }
            }
            else this.btnCancelReceived.Select();
        }
        private void btnAddall_Click(object sender, EventArgs e)
        {
            if (this.cbTranCreditor.Items.Count < 2)
            {
                gloService.Announce("กรุณากรอกข้อมูลให้ครบเพื่อเพิ่มรายการ !!", AnnounceType.Warning);
                this.cbTranCreditor.Select();
                return;
            }

            if (this.gridViewCreditor.RowCount == (this.cbTranCreditor.Items.Count - 1))
            {
                gloService.Announce("คุณได้เลือกรายการนี้ไปแล้ว !!", AnnounceType.Warning);
                this.cbTranCreditor.Select();
                return;
            }
            else
            {
                int _debitorrId = int.Parse(this.cbDebitor.SelectedValue.ToString()); int _jobId = int.Parse(this.cbJob.SelectedValue.ToString());
                int[] dataCre = db.mas_JobCreditor.Where(w => w.mas_Job.DebtorID == _debitorrId).Select(s => s.CreditorID).ToArray();
                var dataTC = db.tran_Creditor.Where(w => bpId.Contains(w.BillingPeriodID) && dataCre.Contains(w.CreditorID) && w.JobID == _jobId).OrderBy(o => o.ID).Select(s => new
                {
                    val = s.ID,
                }).ToList();

                foreach (var item in dataTC)
                {
                    int tranId = item.val;
                    var tran = db.tran_Creditor.Where(w => w.ID == tranId).FirstOrDefault();
                    //Sell Price
                    decimal sellPrice = db.mas_JobDetail.Where(w => w.ProductID == tran.ProductID && w.JobID == tran.JobID).FirstOrDefault().ProductPriceExactly;
                    this.dt.Rows.Add(this.gridViewCreditor.RowCount + 1, 0,
                                     tranId,
                                     tran.TransactionDate,
                                   tran.ProductID,
                                   tran.mas_Product.ProductCode,
                                   tran.mas_Product.ProductName,
                                  tran.TranWeight, sellPrice, sellPrice * tran.TranWeight, "0000");
                    this.dt.AcceptChanges();
                }

                this.gridControlCreditor.DataSource = dt;

                this.numSellPrice.Value = 0; this.txtJobQuantity.Text = string.Empty;
                this.cbTranCreditor.SelectedIndex = 0; this.cbTranCreditor.Select();
                for (int i = 0; i < this.dt.Rows.Count; i++)
                {
                    dt.Rows[i][0] = i + 1;
                }
                this.dt.AcceptChanges();
                this.gridControlCreditor.DataSource = dt;

                Compute();
            }
        }

        private void cbJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbJob.SelectedIndex > 0)
            {
                db = new Entity.CSBNPEntities(); int _jobId = int.Parse(this.cbJob.SelectedValue.ToString());
                var _job = db.mas_Job.Where(w => w.ID == _jobId).FirstOrDefault();
                if (_job == null)
                {
                    gloService.Announce("ไม่พบข้อมูลโครงการ .. โปรดตรวจสอบ !!", AnnounceType.Warning);
                    this.cbDebitor.Select();
                }
                else
                {
                    //How many Creditor for the Debitor
                    var _debitorrId = int.Parse(this.cbDebitor.SelectedValue.ToString());
                    int[] dataCre = db.mas_JobCreditor.Where(w => w.mas_Job.DebtorID == _debitorrId).Select(s => s.CreditorID).ToArray();
                    var dataTC = db.tran_Creditor.Where(w => bpId.Contains(w.BillingPeriodID) && dataCre.Contains(w.CreditorID) && w.JobID == _jobId).OrderBy(o => o.ID).Select(s => new
                    {
                        val = s.ID,
                        txt = s.mas_Creditor.CreditorName + " : " + s.DocumentNo + "-" + s.mas_Job.JobName
                    }).Distinct().ToList();
                    dataTC.Insert(0, new { val = 0, txt = "-- เลือกรายการเจ้าหนี้ --" });
                    this.cbTranCreditor.DataSource = dataTC;
                    this.cbTranCreditor.DisplayMember = "txt";
                    this.cbTranCreditor.ValueMember = "val";
                }
            }
            else
            {
                //this.txtDebitorName.Text = string.Empty;
                this.cbJob.DataSource = null; this.cbTranCreditor.DataSource = null;
            }
        }
    }
}
