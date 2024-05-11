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

namespace CS.BNP.App.SystemSetup.Job
{
    public partial class frmAddEditJobCreditor : Form
    {
        public frmAddEditJobCreditor()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        public int iType = 0; //0 == Insert, any(ID)==Edit
        public int jobId = 0; private byte _saveexit = 0; private DataTable dt;
        private void ClearForm()
        {
            this.txtJobCode.Text = string.Empty; //"-- สร้างให้อัติโนมัติ --";
            this.txtJobName.Text = string.Empty;
            this.numProductSell.Value = 0;
            BindingControl(); this.cbProduct.SelectedIndex = 0; this.lblDetailID.Text = string.Empty; this.lblProdID.Text = string.Empty;
            this.dt = new DataTable(); buildDataTable(); this.btnAdd.Text = "เพิ่ม";
            this.txtDebitor.Text = string.Empty; this.txtJobCode.Enabled = false; this.txtJobName.Enabled = false; this.txtDebitor.Enabled = false;
        }
        private void buildDataTable()
        {
            dt.Columns.Add(new DataColumn("iNo", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("ID", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("JobID", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("CreditorID", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("CreditorName", typeof(System.String)));
            dt.Columns.Add(new DataColumn("ProductID", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("ProductCode", typeof(System.String)));
            dt.Columns.Add(new DataColumn("ProductName", typeof(System.String)));
            dt.Columns.Add(new DataColumn("ProductSellPrice", typeof(System.Decimal)));
            dt.Columns.Add(new DataColumn("SourceFrom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("TranUnit", typeof(System.String)));
            dt.AcceptChanges();
        }
        private void BindingControl()
        {
            using (var db = new Entity.CSBNPEntities())
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

                var dataProd = db.mas_JobDetail.Where(w=>w.JobID == this.jobId).OrderBy(o => o.ID).Select(s => new
                {
                    val = s.ProductID,
                    txt = s.mas_Product.ProductName + " : " + s.mas_Product.ProductCode
                }).ToList();
                dataProd.Insert(0, new { val = 0, txt = "-- เลือกสินค้า/วัสดุ --" });
                this.cbProduct.DataSource = dataProd;
                this.cbProduct.DisplayMember = "txt";
                this.cbProduct.ValueMember = "val";
            }
        }
        private void goSave()
        {
            bool allow = true;
            //Detail
            if (this.gridView.RowCount == 0)
            {
                this.gridView.Appearance.Empty.BackColor = Color.LightCoral;
                allow &= false;
            }
            else
            {
                this.gridView.Appearance.Empty.BackColor = Color.White; allow &= true;
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
                   Entity.mas_JobCreditor objDetail;
                    using (DbContextTransaction trans = db.Database.BeginTransaction())
                    {
                        for (int i = 0; i < this.gridView.DataRowCount; i++)
                        {
                            if (int.Parse(this.gridView.GetRowCellValue(i, "ID").ToString()) == 0)
                            {
                                objDetail = new Entity.mas_JobCreditor();
                                objDetail.JobID = jobId;
                                objDetail.CreditorID = int.Parse(this.gridView.GetRowCellValue(i, "CreditorID").ToString());
                                objDetail.ProductID = int.Parse(this.gridView.GetRowCellValue(i, "ProductID").ToString());
                                objDetail.ProductSellPrice = decimal.Parse(this.gridView.GetRowCellValue(i, "ProductSellPrice").ToString());
                                objDetail.SourceFrom = this.gridView.GetRowCellValue(i, "SourceFrom").ToString();
                                objDetail.CreatedBy = Variable.CurrentProfile.username;
                                objDetail.CreatedDate = DateTime.Now;
                                db.mas_JobCreditor.Add(objDetail);
                            }
                            else
                            {
                                var _id = int.Parse(this.gridView.GetRowCellValue(i, "ID").ToString());
                                var _up = db.mas_JobCreditor.Where(w => w.ID == _id).FirstOrDefault();
                                _up.ProductSellPrice = decimal.Parse(this.gridView.GetRowCellValue(i, "ProductSellPrice").ToString());
                                _up.SourceFrom = this.gridView.GetRowCellValue(i, "SourceFrom").ToString();
                            }
                        }

                        var job = db.mas_Job.Where(w => w.ID == jobId).FirstOrDefault();
                        if (job != null)
                        {
                            job.IsApprove = false;
                            job.UpdatedBy = Variable.CurrentProfile.username;
                            job.UpdatedDate = DateTime.Now;
                        }

                        db.SaveChanges();
                        trans.Commit();

                        //History
                        for (int i = 0; i < this.gridView.DataRowCount; i++)
                        {
                            gloService.LogHistoryService(LogHistory.INSERT, "JOBCREDITOR", String.Format("JOB:{0}|PRODUCT:{1}|SELLPRICE:{2}", this.txtJobCode.Text.Trim(),this.gridView.GetRowCellValue(i, "ProductName").ToString(), decimal.Parse(this.gridView.GetRowCellValue(i, "ProductSellPrice").ToString()).ToString("#,0.00")), Variable.CurrentProfile.username);
                        }
                        // gloService.Announce("บันทึกข้อมูลเรียบร้อย", AnnounceType.Infomation);
                    }
                }
                ClearForm();
                this.txtJobName.Select();
            }
            else
            {
                _saveexit = 0;
                this.btnSave.Select();
                return;
            }
        }
        private void frmAddEditJobCreditor_Load(object sender, EventArgs e)
        {
            ClearForm();
            if (jobId > 0)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    var _data = db.mas_JobCreditor.Where(w => w.JobID == jobId).FirstOrDefault();
                    if (_data != null)
                    {
                        this.txtJobCode.Text = _data.mas_Job.JobCode; 
                        this.txtJobName.Text = _data.mas_Job.JobName;
                        this.txtDebitor.Text = _data.mas_Job.mas_Debtor.DebtorName;

                        var _detail = db.mas_JobCreditor.Where(w => w.JobID == jobId).OrderBy(o => o.ID).AsEnumerable().Select((s, inx) => new
                        {
                            iNo = inx + 1,
                            ID = s.ID,
                            JobID = s.JobID,
                            CreditorID = s.CreditorID,
                            CreditorName = s.mas_Creditor.CreditorName + ":" + s.mas_Creditor.CreditorCode,
                            ProductID = s.ProductID,
                            ProductCode = s.mas_Product.ProductCode,
                            ProductName = s.mas_Product.ProductName,
                            ProductSellPrice = s.ProductSellPrice,
                            SourceFrom = s.SourceFrom,
                            TranUnit = s.mas_Product.ProductUnit
                        }).ToList();
                        foreach (var item in _detail)
                        {
                            this.dt.Rows.Add(item.iNo, item.ID, item.JobID, item.CreditorID, item.CreditorName, item.ProductID, 
                                item.ProductCode, item.ProductName, item.ProductSellPrice, item.SourceFrom,item.TranUnit);
                        }
                        this.dt.AcceptChanges();
                        this.gridControl.DataSource = this.dt;
                        this.gridControl.ForceInitialize();
                        this.cbCreditor.Select();
                    }
                    else
                    {
                        var dataJob = db.mas_Job.Where(w => w.ID == jobId).FirstOrDefault();
                        this.txtJobCode.Text = dataJob.JobCode;
                        this.txtJobName.Text = dataJob.JobName;
                        this.txtDebitor.Text = dataJob.mas_Debtor.DebtorName; ;
                        //New
                        this.gridControl.DataSource = this.dt;
                        this.gridControl.ForceInitialize();
                        this.cbCreditor.Select();
                    }
                }
            }
            else
                this.cbCreditor.Select();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool allow = true;
            allow &= gloService.RequireColorTextbox(this.numProductSell);
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
            if (this.cbProduct.SelectedIndex == 0)
            {
                this.cbProduct.BackColor = Color.LightCoral;
                allow &= false;
            }
            else
            {
                this.cbProduct.BackColor = Color.White;
                allow &= true;
            }

            if (!allow)
            {
                gloService.Announce("กรุณากรอกข้อมูลให้ครบเพื่อเพิ่มรายการ !!", AnnounceType.Warning);
                this.cbProduct.Select();
                return;
            }

            //Dup
            int _ex = 0;
            int _creId = int.Parse(this.cbCreditor.SelectedValue.ToString());
            int _proId = int.Parse(this.cbProduct.SelectedValue.ToString());
            _ex = dt.Select("ProductID = '" + _proId + "' and CreditorID = '" + _creId +"' ").Count();

            if (!string.IsNullOrWhiteSpace(this.lblProdID.Text.Trim()))
            {
                if ((int.Parse(this.lblProdID.Text.Trim()) == _proId) && (int.Parse(this.lblCreditorID.Text.Trim()) == _creId) && (_ex == 1))
                {
                    _ex = 99;
                }
            }


            if (_ex == 0)
            {
                this.dt.Rows.Add(this.gridView.RowCount + 1, 0, jobId,
                    int.Parse(this.cbCreditor.SelectedValue.ToString()),
                     this.cbCreditor.Text.Trim(),
                                 int.Parse(this.cbProduct.SelectedValue.ToString()),
                               this.cbProduct.Text.ToString().Split(':')[1].Trim(),
                               this.cbProduct.Text.ToString().Split(':')[0].Trim(),
                              this.numProductSell.Value, this.txtSourceFrom.Text.Trim());
                this.dt.AcceptChanges();
                this.gridControl.DataSource = dt;

                this.numProductSell.Value = 0; this.cbCreditor.SelectedIndex = 0; this.cbProduct.SelectedIndex = 0; this.txtSourceFrom.Text = string.Empty;
                this.btnAdd.Text = "เพิ่ม"; this.lblProdID.Text = string.Empty; this.lblCreditorID.Text = string.Empty; this.lblDetailID.Text = string.Empty;
                this.cbCreditor.Select();
            }
            else if (_ex == 99)
            {
                for (int i = 0; i < this.dt.Rows.Count; i++)
                {
                    if (this.lblProdID.Text.Trim() == this.dt.Rows[i]["ProductID"].ToString() && this.lblCreditorID.Text.Trim() == this.dt.Rows[i]["CreditorID"].ToString())
                    {
                        this.dt.Rows[i]["ProductSellPrice"] = this.numProductSell.Value; this.dt.Rows[i]["SourceFrom"] = this.txtSourceFrom.Text.Trim();
                        this.dt.AcceptChanges();
                        this.gridControl.DataSource = dt;

                        this.numProductSell.Value = 0; this.cbProduct.Enabled = true; this.cbCreditor.Enabled = true; this.txtSourceFrom.Text = string.Empty;
                        this.cbCreditor.SelectedIndex = 0; this.cbProduct.SelectedIndex = 0;
                        this.btnAdd.Text = "เพิ่ม"; this.lblProdID.Text = string.Empty; this.lblCreditorID.Text = string.Empty; this.lblDetailID.Text = string.Empty;
                        this.cbCreditor.Select();
                        break;
                    }
                }
            }
            else
            {
                gloService.Announce("ข้อมูลที่เลือกซ้ำ !!", AnnounceType.Warning);
                this.cbCreditor.Select();
                return;
            }
            for (int i = 0; i < this.dt.Rows.Count; i++)
            {
                dt.Rows[i][0] = i + 1;
            }
            this.dt.AcceptChanges();
        }

        private void btnEditDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.lblDetailID.Text = this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["ID"]).ToString();
            this.lblCreditorID.Text = this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["CreditorID"]).ToString();
            this.lblProdID.Text = this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["ProductID"]).ToString();
            this.cbCreditor.SelectedValue = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["CreditorID"]).ToString());
            this.cbProduct.SelectedValue = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["ProductID"]).ToString());
            this.numProductSell.Value = decimal.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["ProductSellPrice"]).ToString());
            this.txtSourceFrom.Text = this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["SourceFrom"]).ToString();
            this.cbCreditor.Enabled = false; this.cbProduct.Enabled = false; this.btnAdd.Text = "ปรับปรุง";

            this.numProductSell.Focus(); this.numProductSell.Select(0, this.numProductSell.Text.Length);
        }
        private void btnDeleteDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gloService.Sure("คุณต้องการลบข้อมูลรายการนี้ ?") == DialogResult.Yes)
            {
                int _deldata = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns[0]).ToString());
                if (_deldata == 0)
                {
                    this.dt.Rows.RemoveAt(this.gridView.GetDataSourceRowIndex(this.gridView.FocusedRowHandle)); this.dt.AcceptChanges();
                }
                else
                {
                    this.dt.Rows.RemoveAt(this.gridView.GetDataSourceRowIndex(this.gridView.FocusedRowHandle));
                    using (var db = new Entity.CSBNPEntities())
                    {
                        var del = db.mas_JobCreditor.Where(w => w.ID == _deldata).FirstOrDefault();
                        db.mas_JobCreditor.Remove(del);
                        db.SaveChanges();
                    }
                    this.dt.AcceptChanges();
                 
                }

                for (int i = 0; i < this.dt.Rows.Count; i++)
                {
                    dt.Rows[i][0] = i + 1;
                }
                this.dt.AcceptChanges();
                this.gridControl.DataSource = this.dt;
                this.gridControl.ForceInitialize();
                gloService.Announce("ลบข้อมูลเรียบร้อย", AnnounceType.Infomation);
            }
            else return;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                goSave();

                //Retrieve
                using (var db = new Entity.CSBNPEntities())
                {
                    var _detail = db.mas_JobCreditor.Where(w => w.JobID == jobId).OrderBy(o => o.ID).AsEnumerable().Select((s, inx) => new
                    {
                        iNo = inx + 1,
                        ID = s.ID,
                        JobID = s.JobID,
                        CreditorID = s.CreditorID,
                        CreditorName = s.mas_Creditor.CreditorName + ":" + s.mas_Creditor.CreditorCode,
                        ProductID = s.ProductID,
                        ProductCode = s.mas_Product.ProductCode,
                        ProductName = s.mas_Product.ProductName,
                        ProductSellPrice = s.ProductSellPrice,
                        SourceFrom = s.SourceFrom
                    }).ToList();
                    foreach (var item in _detail)
                    {
                        this.dt.Rows.Add(item.iNo, item.ID, item.JobID, item.CreditorID, item.CreditorName, item.ProductID,
                            item.ProductCode, item.ProductName, item.ProductSellPrice, item.SourceFrom);
                    }
                    this.dt.AcceptChanges();
                    this.gridControl.DataSource = this.dt;
                    this.gridControl.ForceInitialize();
                    this.cbCreditor.Select();
                }
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
                gloService.Announce("Something went wrong : " + ex.InnerException.InnerException.Message, AnnounceType.Error);
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
