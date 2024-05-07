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

namespace CS.BNP.App.SystemSetup.Products
{
    public partial class frmAddEditProduct : Form
    {
        public frmAddEditProduct()
        {
            InitializeComponent();
        }
        Services.GlobalService gloService = new Services.GlobalService();
        public int iType = 0; //0 == Insert, any(ID)==Edit 
        private void ClearForm()
        {
            this.txtProductCode.Enabled = true;
            this.txtProductCode.Text = string.Empty; //"-- สร้างให้อัติโนมัติ --";
            this.txtProductName.Text = string.Empty; this.txtProductPrice.Text = string.Empty;
            this.txtReference.Text = string.Empty; this.txtProductUnit.Text = string.Empty; this.chkIsService.Checked = false;
        }
        private void goSave()
        {
            bool allow = true;
            allow &= gloService.RequireColorTextbox(this.txtProductCode);
            allow &= gloService.RequireColorTextbox(this.txtProductName);
            allow &= gloService.RequireColorTextbox(this.txtProductPrice);
            allow &= gloService.RequireColorTextbox(this.txtProductUnit);
       
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
                    var _dup = db.mas_Product.Where(w => w.ProductCode == this.txtProductCode.Text.Trim()).FirstOrDefault();
                    if (_dup != null)
                    {
                        gloService.Announce("รหัสสินค้าซ้ำ .. กรุณาลองใหม่อีกครั้ง", AnnounceType.Warning);
                        this.txtProductCode.Select(); this.txtProductCode.SelectAll();
                        return;
                    }
                }
            }

            //Save
            if (gloService.Sure("คุณต้องการบันทึกข้อมูล ?") == DialogResult.Yes)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    Entity.mas_Product obj;
                    switch (iType)
                    {
                        case 0:
                            obj = new Entity.mas_Product();
                            obj.ProductCode = this.txtProductCode.Text.Trim(); //gloService.AutoGenerate(GenerateType.Product);
                            obj.ProductName = this.txtProductName.Text.Trim();
                            obj.Reference = this.txtReference.Text.Trim();
                            obj.ProductPrice = decimal.Parse(this.txtProductPrice.Text.Trim());
                            obj.ProductUnit = this.txtProductUnit.Text.Trim();
                            obj.CreatedBy = Variable.CurrentProfile.username;
                            obj.CreatedDate = DateTime.Now;
                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            obj.IsService = this.chkIsService.Checked;
                            db.mas_Product.Add(obj);
                            db.SaveChanges();

                            frmViewProduct frmParent = Application.OpenForms["frmViewProduct"] as frmViewProduct;
                            frmParent.DGV();

                           // gloService.Announce("บันทึกข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            break;
                        default:
                            obj = db.mas_Product.Where(w => w.ID == iType).FirstOrDefault();
                            obj.ProductName = this.txtProductName.Text.Trim();
                            obj.Reference = this.txtReference.Text.Trim();
                            obj.ProductPrice = decimal.Parse(this.txtProductPrice.Text.Trim());
                            obj.ProductUnit = this.txtProductUnit.Text.Trim();
                            obj.UpdatedBy = Variable.CurrentProfile.username;
                            obj.UpdatedDate = DateTime.Now;
                            obj.IsService = this.chkIsService.Checked;
                            db.SaveChanges();
                            //gloService.Announce("แก้ไขข้อมูลเรียบร้อย", AnnounceType.Infomation);
                            this.Close();
                            break;
                    }
                }
                ClearForm();
                this.txtProductCode.Select();
            }
            else
            {
                _saveexit = 0;
                this.btnSave.Select();
                return;
            }
        }

        private byte _saveexit = 0;
        private void frmAddEditProduct_Load(object sender, EventArgs e)
        {
            ClearForm();
            if (iType > 0)
            {
                using (var db = new Entity.CSBNPEntities())
                {
                    var _data = db.mas_Product.Where(w => w.ID == iType).FirstOrDefault();
                    if (_data != null)
                    {
                        this.txtProductCode.Text = _data.ProductCode;
                        this.txtProductName.Text = _data.ProductName;
                        this.txtProductPrice.Text = _data.ProductPrice.ToString();
                        this.txtProductUnit.Text = _data.ProductUnit;
                        this.txtReference.Text = _data.Reference;
                        this.chkIsService.Checked = _data.IsService;
                        this.txtProductCode.Enabled = false; this.txtProductName.Select(); this.txtProductName.SelectAll();
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
                this.txtProductCode.Select();
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

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
