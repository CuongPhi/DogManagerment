namespace DogManage_HCMC.GUI_BLL
{
    partial class frmAddStaff
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
            this.grbAccount = new System.Windows.Forms.GroupBox();
            this.cbTypeAcc = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbSalary = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbBankNum = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.erP = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbAccount.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erP)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAccount
            // 
            this.grbAccount.Controls.Add(this.cbTypeAcc);
            this.grbAccount.Controls.Add(this.label14);
            this.grbAccount.Controls.Add(this.label15);
            this.grbAccount.Controls.Add(this.tbUserName);
            this.grbAccount.Location = new System.Drawing.Point(255, 19);
            this.grbAccount.Name = "grbAccount";
            this.grbAccount.Size = new System.Drawing.Size(251, 118);
            this.grbAccount.TabIndex = 17;
            this.grbAccount.TabStop = false;
            this.grbAccount.Text = "Thông tin đăng nhập";
            // 
            // cbTypeAcc
            // 
            this.cbTypeAcc.FormattingEnabled = true;
            this.cbTypeAcc.Items.AddRange(new object[] {
            "Accountant",
            "Manager",
            "Starff"});
            this.cbTypeAcc.Location = new System.Drawing.Point(110, 48);
            this.cbTypeAcc.Name = "cbTypeAcc";
            this.cbTypeAcc.Size = new System.Drawing.Size(95, 21);
            this.cbTypeAcc.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 51);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Loại TK:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 27);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Tên đăng nhập:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(110, 20);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(94, 20);
            this.tbUserName.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grbSalary);
            this.groupBox1.Controls.Add(this.grbAccount);
            this.groupBox1.Location = new System.Drawing.Point(74, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 154);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // grbSalary
            // 
            this.grbSalary.Controls.Add(this.numericUpDown1);
            this.grbSalary.Controls.Add(this.tbID);
            this.grbSalary.Controls.Add(this.label9);
            this.grbSalary.Controls.Add(this.label2);
            this.grbSalary.Controls.Add(this.label13);
            this.grbSalary.Controls.Add(this.tbBankNum);
            this.grbSalary.Location = new System.Drawing.Point(9, 19);
            this.grbSalary.Name = "grbSalary";
            this.grbSalary.Size = new System.Drawing.Size(231, 118);
            this.grbSalary.TabIndex = 18;
            this.grbSalary.TabStop = false;
            this.grbSalary.Text = "Thông tin nhân viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Lương cơ bản:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 51);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "TK tín dụng:";
            // 
            // tbBankNum
            // 
            this.tbBankNum.Location = new System.Drawing.Point(109, 48);
            this.tbBankNum.Margin = new System.Windows.Forms.Padding(4);
            this.tbBankNum.Name = "tbBankNum";
            this.tbBankNum.Size = new System.Drawing.Size(95, 20);
            this.tbBankNum.TabIndex = 10;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(108, 20);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(96, 20);
            this.tbID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã số:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 28);
            this.button2.TabIndex = 20;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 28);
            this.button3.TabIndex = 21;
            this.button3.Text = "Xóa hết";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "THÊM NHÂN VIÊN";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(108, 75);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(96, 20);
            this.numericUpDown1.TabIndex = 23;
            // 
            // erP
            // 
            this.erP.ContainerControl = this;
            // 
            // frmAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 306);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddStaff";
            this.Text = "frmAddStaff";
            this.grbAccount.ResumeLayout(false);
            this.grbAccount.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grbSalary.ResumeLayout(false);
            this.grbSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAccount;
        private System.Windows.Forms.ComboBox cbTypeAcc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbSalary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbBankNum;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider erP;
    }
}