namespace CS.BNP.App.SystemSetup.Job
{
    partial class frmAddEditJobCreditor
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditJobCreditor));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.btnEditDetail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnDeleteDetail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.lblProdID = new System.Windows.Forms.Label();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductSellPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSourceFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtSourceFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCreditor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numProductSell = new System.Windows.Forms.NumericUpDown();
            this.lblCreditorID = new System.Windows.Forms.Label();
            this.lblDetailID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDebitor = new System.Windows.Forms.TextBox();
            this.txtJobCode = new System.Windows.Forms.TextBox();
            this.lblEmpFirstName = new System.Windows.Forms.Label();
            this.lblEmpCode = new System.Windows.Forms.Label();
            this.txtJobName = new System.Windows.Forms.TextBox();
            this.lblEmpLastName = new System.Windows.Forms.Label();
            this.panelWarning = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProductSell)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelWarning.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditDetail
            // 
            this.btnEditDetail.Appearance.Options.UseTextOptions = true;
            this.btnEditDetail.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnEditDetail.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnEditDetail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions3, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnEditDetail.Name = "btnEditDetail";
            this.btnEditDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEditDetail.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditDetail_ButtonClick);
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.Appearance.Options.UseTextOptions = true;
            this.btnDeleteDetail.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnDeleteDetail.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.btnDeleteDetail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions4, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDeleteDetail.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDeleteDetail_ButtonClick);
            // 
            // lblProdID
            // 
            this.lblProdID.AutoSize = true;
            this.lblProdID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblProdID.Location = new System.Drawing.Point(168, 11);
            this.lblProdID.Name = "lblProdID";
            this.lblProdID.Size = new System.Drawing.Size(0, 14);
            this.lblProdID.TabIndex = 77;
            this.lblProdID.Visible = false;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(216, 97);
            this.gridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditDetail,
            this.btnDeleteDetail});
            this.gridControl.Size = new System.Drawing.Size(718, 254);
            this.gridControl.TabIndex = 73;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colJobID,
            this.colCreditorID,
            this.colNo,
            this.colCreditorName,
            this.colProductID,
            this.colProductName,
            this.colProductSellPrice,
            this.colSourceFrom,
            this.gridEdit,
            this.gridDelete});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
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
            // colJobID
            // 
            this.colJobID.Caption = "JobID";
            this.colJobID.FieldName = "JobID";
            this.colJobID.Name = "colJobID";
            // 
            // colCreditorID
            // 
            this.colCreditorID.Caption = "CreditorID";
            this.colCreditorID.FieldName = "CreditorID";
            this.colCreditorID.Name = "colCreditorID";
            // 
            // colNo
            // 
            this.colNo.Caption = "ที่";
            this.colNo.FieldName = "iNo";
            this.colNo.Name = "colNo";
            this.colNo.OptionsColumn.ReadOnly = true;
            this.colNo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            this.colNo.Width = 26;
            // 
            // colCreditorName
            // 
            this.colCreditorName.Caption = "เจ้าหนี้";
            this.colCreditorName.FieldName = "CreditorName";
            this.colCreditorName.Name = "colCreditorName";
            this.colCreditorName.OptionsColumn.ReadOnly = true;
            this.colCreditorName.Visible = true;
            this.colCreditorName.VisibleIndex = 1;
            this.colCreditorName.Width = 141;
            // 
            // colProductID
            // 
            this.colProductID.Caption = "ProductID";
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "ชื่อสินค้า";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.ReadOnly = true;
            this.colProductName.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 2;
            this.colProductName.Width = 145;
            // 
            // colProductSellPrice
            // 
            this.colProductSellPrice.Caption = "ราคาซื้อ";
            this.colProductSellPrice.DisplayFormat.FormatString = "N2";
            this.colProductSellPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colProductSellPrice.FieldName = "ProductSellPrice";
            this.colProductSellPrice.Name = "colProductSellPrice";
            this.colProductSellPrice.OptionsColumn.ReadOnly = true;
            this.colProductSellPrice.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colProductSellPrice.Visible = true;
            this.colProductSellPrice.VisibleIndex = 3;
            this.colProductSellPrice.Width = 110;
            // 
            // colSourceFrom
            // 
            this.colSourceFrom.Caption = "แหล่งวัสดุ";
            this.colSourceFrom.FieldName = "SourceFrom";
            this.colSourceFrom.Name = "colSourceFrom";
            this.colSourceFrom.Visible = true;
            this.colSourceFrom.VisibleIndex = 4;
            this.colSourceFrom.Width = 101;
            // 
            // gridEdit
            // 
            this.gridEdit.Caption = "Edit";
            this.gridEdit.ColumnEdit = this.btnEditDetail;
            this.gridEdit.Name = "gridEdit";
            this.gridEdit.OptionsColumn.ReadOnly = true;
            this.gridEdit.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridEdit.Visible = true;
            this.gridEdit.VisibleIndex = 5;
            // 
            // gridDelete
            // 
            this.gridDelete.Caption = "Delete";
            this.gridDelete.ColumnEdit = this.btnDeleteDetail;
            this.gridDelete.Name = "gridDelete";
            this.gridDelete.OptionsColumn.ReadOnly = true;
            this.gridDelete.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridDelete.Visible = true;
            this.gridDelete.VisibleIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.txtSourceFrom);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cbCreditor);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.numProductSell);
            this.panel4.Controls.Add(this.lblProdID);
            this.panel4.Controls.Add(this.lblCreditorID);
            this.panel4.Controls.Add(this.lblDetailID);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cbProduct);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(216, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(718, 67);
            this.panel4.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(465, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 64;
            this.label6.Text = "แหล่งวัสดุ";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.ImageIndex = 5;
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.btnAdd.Location = new System.Drawing.Point(622, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 41);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "เพิ่ม";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSourceFrom
            // 
            this.txtSourceFrom.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSourceFrom.Location = new System.Drawing.Point(468, 28);
            this.txtSourceFrom.MaxLength = 10000;
            this.txtSourceFrom.Name = "txtSourceFrom";
            this.txtSourceFrom.Size = new System.Drawing.Size(148, 24);
            this.txtSourceFrom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(18, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 14);
            this.label3.TabIndex = 81;
            this.label3.Visible = false;
            // 
            // cbCreditor
            // 
            this.cbCreditor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCreditor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCreditor.DropDownWidth = 250;
            this.cbCreditor.FormattingEnabled = true;
            this.cbCreditor.Location = new System.Drawing.Point(10, 30);
            this.cbCreditor.Name = "cbCreditor";
            this.cbCreditor.Size = new System.Drawing.Size(158, 22);
            this.cbCreditor.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(7, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 14);
            this.label5.TabIndex = 80;
            this.label5.Text = "เจ้าหนี้";
            // 
            // numProductSell
            // 
            this.numProductSell.DecimalPlaces = 2;
            this.numProductSell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.numProductSell.Location = new System.Drawing.Point(356, 28);
            this.numProductSell.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numProductSell.Name = "numProductSell";
            this.numProductSell.Size = new System.Drawing.Size(101, 24);
            this.numProductSell.TabIndex = 2;
            // 
            // lblCreditorID
            // 
            this.lblCreditorID.AutoSize = true;
            this.lblCreditorID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCreditorID.Location = new System.Drawing.Point(299, 26);
            this.lblCreditorID.Name = "lblCreditorID";
            this.lblCreditorID.Size = new System.Drawing.Size(0, 14);
            this.lblCreditorID.TabIndex = 83;
            this.lblCreditorID.Visible = false;
            // 
            // lblDetailID
            // 
            this.lblDetailID.AutoSize = true;
            this.lblDetailID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDetailID.Location = new System.Drawing.Point(83, 11);
            this.lblDetailID.Name = "lblDetailID";
            this.lblDetailID.Size = new System.Drawing.Size(0, 14);
            this.lblDetailID.TabIndex = 76;
            this.lblDetailID.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(353, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 75;
            this.label4.Text = "ราคาซื้อ";
            // 
            // cbProduct
            // 
            this.cbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(181, 30);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(163, 22);
            this.cbProduct.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(178, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 71;
            this.label2.Text = "สินค้า/วัสดุ ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.txtDebitor);
            this.panel3.Controls.Add(this.txtJobCode);
            this.panel3.Controls.Add(this.lblEmpFirstName);
            this.panel3.Controls.Add(this.lblEmpCode);
            this.panel3.Controls.Add(this.txtJobName);
            this.panel3.Controls.Add(this.lblEmpLastName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 321);
            this.panel3.TabIndex = 77;
            // 
            // txtDebitor
            // 
            this.txtDebitor.Enabled = false;
            this.txtDebitor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDebitor.Location = new System.Drawing.Point(15, 140);
            this.txtDebitor.MaxLength = 10000;
            this.txtDebitor.Multiline = true;
            this.txtDebitor.Name = "txtDebitor";
            this.txtDebitor.Size = new System.Drawing.Size(178, 77);
            this.txtDebitor.TabIndex = 2;
            // 
            // txtJobCode
            // 
            this.txtJobCode.Enabled = false;
            this.txtJobCode.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtJobCode.Location = new System.Drawing.Point(15, 28);
            this.txtJobCode.MaxLength = 10000;
            this.txtJobCode.Name = "txtJobCode";
            this.txtJobCode.Size = new System.Drawing.Size(178, 24);
            this.txtJobCode.TabIndex = 0;
            // 
            // lblEmpFirstName
            // 
            this.lblEmpFirstName.AutoSize = true;
            this.lblEmpFirstName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblEmpFirstName.Location = new System.Drawing.Point(12, 67);
            this.lblEmpFirstName.Name = "lblEmpFirstName";
            this.lblEmpFirstName.Size = new System.Drawing.Size(64, 14);
            this.lblEmpFirstName.TabIndex = 61;
            this.lblEmpFirstName.Text = "ชื่อโครงการ";
            // 
            // lblEmpCode
            // 
            this.lblEmpCode.AutoSize = true;
            this.lblEmpCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblEmpCode.Location = new System.Drawing.Point(12, 12);
            this.lblEmpCode.Name = "lblEmpCode";
            this.lblEmpCode.Size = new System.Drawing.Size(69, 14);
            this.lblEmpCode.TabIndex = 58;
            this.lblEmpCode.Text = "รหัสโครงการ";
            // 
            // txtJobName
            // 
            this.txtJobName.Enabled = false;
            this.txtJobName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtJobName.Location = new System.Drawing.Point(15, 84);
            this.txtJobName.MaxLength = 10000;
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.Size = new System.Drawing.Size(178, 24);
            this.txtJobName.TabIndex = 1;
            // 
            // lblEmpLastName
            // 
            this.lblEmpLastName.AutoSize = true;
            this.lblEmpLastName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblEmpLastName.Location = new System.Drawing.Point(12, 123);
            this.lblEmpLastName.Name = "lblEmpLastName";
            this.lblEmpLastName.Size = new System.Drawing.Size(36, 14);
            this.lblEmpLastName.TabIndex = 62;
            this.lblEmpLastName.Text = "ลูกหนี้";
            // 
            // panelWarning
            // 
            this.panelWarning.BackColor = System.Drawing.Color.LightCoral;
            this.panelWarning.Controls.Add(this.label1);
            this.panelWarning.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelWarning.Location = new System.Drawing.Point(0, 351);
            this.panelWarning.Name = "panelWarning";
            this.panelWarning.Size = new System.Drawing.Size(934, 35);
            this.panelWarning.TabIndex = 76;
            this.panelWarning.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(376, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "กรุณากรอกข้อมูลให้ครบถ้วน !!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.btnSaveExit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 40);
            this.panel2.TabIndex = 75;
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSaveExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveExit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSaveExit.ForeColor = System.Drawing.Color.White;
            this.btnSaveExit.Location = new System.Drawing.Point(727, 6);
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(121, 25);
            this.btnSaveExit.TabIndex = 1;
            this.btnSaveExit.Text = "บันทึกและออก";
            this.btnSaveExit.UseVisualStyleBackColor = false;
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(600, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "บันทึกข้อมูล";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(855, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "ออก";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 30);
            this.panel1.TabIndex = 74;
            // 
            // frmAddEditJobCreditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 426);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelWarning);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(950, 465);
            this.MinimumSize = new System.Drawing.Size(950, 465);
            this.Name = "frmAddEditJobCreditor";
            this.Text = "เพิ่มแก้ไขข้อมูลราคาซื้อ";
            this.Load += new System.EventHandler(this.frmAddEditJobCreditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnEditDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProductSell)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelWarning.ResumeLayout(false);
            this.panelWarning.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblProdID;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteDetail;
        private DevExpress.XtraGrid.GridControl gridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colJobID;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductSellPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridDelete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDetailID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtJobCode;
        private System.Windows.Forms.Label lblEmpFirstName;
        private System.Windows.Forms.Label lblEmpCode;
        private System.Windows.Forms.TextBox txtJobName;
        private System.Windows.Forms.Label lblEmpLastName;
        private System.Windows.Forms.Panel panelWarning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSaveExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numProductSell;
        private System.Windows.Forms.TextBox txtDebitor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCreditor;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditorID;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditorName;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label lblCreditorID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSourceFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colSourceFrom;
    }
}