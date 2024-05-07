namespace CS.BNP.App.Reports.Mills
{
    partial class frmMillConsolidate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMillConsolidate));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMillName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMillCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMillID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebitorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpMonthTo = new System.Windows.Forms.DateTimePicker();
            this.dtpMonthFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJobCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuyPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMillPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuyVat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellVat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceVat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
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
            // colProductName
            // 
            this.colProductName.Caption = "สินค้า";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.ReadOnly = true;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 3;
            this.colProductName.Width = 121;
            // 
            // colProductID
            // 
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.OptionsColumn.ReadOnly = true;
            // 
            // colMillName
            // 
            this.colMillName.Caption = "ผู้ขนส่ง";
            this.colMillName.FieldName = "CreditorServiceName";
            this.colMillName.Name = "colMillName";
            this.colMillName.OptionsColumn.ReadOnly = true;
            this.colMillName.Visible = true;
            this.colMillName.VisibleIndex = 9;
            this.colMillName.Width = 151;
            // 
            // colMillCode
            // 
            this.colMillCode.FieldName = "CreditorServiceCode";
            this.colMillCode.Name = "colMillCode";
            // 
            // colMillID
            // 
            this.colMillID.FieldName = "CreditorServiceID";
            this.colMillID.Name = "colMillID";
            // 
            // colDebitorName
            // 
            this.colDebitorName.Caption = "ลูกหนี้";
            this.colDebitorName.FieldName = "DebitorName";
            this.colDebitorName.Name = "colDebitorName";
            this.colDebitorName.OptionsColumn.ReadOnly = true;
            this.colDebitorName.Visible = true;
            this.colDebitorName.VisibleIndex = 1;
            this.colDebitorName.Width = 211;
            // 
            // colNo
            // 
            this.colNo.Caption = "ที่";
            this.colNo.FieldName = "iNo";
            this.colNo.Name = "colNo";
            this.colNo.OptionsColumn.ReadOnly = true;
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            this.colNo.Width = 42;
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
            this.btnExport.Location = new System.Drawing.Point(917, 8);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(126, 29);
            this.btnExport.TabIndex = 24;
            this.btnExport.Text = "Excel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLoad.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoad.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Appearance.Options.UseBackColor = true;
            this.btnLoad.Appearance.Options.UseBorderColor = true;
            this.btnLoad.Appearance.Options.UseFont = true;
            this.btnLoad.Appearance.Options.UseForeColor = true;
            this.btnLoad.AppearanceHovered.BackColor = System.Drawing.Color.Silver;
            this.btnLoad.AppearanceHovered.Options.UseBackColor = true;
            this.btnLoad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLoad.Location = new System.Drawing.Point(679, 8);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(103, 29);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "เรียกดูข้อมูล";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(239, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "จากเดือนปี";
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
            this.btnExit.AppearanceHovered.BackColor = System.Drawing.Color.Silver;
            this.btnExit.AppearanceHovered.Options.UseBackColor = true;
            this.btnExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExit.Location = new System.Drawing.Point(1049, 8);
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
            this.btnReport.AppearanceHovered.BackColor = System.Drawing.Color.Silver;
            this.btnReport.AppearanceHovered.Options.UseBackColor = true;
            this.btnReport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.ImageOptions.Image")));
            this.btnReport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReport.Location = new System.Drawing.Point(788, 8);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(123, 29);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "รายงาน";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cbJob
            // 
            this.cbJob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbJob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbJob.DropDownHeight = 250;
            this.cbJob.DropDownWidth = 500;
            this.cbJob.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbJob.FormattingEnabled = true;
            this.cbJob.IntegralHeight = false;
            this.cbJob.Location = new System.Drawing.Point(91, 11);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(131, 22);
            this.cbJob.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "เลือกโครงการ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dtpMonthTo);
            this.panel1.Controls.Add(this.dtpMonthFrom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.cbJob);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 47);
            this.panel1.TabIndex = 26;
            // 
            // dtpMonthTo
            // 
            this.dtpMonthTo.Checked = false;
            this.dtpMonthTo.CustomFormat = "MM/yyyy";
            this.dtpMonthTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonthTo.Location = new System.Drawing.Point(517, 11);
            this.dtpMonthTo.Name = "dtpMonthTo";
            this.dtpMonthTo.ShowCheckBox = true;
            this.dtpMonthTo.Size = new System.Drawing.Size(144, 22);
            this.dtpMonthTo.TabIndex = 27;
            // 
            // dtpMonthFrom
            // 
            this.dtpMonthFrom.Checked = false;
            this.dtpMonthFrom.CustomFormat = "MM/yyyy";
            this.dtpMonthFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonthFrom.Location = new System.Drawing.Point(305, 11);
            this.dtpMonthFrom.Name = "dtpMonthFrom";
            this.dtpMonthFrom.ShowCheckBox = true;
            this.dtpMonthFrom.Size = new System.Drawing.Size(144, 22);
            this.dtpMonthFrom.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(458, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 14);
            this.label4.TabIndex = 25;
            this.label4.Text = "ถึงเดือนปี";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "รายงานราคาซื้อและราคาขาย";
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1202, 39);
            this.panelSearch.TabIndex = 25;
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colNo,
            this.colDebitorName,
            this.colJobCode,
            this.colJobName,
            this.colProductID,
            this.colProductName,
            this.colBuyPrice,
            this.colSellPrice,
            this.colCreditorID,
            this.colCreditorName,
            this.colMillID,
            this.colMillCode,
            this.colMillName,
            this.colMillPrice,
            this.colBuyVat,
            this.colSellVat,
            this.colServiceVat});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsMenu.EnableFooterMenu = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowFooter = true;
            // 
            // colJobCode
            // 
            this.colJobCode.Caption = "JobCode";
            this.colJobCode.FieldName = "JobCode";
            this.colJobCode.Name = "colJobCode";
            // 
            // colJobName
            // 
            this.colJobName.Caption = "หน่วยงาน";
            this.colJobName.FieldName = "JobName";
            this.colJobName.Name = "colJobName";
            this.colJobName.OptionsColumn.ReadOnly = true;
            this.colJobName.Visible = true;
            this.colJobName.VisibleIndex = 2;
            this.colJobName.Width = 120;
            // 
            // colBuyPrice
            // 
            this.colBuyPrice.Caption = "ราคาขาย";
            this.colBuyPrice.FieldName = "ProductBuyPrice";
            this.colBuyPrice.Name = "colBuyPrice";
            this.colBuyPrice.OptionsColumn.ReadOnly = true;
            this.colBuyPrice.Visible = true;
            this.colBuyPrice.VisibleIndex = 4;
            this.colBuyPrice.Width = 117;
            // 
            // colSellPrice
            // 
            this.colSellPrice.Caption = "ราคาซื้อรวม";
            this.colSellPrice.FieldName = "ProductSellPrice";
            this.colSellPrice.Name = "colSellPrice";
            this.colSellPrice.OptionsColumn.ReadOnly = true;
            this.colSellPrice.Visible = true;
            this.colSellPrice.VisibleIndex = 6;
            this.colSellPrice.Width = 122;
            // 
            // colCreditorID
            // 
            this.colCreditorID.Caption = "CreditorID";
            this.colCreditorID.FieldName = "CreditorID";
            this.colCreditorID.Name = "colCreditorID";
            // 
            // colCreditorName
            // 
            this.colCreditorName.Caption = "เจ้าหนี้ / โรงโม่";
            this.colCreditorName.FieldName = "CreditorName";
            this.colCreditorName.Name = "colCreditorName";
            this.colCreditorName.OptionsColumn.ReadOnly = true;
            this.colCreditorName.Visible = true;
            this.colCreditorName.VisibleIndex = 8;
            this.colCreditorName.Width = 155;
            // 
            // colMillPrice
            // 
            this.colMillPrice.Caption = "ราคาขนส่ง";
            this.colMillPrice.DisplayFormat.FormatString = "#,0.00";
            this.colMillPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMillPrice.FieldName = "ProductServicePrice";
            this.colMillPrice.Name = "colMillPrice";
            this.colMillPrice.OptionsColumn.ReadOnly = true;
            this.colMillPrice.Visible = true;
            this.colMillPrice.VisibleIndex = 10;
            this.colMillPrice.Width = 114;
            // 
            // colBuyVat
            // 
            this.colBuyVat.Caption = "ภาษี";
            this.colBuyVat.FieldName = "BuyVat";
            this.colBuyVat.Name = "colBuyVat";
            this.colBuyVat.Visible = true;
            this.colBuyVat.VisibleIndex = 7;
            this.colBuyVat.Width = 50;
            // 
            // colSellVat
            // 
            this.colSellVat.Caption = "ภาษี";
            this.colSellVat.FieldName = "SellVat";
            this.colSellVat.Name = "colSellVat";
            this.colSellVat.Visible = true;
            this.colSellVat.VisibleIndex = 5;
            this.colSellVat.Width = 60;
            // 
            // colServiceVat
            // 
            this.colServiceVat.Caption = "ภาษีค่าขน";
            this.colServiceVat.FieldName = "VatInt";
            this.colServiceVat.Name = "colServiceVat";
            this.colServiceVat.Visible = true;
            this.colServiceVat.VisibleIndex = 11;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 86);
            this.gridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnDelete,
            this.repositoryItemCheckEdit1});
            this.gridControl.Size = new System.Drawing.Size(1202, 399);
            this.gridControl.TabIndex = 27;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // frmMillConsolidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 485);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMillConsolidate";
            this.Text = "รายงานเปรียบเทียบเจ้าหนี้และโรงโม่";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMillConsolidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colMillName;
        private DevExpress.XtraGrid.Columns.GridColumn colMillCode;
        private DevExpress.XtraGrid.Columns.GridColumn colMillID;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitorName;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private System.Windows.Forms.ComboBox cbJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Columns.GridColumn colJobCode;
        private DevExpress.XtraGrid.Columns.GridColumn colJobName;
        private DevExpress.XtraGrid.Columns.GridColumn colBuyPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSellPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditorID;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditorName;
        private DevExpress.XtraGrid.Columns.GridColumn colMillPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpMonthTo;
        private System.Windows.Forms.DateTimePicker dtpMonthFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colBuyVat;
        private DevExpress.XtraGrid.Columns.GridColumn colSellVat;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceVat;
    }
}