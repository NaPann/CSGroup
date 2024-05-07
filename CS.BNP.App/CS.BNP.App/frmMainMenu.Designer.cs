namespace CS.BNP.App
{
    partial class frmMainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navAdmin = new DevExpress.XtraNavBar.NavBarGroup();
            this.navItemHistory = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemApproval = new DevExpress.XtraNavBar.NavBarItem();
            this.navSecurity = new DevExpress.XtraNavBar.NavBarGroup();
            this.navItemEmployee = new DevExpress.XtraNavBar.NavBarItem();
            this.navSetting = new DevExpress.XtraNavBar.NavBarGroup();
            this.navItemProduct = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemDebtor = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemCreditor = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemTask = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemCreditorMill = new DevExpress.XtraNavBar.NavBarItem();
            this.navTransaction = new DevExpress.XtraNavBar.NavBarGroup();
            this.navItemBillingPeriod = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemDebitorPeriod = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem1 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navItemTranCreditor = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemTranDebitor = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem2 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navItemPre = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemMillPre = new DevExpress.XtraNavBar.NavBarItem();
            this.navSummary = new DevExpress.XtraNavBar.NavBarGroup();
            this.navItemSummaryCreditor = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemSummaryDebitor = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemBuyVat = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem3 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navItemCreditorReport = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemDebitorReport = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem4 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navItemLetter = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemVS = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemVSBase = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem6 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navItemMillVat = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemTramMillRpt = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemMillConsolidate = new DevExpress.XtraNavBar.NavBarItem();
            this.navExit = new DevExpress.XtraNavBar.NavBarGroup();
            this.navItemChangePassword = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemLogOut = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemExit = new DevExpress.XtraNavBar.NavBarItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.t_Datetime = new System.Windows.Forms.ToolStripStatusLabel();
            this.t_User = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.navItemPrePaid = new DevExpress.XtraNavBar.NavBarItem();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.navBarSeparatorItem5 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 40);
            this.panel1.TabIndex = 0;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(925, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(67, 19);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "V.200501";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "C-S && N.JS Trading Co.,Ltd.";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navAdmin;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navAdmin,
            this.navSecurity,
            this.navSetting,
            this.navTransaction,
            this.navSummary,
            this.navExit});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navItemProduct,
            this.navItemDebtor,
            this.navItemEmployee,
            this.navItemCreditor,
            this.navItemTask,
            this.navItemChangePassword,
            this.navItemLogOut,
            this.navItemExit,
            this.navItemBillingPeriod,
            this.navItemTranCreditor,
            this.navItemSummaryCreditor,
            this.navItemSummaryDebitor,
            this.navItemTranDebitor,
            this.navItemCreditorReport,
            this.navBarSeparatorItem1,
            this.navBarSeparatorItem2,
            this.navBarSeparatorItem3,
            this.navItemPre,
            this.navItemDebitorReport,
            this.navItemDebitorPeriod,
            this.navItemBuyVat,
            this.navItemLetter,
            this.navBarSeparatorItem4,
            this.navItemVS,
            this.navItemApproval,
            this.navItemHistory,
            this.navItemVSBase,
            this.navItemCreditorMill,
            this.navItemMillPre,
            this.navItemMillVat,
            this.navBarSeparatorItem6,
            this.navItemTramMillRpt,
            this.navItemMillConsolidate});
            this.navBarControl1.Location = new System.Drawing.Point(0, 40);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 171;
            this.navBarControl1.OptionsNavPane.ShowGroupImageInHeader = true;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(171, 710);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("DevExpress Style");
            // 
            // navAdmin
            // 
            this.navAdmin.Caption = "ผู้ดูแลระบบ";
            this.navAdmin.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemHistory),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemApproval)});
            this.navAdmin.Name = "navAdmin";
            this.navAdmin.SmallImage = ((System.Drawing.Image)(resources.GetObject("navAdmin.SmallImage")));
            // 
            // navItemHistory
            // 
            this.navItemHistory.Caption = "ประวัติการสร้างโครงการ";
            this.navItemHistory.Name = "navItemHistory";
            this.navItemHistory.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemHistory.SmallImage")));
            this.navItemHistory.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemHistory_LinkClicked);
            // 
            // navItemApproval
            // 
            this.navItemApproval.Caption = "อนุมัติโครงการ";
            this.navItemApproval.Name = "navItemApproval";
            this.navItemApproval.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemApproval.SmallImage")));
            this.navItemApproval.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemApproval_LinkClicked);
            // 
            // navSecurity
            // 
            this.navSecurity.Caption = "ความปลอดภัย";
            this.navSecurity.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemEmployee)});
            this.navSecurity.Name = "navSecurity";
            this.navSecurity.SmallImage = ((System.Drawing.Image)(resources.GetObject("navSecurity.SmallImage")));
            // 
            // navItemEmployee
            // 
            this.navItemEmployee.Caption = "พนักงานและผู้ใช้งานระบบ ";
            this.navItemEmployee.Name = "navItemEmployee";
            this.navItemEmployee.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemEmployee.SmallImage")));
            this.navItemEmployee.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemEmployee_LinkClicked);
            // 
            // navSetting
            // 
            this.navSetting.Caption = "ตั้งค่าระบบ";
            this.navSetting.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navSetting.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemProduct),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemDebtor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemCreditor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemTask),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemCreditorMill)});
            this.navSetting.Name = "navSetting";
            this.navSetting.SmallImage = ((System.Drawing.Image)(resources.GetObject("navSetting.SmallImage")));
            // 
            // navItemProduct
            // 
            this.navItemProduct.Caption = "สินค้า";
            this.navItemProduct.Name = "navItemProduct";
            this.navItemProduct.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemProduct.SmallImage")));
            this.navItemProduct.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemProduct_LinkClicked);
            // 
            // navItemDebtor
            // 
            this.navItemDebtor.Caption = "ลูกหนี้";
            this.navItemDebtor.Name = "navItemDebtor";
            this.navItemDebtor.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemDebtor.SmallImage")));
            this.navItemDebtor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemDebtor_LinkClicked);
            // 
            // navItemCreditor
            // 
            this.navItemCreditor.Caption = "เจ้าหนี้";
            this.navItemCreditor.Name = "navItemCreditor";
            this.navItemCreditor.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemCreditor.SmallImage")));
            this.navItemCreditor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemCreditor_LinkClicked);
            // 
            // navItemTask
            // 
            this.navItemTask.Caption = "โครงการ / งาน";
            this.navItemTask.Name = "navItemTask";
            this.navItemTask.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemTask.SmallImage")));
            this.navItemTask.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemTask_LinkClicked);
            // 
            // navItemCreditorMill
            // 
            this.navItemCreditorMill.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("navItemCreditorMill.Appearance.Image")));
            this.navItemCreditorMill.Appearance.Options.UseImage = true;
            this.navItemCreditorMill.Caption = "โรงโม่หิน";
            this.navItemCreditorMill.Name = "navItemCreditorMill";
            this.navItemCreditorMill.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemCreditorMill.SmallImage")));
            this.navItemCreditorMill.Visible = false;
            this.navItemCreditorMill.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemCreditorMill_LinkClicked);
            // 
            // navTransaction
            // 
            this.navTransaction.Caption = "บันทึกรายการ";
            this.navTransaction.Expanded = true;
            this.navTransaction.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemBillingPeriod),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemDebitorPeriod),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemTranCreditor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemTranDebitor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemPre),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemMillPre)});
            this.navTransaction.Name = "navTransaction";
            this.navTransaction.SmallImage = ((System.Drawing.Image)(resources.GetObject("navTransaction.SmallImage")));
            // 
            // navItemBillingPeriod
            // 
            this.navItemBillingPeriod.AppearancePressed.Image = ((System.Drawing.Image)(resources.GetObject("navItemBillingPeriod.AppearancePressed.Image")));
            this.navItemBillingPeriod.AppearancePressed.Options.UseImage = true;
            this.navItemBillingPeriod.Caption = "ช่วงเวลาเบิกเจ้าหนี้";
            this.navItemBillingPeriod.Name = "navItemBillingPeriod";
            this.navItemBillingPeriod.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemBillingPeriod.SmallImage")));
            this.navItemBillingPeriod.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemBillingPeriod_LinkClicked);
            // 
            // navItemDebitorPeriod
            // 
            this.navItemDebitorPeriod.Caption = "ช่วงเวลาเบิกลูกหนี้";
            this.navItemDebitorPeriod.Name = "navItemDebitorPeriod";
            this.navItemDebitorPeriod.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemDebitorPeriod.SmallImage")));
            this.navItemDebitorPeriod.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemDebitorPeriod_LinkClicked);
            // 
            // navBarSeparatorItem1
            // 
            this.navBarSeparatorItem1.CanDrag = false;
            this.navBarSeparatorItem1.Enabled = false;
            this.navBarSeparatorItem1.Hint = null;
            this.navBarSeparatorItem1.LargeImageIndex = 0;
            this.navBarSeparatorItem1.LargeImageSize = new System.Drawing.Size(0, 0);
            this.navBarSeparatorItem1.Name = "navBarSeparatorItem1";
            this.navBarSeparatorItem1.SmallImageIndex = 0;
            this.navBarSeparatorItem1.SmallImageSize = new System.Drawing.Size(0, 0);
            // 
            // navItemTranCreditor
            // 
            this.navItemTranCreditor.Caption = "รายการบันทึกเจ้าหนี้";
            this.navItemTranCreditor.Name = "navItemTranCreditor";
            this.navItemTranCreditor.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemTranCreditor.SmallImage")));
            this.navItemTranCreditor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemTranCreditor_LinkClicked);
            // 
            // navItemTranDebitor
            // 
            this.navItemTranDebitor.Caption = "รายการบันทึกลูกหนี้";
            this.navItemTranDebitor.Name = "navItemTranDebitor";
            this.navItemTranDebitor.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemTranDebitor.SmallImage")));
            this.navItemTranDebitor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemTranDebitor_LinkClicked);
            // 
            // navBarSeparatorItem2
            // 
            this.navBarSeparatorItem2.CanDrag = false;
            this.navBarSeparatorItem2.Enabled = false;
            this.navBarSeparatorItem2.Hint = null;
            this.navBarSeparatorItem2.LargeImageIndex = 0;
            this.navBarSeparatorItem2.LargeImageSize = new System.Drawing.Size(0, 0);
            this.navBarSeparatorItem2.Name = "navBarSeparatorItem2";
            this.navBarSeparatorItem2.SmallImageIndex = 0;
            this.navBarSeparatorItem2.SmallImageSize = new System.Drawing.Size(0, 0);
            // 
            // navItemPre
            // 
            this.navItemPre.Caption = "จ่ายเจ้าหนี้ล่วงหน้า";
            this.navItemPre.Name = "navItemPre";
            this.navItemPre.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemPre.SmallImage")));
            this.navItemPre.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemPre_LinkClicked);
            // 
            // navItemMillPre
            // 
            this.navItemMillPre.Caption = "วางเงินโรงโม่";
            this.navItemMillPre.Name = "navItemMillPre";
            this.navItemMillPre.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemMillPre.SmallImage")));
            this.navItemMillPre.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemMillPre_LinkClicked);
            // 
            // navSummary
            // 
            this.navSummary.Caption = "รายการ / รายงาน";
            this.navSummary.Expanded = true;
            this.navSummary.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemSummaryCreditor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemSummaryDebitor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemBuyVat),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemCreditorReport),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemDebitorReport),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemLetter),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemVS),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemVSBase),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem6),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemMillVat),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemTramMillRpt),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemMillConsolidate)});
            this.navSummary.Name = "navSummary";
            this.navSummary.SmallImage = ((System.Drawing.Image)(resources.GetObject("navSummary.SmallImage")));
            // 
            // navItemSummaryCreditor
            // 
            this.navItemSummaryCreditor.Caption = "สรุปรายการเจ้าหนี้";
            this.navItemSummaryCreditor.Name = "navItemSummaryCreditor";
            this.navItemSummaryCreditor.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemSummaryCreditor.SmallImage")));
            this.navItemSummaryCreditor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemSummartCreditor_LinkClicked);
            // 
            // navItemSummaryDebitor
            // 
            this.navItemSummaryDebitor.Caption = "สรุปรายการลูกหนี้";
            this.navItemSummaryDebitor.Name = "navItemSummaryDebitor";
            this.navItemSummaryDebitor.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemSummaryDebitor.SmallImage")));
            this.navItemSummaryDebitor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemSummaryDebitor_LinkClicked);
            // 
            // navItemBuyVat
            // 
            this.navItemBuyVat.Caption = "รายการภาษีซื้อ";
            this.navItemBuyVat.Name = "navItemBuyVat";
            this.navItemBuyVat.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemBuyVat.SmallImage")));
            this.navItemBuyVat.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemBuyVat_LinkClicked);
            // 
            // navBarSeparatorItem3
            // 
            this.navBarSeparatorItem3.CanDrag = false;
            this.navBarSeparatorItem3.Enabled = false;
            this.navBarSeparatorItem3.Hint = null;
            this.navBarSeparatorItem3.LargeImageIndex = 0;
            this.navBarSeparatorItem3.LargeImageSize = new System.Drawing.Size(0, 0);
            this.navBarSeparatorItem3.Name = "navBarSeparatorItem3";
            this.navBarSeparatorItem3.SmallImageIndex = 0;
            this.navBarSeparatorItem3.SmallImageSize = new System.Drawing.Size(0, 0);
            // 
            // navItemCreditorReport
            // 
            this.navItemCreditorReport.Caption = "รายงานการจ่าย";
            this.navItemCreditorReport.Name = "navItemCreditorReport";
            this.navItemCreditorReport.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemCreditorReport.SmallImage")));
            this.navItemCreditorReport.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemCreditorReport_LinkClicked);
            // 
            // navItemDebitorReport
            // 
            this.navItemDebitorReport.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("navItemDebitorReport.Appearance.Image")));
            this.navItemDebitorReport.Appearance.Options.UseImage = true;
            this.navItemDebitorReport.Caption = "รายงานการรับ";
            this.navItemDebitorReport.Name = "navItemDebitorReport";
            this.navItemDebitorReport.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemDebitorReport.SmallImage")));
            this.navItemDebitorReport.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemDebitorReport_LinkClicked);
            // 
            // navBarSeparatorItem4
            // 
            this.navBarSeparatorItem4.CanDrag = false;
            this.navBarSeparatorItem4.Enabled = false;
            this.navBarSeparatorItem4.Hint = null;
            this.navBarSeparatorItem4.LargeImageIndex = 0;
            this.navBarSeparatorItem4.LargeImageSize = new System.Drawing.Size(0, 0);
            this.navBarSeparatorItem4.Name = "navBarSeparatorItem4";
            this.navBarSeparatorItem4.SmallImageIndex = 0;
            this.navBarSeparatorItem4.SmallImageSize = new System.Drawing.Size(0, 0);
            // 
            // navItemLetter
            // 
            this.navItemLetter.Caption = "เอกสารวางบิลแจ้งหนี้";
            this.navItemLetter.Name = "navItemLetter";
            this.navItemLetter.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemLetter.SmallImage")));
            this.navItemLetter.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemLetter_LinkClicked);
            // 
            // navItemVS
            // 
            this.navItemVS.Caption = "รายงานราคาซื้อขาย";
            this.navItemVS.Name = "navItemVS";
            this.navItemVS.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemVS.SmallImage")));
            this.navItemVS.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemVS_LinkClicked);
            // 
            // navItemVSBase
            // 
            this.navItemVSBase.Caption = "รายงานซื้อขายโครงการ";
            this.navItemVSBase.Name = "navItemVSBase";
            this.navItemVSBase.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemVSBase.SmallImage")));
            this.navItemVSBase.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemVSBase_LinkClicked);
            // 
            // navBarSeparatorItem6
            // 
            this.navBarSeparatorItem6.CanDrag = false;
            this.navBarSeparatorItem6.Enabled = false;
            this.navBarSeparatorItem6.Hint = null;
            this.navBarSeparatorItem6.LargeImageIndex = 0;
            this.navBarSeparatorItem6.LargeImageSize = new System.Drawing.Size(0, 0);
            this.navBarSeparatorItem6.Name = "navBarSeparatorItem6";
            this.navBarSeparatorItem6.SmallImageIndex = 0;
            this.navBarSeparatorItem6.SmallImageSize = new System.Drawing.Size(0, 0);
            // 
            // navItemMillVat
            // 
            this.navItemMillVat.Caption = "รายงานภาษีโรงโม่";
            this.navItemMillVat.Name = "navItemMillVat";
            this.navItemMillVat.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemMillVat.SmallImage")));
            this.navItemMillVat.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemMillVat_LinkClicked);
            // 
            // navItemTramMillRpt
            // 
            this.navItemTramMillRpt.Caption = "รายงานสรุปโรงโม่";
            this.navItemTramMillRpt.Name = "navItemTramMillRpt";
            this.navItemTramMillRpt.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemTramMillRpt.SmallImage")));
            this.navItemTramMillRpt.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemTramMillRpt_LinkClicked);
            // 
            // navItemMillConsolidate
            // 
            this.navItemMillConsolidate.Caption = "รายงานราคาซื้อและราคาขาย";
            this.navItemMillConsolidate.Name = "navItemMillConsolidate";
            this.navItemMillConsolidate.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemMillConsolidate.SmallImage")));
            this.navItemMillConsolidate.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemMillConsolidate_LinkClicked);
            // 
            // navExit
            // 
            this.navExit.Caption = "เกี่ยวกับโปรแกรม";
            this.navExit.Expanded = true;
            this.navExit.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navExit.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemChangePassword),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemLogOut),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemExit)});
            this.navExit.Name = "navExit";
            this.navExit.SmallImage = ((System.Drawing.Image)(resources.GetObject("navExit.SmallImage")));
            // 
            // navItemChangePassword
            // 
            this.navItemChangePassword.Caption = "เปลี่ยนรหัสผ่าน";
            this.navItemChangePassword.Name = "navItemChangePassword";
            this.navItemChangePassword.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemChangePassword.SmallImage")));
            this.navItemChangePassword.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemChangePassword_LinkClicked);
            // 
            // navItemLogOut
            // 
            this.navItemLogOut.Caption = "เปลี่ยนผู้ใช้งาน";
            this.navItemLogOut.Name = "navItemLogOut";
            this.navItemLogOut.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemLogOut.SmallImage")));
            this.navItemLogOut.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemLogOut_LinkClicked);
            // 
            // navItemExit
            // 
            this.navItemExit.Caption = "ออกจากโปรแกรม";
            this.navItemExit.Name = "navItemExit";
            this.navItemExit.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemExit.SmallImage")));
            this.navItemExit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemExit_LinkClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.t_Datetime,
            this.t_User});
            this.statusStrip1.Location = new System.Drawing.Point(171, 728);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(833, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // t_Datetime
            // 
            this.t_Datetime.Font = new System.Drawing.Font("Tahoma", 9F);
            this.t_Datetime.Name = "t_Datetime";
            this.t_Datetime.Size = new System.Drawing.Size(0, 0);
            // 
            // t_User
            // 
            this.t_User.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.t_User.Name = "t_User";
            this.t_User.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // navItemPrePaid
            // 
            this.navItemPrePaid.Caption = "บันทึกจ่ายเจ้าหนี้ล่วงหน้า";
            this.navItemPrePaid.Name = "navItemPrePaid";
            this.navItemPrePaid.SmallImage = ((System.Drawing.Image)(resources.GetObject("navItemPrePaid.SmallImage")));
            // 
            // alertControl1
            // 
            this.alertControl1.AllowHtmlText = true;
            this.alertControl1.AppearanceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.alertControl1.AppearanceText.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.alertControl1.AppearanceText.ForeColor = System.Drawing.Color.Red;
            this.alertControl1.AppearanceText.Options.UseBackColor = true;
            this.alertControl1.AppearanceText.Options.UseFont = true;
            this.alertControl1.AppearanceText.Options.UseForeColor = true;
            this.alertControl1.AutoFormDelay = 10000;
            this.alertControl1.ControlBoxPosition = DevExpress.XtraBars.Alerter.AlertFormControlBoxPosition.Right;
            this.alertControl1.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Fast;
            this.alertControl1.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
            this.alertControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red;
            this.alertControl1.ShowPinButton = false;
            // 
            // navBarSeparatorItem5
            // 
            this.navBarSeparatorItem5.CanDrag = false;
            this.navBarSeparatorItem5.Enabled = false;
            this.navBarSeparatorItem5.Hint = null;
            this.navBarSeparatorItem5.LargeImageIndex = 0;
            this.navBarSeparatorItem5.LargeImageSize = new System.Drawing.Size(0, 0);
            this.navBarSeparatorItem5.Name = "navBarSeparatorItem5";
            this.navBarSeparatorItem5.SmallImageIndex = 0;
            this.navBarSeparatorItem5.SmallImageSize = new System.Drawing.Size(0, 0);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 750);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "frmMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CS Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navSecurity;
        private DevExpress.XtraNavBar.NavBarItem navItemEmployee;
        private DevExpress.XtraNavBar.NavBarGroup navSetting;
        private DevExpress.XtraNavBar.NavBarItem navItemProduct;
        private DevExpress.XtraNavBar.NavBarItem navItemDebtor;
        private DevExpress.XtraNavBar.NavBarItem navItemCreditor;
        private DevExpress.XtraNavBar.NavBarItem navItemTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel t_Datetime;
        private System.Windows.Forms.ToolStripStatusLabel t_User;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraNavBar.NavBarGroup navExit;
        private DevExpress.XtraNavBar.NavBarItem navItemChangePassword;
        private DevExpress.XtraNavBar.NavBarItem navItemLogOut;
        private DevExpress.XtraNavBar.NavBarItem navItemExit;
        private DevExpress.XtraNavBar.NavBarGroup navTransaction;
        private DevExpress.XtraNavBar.NavBarItem navItemBillingPeriod;
        private DevExpress.XtraNavBar.NavBarItem navItemTranCreditor;
        private DevExpress.XtraNavBar.NavBarGroup navSummary;
        private DevExpress.XtraNavBar.NavBarItem navItemSummaryCreditor;
        private DevExpress.XtraNavBar.NavBarItem navItemSummaryDebitor;
        private DevExpress.XtraNavBar.NavBarItem navItemTranDebitor;
        private DevExpress.XtraNavBar.NavBarItem navItemCreditorReport;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem1;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem2;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem3;
        private DevExpress.XtraNavBar.NavBarItem navItemPrePaid;
        private DevExpress.XtraNavBar.NavBarItem navItemPre;
        private DevExpress.XtraNavBar.NavBarItem navItemDebitorReport;
        private System.Windows.Forms.Label lblVersion;
        private DevExpress.XtraNavBar.NavBarItem navItemDebitorPeriod;
        private DevExpress.XtraNavBar.NavBarItem navItemBuyVat;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem4;
        private DevExpress.XtraNavBar.NavBarItem navItemLetter;
        private DevExpress.XtraNavBar.NavBarItem navItemVS;
        private DevExpress.XtraNavBar.NavBarItem navItemApproval;
        private DevExpress.XtraNavBar.NavBarItem navItemHistory;
        private DevExpress.XtraNavBar.NavBarGroup navAdmin;
        private DevExpress.XtraNavBar.NavBarItem navItemVSBase;
        private DevExpress.XtraNavBar.NavBarItem navItemCreditorMill;
        private DevExpress.XtraNavBar.NavBarItem navItemMillPre;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraNavBar.NavBarItem navItemMillVat;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem5;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem6;
        private DevExpress.XtraNavBar.NavBarItem navItemTramMillRpt;
        private DevExpress.XtraNavBar.NavBarItem navItemMillConsolidate;
    }
}

