namespace CS.BNP.App.Transaction.Creditor
{
    partial class frmAddEditCreditorPrePaid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditCreditorPrePaid));
            this.panelWarning = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmpLastName = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmpCode = new System.Windows.Forms.Label();
            this.lblEmpFirstName = new System.Windows.Forms.Label();
            this.cbCreditor = new System.Windows.Forms.ComboBox();
            this.txtCreditorName = new System.Windows.Forms.TextBox();
            this.numPrePaid = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillingAmount = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlready = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panelWarning.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrePaid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWarning
            // 
            this.panelWarning.BackColor = System.Drawing.Color.LightCoral;
            this.panelWarning.Controls.Add(this.label1);
            this.panelWarning.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelWarning.Location = new System.Drawing.Point(0, 545);
            this.panelWarning.Name = "panelWarning";
            this.panelWarning.Size = new System.Drawing.Size(484, 35);
            this.panelWarning.TabIndex = 78;
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
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblUsername.Location = new System.Drawing.Point(247, 157);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 14);
            this.lblUsername.TabIndex = 76;
            this.lblUsername.Text = "ยอดเบิกล่วงหน้า";
            // 
            // lblEmpLastName
            // 
            this.lblEmpLastName.AutoSize = true;
            this.lblEmpLastName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblEmpLastName.Location = new System.Drawing.Point(13, 220);
            this.lblEmpLastName.Name = "lblEmpLastName";
            this.lblEmpLastName.Size = new System.Drawing.Size(54, 14);
            this.lblEmpLastName.TabIndex = 75;
            this.lblEmpLastName.Text = "หมายเหตุ";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtRemark.Location = new System.Drawing.Point(16, 237);
            this.txtRemark.MaxLength = 500;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(449, 250);
            this.txtRemark.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnSaveExit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 580);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 68);
            this.panel2.TabIndex = 73;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 30);
            this.panel1.TabIndex = 72;
            // 
            // lblEmpCode
            // 
            this.lblEmpCode.AutoSize = true;
            this.lblEmpCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblEmpCode.Location = new System.Drawing.Point(12, 43);
            this.lblEmpCode.Name = "lblEmpCode";
            this.lblEmpCode.Size = new System.Drawing.Size(59, 14);
            this.lblEmpCode.TabIndex = 71;
            this.lblEmpCode.Text = "รหัสเจ้าหนี้";
            // 
            // lblEmpFirstName
            // 
            this.lblEmpFirstName.AutoSize = true;
            this.lblEmpFirstName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblEmpFirstName.Location = new System.Drawing.Point(247, 42);
            this.lblEmpFirstName.Name = "lblEmpFirstName";
            this.lblEmpFirstName.Size = new System.Drawing.Size(54, 14);
            this.lblEmpFirstName.TabIndex = 74;
            this.lblEmpFirstName.Text = "ชื่อเจ้าหนี้";
            // 
            // cbCreditor
            // 
            this.cbCreditor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCreditor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCreditor.DropDownWidth = 400;
            this.cbCreditor.FormattingEnabled = true;
            this.cbCreditor.Location = new System.Drawing.Point(15, 61);
            this.cbCreditor.Name = "cbCreditor";
            this.cbCreditor.Size = new System.Drawing.Size(215, 22);
            this.cbCreditor.TabIndex = 0;
            this.cbCreditor.SelectedIndexChanged += new System.EventHandler(this.cbCreditor_SelectedIndexChanged);
            // 
            // txtCreditorName
            // 
            this.txtCreditorName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCreditorName.Enabled = false;
            this.txtCreditorName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtCreditorName.Location = new System.Drawing.Point(250, 61);
            this.txtCreditorName.MaxLength = 20;
            this.txtCreditorName.Name = "txtCreditorName";
            this.txtCreditorName.Size = new System.Drawing.Size(215, 24);
            this.txtCreditorName.TabIndex = 1;
            // 
            // numPrePaid
            // 
            this.numPrePaid.BackColor = System.Drawing.Color.Cornsilk;
            this.numPrePaid.DecimalPlaces = 2;
            this.numPrePaid.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.numPrePaid.Location = new System.Drawing.Point(250, 174);
            this.numPrePaid.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPrePaid.Name = "numPrePaid";
            this.numPrePaid.Size = new System.Drawing.Size(215, 40);
            this.numPrePaid.TabIndex = 3;
            this.numPrePaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrePaid.ThousandsSeparator = true;
            this.numPrePaid.Enter += new System.EventHandler(this.numPrePaid_Enter);
            this.numPrePaid.Leave += new System.EventHandler(this.numPrePaid_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(13, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 80;
            this.label2.Text = "ยอดวางบิล";
            // 
            // txtBillingAmount
            // 
            this.txtBillingAmount.BackColor = System.Drawing.Color.Cornsilk;
            this.txtBillingAmount.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtBillingAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtBillingAmount.Location = new System.Drawing.Point(16, 174);
            this.txtBillingAmount.MaxLength = 20;
            this.txtBillingAmount.Name = "txtBillingAmount";
            this.txtBillingAmount.ReadOnly = true;
            this.txtBillingAmount.Size = new System.Drawing.Size(214, 40);
            this.txtBillingAmount.TabIndex = 2;
            this.txtBillingAmount.Text = "0.00";
            this.txtBillingAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txtJob.TabIndex = 82;
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
            this.cbJob.TabIndex = 81;
            this.cbJob.SelectedIndexChanged += new System.EventHandler(this.cbJob_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 83;
            this.label3.Text = "รหัสโครงการ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(248, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 84;
            this.label4.Text = "ชื่อโครงการ";
            // 
            // txtAlready
            // 
            this.txtAlready.BackColor = System.Drawing.Color.Cornsilk;
            this.txtAlready.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtAlready.ForeColor = System.Drawing.Color.Chocolate;
            this.txtAlready.Location = new System.Drawing.Point(15, 262);
            this.txtAlready.MaxLength = 20;
            this.txtAlready.Name = "txtAlready";
            this.txtAlready.ReadOnly = true;
            this.txtAlready.Size = new System.Drawing.Size(214, 40);
            this.txtAlready.TabIndex = 85;
            this.txtAlready.Text = "0.00";
            this.txtAlready.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAlready.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 14);
            this.label5.TabIndex = 86;
            this.label5.Text = "ยอดเบิกก่อนหน้านี้";
            this.label5.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblID.Location = new System.Drawing.Point(456, 229);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 14);
            this.lblID.TabIndex = 87;
            this.lblID.Visible = false;
            // 
            // frmAddEditCreditorPrePaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 648);
            this.ControlBox = false;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtAlready);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbJob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBillingAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numPrePaid);
            this.Controls.Add(this.txtCreditorName);
            this.Controls.Add(this.cbCreditor);
            this.Controls.Add(this.panelWarning);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblEmpLastName);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEmpCode);
            this.Controls.Add(this.lblEmpFirstName);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(500, 750);
            this.MinimumSize = new System.Drawing.Size(500, 650);
            this.Name = "frmAddEditCreditorPrePaid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เพิ่มแก้ไขรายการจ่ายล่วงหนี้";
            this.Load += new System.EventHandler(this.frmAddEditCreditorPrePaid_Load);
            this.panelWarning.ResumeLayout(false);
            this.panelWarning.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPrePaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWarning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmpLastName;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmpCode;
        private System.Windows.Forms.Label lblEmpFirstName;
        private System.Windows.Forms.ComboBox cbCreditor;
        private System.Windows.Forms.TextBox txtCreditorName;
        private System.Windows.Forms.NumericUpDown numPrePaid;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnSaveExit;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillingAmount;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.ComboBox cbJob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlready;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblID;
    }
}