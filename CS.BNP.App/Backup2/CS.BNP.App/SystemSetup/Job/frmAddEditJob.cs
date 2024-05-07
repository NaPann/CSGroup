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
    public partial class frmAddEditJob : Form
    {
        public frmAddEditJob()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        public int iType = 0; //0 == Insert, any(ID)==Edit 
        private void ClearForm()
        {
            this.txtJobCode.Text = string.Empty; //"-- สร้างให้อัติโนมัติ --";
            this.txtJobName.Text = string.Empty;
            this.txtBudget.Text = string.Empty; this.numProductPrice.Value = 0;
            this.txtQuantity.Text = string.Empty;
            BindingControl(); this.cbProduct.SelectedIndex = 0; this.lblDetailID.Text = string.Empty; this.lblProdID.Text = string.Empty;
            this.dt = new DataTable(); buildDataTable(); this.btnAdd.Text = "เพิ่ม";
            this.cbDebtor.SelectedIndex = 0; this.dtpJodDateStart.Value = DateTime.Now; this.txtJobCode.Enabled = true;
        }
        private void BindingControl()
        {
            using (var db = new Entity.CSBNPEntities())
            {
                var data = db.mas_Debtor.OrderBy(o => o.ID).Select(s => new
                {
                    val = s.ID,
                    txt = s.DebtorName + " : " + s.DebtorCode
                }).ToList();
                data.Insert(0, new { val = 0, txt = "-- เลือกลูกหนี้ --" });
                this.cbDebtor.DataSource = data;
                this.cbDebtor.DisplayMember = "txt";
                this.cbDebtor.ValueMember = "val";


                var dataProd = db.mas_Product.OrderBy(o => o.ID).Select(s => new
                {
                    val = s.ID,
                    txt = s.ProductName + " : " + s.ProductCode
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
            allow &= gloService.RequireColorTextbox(this.txtJobCode);
            allow &= gloService.RequireColorTextbox(this.txtJobName);
            allow &= gloService.RequireColorTextbox(this.txtBudget);
            if (this.cbDebtor.SelectedIndex == 0)
            {
                this.cbDebtor.BackColor = Color.LightCoral;
                allow &= false;
            }
            else
            {
                this.cbDebtor.BackColor = Color.White;
                allow &= true;
            }

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

            //Duplicate
            if (this.iType == 0)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    var _dup = db.mas_Job.Where(w => w.JobCode == this.txtJobCode.Text.Trim()).FirstOrDefault();
                    if (_dup != null)
                    {
                        gloService.Announce("รหัสงานซ้ำ .. กรุณาลองใหม่อีกครั้ง", AnnounceType.Warning);
                        this.txtJobCode.Select(); this.txtJobCode.SelectAll();
                        return;
                    }
                }
            }

            //Save
            if (gloService.Sure("คุณต้องการบันทึกข้อมูล ?") == DialogResult.Yes)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    Entity.mas_Job obj; Entity.mas_JobDetail objDetail;
                    using (DbContextTransaction trans = db.Database.BeginTransaction())
                    {
                        switch (iType)
                        {
                            case 0:
                                obj = new Entity.mas_Job();
                                obj.JobCode = this.txtJobCode.Text.Trim();  //gloService.AutoGenerate(GenerateType.Job);
                                obj.JobName = this.txtJobName.Text.Trim();
                                obj.Budget = decimal.Parse(this.txtBudget.Text.Trim());
                                obj.JobDateStart = this.dtpJodDateStart.Value;
                                obj.DebtorID = int.Parse(this.cbDebtor.SelectedValue.ToString());
                                obj.CreatedBy = Variable.CurrentProfile.username;
                                obj.CreatedDate = DateTime.Now;
                                obj.UpdatedBy = Variable.CurrentProfile.username;
                                obj.UpdatedDate = DateTime.Now;
                                obj.IsApprove = false;
                                db.mas_Job.Add(obj);
                                db.SaveChanges();                                                        

                                for (int i = 0; i < this.gridView.DataRowCount; i++)
                                {
                                    objDetail = new Entity.mas_JobDetail();
                                    objDetail.JobID = obj.ID;
                                    objDetail.JobQuantity = decimal.Parse(this.gridView.GetRowCellValue(i, "JobQuantity").ToString());
                                    objDetail.ProductPriceExactly = decimal.Parse(this.gridView.GetRowCellValue(i, "ProductPriceExactly").ToString());
                                    objDetail.ProductID = int.Parse(this.gridView.GetRowCellValue(i, "ProductID").ToString());
                                    objDetail.CreatedBy = Variable.CurrentProfile.username;
                                    objDetail.CreatedDate = DateTime.Now;
                                    db.mas_JobDetail.Add(objDetail);
                                }
                                db.SaveChanges();
                                trans.Commit();

                                //History
                                gloService.LogHistoryService(LogHistory.INSERT, "JOB", String.Format("JOB:{0}|NAME:{1}", this.txtJobCode.Text.Trim(), this.txtJobName.Text.Trim()), Variable.CurrentProfile.username);
                                for (int i = 0; i < this.gridView.DataRowCount; i++)
                                {
                                    gloService.LogHistoryService(LogHistory.INSERT, "JOBDETAIL", String.Format("JOB:{0}|JOBQTY:{1}|PRODUCT:{2}|PRICE:{3}", this.txtJobCode.Text.Trim(), decimal.Parse(this.gridView.GetRowCellValue(i, "JobQuantity").ToString()).ToString("#,0.00"), this.gridView.GetRowCellValue(i, "ProductName").ToString(), decimal.Parse(this.gridView.GetRowCellValue(i, "ProductPriceExactly").ToString()).ToString("#,0.00")), Variable.CurrentProfile.username);
                                }

                                frmViewJob frmParent = Application.OpenForms["frmViewJob"] as frmViewJob;
                                frmParent.DGV();

                               // gloService.Announce("บันทึกข้อมูลเรียบร้อย", AnnounceType.Infomation);
                                break;
                            default:
                                obj = db.mas_Job.Where(w => w.ID == iType).FirstOrDefault();
                                obj.JobName = this.txtJobName.Text.Trim();
                                obj.Budget = decimal.Parse(this.txtBudget.Text.Trim());
                                obj.JobDateStart = this.dtpJodDateStart.Value;
                                obj.DebtorID = int.Parse(this.cbDebtor.SelectedValue.ToString());
                                obj.UpdatedBy = Variable.CurrentProfile.username;
                                obj.UpdatedDate = DateTime.Now;
                                obj.IsApprove = false;
                                db.SaveChanges();

                                for (int i = 0; i < this.gridView.DataRowCount; i++)
                                {
                                    if (int.Parse(this.gridView.GetRowCellValue(i, "ID").ToString()) == 0)
                                    {
                                        objDetail = new Entity.mas_JobDetail();
                                        objDetail.JobID = obj.ID;
                                        objDetail.JobQuantity = decimal.Parse(this.gridView.GetRowCellValue(i, "JobQuantity").ToString());
                                        objDetail.ProductPriceExactly = decimal.Parse(this.gridView.GetRowCellValue(i, "ProductPriceExactly").ToString());
                                        objDetail.ProductID = int.Parse(this.gridView.GetRowCellValue(i, "ProductID").ToString());
                                        objDetail.CreatedBy = Variable.CurrentProfile.username;
                                        objDetail.CreatedDate = DateTime.Now;
                                        db.mas_JobDetail.Add(objDetail);
                                    }
                                    else
                                    {
                                        var _id = int.Parse(this.gridView.GetRowCellValue(i, "ID").ToString());
                                        var _up = db.mas_JobDetail.Where(w => w.ID == _id).FirstOrDefault();
                                        _up.JobQuantity = decimal.Parse(this.gridView.GetRowCellValue(i, "JobQuantity").ToString());
                                        _up.ProductPriceExactly = decimal.Parse(this.gridView.GetRowCellValue(i, "ProductPriceExactly").ToString());
                                    }
                                }
                                db.SaveChanges();
                                trans.Commit();

                                //History
                                gloService.LogHistoryService(LogHistory.INSERT, "JOB", String.Format("JOB:{0}|NAME:{1}", this.txtJobCode.Text.Trim(), this.txtJobName.Text.Trim()), Variable.CurrentProfile.username);
                                for (int i = 0; i < this.gridView.DataRowCount; i++)
                                {
                                    gloService.LogHistoryService(LogHistory.INSERT, "JOBDETAIL", String.Format("JOB:{0}|JOBQTY:{1}|PRODUCT:{2}|PRICE:{3}", this.txtJobCode.Text.Trim(), decimal.Parse(this.gridView.GetRowCellValue(i, "JobQuantity").ToString()).ToString("#,0.00"), this.gridView.GetRowCellValue(i, "ProductName").ToString(), decimal.Parse(this.gridView.GetRowCellValue(i, "ProductPriceExactly").ToString()).ToString("#,0.00")), Variable.CurrentProfile.username);
                                }

                                this.Close();
                                break;
                        }
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
        private byte _saveexit = 0;
        private void txtBudget_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void frmAddEditJob_Load(object sender, EventArgs e)
        {
            ClearForm();
            if (iType > 0)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    var _data = db.mas_Job.Where(w => w.ID == iType).FirstOrDefault();
                    if (_data != null)
                    {
                        this.txtJobCode.Text = _data.JobCode; this.txtJobCode.Enabled = false;
                        this.txtJobName.Text = _data.JobName;
                        this.dtpJodDateStart.Value = _data.JobDateStart;
                        this.txtBudget.Text = _data.Budget.ToString("#,0.00");
                        this.cbDebtor.SelectedValue = _data.DebtorID;

                        var _detail = db.mas_JobDetail.Where(w => w.JobID == _data.ID).OrderBy(o => o.ID).AsEnumerable().Select((s, inx) => new
                        {
                            iNo = inx + 1,
                            ID = s.ID,
                            JobID = s.JobID,
                            ProductID = s.ProductID,
                            ProductCode = s.mas_Product.ProductCode,
                            ProductName = s.mas_Product.ProductName,
                            JobQuantity = s.JobQuantity,
                            ProductPriceExactly = s.ProductPriceExactly
                        }).ToList();
                        foreach (var item in _detail)
                        {
                            this.dt.Rows.Add(item.iNo, item.ID, item.JobID, item.ProductID, item.ProductCode, item.ProductName, item.JobQuantity, item.ProductPriceExactly);
                        }
                        this.dt.AcceptChanges();
                        this.gridControl.DataSource = this.dt;
                        this.gridControl.ForceInitialize();
                        this.txtJobCode.Enabled = false; this.txtJobName.Select(); this.txtJobName.SelectAll();
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
                this.txtJobCode.Select();
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
            try { 
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

        private DataTable dt;
        private void buildDataTable()
        {
            dt.Columns.Add(new DataColumn("iNo", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("ID", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("JobID", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("ProductID", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("ProductCode", typeof(System.String)));
            dt.Columns.Add(new DataColumn("ProductName", typeof(System.String)));
            dt.Columns.Add(new DataColumn("JobQuantity", typeof(System.Decimal)));
            dt.Columns.Add(new DataColumn("ProductPriceExactly", typeof(System.Decimal)));
            dt.AcceptChanges();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool allow = true;
            allow &= gloService.RequireColorTextbox(this.txtQuantity);
            allow &= gloService.RequireColorTextbox(this.numProductPrice);
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
            int _proId = int.Parse(this.cbProduct.SelectedValue.ToString());
            _ex = dt.Select("ProductID = '" + _proId + "'").Count();

            if (!string.IsNullOrWhiteSpace(this.lblProdID.Text.Trim()))
            {
                if ((int.Parse(this.lblProdID.Text.Trim()) == _proId) && (_ex == 1))
                {
                    _ex = 99;
                }
            }


            if (_ex == 0)
            {
                this.dt.Rows.Add(this.gridView.RowCount + 1, 0, 0,
                                 int.Parse(this.cbProduct.SelectedValue.ToString()),
                               this.cbProduct.Text.ToString().Split(':')[1].Trim(),
                               this.cbProduct.Text.ToString().Split(':')[0].Trim(),
                               decimal.Parse(this.txtQuantity.Text.Trim()), this.numProductPrice.Value);
                this.dt.AcceptChanges();
                this.gridControl.DataSource = dt;

                this.numProductPrice.Value = 0; this.txtQuantity.Text = string.Empty; this.cbProduct.SelectedIndex = 0;
                this.cbProduct.Select();
            }
            else if (_ex == 99)
            {
                for (int i = 0; i < this.dt.Rows.Count; i++)
                {
                    if (this.lblProdID.Text.Trim() == this.dt.Rows[i]["ProductID"].ToString())
                    {
                        this.dt.Rows[i]["JobQuantity"] = decimal.Parse(this.txtQuantity.Text.Trim());
                        this.dt.Rows[i]["ProductPriceExactly"] = this.numProductPrice.Value;
                        this.dt.AcceptChanges();
                        this.gridControl.DataSource = dt;

                        this.numProductPrice.Value = 0; this.txtQuantity.Text = string.Empty;
                        this.cbProduct.Enabled = true; this.cbProduct.SelectedIndex = 0; this.btnAdd.Text = "เพิ่ม";
                        this.cbProduct.Select();
                        break;
                    }
                }
            }
            else
            {
                gloService.Announce("คุณได้เลือกสินค้าชนิดนี้ไปแล้ว !!", AnnounceType.Warning);
                this.cbProduct.Select();
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
            this.lblProdID.Text = this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["ProductID"]).ToString();
            this.cbProduct.SelectedValue = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["ProductID"]).ToString());
            this.numProductPrice.Value = decimal.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["ProductPriceExactly"]).ToString());
            this.txtQuantity.Text = this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns["JobQuantity"]).ToString();
            this.cbProduct.Enabled = false; this.btnAdd.Text = "ปรับปรุง";
            this.txtQuantity.Select();
        }

        private void btnDeleteDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gloService.Sure("คุณต้องการลบข้อมูลรายการนี้ ?") == DialogResult.Yes)
            {
                int _deldata = int.Parse(this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, gridView.Columns[0]).ToString());
                if (_deldata == 0)
                {
                    this.dt.Rows.RemoveAt(this.gridView.GetDataSourceRowIndex(this.gridView.FocusedRowHandle)); this.dt.AcceptChanges();
                    this.gridControl.DataSource = this.dt;
                }
                else
                {
                    this.dt.Rows.RemoveAt(this.gridView.GetDataSourceRowIndex(this.gridView.FocusedRowHandle));
                    using (var db = new Entity.CSBNPEntities())
                    {
                        var del = db.mas_JobDetail.Where(w => w.ID == _deldata).FirstOrDefault();
                        db.mas_JobDetail.Remove(del);
                        db.SaveChanges();
                    }
                    this.dt.AcceptChanges();
                    this.gridControl.DataSource = this.dt;
                    this.gridControl.ForceInitialize();
                }            

                gloService.Announce("ลบข้อมูลเรียบร้อย", AnnounceType.Infomation);
            }
            else return;
        }

    }
}
