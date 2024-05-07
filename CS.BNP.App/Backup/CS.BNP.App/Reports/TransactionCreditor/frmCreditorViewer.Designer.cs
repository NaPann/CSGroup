namespace CS.BNP.App.Reports.TransactionCreditor
{
    partial class frmCreditorViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreditorViewer));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillingPeriodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillingPeriodCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionCreditorCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarLicense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDriver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTranWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckEditPaid = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colTranUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.cbBillingPeriod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEditPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1238, 36);
            this.panelSearch.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "สรุปใบวางบิลเจ้าหนี้ (ใบเหลือง)";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 83);
            this.gridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnDelete,
            this.CheckEditPaid});
            this.gridControl.Size = new System.Drawing.Size(1238, 402);
            this.gridControl.TabIndex = 15;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colNo,
            this.colBillingPeriodID,
            this.colBillingPeriodCode,
            this.colTransactionCreditorCode,
            this.colTransactionDate,
            this.colTransactionSeq,
            this.colDocumentNo,
            this.colJodID,
            this.colJobName,
            this.colCarLicense,
            this.colDriver,
            this.colCreditorName,
            this.colProdID,
            this.colProdCode,
            this.colProdName,
            this.colUnitQty,
            this.colTranWeight,
            this.colUnitPrice,
            this.colTotalAmount,
            this.colPaid,
            this.colTranUnit});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsMenu.EnableFooterMenu = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowFooter = true;
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
            // colNo
            // 
            this.colNo.Caption = "ที่";
            this.colNo.FieldName = "iNo";
            this.colNo.Name = "colNo";
            this.colNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            this.colNo.Width = 27;
            // 
            // colBillingPeriodID
            // 
            this.colBillingPeriodID.Caption = "รหัสช่วงเวลาการเบิกจ่าย";
            this.colBillingPeriodID.FieldName = "BillingPeriodID";
            this.colBillingPeriodID.Name = "colBillingPeriodID";
            this.colBillingPeriodID.Width = 122;
            // 
            // colBillingPeriodCode
            // 
            this.colBillingPeriodCode.Caption = "ช่วงเวลาการเบิกจ่าย";
            this.colBillingPeriodCode.FieldName = "BillingPeriodCode";
            this.colBillingPeriodCode.Name = "colBillingPeriodCode";
            this.colBillingPeriodCode.Visible = true;
            this.colBillingPeriodCode.VisibleIndex = 1;
            this.colBillingPeriodCode.Width = 103;
            // 
            // colTransactionCreditorCode
            // 
            this.colTransactionCreditorCode.AppearanceCell.BackColor = System.Drawing.Color.Bisque;
            this.colTransactionCreditorCode.AppearanceCell.Options.UseBackColor = true;
            this.colTransactionCreditorCode.Caption = "รหัสรายการบันทึกเจ้าหนี้";
            this.colTransactionCreditorCode.FieldName = "TransactionCreditorCode";
            this.colTransactionCreditorCode.Name = "colTransactionCreditorCode";
            this.colTransactionCreditorCode.Visible = true;
            this.colTransactionCreditorCode.VisibleIndex = 2;
            this.colTransactionCreditorCode.Width = 124;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.Caption = "วันที่";
            this.colTransactionDate.DisplayFormat.FormatString = "d";
            this.colTransactionDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTransactionDate.FieldName = "TransactionDate";
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.OptionsColumn.ReadOnly = true;
            this.colTransactionDate.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colTransactionDate.Visible = true;
            this.colTransactionDate.VisibleIndex = 3;
            this.colTransactionDate.Width = 72;
            // 
            // colTransactionSeq
            // 
            this.colTransactionSeq.Caption = "ลำดับ";
            this.colTransactionSeq.FieldName = "TransactionSeq";
            this.colTransactionSeq.Name = "colTransactionSeq";
            this.colTransactionSeq.Visible = true;
            this.colTransactionSeq.VisibleIndex = 4;
            this.colTransactionSeq.Width = 46;
            // 
            // colDocumentNo
            // 
            this.colDocumentNo.Caption = "เลขที่ No.";
            this.colDocumentNo.FieldName = "DocumentNo";
            this.colDocumentNo.Name = "colDocumentNo";
            this.colDocumentNo.Visible = true;
            this.colDocumentNo.VisibleIndex = 5;
            // 
            // colJodID
            // 
            this.colJodID.Caption = "JobID";
            this.colJodID.FieldName = "JobID";
            this.colJodID.Name = "colJodID";
            // 
            // colJobName
            // 
            this.colJobName.Caption = "ชื่องาน";
            this.colJobName.FieldName = "JobName";
            this.colJobName.Name = "colJobName";
            this.colJobName.Visible = true;
            this.colJobName.VisibleIndex = 6;
            this.colJobName.Width = 117;
            // 
            // colCarLicense
            // 
            this.colCarLicense.Caption = "ทะเบียนรถ";
            this.colCarLicense.FieldName = "CarLicense";
            this.colCarLicense.Name = "colCarLicense";
            this.colCarLicense.Width = 103;
            // 
            // colDriver
            // 
            this.colDriver.Caption = "พนักงานขับรถ";
            this.colDriver.FieldName = "Driver";
            this.colDriver.Name = "colDriver";
            this.colDriver.Width = 119;
            // 
            // colCreditorName
            // 
            this.colCreditorName.Caption = "เจ้าหนี้";
            this.colCreditorName.FieldName = "CreditorName";
            this.colCreditorName.Name = "colCreditorName";
            this.colCreditorName.OptionsColumn.ReadOnly = true;
            this.colCreditorName.Visible = true;
            this.colCreditorName.VisibleIndex = 7;
            this.colCreditorName.Width = 121;
            // 
            // colProdID
            // 
            this.colProdID.Caption = "ProductID";
            this.colProdID.FieldName = "ProductID";
            this.colProdID.Name = "colProdID";
            // 
            // colProdCode
            // 
            this.colProdCode.Caption = "รหัสสินค้า";
            this.colProdCode.FieldName = "ProductCode";
            this.colProdCode.Name = "colProdCode";
            this.colProdCode.Width = 89;
            // 
            // colProdName
            // 
            this.colProdName.Caption = "ชื่อสินค้า";
            this.colProdName.FieldName = "ProductName";
            this.colProdName.Name = "colProdName";
            this.colProdName.Visible = true;
            this.colProdName.VisibleIndex = 8;
            this.colProdName.Width = 107;
            // 
            // colUnitQty
            // 
            this.colUnitQty.Caption = "จำนวนพ่วง";
            this.colUnitQty.FieldName = "TranUnitQuantity";
            this.colUnitQty.Name = "colUnitQty";
            this.colUnitQty.OptionsColumn.ReadOnly = true;
            this.colUnitQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TranUnitQuantity", "รวม:{0:0.##}")});
            this.colUnitQty.Visible = true;
            this.colUnitQty.VisibleIndex = 9;
            // 
            // colTranWeight
            // 
            this.colTranWeight.Caption = "จำนวน";
            this.colTranWeight.FieldName = "TranWeight";
            this.colTranWeight.Name = "colTranWeight";
            this.colTranWeight.OptionsColumn.ReadOnly = true;
            this.colTranWeight.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TranWeight", "รวม:{0:0.##}")});
            this.colTranWeight.Visible = true;
            this.colTranWeight.VisibleIndex = 10;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "ราคาซื้อ";
            this.colUnitPrice.FieldName = "TranBuyPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 12;
            this.colUnitPrice.Width = 105;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.Caption = "รวมสุทธิ";
            this.colTotalAmount.DisplayFormat.FormatString = "#,0.00";
            this.colTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "รวม:{0:#,0.00}")});
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 13;
            this.colTotalAmount.Width = 100;
            // 
            // colPaid
            // 
            this.colPaid.Caption = "ชำระแล้ว";
            this.colPaid.ColumnEdit = this.CheckEditPaid;
            this.colPaid.FieldName = "IsPaid";
            this.colPaid.Name = "colPaid";
            this.colPaid.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colPaid.Visible = true;
            this.colPaid.VisibleIndex = 14;
            // 
            // CheckEditPaid
            // 
            this.CheckEditPaid.AutoHeight = false;
            this.CheckEditPaid.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1;
            this.CheckEditPaid.Name = "CheckEditPaid";
            // 
            // colTranUnit
            // 
            this.colTranUnit.Caption = "หน่วยนับ";
            this.colTranUnit.FieldName = "TranUnit";
            this.colTranUnit.Name = "colTranUnit";
            this.colTranUnit.OptionsColumn.ReadOnly = true;
            this.colTranUnit.Visible = true;
            this.colTranUnit.VisibleIndex = 11;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.cbBillingPeriod);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 47);
            this.panel1.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.Appearance.Options.UseBorderColor = true;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExit.Location = new System.Drawing.Point(806, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 29);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "ออก";
            this.btnExit.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnReport
            // 
            this.btnReport.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.btnReport.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnReport.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnReport.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnReport.Appearance.Options.UseBackColor = true;
            this.btnReport.Appearance.Options.UseBorderColor = true;
            this.btnReport.Appearance.Options.UseFont = true;
            this.btnReport.Appearance.Options.UseForeColor = true;
            this.btnReport.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReport.AppearanceHovered.Options.UseBackColor = true;
            this.btnReport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.ImageOptions.Image")));
            this.btnReport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReport.Location = new System.Drawing.Point(542, 9);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(126, 29);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "รายงาน";
            this.btnReport.Visible = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cbBillingPeriod
            // 
            this.cbBillingPeriod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBillingPeriod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBillingPeriod.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbBillingPeriod.FormattingEnabled = true;
            this.cbBillingPeriod.Location = new System.Drawing.Point(189, 11);
            this.cbBillingPeriod.Name = "cbBillingPeriod";
            this.cbBillingPeriod.Size = new System.Drawing.Size(342, 24);
            this.cbBillingPeriod.TabIndex = 1;
            this.cbBillingPeriod.SelectedIndexChanged += new System.EventHandler(this.cbBillingPeriod_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "เลือกช่วงเวลาการเบิกเจ้าหนี้";
            // 
            // btnExport
            // 
            this.btnExport.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExport.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnExport.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnExport.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnExport.Appearance.Options.UseBackColor = true;
            this.btnExport.Appearance.Options.UseBorderColor = true;
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Appearance.Options.UseForeColor = true;
            this.btnExport.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExport.AppearanceHovered.Options.UseBackColor = true;
            this.btnExport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExport.Location = new System.Drawing.Point(674, 9);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(126, 29);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Excel";
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmCreditorViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1238, 485);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCreditorViewer";
            this.Text = "สรุปใบวางบิลเจ้าหนี้";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCreditorViewer_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEditPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBillingPeriodID;
        private DevExpress.XtraGrid.Columns.GridColumn colBillingPeriodCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionCreditorCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionSeq;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentNo;
        private DevExpress.XtraGrid.Columns.GridColumn colJodID;
        private DevExpress.XtraGrid.Columns.GridColumn colJobName;
        private DevExpress.XtraGrid.Columns.GridColumn colCarLicense;
        private DevExpress.XtraGrid.Columns.GridColumn colDriver;
        private DevExpress.XtraGrid.Columns.GridColumn colProdID;
        private DevExpress.XtraGrid.Columns.GridColumn colProdCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProdName;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPaid;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CheckEditPaid;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private System.Windows.Forms.ComboBox cbBillingPeriod;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitQty;
        private DevExpress.XtraGrid.Columns.GridColumn colTranWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditorName;
        private DevExpress.XtraGrid.Columns.GridColumn colTranUnit;
        private DevExpress.XtraEditors.SimpleButton btnExport;
    }
}