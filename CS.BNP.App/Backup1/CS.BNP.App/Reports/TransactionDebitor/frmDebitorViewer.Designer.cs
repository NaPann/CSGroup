namespace CS.BNP.App.Reports.TransactionDebitor
{
    partial class frmDebitorViewer
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDebitorViewer));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.cbDebitorPeriod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebitorPeriodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebitorPeriodCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionDebitorCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebitorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebitorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceived = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckEditPaid = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colCheckedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheckedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEditPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.cbDebitorPeriod);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 47);
            this.panel1.TabIndex = 19;
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
            this.btnReport.Location = new System.Drawing.Point(542, 9);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(126, 29);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "รายงาน";
            this.btnReport.Visible = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cbDebitorPeriod
            // 
            this.cbDebitorPeriod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDebitorPeriod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDebitorPeriod.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbDebitorPeriod.FormattingEnabled = true;
            this.cbDebitorPeriod.Location = new System.Drawing.Point(189, 11);
            this.cbDebitorPeriod.Name = "cbDebitorPeriod";
            this.cbDebitorPeriod.Size = new System.Drawing.Size(342, 24);
            this.cbDebitorPeriod.TabIndex = 1;
            this.cbDebitorPeriod.SelectedIndexChanged += new System.EventHandler(this.cbBillingPeriod_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "สรุปใบวางบิลลูกหนี้ (ใบชมพู)";
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(967, 36);
            this.panelSearch.TabIndex = 17;
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
            this.gridControl.Size = new System.Drawing.Size(967, 367);
            this.gridControl.TabIndex = 20;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colNo,
            this.colDebitorPeriodID,
            this.colDebitorPeriodCode,
            this.colTransactionDebitorCode,
            this.colTransactionDate,
            this.colDebitorID,
            this.colDebitorName,
            this.colTotalAmount,
            this.colReceived,
            this.colCheckedBy,
            this.colCheckedDate});
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
            this.colID.Width = 20;
            // 
            // colNo
            // 
            this.colNo.Caption = "ที่";
            this.colNo.FieldName = "iNo";
            this.colNo.Name = "colNo";
            this.colNo.OptionsColumn.ReadOnly = true;
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            this.colNo.Width = 29;
            // 
            // colDebitorPeriodID
            // 
            this.colDebitorPeriodID.Caption = "รหัสช่วงเวลาการเบิกลูกหนี้";
            this.colDebitorPeriodID.FieldName = "DebitorPeriodID";
            this.colDebitorPeriodID.Name = "colDebitorPeriodID";
            this.colDebitorPeriodID.OptionsColumn.ReadOnly = true;
            this.colDebitorPeriodID.Width = 122;
            // 
            // colDebitorPeriodCode
            // 
            this.colDebitorPeriodCode.Caption = "ช่วงเวลาการเบิกลูกหนี้";
            this.colDebitorPeriodCode.FieldName = "DebitorPeriodCode";
            this.colDebitorPeriodCode.Name = "colDebitorPeriodCode";
            this.colDebitorPeriodCode.OptionsColumn.ReadOnly = true;
            this.colDebitorPeriodCode.Visible = true;
            this.colDebitorPeriodCode.VisibleIndex = 1;
            this.colDebitorPeriodCode.Width = 130;
            // 
            // colTransactionDebitorCode
            // 
            this.colTransactionDebitorCode.AppearanceCell.BackColor = System.Drawing.Color.Bisque;
            this.colTransactionDebitorCode.AppearanceCell.Options.UseBackColor = true;
            this.colTransactionDebitorCode.Caption = "รหัสรายการบันทึกลูกหนี้";
            this.colTransactionDebitorCode.FieldName = "TransactionDebitorCode";
            this.colTransactionDebitorCode.Name = "colTransactionDebitorCode";
            this.colTransactionDebitorCode.OptionsColumn.ReadOnly = true;
            this.colTransactionDebitorCode.Visible = true;
            this.colTransactionDebitorCode.VisibleIndex = 2;
            this.colTransactionDebitorCode.Width = 133;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.Caption = "วันที่";
            this.colTransactionDate.DisplayFormat.FormatString = "d";
            this.colTransactionDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTransactionDate.FieldName = "TransactionDate";
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.OptionsColumn.ReadOnly = true;
            this.colTransactionDate.Visible = true;
            this.colTransactionDate.VisibleIndex = 3;
            this.colTransactionDate.Width = 83;
            // 
            // colDebitorID
            // 
            this.colDebitorID.Caption = "DebitorID";
            this.colDebitorID.FieldName = "DebitorID";
            this.colDebitorID.Name = "colDebitorID";
            this.colDebitorID.OptionsColumn.ReadOnly = true;
            // 
            // colDebitorName
            // 
            this.colDebitorName.Caption = "ลูกหนี้";
            this.colDebitorName.FieldName = "DebitorName";
            this.colDebitorName.Name = "colDebitorName";
            this.colDebitorName.OptionsColumn.ReadOnly = true;
            this.colDebitorName.Visible = true;
            this.colDebitorName.VisibleIndex = 4;
            this.colDebitorName.Width = 119;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.Caption = "รวมสุทธิ";
            this.colTotalAmount.DisplayFormat.FormatString = "#,0.00";
            this.colTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.OptionsColumn.ReadOnly = true;
            this.colTotalAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "รวม:{0:#,0.00}")});
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 5;
            this.colTotalAmount.Width = 99;
            // 
            // colReceived
            // 
            this.colReceived.Caption = "ได้รับเงินแล้ว";
            this.colReceived.ColumnEdit = this.CheckEditPaid;
            this.colReceived.FieldName = "IsReceived";
            this.colReceived.Name = "colReceived";
            this.colReceived.OptionsColumn.ReadOnly = true;
            this.colReceived.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colReceived.Visible = true;
            this.colReceived.VisibleIndex = 6;
            this.colReceived.Width = 92;
            // 
            // CheckEditPaid
            // 
            this.CheckEditPaid.AutoHeight = false;
            this.CheckEditPaid.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1;
            this.CheckEditPaid.Name = "CheckEditPaid";
            // 
            // colCheckedBy
            // 
            this.colCheckedBy.Caption = "ตรวจสอบโดย";
            this.colCheckedBy.FieldName = "CheckedBy";
            this.colCheckedBy.Name = "colCheckedBy";
            this.colCheckedBy.OptionsColumn.ReadOnly = true;
            this.colCheckedBy.Width = 80;
            // 
            // colCheckedDate
            // 
            this.colCheckedDate.Caption = "วันที่ตรวจสอบ";
            this.colCheckedDate.FieldName = "CheckedDate";
            this.colCheckedDate.Name = "colCheckedDate";
            this.colCheckedDate.OptionsColumn.ReadOnly = true;
            this.colCheckedDate.Width = 95;
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
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Excel";
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmDebitorViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDebitorViewer";
            this.Text = "สรุปใบวางบิลลูกหนี้";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDebitorViewer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEditPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbDebitorPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSearch;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitorPeriodID;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitorPeriodCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDebitorCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colReceived;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CheckEditPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colCheckedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCheckedDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitorID;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitorName;
        private DevExpress.XtraEditors.SimpleButton btnExport;
    }
}