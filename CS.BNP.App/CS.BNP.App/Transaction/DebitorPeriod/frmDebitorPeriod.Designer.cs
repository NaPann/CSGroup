namespace CS.BNP.App.Transaction.DebitorPeriod
{
    partial class frmDebitorPeriod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDebitorPeriod));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebitorBillingStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebitorDateTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebitorDateFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebitorPeriodCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCountBilling = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.colDetailID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            this.panelSearch.SuspendLayout();
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
            this.gridDelete.VisibleIndex = 7;
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
            this.gridEdit.VisibleIndex = 6;
            // 
            // colDebitorBillingStatus
            // 
            this.colDebitorBillingStatus.Caption = "สถานะ";
            this.colDebitorBillingStatus.FieldName = "DebitorBillingStatus";
            this.colDebitorBillingStatus.Name = "colDebitorBillingStatus";
            this.colDebitorBillingStatus.OptionsColumn.ReadOnly = true;
            this.colDebitorBillingStatus.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colDebitorBillingStatus.Visible = true;
            this.colDebitorBillingStatus.VisibleIndex = 4;
            this.colDebitorBillingStatus.Width = 81;
            // 
            // colDebitorDateTo
            // 
            this.colDebitorDateTo.Caption = "วันที่สิ้นสุด";
            this.colDebitorDateTo.DisplayFormat.FormatString = "d";
            this.colDebitorDateTo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDebitorDateTo.FieldName = "DebitorDateTo";
            this.colDebitorDateTo.Name = "colDebitorDateTo";
            this.colDebitorDateTo.OptionsColumn.ReadOnly = true;
            this.colDebitorDateTo.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.colDebitorDateTo.Visible = true;
            this.colDebitorDateTo.VisibleIndex = 3;
            this.colDebitorDateTo.Width = 136;
            // 
            // colDebitorDateFrom
            // 
            this.colDebitorDateFrom.Caption = "วันที่เริ่มต้น";
            this.colDebitorDateFrom.DisplayFormat.FormatString = "d";
            this.colDebitorDateFrom.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDebitorDateFrom.FieldName = "DebitorDateFrom";
            this.colDebitorDateFrom.Name = "colDebitorDateFrom";
            this.colDebitorDateFrom.OptionsColumn.ReadOnly = true;
            this.colDebitorDateFrom.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colDebitorDateFrom.Visible = true;
            this.colDebitorDateFrom.VisibleIndex = 2;
            this.colDebitorDateFrom.Width = 137;
            // 
            // colDebitorPeriodCode
            // 
            this.colDebitorPeriodCode.Caption = "ช่วงเวลาการเบิกลูกหนี้";
            this.colDebitorPeriodCode.FieldName = "DebitorPeriodCode";
            this.colDebitorPeriodCode.Name = "colDebitorPeriodCode";
            this.colDebitorPeriodCode.Visible = true;
            this.colDebitorPeriodCode.VisibleIndex = 1;
            this.colDebitorPeriodCode.Width = 154;
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
            this.colDebitorPeriodCode,
            this.colDebitorDateFrom,
            this.colDebitorDateTo,
            this.colDebitorBillingStatus,
            this.colCountBilling,
            this.gridEdit,
            this.gridDelete});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView_ShowingEditor);
            // 
            // colCountBilling
            // 
            this.colCountBilling.Caption = "จำนวนช่วงเวลาเบิกจ่าย";
            this.colCountBilling.FieldName = "CountBilling";
            this.colCountBilling.Name = "colCountBilling";
            this.colCountBilling.Visible = true;
            this.colCountBilling.VisibleIndex = 5;
            this.colCountBilling.Width = 119;
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
            this.gridControl.TabIndex = 12;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
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
            this.label1.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ตั้งค่าช่วงเวลาการเบิกลูกหนี้";
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
            this.panelSearch.TabIndex = 13;
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
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // frmDebitorPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panelSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDebitorPeriod";
            this.Text = "ตั้งค่าช่วงเวลาเบิกลูกหนี้";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDebitorPeriod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn gridDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitorBillingStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitorDateTo;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitorDateFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitorPeriodCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSearch;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailID;
        private DevExpress.XtraGrid.Columns.GridColumn colJobID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraGrid.Columns.GridColumn colCountBilling;
    }
}