﻿namespace CS.BNP.App.SystemSetup.Products
{
    partial class frmViewProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewProduct));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReference = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsService = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage2";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 40);
            this.gridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnDelete});
            this.gridControl.Size = new System.Drawing.Size(933, 445);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colProductCode,
            this.colProductName,
            this.colReference,
            this.colProductPrice,
            this.colProductUnit,
            this.colIsService,
            this.gridEdit,
            this.gridDelete});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            // 
            // colID
            // 
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colID.Width = 20;
            // 
            // colProductCode
            // 
            this.colProductCode.Caption = "รหัสสินค้า";
            this.colProductCode.FieldName = "ProductCode";
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.OptionsColumn.ReadOnly = true;
            this.colProductCode.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 0;
            this.colProductCode.Width = 106;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "ชื่อสินค้า";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.ReadOnly = true;
            this.colProductName.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            this.colProductName.Width = 202;
            // 
            // colReference
            // 
            this.colReference.Caption = "แหล่งที่มา";
            this.colReference.FieldName = "Reference";
            this.colReference.Name = "colReference";
            this.colReference.OptionsColumn.ReadOnly = true;
            this.colReference.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colReference.Visible = true;
            this.colReference.VisibleIndex = 2;
            this.colReference.Width = 136;
            // 
            // colProductPrice
            // 
            this.colProductPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colProductPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colProductPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colProductPrice.Caption = "ราคาสินค้า";
            this.colProductPrice.DisplayFormat.FormatString = "N2";
            this.colProductPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colProductPrice.FieldName = "ProductPrice";
            this.colProductPrice.Name = "colProductPrice";
            this.colProductPrice.OptionsColumn.ReadOnly = true;
            this.colProductPrice.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colProductPrice.Visible = true;
            this.colProductPrice.VisibleIndex = 3;
            this.colProductPrice.Width = 96;
            // 
            // colProductUnit
            // 
            this.colProductUnit.Caption = "หน่วยนับ";
            this.colProductUnit.FieldName = "ProductUnit";
            this.colProductUnit.Name = "colProductUnit";
            this.colProductUnit.OptionsColumn.ReadOnly = true;
            this.colProductUnit.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colProductUnit.Visible = true;
            this.colProductUnit.VisibleIndex = 4;
            this.colProductUnit.Width = 114;
            // 
            // colIsService
            // 
            this.colIsService.Caption = "เป็นงานบริการ";
            this.colIsService.FieldName = "IsService";
            this.colIsService.Name = "colIsService";
            this.colIsService.OptionsColumn.ReadOnly = true;
            this.colIsService.Visible = true;
            this.colIsService.VisibleIndex = 5;
            this.colIsService.Width = 98;
            // 
            // gridEdit
            // 
            this.gridEdit.AppearanceHeader.Options.UseTextOptions = true;
            this.gridEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridEdit.Caption = "Edit";
            this.gridEdit.ColumnEdit = this.btnEdit;
            this.gridEdit.Name = "gridEdit";
            this.gridEdit.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridEdit.Visible = true;
            this.gridEdit.VisibleIndex = 6;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEdit_ButtonClick);
            // 
            // gridDelete
            // 
            this.gridDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.gridDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridDelete.Caption = "Delete";
            this.gridDelete.ColumnEdit = this.btnDelete;
            this.gridDelete.Name = "gridDelete";
            this.gridDelete.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridDelete.Visible = true;
            this.gridDelete.VisibleIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDelete_ButtonClick);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage2";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(850, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "ออก";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddData
            // 
            this.btnAddData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddData.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAddData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAddData.ForeColor = System.Drawing.Color.White;
            this.btnAddData.Location = new System.Drawing.Point(734, 7);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(110, 29);
            this.btnAddData.TabIndex = 1;
            this.btnAddData.Text = "เพิ่มข้อมูล";
            this.btnAddData.UseVisualStyleBackColor = false;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "สินค้าและวัสดุ";
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.MintCream;
            this.panelSearch.Controls.Add(this.btnExit);
            this.panelSearch.Controls.Add(this.btnAddData);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(933, 40);
            this.panelSearch.TabIndex = 5;
            // 
            // frmViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panelSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewProduct";
            this.Text = "ข้อมูลสินค้าวัสดุ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraGrid.GridControl gridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colReference;
        private DevExpress.XtraGrid.Columns.GridColumn colProductPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colProductUnit;
        private DevExpress.XtraGrid.Columns.GridColumn gridEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSearch;
        private DevExpress.XtraGrid.Columns.GridColumn colIsService;
    }
}