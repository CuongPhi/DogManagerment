namespace DogManage_HCMC.GUI_BLL
{
    partial class frmAddDog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbFoodMoney = new System.Windows.Forms.TextBox();
            this.dtpkOut = new System.Windows.Forms.DateTimePicker();
            this.rdbtnNo = new System.Windows.Forms.RadioButton();
            this.rdbtnYes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpkIn = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.nmrudDayDetroy = new System.Windows.Forms.NumericUpDown();
            this.nmrudweigth = new System.Windows.Forms.NumericUpDown();
            this.rdbtnType3 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbtnType2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbtnType1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearALL = new System.Windows.Forms.Button();
            this.btnEditTimeDetroy = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrudDayDetroy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrudweigth)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbFoodMoney);
            this.panel1.Controls.Add(this.dtpkOut);
            this.panel1.Controls.Add(this.rdbtnNo);
            this.panel1.Controls.Add(this.rdbtnYes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(268, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 115);
            this.panel1.TabIndex = 0;
            // 
            // tbFoodMoney
            // 
            this.tbFoodMoney.Location = new System.Drawing.Point(119, 48);
            this.tbFoodMoney.Name = "tbFoodMoney";
            this.tbFoodMoney.Size = new System.Drawing.Size(128, 20);
            this.tbFoodMoney.TabIndex = 14;
            this.tbFoodMoney.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbFoodMoney_MouseClick);
            this.tbFoodMoney.TabStopChanged += new System.EventHandler(this.tbFoodMoney_TabStopChanged);
            this.tbFoodMoney.TextChanged += new System.EventHandler(this.tbFoodMoney_TextChanged_1);
            this.tbFoodMoney.Enter += new System.EventHandler(this.tbFoodMoney_Enter);
            this.tbFoodMoney.Validated += new System.EventHandler(this.tbFoodMoney_Validated);
            // 
            // dtpkOut
            // 
            this.dtpkOut.Enabled = false;
            this.dtpkOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkOut.Location = new System.Drawing.Point(119, 80);
            this.dtpkOut.Name = "dtpkOut";
            this.dtpkOut.Size = new System.Drawing.Size(128, 20);
            this.dtpkOut.TabIndex = 13;
            // 
            // rdbtnNo
            // 
            this.rdbtnNo.AutoSize = true;
            this.rdbtnNo.Checked = true;
            this.rdbtnNo.Location = new System.Drawing.Point(197, 14);
            this.rdbtnNo.Name = "rdbtnNo";
            this.rdbtnNo.Size = new System.Drawing.Size(50, 17);
            this.rdbtnNo.TabIndex = 7;
            this.rdbtnNo.TabStop = true;
            this.rdbtnNo.Text = "Chưa";
            this.rdbtnNo.UseVisualStyleBackColor = true;
            // 
            // rdbtnYes
            // 
            this.rdbtnYes.AutoSize = true;
            this.rdbtnYes.Location = new System.Drawing.Point(119, 14);
            this.rdbtnYes.Name = "rdbtnYes";
            this.rdbtnYes.Size = new System.Drawing.Size(61, 17);
            this.rdbtnYes.TabIndex = 6;
            this.rdbtnYes.Text = "Đã tiêm";
            this.rdbtnYes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày ra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thức ăn (VNĐ):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêm phòng:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(56, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chó";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpkIn);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.nmrudDayDetroy);
            this.panel2.Controls.Add(this.nmrudweigth);
            this.panel2.Controls.Add(this.rdbtnType3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.rdbtnType2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.rdbtnType1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(6, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 115);
            this.panel2.TabIndex = 0;
            // 
            // dtpkIn
            // 
            this.dtpkIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkIn.Location = new System.Drawing.Point(103, 80);
            this.dtpkIn.Name = "dtpkIn";
            this.dtpkIn.Size = new System.Drawing.Size(131, 20);
            this.dtpkIn.TabIndex = 4;
            this.dtpkIn.ValueChanged += new System.EventHandler(this.dtpkIn_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tiêu hủy: ";
            // 
            // nmrudDayDetroy
            // 
            this.nmrudDayDetroy.Enabled = false;
            this.nmrudDayDetroy.Location = new System.Drawing.Point(199, 47);
            this.nmrudDayDetroy.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nmrudDayDetroy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrudDayDetroy.Name = "nmrudDayDetroy";
            this.nmrudDayDetroy.ReadOnly = true;
            this.nmrudDayDetroy.Size = new System.Drawing.Size(35, 20);
            this.nmrudDayDetroy.TabIndex = 11;
            this.nmrudDayDetroy.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nmrudDayDetroy.ValueChanged += new System.EventHandler(this.nmrudDayDetroy_ValueChanged);
            // 
            // nmrudweigth
            // 
            this.nmrudweigth.Location = new System.Drawing.Point(103, 47);
            this.nmrudweigth.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nmrudweigth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrudweigth.Name = "nmrudweigth";
            this.nmrudweigth.Size = new System.Drawing.Size(36, 20);
            this.nmrudweigth.TabIndex = 4;
            this.nmrudweigth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rdbtnType3
            // 
            this.rdbtnType3.AutoSize = true;
            this.rdbtnType3.Location = new System.Drawing.Point(203, 14);
            this.rdbtnType3.Name = "rdbtnType3";
            this.rdbtnType3.Size = new System.Drawing.Size(31, 17);
            this.rdbtnType3.TabIndex = 10;
            this.rdbtnType3.Text = "3";
            this.rdbtnType3.UseVisualStyleBackColor = true;
            this.rdbtnType3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nặng (kg):";
            // 
            // rdbtnType2
            // 
            this.rdbtnType2.AutoSize = true;
            this.rdbtnType2.Checked = true;
            this.rdbtnType2.Location = new System.Drawing.Point(148, 14);
            this.rdbtnType2.Name = "rdbtnType2";
            this.rdbtnType2.Size = new System.Drawing.Size(31, 17);
            this.rdbtnType2.TabIndex = 9;
            this.rdbtnType2.TabStop = true;
            this.rdbtnType2.Text = "2";
            this.rdbtnType2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày vào:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 0;
            // 
            // rdbtnType1
            // 
            this.rdbtnType1.AutoSize = true;
            this.rdbtnType1.Location = new System.Drawing.Point(103, 14);
            this.rdbtnType1.Name = "rdbtnType1";
            this.rdbtnType1.Size = new System.Drawing.Size(31, 17);
            this.rdbtnType1.TabIndex = 8;
            this.rdbtnType1.Text = "1";
            this.rdbtnType1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Loại";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(165, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 37);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm chó";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(410, 236);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Hủy bỏ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearALL
            // 
            this.btnClearALL.Location = new System.Drawing.Point(328, 236);
            this.btnClearALL.Name = "btnClearALL";
            this.btnClearALL.Size = new System.Drawing.Size(76, 37);
            this.btnClearALL.TabIndex = 4;
            this.btnClearALL.Text = "Clear All";
            this.btnClearALL.UseVisualStyleBackColor = true;
            this.btnClearALL.Click += new System.EventHandler(this.btnClearALL_Click);
            // 
            // btnEditTimeDetroy
            // 
            this.btnEditTimeDetroy.Location = new System.Drawing.Point(247, 236);
            this.btnEditTimeDetroy.Name = "btnEditTimeDetroy";
            this.btnEditTimeDetroy.Size = new System.Drawing.Size(75, 37);
            this.btnEditTimeDetroy.TabIndex = 5;
            this.btnEditTimeDetroy.Text = "Set time detroy";
            this.btnEditTimeDetroy.UseVisualStyleBackColor = true;
            this.btnEditTimeDetroy.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(215, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "THÊM CHÓ BỊ BẮT";
            // 
            // frmAddDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(672, 312);
            this.Controls.Add(this.btnClearALL);
            this.Controls.Add(this.btnEditTimeDetroy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddDog";
            this.Text = "Thêm chó";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrudDayDetroy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrudweigth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnNo;
        private System.Windows.Forms.RadioButton rdbtnYes;
        private System.Windows.Forms.Button btnEditTimeDetroy;
        private System.Windows.Forms.Button btnClearALL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmrudDayDetroy;
        private System.Windows.Forms.NumericUpDown nmrudweigth;
        private System.Windows.Forms.RadioButton rdbtnType3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbtnType2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbtnType1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpkOut;
        private System.Windows.Forms.DateTimePicker dtpkIn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbFoodMoney;
    }
}