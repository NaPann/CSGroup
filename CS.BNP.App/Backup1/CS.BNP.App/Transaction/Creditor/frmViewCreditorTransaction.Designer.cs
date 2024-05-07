namespace CS.BNP.App.Transaction.Creditor
{
    partial class frmViewCreditorTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewCreditorTransaction));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillingPeriodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBillingPeriodCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionCreditorCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillingDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTranWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarLicense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDriver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckEditPaid = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colDetailID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirmPaid = new System.Windows.Forms.Button();
            this.cbBillingPeriod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colTranUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEditPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colProductID
            // 
            this.colProductID.Caption = "ProductID";
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.OptionsColumn.ReadOnly = true;
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
            this.gridDelete.VisibleIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDelete_ButtonClick);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEdit_ButtonClick);
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
            this.gridEdit.VisibleIndex = 15;
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
            this.colTransactionDate.Width = 78;
            // 
            // colBillingPeriodID
            // 
            this.colBillingPeriodID.Caption = "รหัสช่วงเวลาการเบิกจ่าย";
            this.colBillingPeriodID.FieldName = "BillingPeriodID";
            this.colBillingPeriodID.Name = "colBillingPeriodID";
            this.colBillingPeriodID.Width = 122;
            // 
            // colNo
            // 
            this.colNo.Caption = "ที่";
            this.colNo.FieldName = "iNo";
            this.colNo.Name = "colNo";
            this.colNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            this.colNo.Width = 45;
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
            this.colBillingDate,
            this.colTransactionSeq,
            this.colDocumentNo,
            this.colUnitQty,
            this.colTranWeight,
            this.colJodID,
            this.colJobName,
            this.colCreditorName,
            this.colCarLicense,
            this.colDriver,
            this.colProdID,
            this.colProdCode,
            this.colProdName,
            this.colTotalAmount,
            this.colPaid,
            this.gridEdit,
            this.gridDelete,
            this.colTranUnit});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsMenu.EnableFooterMenu = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView_ShowingEditor);
            // 
            // colBillingPeriodCode
            // 
            this.colBillingPeriodCode.Caption = "ช่วงเวลาการเบิกเจ้าหนี้";
            this.colBillingPeriodCode.FieldName = "BillingPeriodCode";
            this.colBillingPeriodCode.Name = "colBillingPeriodCode";
            this.colBillingPeriodCode.Visible = true;
            this.colBillingPeriodCode.VisibleIndex = 1;
            this.colBillingPeriodCode.Width = 112;
            // 
            // colTransactionCreditorCode
            // 
            this.colTransactionCreditorCode.AppearanceCell.BackColor = System.Drawing.Color.Bisque;
            this.colTransactionCreditorCode.AppearanceCell.Options.UseBackColor = true;
            this.colTransactionCreditorCode.Caption = "รหัสรายการบันทึกเจ้าหนี้";
            this.colTransactionCreditorCode.FieldName = "TransactionCreditorCode";
            this.colTransactionCreditorCode.Name = "colTransactionCreditorCode";
            this.colTransactionCreditorCode.Width = 126;
            // 
            // colBillingDate
            // 
            this.colBillingDate.Caption = "วางบิล";
            this.colBillingDate.FieldName = "BillingDate";
            this.colBillingDate.Name = "colBillingDate";
            this.colBillingDate.OptionsColumn.ReadOnly = true;
            this.colBillingDate.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colBillingDate.Visible = true;
            this.colBillingDate.VisibleIndex = 2;
            this.colBillingDate.Width = 71;
            // 
            // colTransactionSeq
            // 
            this.colTransactionSeq.Caption = "ลำดับ";
            this.colTransactionSeq.FieldName = "TransactionSeq";
            this.colTransactionSeq.Name = "colTransactionSeq";
            this.colTransactionSeq.Visible = true;
            this.colTransactionSeq.VisibleIndex = 4;
            this.colTransactionSeq.Width = 41;
            // 
            // colDocumentNo
            // 
            this.colDocumentNo.Caption = "เลขที่ No.";
            this.colDocumentNo.FieldName = "DocumentNo";
            this.colDocumentNo.Name = "colDocumentNo";
            this.colDocumentNo.Visible = true;
            this.colDocumentNo.VisibleIndex = 5;
            this.colDocumentNo.Width = 67;
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
            this.colUnitQty.VisibleIndex = 6;
            this.colUnitQty.Width = 78;
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
            this.colTranWeight.VisibleIndex = 7;
            this.colTranWeight.Width = 74;
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
            this.colJobName.VisibleIndex = 10;
            this.colJobName.Width = 98;
            // 
            // colCreditorName
            // 
            this.colCreditorName.Caption = "เจ้าหนี้";
            this.colCreditorName.FieldName = "CreditorName";
            this.colCreditorName.Name = "colCreditorName";
            this.colCreditorName.Visible = true;
            this.colCreditorName.VisibleIndex = 9;
            this.colCreditorName.Width = 107;
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
            this.colDriver.Width = 73;
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
            this.colProdCode.Visible = true;
            this.colProdCode.VisibleIndex = 11;
            this.colProdCode.Width = 89;
            // 
            // colProdName
            // 
            this.colProdName.Caption = "ชื่อสินค้า";
            this.colProdName.FieldName = "ProductName";
            this.colProdName.Name = "colProdName";
            this.colProdName.Visible = true;
            this.colProdName.VisibleIndex = 12;
            this.colProdName.Width = 107;
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
            this.CheckEditPaid.Click += new System.EventHandler(this.CheckEditPaid_Click);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 74);
            this.gridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnDelete,
            this.CheckEditPaid});
            this.gridControl.Size = new System.Drawing.Size(1207, 411);
            this.gridControl.TabIndex = 12;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
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
            this.btnExit.Location = new System.Drawing.Point(1130, 4);
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
            this.btnAddData.Location = new System.Drawing.Point(1017, 2);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(110, 29);
            this.btnAddData.TabIndex = 1;
            this.btnAddData.Text = "เพิ่มข้อมูล";
            this.btnAddData.UseVisualStyleBackColor = false;
            this.btnAddData.Visible = false;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ข้อมูลรายการเจ้าหนี้ (ใบเหลือง)";
            // 
            // colDetailID
            // 
            this.colDetailID.Caption = "DetailID";
            this.colDetailID.FieldName = "ID";
            this.colDetailID.Name = "colDetailID";
            this.colDetailID.OptionsColumn.ReadOnly = true;
            // 
            // colJobID
            // 
            this.colJobID.Caption = "JobID";
            this.colJobID.FieldName = "JobID";
            this.colJobID.Name = "colJobID";
            this.colJobID.OptionsColumn.ReadOnly = true;
            // 
            // colProductCode
            // 
            this.colProductCode.Caption = "รหัสสินค้า";
            this.colProductCode.FieldName = "ProductCode";
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.OptionsColumn.ReadOnly = true;
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 0;
            this.colProductCode.Width = 127;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1207, 40);
            this.panelSearch.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnConfirmPaid);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.cbBillingPeriod);
            this.panel1.Controls.Add(this.btnAddData);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 34);
            this.panel1.TabIndex = 14;
            // 
            // btnConfirmPaid
            // 
            this.btnConfirmPaid.BackColor = System.Drawing.Color.DarkCyan;
            this.btnConfirmPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPaid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnConfirmPaid.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPaid.Location = new System.Drawing.Point(508, 2);
            this.btnConfirmPaid.Name = "btnConfirmPaid";
            this.btnConfirmPaid.Size = new System.Drawing.Size(151, 29);
            this.btnConfirmPaid.TabIndex = 4;
            this.btnConfirmPaid.Text = "ยืนยันการจ่ายทั้งหมด";
            this.btnConfirmPaid.UseVisualStyleBackColor = false;
            this.btnConfirmPaid.Visible = false;
            this.btnConfirmPaid.Click += new System.EventHandler(this.btnConfirmPaid_Click);
            // 
            // cbBillingPeriod
            // 
            this.cbBillingPeriod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBillingPeriod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBillingPeriod.FormattingEnabled = true;
            this.cbBillingPeriod.Location = new System.Drawing.Point(162, 6);
            this.cbBillingPeriod.Name = "cbBillingPeriod";
            this.cbBillingPeriod.Size = new System.Drawing.Size(340, 22);
            this.cbBillingPeriod.TabIndex = 1;
            this.cbBillingPeriod.SelectedIndexChanged += new System.EventHandler(this.cbBillingPeriod_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "เลือกช่วงเวลาการเบิกเจ้าหนี้";
            // 
            // colTranUnit
            // 
            this.colTranUnit.Caption = "หน่วย";
            this.colTranUnit.FieldName = "TranUnit";
            this.colTranUnit.Name = "colTranUnit";
            this.colTranUnit.OptionsColumn.ReadOnly = true;
            this.colTranUnit.Visible = true;
            this.colTranUnit.VisibleIndex = 8;
            this.colTranUnit.Width = 52;
            // 
            // frmViewCreditorTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1207, 485);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewCreditorTransaction";
            this.Text = "ข้อมูลรายการเจ้าหนี้ (ใบเหลือง)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewCreditorTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEditPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn gridDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBillingPeriodID;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailID;
        private DevExpress.XtraGrid.Columns.GridColumn colJobID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbBillingPeriod;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colBillingPeriodCode;
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
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionCreditorCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CheckEditPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditorName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitQty;
        private DevExpress.XtraGrid.Columns.GridColumn colBillingDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTranWeight;
        private System.Windows.Forms.Button btnConfirmPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colTranUnit;
    }
}