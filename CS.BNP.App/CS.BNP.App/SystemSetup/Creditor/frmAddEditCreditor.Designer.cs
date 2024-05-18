namespace CS.BNP.App.SystemSetup.Creditor
{
    partial class frmAddEditCreditor
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
			this.panelWarning = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.txtCreditorTel = new System.Windows.Forms.TextBox();
			this.lblEmpLastName = new System.Windows.Forms.Label();
			this.txtCreditorName = new System.Windows.Forms.TextBox();
			this.txtCreditorAddress = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnSaveExit = new System.Windows.Forms.Button();
			this.txtCreditorContact = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblEmpCode = new System.Windows.Forms.Label();
			this.txtCreditorCode = new System.Windows.Forms.TextBox();
			this.lblEmpFirstName = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCreditorTaxID = new System.Windows.Forms.TextBox();
			this.panelWarning.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelWarning
			// 
			this.panelWarning.BackColor = System.Drawing.Color.LightCoral;
			this.panelWarning.Controls.Add(this.label1);
			this.panelWarning.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelWarning.Location = new System.Drawing.Point(0, 286);
			this.panelWarning.Name = "panelWarning";
			this.panelWarning.Size = new System.Drawing.Size(484, 35);
			this.panelWarning.TabIndex = 65;
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
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblPassword.Location = new System.Drawing.Point(12, 96);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(42, 14);
			this.lblPassword.TabIndex = 64;
			this.lblPassword.Text = "ผู้ติดต่อ";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblUsername.Location = new System.Drawing.Point(247, 96);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(74, 14);
			this.lblUsername.TabIndex = 63;
			this.lblUsername.Text = "เบอร์โทรศัพท์";
			// 
			// txtCreditorTel
			// 
			this.txtCreditorTel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtCreditorTel.Location = new System.Drawing.Point(250, 112);
			this.txtCreditorTel.MaxLength = 10;
			this.txtCreditorTel.Name = "txtCreditorTel";
			this.txtCreditorTel.Size = new System.Drawing.Size(215, 24);
			this.txtCreditorTel.TabIndex = 3;
			// 
			// lblEmpLastName
			// 
			this.lblEmpLastName.AutoSize = true;
			this.lblEmpLastName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblEmpLastName.Location = new System.Drawing.Point(12, 192);
			this.lblEmpLastName.Name = "lblEmpLastName";
			this.lblEmpLastName.Size = new System.Drawing.Size(30, 14);
			this.lblEmpLastName.TabIndex = 62;
			this.lblEmpLastName.Text = "ที่อยู่";
			// 
			// txtCreditorName
			// 
			this.txtCreditorName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtCreditorName.Location = new System.Drawing.Point(250, 59);
			this.txtCreditorName.MaxLength = 100;
			this.txtCreditorName.Name = "txtCreditorName";
			this.txtCreditorName.Size = new System.Drawing.Size(215, 24);
			this.txtCreditorName.TabIndex = 1;
			// 
			// txtCreditorAddress
			// 
			this.txtCreditorAddress.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtCreditorAddress.Location = new System.Drawing.Point(15, 208);
			this.txtCreditorAddress.MaxLength = 500;
			this.txtCreditorAddress.Multiline = true;
			this.txtCreditorAddress.Name = "txtCreditorAddress";
			this.txtCreditorAddress.Size = new System.Drawing.Size(450, 57);
			this.txtCreditorAddress.TabIndex = 5;
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
			this.panel2.TabIndex = 60;
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
			// txtCreditorContact
			// 
			this.txtCreditorContact.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtCreditorContact.Location = new System.Drawing.Point(15, 112);
			this.txtCreditorContact.MaxLength = 10;
			this.txtCreditorContact.Name = "txtCreditorContact";
			this.txtCreditorContact.Size = new System.Drawing.Size(215, 24);
			this.txtCreditorContact.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkCyan;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(484, 30);
			this.panel1.TabIndex = 59;
			// 
			// lblEmpCode
			// 
			this.lblEmpCode.AutoSize = true;
			this.lblEmpCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblEmpCode.Location = new System.Drawing.Point(12, 43);
			this.lblEmpCode.Name = "lblEmpCode";
			this.lblEmpCode.Size = new System.Drawing.Size(59, 14);
			this.lblEmpCode.TabIndex = 58;
			this.lblEmpCode.Text = "รหัสเจ้าหนี้";
			// 
			// txtCreditorCode
			// 
			this.txtCreditorCode.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtCreditorCode.Location = new System.Drawing.Point(15, 59);
			this.txtCreditorCode.MaxLength = 20;
			this.txtCreditorCode.Name = "txtCreditorCode";
			this.txtCreditorCode.Size = new System.Drawing.Size(215, 24);
			this.txtCreditorCode.TabIndex = 0;
			// 
			// lblEmpFirstName
			// 
			this.lblEmpFirstName.AutoSize = true;
			this.lblEmpFirstName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lblEmpFirstName.Location = new System.Drawing.Point(247, 43);
			this.lblEmpFirstName.Name = "lblEmpFirstName";
			this.lblEmpFirstName.Size = new System.Drawing.Size(54, 14);
			this.lblEmpFirstName.TabIndex = 61;
			this.lblEmpFirstName.Text = "ชื่อเจ้าหนี้";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label2.Location = new System.Drawing.Point(12, 146);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 14);
			this.label2.TabIndex = 67;
			this.label2.Text = "เลขประจำตัวผู้เสียภาษี";
			// 
			// txtCreditorTaxID
			// 
			this.txtCreditorTaxID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtCreditorTaxID.Location = new System.Drawing.Point(15, 162);
			this.txtCreditorTaxID.MaxLength = 20;
			this.txtCreditorTaxID.Name = "txtCreditorTaxID";
			this.txtCreditorTaxID.Size = new System.Drawing.Size(450, 24);
			this.txtCreditorTaxID.TabIndex = 4;
			// 
			// frmAddEditCreditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(484, 361);
			this.ControlBox = false;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCreditorTaxID);
			this.Controls.Add(this.panelWarning);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.txtCreditorTel);
			this.Controls.Add(this.lblEmpLastName);
			this.Controls.Add(this.txtCreditorName);
			this.Controls.Add(this.txtCreditorAddress);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.txtCreditorContact);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblEmpCode);
			this.Controls.Add(this.txtCreditorCode);
			this.Controls.Add(this.lblEmpFirstName);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximumSize = new System.Drawing.Size(500, 400);
			this.MinimumSize = new System.Drawing.Size(500, 400);
			this.Name = "frmAddEditCreditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "เพิ่มแก้ไขข้อมูลเจ้าหนี้";
			this.Load += new System.EventHandler(this.frmAddEditCreditor_Load);
			this.panelWarning.ResumeLayout(false);
			this.panelWarning.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWarning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtCreditorTel;
        private System.Windows.Forms.Label lblEmpLastName;
        private System.Windows.Forms.TextBox txtCreditorName;
        private System.Windows.Forms.TextBox txtCreditorAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSaveExit;
        private System.Windows.Forms.TextBox txtCreditorContact;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmpCode;
        private System.Windows.Forms.TextBox txtCreditorCode;
        private System.Windows.Forms.Label lblEmpFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCreditorTaxID;
    }
}