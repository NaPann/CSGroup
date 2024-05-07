namespace CS.BNP.App.Transaction.Creditor
{
    partial class frmAddEditCreditorMill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditCreditorMill));
            this.lblID = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numTotalAmount = new System.Windows.Forms.NumericUpDown();
            this.txtCreditorMillName = new System.Windows.Forms.TextBox();
            this.cbCreditorMill = new System.Windows.Forms.ComboBox();
            this.panelWarning = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmpLastName = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveExit = new DevExpress.XtraEditors.SimpleButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmpCode = new System.Windows.Forms.Label();
            this.lblEmpFirstName = new System.Windows.Forms.Label();
            this.txtJobCode = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.numVat = new System.Windows.Forms.NumericUpDown();
            this.lblEX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalAmount)).BeginInit();
            this.panelWarning.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblID.Location = new System.Drawing.Point(456, 229);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 14);
            this.lblID.TabIndex = 125;
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
            this.txtJob.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 123;
            this.label3.Text = "รหัสโครงการ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(248, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 124;
            this.label4.Text = "ชื่อโครงการ";
            // 
            // numTotalAmount
            // 
            this.numTotalAmount.BackColor = System.Drawing.Color.Cornsilk;
            this.numTotalAmount.DecimalPlaces = 2;
            this.numTotalAmount.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.numTotalAmount.Location = new System.Drawing.Point(250, 169);
            this.numTotalAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numTotalAmount.Name = "numTotalAmount";
            this.numTotalAmount.Size = new System.Drawing.Size(215, 40);
            this.numTotalAmount.TabIndex = 111;
            this.numTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTotalAmount.ThousandsSeparator = true;
            this.numTotalAmount.ValueChanged += new System.EventHandler(this.numTotalAmount_ValueChanged);
            this.numTotalAmount.Enter += new System.EventHandler(this.numTotalAmount_Enter);
            this.numTotalAmount.Leave += new System.EventHandler(this.numTotalAmount_Leave);
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
            this.txtCreditorMillName.TabIndex = 109;
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
            this.cbCreditorMill.TabIndex = 108;
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
            this.panelWarning.TabIndex = 119;
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
            this.panel1.TabIndex = 114;
            // 
            // lblEmpLastName
            // 
            this.lblEmpLastName.AutoSize = true;
            this.lblEmpLastName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblEmpLastName.Location = new System.Drawing.Point(13, 211);
            this.lblEmpLastName.Name = "lblEmpLastName";
            this.lblEmpLastName.Size = new System.Drawing.Size(54, 14);
            this.lblEmpLastName.TabIndex = 117;
            this.lblEmpLastName.Text = "หมายเหตุ";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtRemark.Location = new System.Drawing.Point(15, 229);
            this.txtRemark.MaxLength = 500;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(449, 65);
            this.txtRemark.TabIndex = 112;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnSaveExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 68);
            this.panel2.TabIndex = 115;
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
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblUsername.Location = new System.Drawing.Point(247, 152);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(43, 14);
            this.lblUsername.TabIndex = 118;
            this.lblUsername.Text = "ยอดหัก";
            // 
            // lblEmpCode
            // 
            this.lblEmpCode.AutoSize = true;
            this.lblEmpCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblEmpCode.Location = new System.Drawing.Point(12, 43);
            this.lblEmpCode.Name = "lblEmpCode";
            this.lblEmpCode.Size = new System.Drawing.Size(57, 14);
            this.lblEmpCode.TabIndex = 113;
            this.lblEmpCode.Text = "รหัสโรงโม่";
            // 
            // lblEmpFirstName
            // 
            this.lblEmpFirstName.AutoSize = true;
            this.lblEmpFirstName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblEmpFirstName.Location = new System.Drawing.Point(247, 42);
            this.lblEmpFirstName.Name = "lblEmpFirstName";
            this.lblEmpFirstName.Size = new System.Drawing.Size(52, 14);
            this.lblEmpFirstName.TabIndex = 116;
            this.lblEmpFirstName.Text = "ชื่อโรงโม่";
            // 
            // txtJobCode
            // 
            this.txtJobCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtJobCode.Enabled = false;
            this.txtJobCode.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtJobCode.Location = new System.Drawing.Point(15, 114);
            this.txtJobCode.MaxLength = 20;
            this.txtJobCode.Name = "txtJobCode";
            this.txtJobCode.Size = new System.Drawing.Size(215, 24);
            this.txtJobCode.TabIndex = 126;
            // 
            // txtVat
            // 
            this.txtVat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtVat.Enabled = false;
            this.txtVat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtVat.Location = new System.Drawing.Point(76, 167);
            this.txtVat.MaxLength = 20;
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(154, 24);
            this.txtVat.TabIndex = 145;
            this.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label23.Location = new System.Drawing.Point(13, 152);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 14);
            this.label23.TabIndex = 146;
            this.label23.Text = "ภาษี %";
            // 
            // numVat
            // 
            this.numVat.Location = new System.Drawing.Point(16, 169);
            this.numVat.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numVat.Name = "numVat";
            this.numVat.Size = new System.Drawing.Size(54, 22);
            this.numVat.TabIndex = 144;
            this.numVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numVat.ValueChanged += new System.EventHandler(this.numVat_ValueChanged);
            // 
            // lblEX
            // 
            this.lblEX.AutoSize = true;
            this.lblEX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblEX.Location = new System.Drawing.Point(136, 194);
            this.lblEX.Name = "lblEX";
            this.lblEX.Size = new System.Drawing.Size(0, 14);
            this.lblEX.TabIndex = 147;
            this.lblEX.Visible = false;
            // 
            // frmAddEditCreditorMill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.ControlBox = false;
            this.Controls.Add(this.lblEX);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.numVat);
            this.Controls.Add(this.txtJobCode);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numTotalAmount);
            this.Controls.Add(this.txtCreditorMillName);
            this.Controls.Add(this.cbCreditorMill);
            this.Controls.Add(this.panelWarning);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEmpLastName);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblEmpCode);
            this.Controls.Add(this.lblEmpFirstName);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(500, 450);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "frmAddEditCreditorMill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เพิ่มบันทึกโรงโม่";
            this.Load += new System.EventHandler(this.frmAddEditCreditorMill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTotalAmount)).EndInit();
            this.panelWarning.ResumeLayout(false);
            this.panelWarning.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numVat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTotalAmount;
        private System.Windows.Forms.TextBox txtCreditorMillName;
        private System.Windows.Forms.ComboBox cbCreditorMill;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private System.Windows.Forms.Panel panelWarning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmpLastName;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmpCode;
        private System.Windows.Forms.Label lblEmpFirstName;
        private System.Windows.Forms.TextBox txtJobCode;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown numVat;
        private DevExpress.XtraEditors.SimpleButton btnSaveExit;
        private System.Windows.Forms.Label lblEX;
    }
}