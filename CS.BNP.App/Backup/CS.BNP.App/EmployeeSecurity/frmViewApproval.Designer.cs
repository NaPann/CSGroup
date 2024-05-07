namespace CS.BNP.App.EmployeeSecurity
{
    partial class frmViewApproval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewApproval));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBudget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridApprove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnApp = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApproveAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 40);
            this.gridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnApp});
            this.gridControl.Size = new System.Drawing.Size(933, 445);
            this.gridControl.TabIndex = 9;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.cardView1});
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colJobCode,
            this.colJobName,
            this.colBudget,
            this.gridApprove});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
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
            // colJobCode
            // 
            this.colJobCode.Caption = "รหัสโครงการ";
            this.colJobCode.FieldName = "JobCode";
            this.colJobCode.Name = "colJobCode";
            this.colJobCode.OptionsColumn.ReadOnly = true;
            this.colJobCode.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colJobCode.Visible = true;
            this.colJobCode.VisibleIndex = 0;
            this.colJobCode.Width = 115;
            // 
            // colJobName
            // 
            this.colJobName.Caption = "ชื่อโครงการ";
            this.colJobName.FieldName = "JobName";
            this.colJobName.Name = "colJobName";
            this.colJobName.OptionsColumn.ReadOnly = true;
            this.colJobName.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colJobName.Visible = true;
            this.colJobName.VisibleIndex = 1;
            this.colJobName.Width = 287;
            // 
            // colBudget
            // 
            this.colBudget.Caption = "งบประมาณ";
            this.colBudget.DisplayFormat.FormatString = "N2";
            this.colBudget.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBudget.FieldName = "Budget";
            this.colBudget.Name = "colBudget";
            this.colBudget.OptionsColumn.ReadOnly = true;
            this.colBudget.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colBudget.Visible = true;
            this.colBudget.VisibleIndex = 2;
            this.colBudget.Width = 114;
            // 
            // gridApprove
            // 
            this.gridApprove.AppearanceHeader.Options.UseTextOptions = true;
            this.gridApprove.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridApprove.Caption = "อนุมัติ";
            this.gridApprove.ColumnEdit = this.btnApp;
            this.gridApprove.Name = "gridApprove";
            this.gridApprove.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridApprove.Visible = true;
            this.gridApprove.VisibleIndex = 3;
            // 
            // btnApp
            // 
            this.btnApp.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnApp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.btnApp.Name = "btnApp";
            this.btnApp.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnApp.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnApp_ButtonClick);
            // 
            // cardView1
            // 
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsFind.AlwaysVisible = true;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.MintCream;
            this.panelSearch.Controls.Add(this.btnExit);
            this.panelSearch.Controls.Add(this.btnApproveAll);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(933, 40);
            this.panelSearch.TabIndex = 10;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ข้อมูลการอนุมัติ";
            // 
            // btnApproveAll
            // 
            this.btnApproveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApproveAll.BackColor = System.Drawing.Color.DarkCyan;
            this.btnApproveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproveAll.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnApproveAll.ForeColor = System.Drawing.Color.White;
            this.btnApproveAll.Location = new System.Drawing.Point(734, 7);
            this.btnApproveAll.Name = "btnApproveAll";
            this.btnApproveAll.Size = new System.Drawing.Size(110, 29);
            this.btnApproveAll.TabIndex = 1;
            this.btnApproveAll.Text = "อนุมัติทั้งหมด";
            this.btnApproveAll.UseVisualStyleBackColor = false;
            this.btnApproveAll.Click += new System.EventHandler(this.btnApproveAll_Click);
            // 
            // frmViewApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panelSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewApproval";
            this.Text = "ข้อมูลการอนุมัติ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewApproval_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colJobCode;
        private DevExpress.XtraGrid.Columns.GridColumn colJobName;
        private DevExpress.XtraGrid.Columns.GridColumn colBudget;
        private DevExpress.XtraGrid.Columns.GridColumn gridApprove;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnApp;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApproveAll;
    }
}