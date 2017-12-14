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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePersonInfor));
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFeMale = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSave4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIDCardNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbBankNum = new System.Windows.Forms.Label();
            this.tbMedicalCode = new System.Windows.Forms.TextBox();
            this.TbBankNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPersonalInfo = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grbSetAll = new System.Windows.Forms.GroupBox();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSave3 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbDateJoin = new System.Windows.Forms.TextBox();
            this.tbTypeAcc = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbBasicSalary = new System.Windows.Forms.TextBox();
            this.tbFringeBenefit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbPersonalInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbSetAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbUserInfo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(149, 28);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(162, 23);
            this.tbName.TabIndex = 0;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(149, 58);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(162, 23);
            this.tbID.TabIndex = 1;
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Location = new System.Drawing.Point(146, 57);
            this.tbPhoneNum.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(164, 23);
            this.tbPhoneNum.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbFeMale);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnSave4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbIDCardNum);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbAddress);
            this.panel1.Controls.Add(this.tbPhoneNum);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Location = new System.Drawing.Point(8, 209);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 208);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbFeMale
            // 
            this.cbFeMale.AutoSize = true;
            this.cbFeMale.Location = new System.Drawing.Point(267, 29);
            this.cbFeMale.Name = "cbFeMale";
            this.cbFeMale.Size = new System.Drawing.Size(43, 21);
            this.cbFeMale.TabIndex = 15;
            this.cbFeMale.Text = "Nữ";
            this.cbFeMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 23);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // btnSave4
            // 
            this.btnSave4.Location = new System.Drawing.Point(19, 178);
            this.btnSave4.Name = "btnSave4";
            this.btnSave4.Size = new System.Drawing.Size(75, 23);
            this.btnSave4.TabIndex = 13;
            this.btnSave4.Text = "Save";
            this.btnSave4.UseVisualStyleBackColor = true;
            this.btnSave4.Click += new System.EventHandler(this.btnSave4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số ĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số CMND:";
            // 
            // tbIDCardNum
            // 
            this.tbIDCardNum.Location = new System.Drawing.Point(146, 116);
            this.tbIDCardNum.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDCardNum.Name = "tbIDCardNum";
            this.tbIDCardNum.Size = new System.Drawing.Size(164, 23);
            this.tbIDCardNum.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Địa chỉ:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(146, 146);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(164, 53);
            this.tbAddress.TabIndex = 0;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(146, 86);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(164, 23);
            this.tbEmail.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 58);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Mã số BHYT:";
            // 
            // lbBankNum
            // 
            this.lbBankNum.AutoSize = true;
            this.lbBankNum.Location = new System.Drawing.Point(18, 27);
            this.lbBankNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBankNum.Name = "lbBankNum";
            this.lbBankNum.Size = new System.Drawing.Size(104, 17);
            this.lbBankNum.TabIndex = 5;
            this.lbBankNum.Text = "TK tín dụng:";
            // 
            // tbMedicalCode
            // 
            this.tbMedicalCode.Location = new System.Drawing.Point(144, 56);
            this.tbMedicalCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbMedicalCode.Name = "tbMedicalCode";
            this.tbMedicalCode.Size = new System.Drawing.Size(165, 23);
            this.tbMedicalCode.TabIndex = 1;
            // 
            // TbBankNumber
            // 
            this.TbBankNumber.Location = new System.Drawing.Point(144, 24);
            this.TbBankNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TbBankNumber.Name = "TbBankNumber";
            this.TbBankNumber.ReadOnly = true;
            this.TbBankNumber.Size = new System.Drawing.Size(165, 23);
            this.TbBankNumber.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã số:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ Tên:";
            // 
            // gbPersonalInfo
            // 
            this.gbPersonalInfo.Controls.Add(this.panel2);
            this.gbPersonalInfo.Controls.Add(this.panel1);
            this.gbPersonalInfo.Location = new System.Drawing.Point(444, 76);
            this.gbPersonalInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbPersonalInfo.Name = "gbPersonalInfo";
            this.gbPersonalInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbPersonalInfo.Size = new System.Drawing.Size(366, 425);
            this.gbPersonalInfo.TabIndex = 9;
            this.gbPersonalInfo.TabStop = false;
            this.gbPersonalInfo.Text = "Thông tin cá nhân";
            this.gbPersonalInfo.Enter += new System.EventHandler(this.gbPersonalInfo_Enter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel2.Controls.Add(this.grbSetAll);
            this.panel2.Controls.Add(this.btnSave2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(8, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 173);
            this.panel2.TabIndex = 9;
            // 
            // grbSetAll
            // 
            this.grbSetAll.BackColor = System.Drawing.Color.NavajoWhite;
            this.grbSetAll.Controls.Add(this.btnSaveAll);
            this.grbSetAll.Controls.Add(this.btnReset);
            this.grbSetAll.Controls.Add(this.btnClearAll);
            this.grbSetAll.Location = new System.Drawing.Point(20, 11);
            this.grbSetAll.Name = "grbSetAll";
            this.grbSetAll.Size = new System.Drawing.Size(122, 126);
            this.grbSetAll.TabIndex = 15;
            this.grbSetAll.TabStop = false;
            this.grbSetAll.Text = "Sửa tất cả ";
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(15, 92);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(90, 25);
            this.btnSaveAll.TabIndex = 15;
            this.btnSaveAll.Text = "Save All";
            this.toolTip1.SetToolTip(this.btnSaveAll, "Lưu lại tất cả thông tin");
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(15, 32);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 25);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset All";
            this.toolTip1.SetToolTip(this.btnReset, "Reset lại thông tin ban đầu");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(15, 61);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(90, 25);
            this.btnClearAll.TabIndex = 14;
            this.btnClearAll.Text = "Clear All";
            this.toolTip1.SetToolTip(this.btnClearAll, "Xóa hết các ô ");
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(20, 147);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(75, 23);
            this.btnSave2.TabIndex = 12;
            this.btnSave2.Text = "Save";
            this.toolTip1.SetToolTip(this.btnSave2, "Lưu hảnh đại diện của bạn");
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Moccasin;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(148, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.panel4);
            this.gbUserInfo.Controls.Add(this.panel3);
            this.gbUserInfo.Location = new System.Drawing.Point(79, 76);
            this.gbUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbUserInfo.Size = new System.Drawing.Size(357, 425);
            this.gbUserInfo.TabIndex = 10;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "Thông tin nhân viên";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnSave3);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.lbBankNum);
            this.panel4.Controls.Add(this.TbBankNumber);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.tbUserName);
            this.panel4.Controls.Add(this.tbMedicalCode);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.tbDateJoin);
            this.panel4.Controls.Add(this.tbTypeAcc);
            this.panel4.Location = new System.Drawing.Point(9, 209);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(338, 207);
            this.panel4.TabIndex = 10;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnSave3
            // 
            this.btnSave3.Location = new System.Drawing.Point(231, 177);
            this.btnSave3.Name = "btnSave3";
            this.btnSave3.Size = new System.Drawing.Size(75, 23);
            this.btnSave3.TabIndex = 13;
            this.btnSave3.Text = "Save";
            this.toolTip1.SetToolTip(this.btnSave3, "2222222222222222222");
            this.btnSave3.UseVisualStyleBackColor = true;
            this.btnSave3.Click += new System.EventHandler(this.btnSave3_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 115);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "Loại TK:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 87);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 17);
            this.label15.TabIndex = 6;
            this.label15.Text = "Tên tài khoản";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(144, 84);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(164, 23);
            this.tbUserName.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 146);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Ngày vào CTY:";
            // 
            // tbDateJoin
            // 
            this.tbDateJoin.Location = new System.Drawing.Point(144, 143);
            this.tbDateJoin.Margin = new System.Windows.Forms.Padding(4);
            this.tbDateJoin.Name = "tbDateJoin";
            this.tbDateJoin.ReadOnly = true;
            this.tbDateJoin.Size = new System.Drawing.Size(164, 23);
            this.tbDateJoin.TabIndex = 0;
            // 
            // tbTypeAcc
            // 
            this.tbTypeAcc.Location = new System.Drawing.Point(144, 114);
            this.tbTypeAcc.Margin = new System.Windows.Forms.Padding(4);
            this.tbTypeAcc.Name = "tbTypeAcc";
            this.tbTypeAcc.ReadOnly = true;
            this.tbTypeAcc.Size = new System.Drawing.Size(164, 23);
            this.tbTypeAcc.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnSave1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbName);
            this.panel3.Controls.Add(this.tbBasicSalary);
            this.panel3.Controls.Add(this.tbID);
            this.panel3.Controls.Add(this.tbFringeBenefit);
            this.panel3.Location = new System.Drawing.Point(7, 20);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 173);
            this.panel3.TabIndex = 8;
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(236, 146);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(75, 23);
            this.btnSave1.TabIndex = 13;
            this.btnSave1.Text = "Save";
            this.toolTip1.SetToolTip(this.btnSave1, "Lưu lại Họ và Tên");
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phụ cấp %:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 92);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Lương cơ bản:";
            // 
            // tbBasicSalary
            // 
            this.tbBasicSalary.Location = new System.Drawing.Point(149, 86);
            this.tbBasicSalary.Margin = new System.Windows.Forms.Padding(4);
            this.tbBasicSalary.Name = "tbBasicSalary";
            this.tbBasicSalary.ReadOnly = true;
            this.tbBasicSalary.Size = new System.Drawing.Size(162, 23);
            this.tbBasicSalary.TabIndex = 2;
            // 
            // tbFringeBenefit
            // 
            this.tbFringeBenefit.Location = new System.Drawing.Point(149, 116);
            this.tbFringeBenefit.Margin = new System.Windows.Forms.Padding(4);
            this.tbFringeBenefit.Name = "tbFringeBenefit";
            this.tbFringeBenefit.ReadOnly = true;
            this.tbFringeBenefit.Size = new System.Drawing.Size(162, 23);
            this.tbFringeBenefit.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.MediumBlue;
            this.label12.Location = new System.Drawing.Point(278, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(348, 26);
            this.label12.TabIndex = 11;
            this.label12.Text = "THÔNG TIN CÁ NHÂN NHÂN VIÊN ";
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.SystemColors.Control;
            this.btnOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOut.BackgroundImage")));
            this.btnOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOut.Location = new System.Drawing.Point(12, 12);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(48, 43);
            this.btnOut.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnOut, "Thoát");
            this.btnOut.UseMnemonic = false;
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // frmChangePersonInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(887, 514);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gbUserInfo);
            this.Controls.Add(this.gbPersonalInfo);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChangePersonInfor";
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.frmChangePersonInfor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbPersonalInfo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.grbSetAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbUserInfo.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPersonalInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIDCardNum;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbDateJoin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbBankNum;
        private System.Windows.Forms.TextBox TbBankNumber;
        private System.Windows.Forms.TextBox tbMedicalCode;
        private System.Windows.Forms.TextBox tbBasicSalary;
        private System.Windows.Forms.TextBox tbFringeBenefit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbTypeAcc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button btnSave4;
        private System.Windows.Forms.Button btnSave3;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox cbFeMale;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grbSetAll;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnOut;
    }
}