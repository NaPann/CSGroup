namespace CS.BNP.App.Reports.Letter
{
    partial class frmLetterCond
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLetterCond));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.cbDebitor = new System.Windows.Forms.ComboBox();
            this.btnEachDay = new DevExpress.XtraEditors.SimpleButton();
            this.btnBillDetail = new DevExpress.XtraEditors.SimpleButton();
            this.cbDebitorPeriod = new System.Windows.Forms.ComboBox();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.CheckEditPaid = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTranWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarLicense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebitorPeriodCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebitorPeriodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDriver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebitorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.colTranUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEditPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
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
            this.btnExit.Location = new System.Drawing.Point(898, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 24);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "ออก";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnReport.Location = new System.Drawing.Point(186, 44);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(254, 29);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "เอกสารวางบิลแจ้งหนี้";
            this.btnReport.Visible = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "เลือกช่วงเวลาการเบิกลูกหนี้";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cbJob);
            this.panel1.Controls.Add(this.cbDebitor);
            this.panel1.Controls.Add(this.btnEachDay);
            this.panel1.Controls.Add(this.btnBillDetail);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.cbDebitorPeriod);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 84);
            this.panel1.TabIndex = 19;
            // 
            // cbJob
            // 
            this.cbJob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbJob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbJob.DropDownHeight = 250;
            this.cbJob.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbJob.FormattingEnabled = true;
            this.cbJob.IntegralHeight = false;
            this.cbJob.Location = new System.Drawing.Point(706, 11);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(186, 24);
            this.cbJob.TabIndex = 9;
            // 
            // cbDebitor
            // 
            this.cbDebitor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDebitor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDebitor.DropDownHeight = 250;
            this.cbDebitor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbDebitor.FormattingEnabled = true;
            this.cbDebitor.IntegralHeight = false;
            this.cbDebitor.Location = new System.Drawing.Point(446, 11);
            this.cbDebitor.Name = "cbDebitor";
            this.cbDebitor.Size = new System.Drawing.Size(254, 24);
            this.cbDebitor.TabIndex = 8;
            // 
            // btnEachDay
            // 
            this.btnEachDay.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEachDay.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnEachDay.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnEachDay.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnEachDay.Appearance.Options.UseBackColor = true;
            this.btnEachDay.Appearance.Options.UseBorderColor = true;
            this.btnEachDay.Appearance.Options.UseFont = true;
            this.btnEachDay.Appearance.Options.UseForeColor = true;
            this.btnEachDay.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEachDay.AppearanceHovered.Options.UseBackColor = true;
            this.btnEachDay.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEachDay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEachDay.ImageOptions.Image")));
            this.btnEachDay.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEachDay.Location = new System.Drawing.Point(706, 44);
            this.btnEachDay.Name = "btnEachDay";
            this.btnEachDay.Size = new System.Drawing.Size(186, 29);
            this.btnEachDay.TabIndex = 7;
            this.btnEachDay.Text = "รายละเอียดประจำวัน";
            this.btnEachDay.Visible = false;
            this.btnEachDay.Click += new System.EventHandler(this.btnEachDay_Click);
            // 
            // btnBillDetail
            // 
            this.btnBillDetail.Appearance.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBillDetail.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnBillDetail.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnBillDetail.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBillDetail.Appearance.Options.UseBackColor = true;
            this.btnBillDetail.Appearance.Options.UseBorderColor = true;
            this.btnBillDetail.Appearance.Options.UseFont = true;
            this.btnBillDetail.Appearance.Options.UseForeColor = true;
            this.btnBillDetail.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBillDetail.AppearanceHovered.Options.UseBackColor = true;
            this.btnBillDetail.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnBillDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBillDetail.ImageOptions.Image")));
            this.btnBillDetail.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnBillDetail.Location = new System.Drawing.Point(446, 44);
            this.btnBillDetail.Name = "btnBillDetail";
            this.btnBillDetail.Size = new System.Drawing.Size(254, 29);
            this.btnBillDetail.TabIndex = 6;
            this.btnBillDetail.Text = "รายละเอียดในการตั้งเบิกเงิน";
            this.btnBillDetail.Visible = false;
            this.btnBillDetail.Click += new System.EventHandler(this.btnBillDetail_Click);
            // 
            // cbDebitorPeriod
            // 
            this.cbDebitorPeriod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDebitorPeriod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDebitorPeriod.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbDebitorPeriod.FormattingEnabled = true;
            this.cbDebitorPeriod.Location = new System.Drawing.Point(186, 11);
            this.cbDebitorPeriod.Name = "cbDebitorPeriod";
            this.cbDebitorPeriod.Size = new System.Drawing.Size(254, 24);
            this.cbDebitorPeriod.TabIndex = 1;
            this.cbDebitorPeriod.SelectedIndexChanged += new System.EventHandler(this.cbDebitorPeriod_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // CheckEditPaid
            // 
            this.CheckEditPaid.AutoHeight = false;
            this.CheckEditPaid.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1;
            this.CheckEditPaid.Name = "CheckEditPaid";
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.Caption = "รวมก่อนภาษี";
            this.colTotalAmount.DisplayFormat.FormatString = "#,0.00";
            this.colTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.OptionsColumn.ReadOnly = true;
            this.colTotalAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "รวม:{0:#,0.00}")});
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 8;
            this.colTotalAmount.Width = 113;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "ราคาซื้อ";
            this.colUnitPrice.FieldName = "TranSellPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.OptionsColumn.ReadOnly = true;
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 6;
            this.colUnitPrice.Width = 105;
            // 
            // colTranWeight
            // 
            this.colTranWeight.Caption = "จำนวน";
            this.colTranWeight.DisplayFormat.FormatString = "#,0";
            this.colTranWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTranWeight.FieldName = "TranWeight";
            this.colTranWeight.Name = "colTranWeight";
            this.colTranWeight.OptionsColumn.ReadOnly = true;
            this.colTranWeight.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TranWeight", "รวม:{0:0,#.##}")});
            this.colTranWeight.Visible = true;
            this.colTranWeight.VisibleIndex = 4;
            this.colTranWeight.Width = 83;
            // 
            // colProdName
            // 
            this.colProdName.Caption = "ชื่อสินค้า";
            this.colProdName.FieldName = "ProductName";
            this.colProdName.Name = "colProdName";
            this.colProdName.OptionsColumn.ReadOnly = true;
            this.colProdName.Visible = true;
            this.colProdName.VisibleIndex = 3;
            this.colProdName.Width = 107;
            // 
            // colProdCode
            // 
            this.colProdCode.Caption = "รหัสสินค้า";
            this.colProdCode.FieldName = "ProductCode";
            this.colProdCode.Name = "colProdCode";
            this.colProdCode.Width = 89;
            // 
            // colProdID
            // 
            this.colProdID.Caption = "ProductID";
            this.colProdID.FieldName = "ProductID";
            this.colProdID.Name = "colProdID";
            // 
            // colCarLicense
            // 
            this.colCarLicense.Caption = "ทะเบียนรถ";
            this.colCarLicense.FieldName = "CarLicense";
            this.colCarLicense.Name = "colCarLicense";
            this.colCarLicense.Width = 103;
            // 
            // colJobName
            // 
            this.colJobName.Caption = "ชื่องาน";
            this.colJobName.FieldName = "JobName";
            this.colJobName.Name = "colJobName";
            this.colJobName.OptionsColumn.ReadOnly = true;
            this.colJobName.Visible = true;
            this.colJobName.VisibleIndex = 2;
            this.colJobName.Width = 117;
            // 
            // colJodID
            // 
            this.colJodID.Caption = "JobID";
            this.colJodID.FieldName = "JobID";
            this.colJodID.Name = "colJodID";
            // 
            // colDebitorPeriodCode
            // 
            this.colDebitorPeriodCode.Caption = "ช่วงเวลาการเบิกลูกหนี้";
            this.colDebitorPeriodCode.FieldName = "DebitorPeriodCode";
            this.colDebitorPeriodCode.Name = "colDebitorPeriodCode";
            this.colDebitorPeriodCode.OptionsColumn.ReadOnly = true;
            this.colDebitorPeriodCode.Visible = true;
            this.colDebitorPeriodCode.VisibleIndex = 0;
            this.colDebitorPeriodCode.Width = 138;
            // 
            // colDebitorPeriodID
            // 
            this.colDebitorPeriodID.Caption = "รหัสช่วงเวลาการเบิกลูกหนี้";
            this.colDebitorPeriodID.FieldName = "DebitorPeriodID";
            this.colDebitorPeriodID.Name = "colDebitorPeriodID";
            this.colDebitorPeriodID.Width = 122;
            // 
            // colID
            // 
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colID.Caption = "ID";
            this.colID.FieldName = "DetailID";
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
            this.colDebitorPeriodID,
            this.colDebitorPeriodCode,
            this.colJodID,
            this.colJobName,
            this.colCarLicense,
            this.colDriver,
            this.colProdID,
            this.colProdCode,
            this.colProdName,
            this.colTranWeight,
            this.colUnitPrice,
            this.colTotalAmount,
            this.colbCount,
            this.colVat,
            this.colNet,
            this.colDebitorName,
            this.colTranUnit});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsMenu.EnableFooterMenu = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowFooter = true;
            // 
            // colDriver
            // 
            this.colDriver.Caption = "พนักงานขับรถ";
            this.colDriver.FieldName = "Driver";
            this.colDriver.Name = "colDriver";
            this.colDriver.Width = 119;
            // 
            // colbCount
            // 
            this.colbCount.Caption = "จำนวนบิล";
            this.colbCount.DisplayFormat.FormatString = "#,0";
            this.colbCount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colbCount.FieldName = "bCount";
            this.colbCount.Name = "colbCount";
            this.colbCount.OptionsColumn.ReadOnly = true;
            this.colbCount.Visible = true;
            this.colbCount.VisibleIndex = 7;
            this.colbCount.Width = 108;
            // 
            // colVat
            // 
            this.colVat.Caption = "ภาษี";
            this.colVat.DisplayFormat.FormatString = "#,0.00";
            this.colVat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVat.FieldName = "TranVat";
            this.colVat.Name = "colVat";
            this.colVat.OptionsColumn.ReadOnly = true;
            this.colVat.Visible = true;
            this.colVat.VisibleIndex = 9;
            this.colVat.Width = 97;
            // 
            // colNet
            // 
            this.colNet.Caption = "รวมสุทธิ";
            this.colNet.DisplayFormat.FormatString = "#,0.00";
            this.colNet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNet.FieldName = "NetAmount";
            this.colNet.Name = "colNet";
            this.colNet.OptionsColumn.ReadOnly = true;
            this.colNet.Visible = true;
            this.colNet.VisibleIndex = 10;
            this.colNet.Width = 146;
            // 
            // colDebitorName
            // 
            this.colDebitorName.Caption = "ลูกหนี้";
            this.colDebitorName.FieldName = "DebitorName";
            this.colDebitorName.Name = "colDebitorName";
            this.colDebitorName.OptionsColumn.ReadOnly = true;
            this.colDebitorName.Visible = true;
            this.colDebitorName.VisibleIndex = 1;
            this.colDebitorName.Width = 147;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 120);
            this.gridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnDelete,
            this.CheckEditPaid});
            this.gridControl.Size = new System.Drawing.Size(1129, 365);
            this.gridControl.TabIndex = 18;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FloralWhite;
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1129, 36);
            this.panelSearch.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "เอกสารวางบิลแจ้งหนี้";
            // 
            // colTranUnit
            // 
            this.colTranUnit.Caption = "หน่วย";
            this.colTranUnit.FieldName = "TranUnit";
            this.colTranUnit.Name = "colTranUnit";
            this.colTranUnit.OptionsColumn.ReadOnly = true;
            this.colTranUnit.Visible = true;
            this.colTranUnit.VisibleIndex = 5;
            this.colTranUnit.Width = 47;
            // 
            // frmLetterCond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1129, 485);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLetterCond";
            this.Text = "เอกสารวางบิลแจ้งหนี้";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLetterCond_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEditPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbDebitorPeriod;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CheckEditPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTranWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colProdName;
        private DevExpress.XtraGrid.Columns.GridColumn colProdCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProdID;
        private DevExpress.XtraGrid.Columns.GridColumn colCarLicense;
        private DevExpress.XtraGrid.Columns.GridColumn colJobName;
        private DevExpress.XtraGrid.Columns.GridColumn colJodID;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionSeq;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionCreditorCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBillingPeriodCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBillingPeriodID;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDriver;
        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitorPeriodCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitorPeriodID;
        private DevExpress.XtraGrid.Columns.GridColumn colbCount;
        private DevExpress.XtraEditors.SimpleButton btnBillDetail;
        private DevExpress.XtraEditors.SimpleButton btnEachDay;
        private DevExpress.XtraGrid.Columns.GridColumn colVat;
        private DevExpress.XtraGrid.Columns.GridColumn colNet;
        private System.Windows.Forms.ComboBox cbJob;
        private System.Windows.Forms.ComboBox cbDebitor;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitorName;
        private DevExpress.XtraGrid.Columns.GridColumn colTranUnit;
    }
}