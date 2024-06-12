namespace CS.BNP.App.EmployeeSecurity
{
    partial class frmAddEditEmployeeSecurity
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEmpCode = new System.Windows.Forms.Label();
            this.txtEmpCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveExit = new System.Windows.Forms.Button();
            this.lblEmpFirstName = new System.Windows.Forms.Label();
            this.txtEmpFirstName = new System.Windows.Forms.TextBox();
            this.lblEmpLastName = new System.Windows.Forms.Label();
            this.txtEmpLastName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.chkListFunction = new System.Windows.Forms.CheckedListBox();
            this.lblChkList = new System.Windows.Forms.Label();
            this.panelWarning = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkIsApprove = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbApp = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.panel2.SuspendLayout();
            this.panelWarning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbApp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(404, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "ออก";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(149, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "บันทึกข้อมูล";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblEmpCode
            // 
            this.lblEmpCode.AutoSize = true;
            this.lblEmpCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblEmpCode.Location = new System.Drawing.Point(12, 43);
            this.lblEmpCode.Name = "lblEmpCode";
            this.lblEmpCode.Size = new System.Drawing.Size(67, 14);
            this.lblEmpCode.TabIndex = 8;
            this.lblEmpCode.Text = "รหัสพนักงาน";
            // 
            // txtEmpCode
            // 
            this.txtEmpCode.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtEmpCode.Location = new System.Drawing.Point(15, 59);
            this.txtEmpCode.MaxLength = 10;
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.Size = new System.Drawing.Size(215, 24);
            this.txtEmpCode.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 30);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.btnSaveExit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 40);
            this.panel2.TabIndex = 13;
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSaveExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveExit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSaveExit.ForeColor = System.Drawing.Color.White;
            this.btnSaveExit.Location = new System.Drawing.Point(276, 7);
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(121, 25);
            this.btnSaveExit.TabIndex = 1;
            this.btnSaveExit.Text = "บันทึกและออก";
            this.btnSaveExit.UseVisualStyleBackColor = false;
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // lblEmpFirstName
            // 
            this.lblEmpFirstName.AutoSize = true;
            this.lblEmpFirstName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblEmpFirstName.Location = new System.Drawing.Point(12, 97);
            this.lblEmpFirstName.Name = "lblEmpFirstName";
            this.lblEmpFirstName.Size = new System.Drawing.Size(62, 14);
            this.lblEmpFirstName.TabIndex = 15;
            this.lblEmpFirstName.Text = "ชื่อพนักงาน";
            // 
            // txtEmpFirstName
            // 
            this.txtEmpFirstName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtEmpFirstName.Location = new System.Drawing.Point(15, 113);
            this.txtEmpFirstName.MaxLength = 50;
            this.txtEmpFirstName.Name = "txtEmpFirstName";
            this.txtEmpFirstName.Size = new System.Drawing.Size(215, 24);
            this.txtEmpFirstName.TabIndex = 1;
            // 
            // lblEmpLastName
            // 
            this.lblEmpLastName.AutoSize = true;
            this.lblEmpLastName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblEmpLastName.Location = new System.Drawing.Point(12, 150);
            this.lblEmpLastName.Name = "lblEmpLastName";
            this.lblEmpLastName.Size = new System.Drawing.Size(88, 14);
            this.lblEmpLastName.TabIndex = 17;
            this.lblEmpLastName.Text = "นามสกุลพนักงาน";
            // 
            // txtEmpLastName
            // 
            this.txtEmpLastName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtEmpLastName.Location = new System.Drawing.Point(15, 166);
            this.txtEmpLastName.MaxLength = 50;
            this.txtEmpLastName.Name = "txtEmpLastName";
            this.txtEmpLastName.Size = new System.Drawing.Size(215, 24);
            this.txtEmpLastName.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPassword.Location = new System.Drawing.Point(247, 97);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 14);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "รหัสผ่าน (Password)";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtPassword.Location = new System.Drawing.Point(250, 113);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = 'x';
            this.txtPassword.Size = new System.Drawing.Size(215, 24);
            this.txtPassword.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblUsername.Location = new System.Drawing.Point(247, 43);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(134, 14);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "รหัสผู้ใช้งาน (Username)";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtUsername.Location = new System.Drawing.Point(250, 59);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(215, 24);
            this.txtUsername.TabIndex = 3;
            // 
            // chkListFunction
            // 
            this.chkListFunction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkListFunction.CheckOnClick = true;
            this.chkListFunction.Items.AddRange(new object[] {
            "ความปลอดภัย",
            "การตั้งค่าระบบ",
            "การบันทึกรายการ",
            "การออกรายงาน",
            "สิทธิ์ผู้ดูแลระบบ (Admin)"});
            this.chkListFunction.Location = new System.Drawing.Point(270, 168);
            this.chkListFunction.Name = "chkListFunction";
            this.chkListFunction.Size = new System.Drawing.Size(180, 102);
            this.chkListFunction.TabIndex = 5;
            // 
            // lblChkList
            // 
            this.lblChkList.AutoSize = true;
            this.lblChkList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblChkList.Location = new System.Drawing.Point(247, 149);
            this.lblChkList.Name = "lblChkList";
            this.lblChkList.Size = new System.Drawing.Size(106, 14);
            this.lblChkList.TabIndex = 23;
            this.lblChkList.Text = "เลือกสิทธิ์การทำงาน";
            // 
            // panelWarning
            // 
            this.panelWarning.BackColor = System.Drawing.Color.LightCoral;
            this.panelWarning.Controls.Add(this.label1);
            this.panelWarning.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelWarning.Location = new System.Drawing.Point(0, 286);
            this.panelWarning.Name = "panelWarning";
            this.panelWarning.Size = new System.Drawing.Size(484, 35);
            this.panelWarning.TabIndex = 24;
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
            // chkIsApprove
            // 
            this.chkIsApprove.AutoSize = true;
            this.chkIsApprove.Location = new System.Drawing.Point(108, 202);
            this.chkIsApprove.Name = "chkIsApprove";
            this.chkIsApprove.Size = new System.Drawing.Size(121, 18);
            this.chkIsApprove.TabIndex = 25;
            this.chkIsApprove.Text = "ต้องมีการ Approve";
            this.chkIsApprove.UseVisualStyleBackColor = true;
            this.chkIsApprove.CheckedChanged += new System.EventHandler(this.chkIsApprove_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(15, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 26;
            this.label2.Text = "Approve โดย";
            // 
            // cbApp
            // 
            this.cbApp.Location = new System.Drawing.Point(15, 226);
            this.cbApp.Name = "cbApp";
            this.cbApp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cbApp.Properties.Appearance.Options.UseFont = true;
            this.cbApp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbApp.Size = new System.Drawing.Size(214, 24);
            this.cbApp.TabIndex = 28;
            // 
            // frmAddEditEmployeeSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.ControlBox = false;
            this.Controls.Add(this.cbApp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkIsApprove);
            this.Controls.Add(this.panelWarning);
            this.Controls.Add(this.lblChkList);
            this.Controls.Add(this.chkListFunction);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblEmpLastName);
            this.Controls.Add(this.txtEmpLastName);
            this.Controls.Add(this.lblEmpFirstName);
            this.Controls.Add(this.txtEmpFirstName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEmpCode);
            this.Controls.Add(this.txtEmpCode);
            this.Controls.Add(this.txtPassword);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "frmAddEditEmployeeSecurity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เพิ่มและแก้ไขข้อมูลพนักงานและผู้ใช้งาน";
            this.Load += new System.EventHandler(this.frmAddEditEmployeeSecurity_Load);
            this.panel2.ResumeLayout(false);
            this.panelWarning.ResumeLayout(false);
            this.panelWarning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbApp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEmpCode;
        private System.Windows.Forms.TextBox txtEmpCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSaveExit;
        private System.Windows.Forms.Label lblEmpFirstName;
        private System.Windows.Forms.TextBox txtEmpFirstName;
        private System.Windows.Forms.Label lblEmpLastName;
        private System.Windows.Forms.TextBox txtEmpLastName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.CheckedListBox chkListFunction;
        private System.Windows.Forms.Label lblChkList;
        private System.Windows.Forms.Panel panelWarning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkIsApprove;
        private System.Windows.Forms.Label label2;
		private DevExpress.XtraEditors.CheckedComboBoxEdit cbApp;
	}
}