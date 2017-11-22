namespace DogManage_HCMC.GUI_BLL
{
    partial class frmChangePersonInfor
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPersonalInfo = new System.Windows.Forms.GroupBox();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbIDCardNum = new System.Windows.Forms.TextBox();
            this.tbBirthDay = new System.Windows.Forms.TextBox();
            this.cbMale = new System.Windows.Forms.CheckBox();
            this.cbFeMale = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbBankNum = new System.Windows.Forms.Label();
            this.TbBankNumber = new System.Windows.Forms.TextBox();
            this.tbMedicalCode = new System.Windows.Forms.TextBox();
            this.tbBasicSalary = new System.Windows.Forms.TextBox();
            this.tbFringeBenefit = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbDateJoin = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbTypeAcc = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gbPersonalInfo.SuspendLayout();
            this.gbUserInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(157, 19);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(164, 23);
            this.tbName.TabIndex = 0;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(157, 49);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(164, 23);
            this.tbID.TabIndex = 1;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(157, 79);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(164, 23);
            this.tbEmail.TabIndex = 2;
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Location = new System.Drawing.Point(157, 109);
            this.tbPhoneNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(164, 23);
            this.tbPhoneNum.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbPhoneNum);
            this.panel1.Location = new System.Drawing.Point(7, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 148);
            this.panel1.TabIndex = 7;
            // 
            // gbPersonalInfo
            // 
            this.gbPersonalInfo.Controls.Add(this.panel2);
            this.gbPersonalInfo.Controls.Add(this.panel1);
            this.gbPersonalInfo.Location = new System.Drawing.Point(14, 14);
            this.gbPersonalInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPersonalInfo.Name = "gbPersonalInfo";
            this.gbPersonalInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPersonalInfo.Size = new System.Drawing.Size(718, 187);
            this.gbPersonalInfo.TabIndex = 9;
            this.gbPersonalInfo.TabStop = false;
            this.gbPersonalInfo.Text = "Thông tin cá nhân";
            this.gbPersonalInfo.Enter += new System.EventHandler(this.gbPersonalInfo_Enter);
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.panel4);
            this.gbUserInfo.Controls.Add(this.panel3);
            this.gbUserInfo.Location = new System.Drawing.Point(14, 221);
            this.gbUserInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbUserInfo.Size = new System.Drawing.Size(718, 185);
            this.gbUserInfo.TabIndex = 10;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "Thông tin nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số ĐT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbFeMale);
            this.panel2.Controls.Add(this.cbMale);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbAddress);
            this.panel2.Controls.Add(this.tbIDCardNum);
            this.panel2.Controls.Add(this.tbBirthDay);
            this.panel2.Location = new System.Drawing.Point(369, 22);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 148);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số CMND:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Địa chỉ:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(157, 19);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(164, 23);
            this.tbAddress.TabIndex = 0;
            // 
            // tbIDCardNum
            // 
            this.tbIDCardNum.Location = new System.Drawing.Point(157, 49);
            this.tbIDCardNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIDCardNum.Name = "tbIDCardNum";
            this.tbIDCardNum.Size = new System.Drawing.Size(164, 23);
            this.tbIDCardNum.TabIndex = 1;
            // 
            // tbBirthDay
            // 
            this.tbBirthDay.Location = new System.Drawing.Point(157, 79);
            this.tbBirthDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBirthDay.Name = "tbBirthDay";
            this.tbBirthDay.Size = new System.Drawing.Size(164, 23);
            this.tbBirthDay.TabIndex = 2;
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.Location = new System.Drawing.Point(157, 112);
            this.cbMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(51, 21);
            this.cbMale.TabIndex = 9;
            this.cbMale.Text = "Nam";
            this.cbMale.UseVisualStyleBackColor = true;
            this.cbMale.CheckedChanged += new System.EventHandler(this.cbMale_CheckedChanged);
            this.cbMale.CheckStateChanged += new System.EventHandler(this.cbMale_CheckStateChanged);
            // 
            // cbFeMale
            // 
            this.cbFeMale.AutoSize = true;
            this.cbFeMale.Location = new System.Drawing.Point(265, 112);
            this.cbFeMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFeMale.Name = "cbFeMale";
            this.cbFeMale.Size = new System.Drawing.Size(43, 21);
            this.cbFeMale.TabIndex = 10;
            this.cbFeMale.Text = "Nữ";
            this.cbFeMale.UseVisualStyleBackColor = true;
            this.cbFeMale.CheckedChanged += new System.EventHandler(this.cbFeMale_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lbBankNum);
            this.panel3.Controls.Add(this.TbBankNumber);
            this.panel3.Controls.Add(this.tbMedicalCode);
            this.panel3.Controls.Add(this.tbBasicSalary);
            this.panel3.Controls.Add(this.tbFringeBenefit);
            this.panel3.Location = new System.Drawing.Point(7, 24);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 148);
            this.panel3.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 99);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phụ cấp %:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Lương cơ bản:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 43);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Mã số BHYT:";
            // 
            // lbBankNum
            // 
            this.lbBankNum.AutoSize = true;
            this.lbBankNum.Location = new System.Drawing.Point(18, 9);
            this.lbBankNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBankNum.Name = "lbBankNum";
            this.lbBankNum.Size = new System.Drawing.Size(104, 17);
            this.lbBankNum.TabIndex = 5;
            this.lbBankNum.Text = "TK tín dụng:";
            // 
            // TbBankNumber
            // 
            this.TbBankNumber.Location = new System.Drawing.Point(156, 6);
            this.TbBankNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TbBankNumber.Name = "TbBankNumber";
            this.TbBankNumber.Size = new System.Drawing.Size(165, 23);
            this.TbBankNumber.TabIndex = 0;
            // 
            // tbMedicalCode
            // 
            this.tbMedicalCode.Location = new System.Drawing.Point(157, 36);
            this.tbMedicalCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbMedicalCode.Name = "tbMedicalCode";
            this.tbMedicalCode.Size = new System.Drawing.Size(164, 23);
            this.tbMedicalCode.TabIndex = 1;
            // 
            // tbBasicSalary
            // 
            this.tbBasicSalary.Location = new System.Drawing.Point(157, 66);
            this.tbBasicSalary.Margin = new System.Windows.Forms.Padding(4);
            this.tbBasicSalary.Name = "tbBasicSalary";
            this.tbBasicSalary.ReadOnly = true;
            this.tbBasicSalary.Size = new System.Drawing.Size(164, 23);
            this.tbBasicSalary.TabIndex = 2;
            // 
            // tbFringeBenefit
            // 
            this.tbFringeBenefit.Location = new System.Drawing.Point(157, 96);
            this.tbFringeBenefit.Margin = new System.Windows.Forms.Padding(4);
            this.tbFringeBenefit.Name = "tbFringeBenefit";
            this.tbFringeBenefit.ReadOnly = true;
            this.tbFringeBenefit.Size = new System.Drawing.Size(164, 23);
            this.tbFringeBenefit.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.tbDateJoin);
            this.panel4.Controls.Add(this.tbUserName);
            this.panel4.Controls.Add(this.tbTypeAcc);
            this.panel4.Controls.Add(this.tbPass);
            this.panel4.Location = new System.Drawing.Point(369, 24);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 148);
            this.panel4.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 102);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Mật khẩu:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 76);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "Loại TK:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 46);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 17);
            this.label15.TabIndex = 6;
            this.label15.Text = "Tên tài khoản";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 12);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Ngày vào CTY:";
            // 
            // tbDateJoin
            // 
            this.tbDateJoin.Location = new System.Drawing.Point(156, 9);
            this.tbDateJoin.Margin = new System.Windows.Forms.Padding(4);
            this.tbDateJoin.Name = "tbDateJoin";
            this.tbDateJoin.ReadOnly = true;
            this.tbDateJoin.Size = new System.Drawing.Size(165, 23);
            this.tbDateJoin.TabIndex = 0;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(157, 39);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(164, 23);
            this.tbUserName.TabIndex = 1;
            // 
            // tbTypeAcc
            // 
            this.tbTypeAcc.Location = new System.Drawing.Point(157, 69);
            this.tbTypeAcc.Margin = new System.Windows.Forms.Padding(4);
            this.tbTypeAcc.Name = "tbTypeAcc";
            this.tbTypeAcc.ReadOnly = true;
            this.tbTypeAcc.Size = new System.Drawing.Size(164, 23);
            this.tbTypeAcc.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(157, 99);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbPass.Name = "tbPass";
            this.tbPass.ReadOnly = true;
            this.tbPass.Size = new System.Drawing.Size(164, 23);
            this.tbPass.TabIndex = 4;
            // 
            // frmChangePersonInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 419);
            this.Controls.Add(this.gbUserInfo);
            this.Controls.Add(this.gbPersonalInfo);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChangePersonInfor";
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.frmChangePersonInfor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbPersonalInfo.ResumeLayout(false);
            this.gbUserInfo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPersonalInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbFeMale;
        private System.Windows.Forms.CheckBox cbMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbIDCardNum;
        private System.Windows.Forms.TextBox tbBirthDay;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbDateJoin;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbTypeAcc;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbBankNum;
        private System.Windows.Forms.TextBox TbBankNumber;
        private System.Windows.Forms.TextBox tbMedicalCode;
        private System.Windows.Forms.TextBox tbBasicSalary;
        private System.Windows.Forms.TextBox tbFringeBenefit;
    }
}