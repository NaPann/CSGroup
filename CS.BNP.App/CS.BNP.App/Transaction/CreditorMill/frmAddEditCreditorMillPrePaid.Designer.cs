namespace CS.BNP.App.Transaction.Creditor
{
    partial class frmAddEditCreditorMillPrePaid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditCreditorMillPrePaid));
            this.lblID = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBillingAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numPrePaid = new System.Windows.Forms.NumericUpDown();
            this.txtCreditorMillName = new System.Windows.Forms.TextBox();
            this.cbCreditorMill = new System.Windows.Forms.ComboBox();
            this.panelWarning = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmpLastName = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblEmpCode = new System.Windows.Forms.Label();
            this.lblEmpFirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPrePaid)).BeginInit();
            this.panelWarning.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblID.Location = new System.Drawing.Point(456, 229);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 14);
            this.lblID.TabIndex = 107;
            this.lblID.Visible = false;
            // 
            // txtJob
            // 
            this.txtJob.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtJob.Enabled = false;
            this.txtJob.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtJob.Location = new System.Drawing.Point(251, 114);
            this.txtJob.MaxLength = 20;
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(215, 24);
            this.txtJob.TabIndex = 102;
            // 
            // cbJob
            // 
            this.cbJob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbJob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbJob.DropDownWidth = 400;
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Location = new System.Drawing.Point(16, 114);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(215, 22);
            this.cbJob.TabIndex = 101;
            this.cbJob.SelectedIndexChanged += new System.EventHandler(this.cbJob_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 103;
            this.label3.Text = "รหัสโครงการ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(248, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 104;
            this.label4.Text = "ชื่อโครงการ";
            // 
            // txtBillingAmount
            // 
            this.txtBillingAmount.BackColor = System.Drawing.Color.Cornsilk;
            this.txtBillingAmount.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtBillingAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtBillingAmount.Location = new System.Drawing.Point(16, 169);
            this.txtBillingAmount.MaxLength = 20;
            this.txtBillingAmount.Name = "txtBillingAmount";
            this.txtBillingAmount.ReadOnly = true;
            this.txtBillingAmount.Size = new System.Drawing.Size(214, 40);
            this.txtBillingAmount.TabIndex = 90;
            this.txtBillingAmount.Text = "0.00";
            this.txtBillingAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(13, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 100;
            this.label2.Text = "ยอดหัก";
            // 
            // numPrePaid
            // 
            this.numPrePaid.BackColor = System.Drawing.Color.Cornsilk;
            this.numPrePaid.DecimalPlaces = 2;
            this.numPrePaid.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.numPrePaid.Location = new System.Drawing.Point(250, 169);
            this.numPrePaid.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPrePaid.Minimum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            -2147483648});
            this.numPrePaid.Name = "numPrePaid";
            this.numPrePaid.Size = new System.Drawing.Size(215, 40);
            this.numPrePaid.TabIndex = 91;
            this.numPrePaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrePaid.ThousandsSeparator = true;
            this.numPrePaid.Enter += new System.EventHandler(this.numPrePaid_Enter);
            // 
            // txtCreditorMillName
            // 
            this.txtCreditorMillName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCreditorMillName.Enabled = false;
            this.txtCreditorMillName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtCreditorMillName.Location = new System.Drawing.Point(250, 61);
            this.txtCreditorMillName.MaxLength = 20;
            this.txtCreditorMillName.Name = "txtCreditorMillName";
            this.txtCreditorMillName.Size = new System.Drawing.Size(215, 24);
            this.txtCreditorMillName.TabIndex = 89;
            // 
            // cbCreditorMill
            // 
            this.cbCreditorMill.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCreditorMill.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCreditorMill.DropDownWidth = 400;
            this.cbCreditorMill.FormattingEnabled = true;
            this.cbCreditorMill.Location = new System.Drawing.Point(15, 61);
            this.cbCreditorMill.Name = "cbCreditorMill";
            this.cbCreditorMill.Size = new System.Drawing.Size(215, 22);
            this.cbCreditorMill.TabIndex = 88;
            this.cbCreditorMill.SelectedIndexChanged += new System.EventHandler(this.cbCreditorMill_SelectedIndexChanged);
            // 
            // panelWarning
            // 
            this.panelWarning.BackColor = System.Drawing.Color.LightCoral;
            this.panelWarning.Controls.Add(this.label1);
            this.panelWarning.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelWarning.Location = new System.Drawing.Point(0, 308);
            this.panelWarning.Name = "panelWarning";
            this.panelWarning.Size = new System.Drawing.Size(484, 35);
            this.panelWarning.TabIndex = 99;
            this.panelWarning.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(146, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "กรุณากรอกข้อมูลให้ครบถ้วน !!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 30);
            this.panel1.TabIndex = 94;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblUsername.Location = new System.Drawing.Point(247, 152);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(63, 14);
            this.lblUsername.TabIndex = 98;
            this.lblUsername.Text = "ยอดวางเงิน";
            // 
            // lblEmpLastName
            // 
            this.lblEmpLastName.AutoSize = true;
            this.lblEmpLastName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblEmpLastName.Location = new System.Drawing.Point(13, 220);
            this.lblEmpLastName.Name = "lblEmpLastName";
            this.lblEmpLastName.Size = new System.Drawing.Size(54, 14);
            this.lblEmpLastName.TabIndex = 97;
            this.lblEmpLastName.Text = "หมายเหตุ";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtRemark.Location = new System.Drawing.Point(15, 238);
            this.txtRemark.MaxLength = 500;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(449, 65);
            this.txtRemark.TabIndex = 92;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnSaveExit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 68);
            this.panel2.TabIndex = 95;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Appearance.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.Appearance.Options.UseBorderColor = true;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExit.Location = new System.Drawing.Point(370, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 41);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "ออก";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveExit.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSaveExit.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveExit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveExit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSaveExit.Appearance.Options.UseBackColor = true;
            this.btnSaveExit.Appearance.Options.UseBorderColor = true;
            this.btnSaveExit.Appearance.Options.UseFont = true;
            this.btnSaveExit.Appearance.Options.UseForeColor = true;
            this.btnSaveExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSaveExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveExit.ImageOptions.Image")));
            this.btnSaveExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSaveExit.Location = new System.Drawing.Point(178, 14);
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(185, 41);
            this.btnSaveExit.TabIndex = 1;
            this.btnSaveExit.Text = "บันทึกข้อมูลและออก";
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSave.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseBorderColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.Location = new System.Drawing.Point(16, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 41);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "บันทึกข้อมูล";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblEmpCode
            // 
            this.lblEmpCode.AutoSize = true;
            this.lblEmpCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblEmpCode.Location = new System.Drawing.Point(12, 43);
            this.lblEmpCode.Name = "lblEmpCode";
            this.lblEmpCode.Size = new System.Drawing.Size(57, 14);
            this.lblEmpCode.TabIndex = 93;
            this.lblEmpCode.Text = "รหัสโรงโม่";
            // 
            // lblEmpFirstName
            // 
            this.lblEmpFirstName.AutoSize = true;
            this.lblEmpFirstName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblEmpFirstName.Location = new System.Drawing.Point(247, 42);
            this.lblEmpFirstName.Name = "lblEmpFirstName";
            this.lblEmpFirstName.Size = new System.Drawing.Size(52, 14);
            this.lblEmpFirstName.TabIndex = 96;
            this.lblEmpFirstName.Text = "ชื่อโรงโม่";
            // 
            // frmAddEditCreditorMillPrePaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.ControlBox = false;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.cbJob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBillingAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numPrePaid);
            this.Controls.Add(this.txtCreditorMillName);
            this.Controls.Add(this.cbCreditorMill);
            this.Controls.Add(this.panelWarning);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblEmpLastName);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblEmpCode);
            this.Controls.Add(this.lblEmpFirstName);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(500, 450);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "frmAddEditCreditorMillPrePaid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เพิ่มแก้ไขรายการเงินวาง";
            this.Load += new System.EventHandler(this.frmAddEditCreditorMillPrePaid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrePaid)).EndInit();
            this.panelWarning.ResumeLayout(false);
            this.panelWarning.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.ComboBox cbJob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBillingAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPrePaid;
        private System.Windows.Forms.TextBox txtCreditorMillName;
        private System.Windows.Forms.ComboBox cbCreditorMill;
        private System.Windows.Forms.Panel panelWarning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnSaveExit;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmpLastName;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEmpCode;
        private System.Windows.Forms.Label lblEmpFirstName;
    }
}