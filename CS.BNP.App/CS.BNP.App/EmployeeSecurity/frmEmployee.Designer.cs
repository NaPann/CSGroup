namespace CS.BNP.App.EmployeeSecurity
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridEmployeeSecurity = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSecurity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSystemSetup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsTransaction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsReport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colNeedToApprove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproveBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployeeSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
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
            this.panelSearch.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "พนักงานและผู้ใช้ระบบ";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 40);
            this.gridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.gridControl.MainView = this.gridEmployeeSecurity;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnDelete});
            this.gridControl.Size = new System.Drawing.Size(933, 445);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridEmployeeSecurity});
            // 
            // gridEmployeeSecurity
            // 
            this.gridEmployeeSecurity.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.gridEmployeeSecurity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colEmployeeCode,
            this.colEmployeeFirstName,
            this.colEmployeeLastName,
            this.colUsername,
            this.colIsSecurity,
            this.colIsSystemSetup,
            this.colIsTransaction,
            this.colIsReport,
            this.colIsAdmin,
            this.colNeedToApprove,
            this.colApproveBy,
            this.gridEdit,
            this.gridDelete});
            this.gridEmployeeSecurity.GridControl = this.gridControl;
            this.gridEmployeeSecurity.Name = "gridEmployeeSecurity";
            this.gridEmployeeSecurity.OptionsFind.AlwaysVisible = true;
            this.gridEmployeeSecurity.OptionsView.ColumnAutoWidth = false;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colID.Width = 20;
            // 
            // colEmployeeCode
            // 
            this.colEmployeeCode.Caption = "รหัสพนักงาน";
            this.colEmployeeCode.FieldName = "EmployeeCode";
            this.colEmployeeCode.Name = "colEmployeeCode";
            this.colEmployeeCode.OptionsColumn.ReadOnly = true;
            this.colEmployeeCode.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colEmployeeCode.Visible = true;
            this.colEmployeeCode.VisibleIndex = 0;
            this.colEmployeeCode.Width = 94;
            // 
            // colEmployeeFirstName
            // 
            this.colEmployeeFirstName.Caption = "ชื่อพนักงาน";
            this.colEmployeeFirstName.FieldName = "EmployeeFirstName";
            this.colEmployeeFirstName.Name = "colEmployeeFirstName";
            this.colEmployeeFirstName.OptionsColumn.ReadOnly = true;
            this.colEmployeeFirstName.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colEmployeeFirstName.Visible = true;
            this.colEmployeeFirstName.VisibleIndex = 1;
            this.colEmployeeFirstName.Width = 113;
            // 
            // colEmployeeLastName
            // 
            this.colEmployeeLastName.Caption = "นามสกุลพนักงาน";
            this.colEmployeeLastName.FieldName = "EmployeeLastName";
            this.colEmployeeLastName.Name = "colEmployeeLastName";
            this.colEmployeeLastName.OptionsColumn.ReadOnly = true;
            this.colEmployeeLastName.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colEmployeeLastName.Visible = true;
            this.colEmployeeLastName.VisibleIndex = 2;
            this.colEmployeeLastName.Width = 136;
            // 
            // colUsername
            // 
            this.colUsername.Caption = "รหัสผู้ใช้งาน";
            this.colUsername.FieldName = "Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.OptionsColumn.ReadOnly = true;
            this.colUsername.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 3;
            this.colUsername.Width = 120;
            // 
            // colIsSecurity
            // 
            this.colIsSecurity.Caption = "สิทธิ์ความปลอดภัย";
            this.colIsSecurity.FieldName = "IsSecurity";
            this.colIsSecurity.Name = "colIsSecurity";
            this.colIsSecurity.OptionsColumn.ReadOnly = true;
            this.colIsSecurity.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colIsSecurity.Visible = true;
            this.colIsSecurity.VisibleIndex = 4;
            this.colIsSecurity.Width = 114;
            // 
            // colIsSystemSetup
            // 
            this.colIsSystemSetup.Caption = "สิทธิ์การตั้งค่าระบบ";
            this.colIsSystemSetup.FieldName = "IsSystemSetup";
            this.colIsSystemSetup.Name = "colIsSystemSetup";
            this.colIsSystemSetup.OptionsColumn.ReadOnly = true;
            this.colIsSystemSetup.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colIsSystemSetup.Visible = true;
            this.colIsSystemSetup.VisibleIndex = 5;
            this.colIsSystemSetup.Width = 114;
            // 
            // colIsTransaction
            // 
            this.colIsTransaction.Caption = "การจัดการระบบ";
            this.colIsTransaction.FieldName = "IsTransaction";
            this.colIsTransaction.Name = "colIsTransaction";
            this.colIsTransaction.OptionsColumn.ReadOnly = true;
            this.colIsTransaction.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colIsTransaction.Visible = true;
            this.colIsTransaction.VisibleIndex = 6;
            this.colIsTransaction.Width = 93;
            // 
            // colIsReport
            // 
            this.colIsReport.Caption = "รายงาน";
            this.colIsReport.FieldName = "IsReport";
            this.colIsReport.Name = "colIsReport";
            this.colIsReport.OptionsColumn.ReadOnly = true;
            this.colIsReport.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colIsReport.Visible = true;
            this.colIsReport.VisibleIndex = 7;
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
            this.gridEdit.VisibleIndex = 11;
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
            this.gridDelete.VisibleIndex = 12;
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
            // colNeedToApprove
            // 
            this.colNeedToApprove.Caption = "ต้อง Approve";
            this.colNeedToApprove.FieldName = "NeedToApprove";
            this.colNeedToApprove.Name = "colNeedToApprove";
            this.colNeedToApprove.OptionsColumn.ReadOnly = true;
            this.colNeedToApprove.Visible = true;
            this.colNeedToApprove.VisibleIndex = 9;
            // 
            // colApproveBy
            // 
            this.colApproveBy.Caption = "Approve โดย";
            this.colApproveBy.FieldName = "NeedToApproveBy";
            this.colApproveBy.Name = "colApproveBy";
            this.colApproveBy.OptionsColumn.ReadOnly = true;
            this.colApproveBy.Visible = true;
            this.colApproveBy.VisibleIndex = 10;
            this.colApproveBy.Width = 89;
            // 
            // colIsAdmin
            // 
            this.colIsAdmin.Caption = "Administrator";
            this.colIsAdmin.FieldName = "IsAdmin";
            this.colIsAdmin.Name = "colIsAdmin";
            this.colIsAdmin.OptionsColumn.ReadOnly = true;
            this.colIsAdmin.Visible = true;
            this.colIsAdmin.VisibleIndex = 8;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panelSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEmployee";
            this.ShowIcon = false;
            this.Text = "Emploee & Security";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployeeSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSecurity;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSystemSetup;
        private DevExpress.XtraGrid.Columns.GridColumn colIsTransaction;
        private DevExpress.XtraGrid.Columns.GridColumn colIsReport;
        private System.Windows.Forms.Button btnAddData;
        public DevExpress.XtraGrid.Views.Grid.GridView gridEmployeeSecurity;
        private DevExpress.XtraGrid.Columns.GridColumn gridEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private System.Windows.Forms.Button btnExit;
        private DevExpress.XtraGrid.Columns.GridColumn colNeedToApprove;
        private DevExpress.XtraGrid.Columns.GridColumn colApproveBy;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAdmin;
    }
}