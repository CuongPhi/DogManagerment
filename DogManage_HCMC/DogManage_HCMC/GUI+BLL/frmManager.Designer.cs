namespace DogManage_HCMC
{
    partial class frmManager
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
            this.tabp = new System.Windows.Forms.TabControl();
            this.tabpAccount = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grbChoosingAcc = new System.Windows.Forms.GroupBox();
            this.btnResetPassW = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbPassW = new System.Windows.Forms.TextBox();
            this.lbPassW = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.lbname = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbbTypeAcc = new System.Windows.Forms.ComboBox();
            this.lbTypeAcc = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbAccName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewListAcc = new System.Windows.Forms.Button();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.btnDelAcc = new System.Windows.Forms.Button();
            this.btnEditAcc = new System.Windows.Forms.Button();
            this.tbFindAcc = new System.Windows.Forms.TextBox();
            this.dtgvAllAcc = new System.Windows.Forms.DataGridView();
            this.tabPageMenu = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.grbListStaff = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbFindUser = new System.Windows.Forms.TextBox();
            this.lbLoginning = new System.Windows.Forms.Label();
            this.lbDisplayName = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.tabp.SuspendLayout();
            this.tabpAccount.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbChoosingAcc.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAllAcc)).BeginInit();
            this.tabPageMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.grbListStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabp
            // 
            this.tabp.Controls.Add(this.tabpAccount);
            this.tabp.Controls.Add(this.tabPageMenu);
            this.tabp.Location = new System.Drawing.Point(12, 12);
            this.tabp.Name = "tabp";
            this.tabp.SelectedIndex = 0;
            this.tabp.Size = new System.Drawing.Size(864, 414);
            this.tabp.TabIndex = 0;
            // 
            // tabpAccount
            // 
            this.tabpAccount.AutoScroll = true;
            this.tabpAccount.Controls.Add(this.panel2);
            this.tabpAccount.Controls.Add(this.panel1);
            this.tabpAccount.Controls.Add(this.dtgvAllAcc);
            this.tabpAccount.Location = new System.Drawing.Point(4, 22);
            this.tabpAccount.Name = "tabpAccount";
            this.tabpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabpAccount.Size = new System.Drawing.Size(856, 388);
            this.tabpAccount.TabIndex = 0;
            this.tabpAccount.Text = "Tài khoản";
            this.tabpAccount.UseVisualStyleBackColor = true;
            this.tabpAccount.Click += new System.EventHandler(this.tabpAccount_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grbChoosingAcc);
            this.panel2.Location = new System.Drawing.Point(489, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 341);
            this.panel2.TabIndex = 9;
            // 
            // grbChoosingAcc
            // 
            this.grbChoosingAcc.BackColor = System.Drawing.SystemColors.Window;
            this.grbChoosingAcc.Controls.Add(this.btnResetPassW);
            this.grbChoosingAcc.Controls.Add(this.panel6);
            this.grbChoosingAcc.Controls.Add(this.panel7);
            this.grbChoosingAcc.Controls.Add(this.panel8);
            this.grbChoosingAcc.Controls.Add(this.panel9);
            this.grbChoosingAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbChoosingAcc.Location = new System.Drawing.Point(3, 3);
            this.grbChoosingAcc.Name = "grbChoosingAcc";
            this.grbChoosingAcc.Size = new System.Drawing.Size(361, 335);
            this.grbChoosingAcc.TabIndex = 8;
            this.grbChoosingAcc.TabStop = false;
            this.grbChoosingAcc.Text = "Tài khoản đang chọn";
            this.grbChoosingAcc.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnResetPassW
            // 
            this.btnResetPassW.Location = new System.Drawing.Point(209, 97);
            this.btnResetPassW.Name = "btnResetPassW";
            this.btnResetPassW.Size = new System.Drawing.Size(73, 29);
            this.btnResetPassW.TabIndex = 12;
            this.btnResetPassW.Text = "Đặt lại";
            this.btnResetPassW.UseVisualStyleBackColor = true;
            this.btnResetPassW.Click += new System.EventHandler(this.btnResetPassW_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbPassW);
            this.panel6.Controls.Add(this.lbPassW);
            this.panel6.Location = new System.Drawing.Point(1, 94);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 36);
            this.panel6.TabIndex = 10;
            // 
            // tbPassW
            // 
            this.tbPassW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbPassW.Location = new System.Drawing.Point(97, 9);
            this.tbPassW.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassW.Name = "tbPassW";
            this.tbPassW.Size = new System.Drawing.Size(100, 23);
            this.tbPassW.TabIndex = 1;
            this.tbPassW.Text = "*****min";
            // 
            // lbPassW
            // 
            this.lbPassW.AutoSize = true;
            this.lbPassW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPassW.Location = new System.Drawing.Point(4, 9);
            this.lbPassW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassW.Name = "lbPassW";
            this.lbPassW.Size = new System.Drawing.Size(79, 17);
            this.lbPassW.TabIndex = 0;
            this.lbPassW.Text = "Mật khẩu:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbDisplayName);
            this.panel7.Controls.Add(this.lbname);
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel7.Location = new System.Drawing.Point(1, 20);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(359, 36);
            this.panel7.TabIndex = 8;
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbDisplayName.Location = new System.Drawing.Point(97, 9);
            this.tbDisplayName.Margin = new System.Windows.Forms.Padding(4);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(258, 23);
            this.tbDisplayName.TabIndex = 1;
            this.tbDisplayName.Text = "Nguyễn Phi Cường";
            this.tbDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbname.Location = new System.Drawing.Point(4, 12);
            this.lbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(41, 17);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "Tên:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbbTypeAcc);
            this.panel8.Controls.Add(this.lbTypeAcc);
            this.panel8.Location = new System.Drawing.Point(206, 56);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(154, 36);
            this.panel8.TabIndex = 11;
            // 
            // cbbTypeAcc
            // 
            this.cbbTypeAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTypeAcc.FormattingEnabled = true;
            this.cbbTypeAcc.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên",
            "Kế toán"});
            this.cbbTypeAcc.Location = new System.Drawing.Point(69, 7);
            this.cbbTypeAcc.Name = "cbbTypeAcc";
            this.cbbTypeAcc.Size = new System.Drawing.Size(82, 21);
            this.cbbTypeAcc.TabIndex = 1;
            this.cbbTypeAcc.Text = "Quản lý";
            // 
            // lbTypeAcc
            // 
            this.lbTypeAcc.AutoSize = true;
            this.lbTypeAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTypeAcc.Location = new System.Drawing.Point(0, 9);
            this.lbTypeAcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTypeAcc.Name = "lbTypeAcc";
            this.lbTypeAcc.Size = new System.Drawing.Size(69, 17);
            this.lbTypeAcc.TabIndex = 0;
            this.lbTypeAcc.Text = "Loại TK:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tbUserName);
            this.panel9.Controls.Add(this.lbAccName);
            this.panel9.Location = new System.Drawing.Point(1, 56);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 36);
            this.panel9.TabIndex = 9;
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbUserName.Location = new System.Drawing.Point(97, 9);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(100, 23);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.Text = "admin";
            // 
            // lbAccName
            // 
            this.lbAccName.AutoSize = true;
            this.lbAccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAccName.Location = new System.Drawing.Point(4, 9);
            this.lbAccName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAccName.Name = "lbAccName";
            this.lbAccName.Size = new System.Drawing.Size(85, 17);
            this.lbAccName.TabIndex = 0;
            this.lbAccName.Text = "Tài khoản:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewListAcc);
            this.panel1.Controls.Add(this.btnAddAcc);
            this.panel1.Controls.Add(this.btnDelAcc);
            this.panel1.Controls.Add(this.btnEditAcc);
            this.panel1.Controls.Add(this.tbFindAcc);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 39);
            this.panel1.TabIndex = 3;
            // 
            // btnViewListAcc
            // 
            this.btnViewListAcc.Location = new System.Drawing.Point(232, 7);
            this.btnViewListAcc.Name = "btnViewListAcc";
            this.btnViewListAcc.Size = new System.Drawing.Size(81, 29);
            this.btnViewListAcc.TabIndex = 6;
            this.btnViewListAcc.Text = "Xem D.Sách";
            this.btnViewListAcc.UseVisualStyleBackColor = true;
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.Location = new System.Drawing.Point(3, 7);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(73, 29);
            this.btnAddAcc.TabIndex = 5;
            this.btnAddAcc.Text = "Thêm TK";
            this.btnAddAcc.UseVisualStyleBackColor = true;
            // 
            // btnDelAcc
            // 
            this.btnDelAcc.Location = new System.Drawing.Point(161, 7);
            this.btnDelAcc.Name = "btnDelAcc";
            this.btnDelAcc.Size = new System.Drawing.Size(65, 29);
            this.btnDelAcc.TabIndex = 4;
            this.btnDelAcc.Text = "Xóa TK";
            this.btnDelAcc.UseVisualStyleBackColor = true;
            // 
            // btnEditAcc
            // 
            this.btnEditAcc.Location = new System.Drawing.Point(82, 6);
            this.btnEditAcc.Name = "btnEditAcc";
            this.btnEditAcc.Size = new System.Drawing.Size(73, 29);
            this.btnEditAcc.TabIndex = 3;
            this.btnEditAcc.Text = "Sửa TT TK";
            this.btnEditAcc.UseVisualStyleBackColor = true;
            // 
            // tbFindAcc
            // 
            this.tbFindAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbFindAcc.Location = new System.Drawing.Point(319, 9);
            this.tbFindAcc.Name = "tbFindAcc";
            this.tbFindAcc.Size = new System.Drawing.Size(158, 21);
            this.tbFindAcc.TabIndex = 2;
            this.tbFindAcc.Text = "Tìm kiếm";
            this.tbFindAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtgvAllAcc
            // 
            this.dtgvAllAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAllAcc.Location = new System.Drawing.Point(6, 44);
            this.dtgvAllAcc.Name = "dtgvAllAcc";
            this.dtgvAllAcc.Size = new System.Drawing.Size(480, 338);
            this.dtgvAllAcc.TabIndex = 0;
            // 
            // tabPageMenu
            // 
            this.tabPageMenu.Controls.Add(this.groupBox2);
            this.tabPageMenu.Controls.Add(this.grbListStaff);
            this.tabPageMenu.Controls.Add(this.panel4);
            this.tabPageMenu.Controls.Add(this.panel3);
            this.tabPageMenu.Location = new System.Drawing.Point(4, 22);
            this.tabPageMenu.Name = "tabPageMenu";
            this.tabPageMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMenu.Size = new System.Drawing.Size(856, 388);
            this.tabPageMenu.TabIndex = 1;
            this.tabPageMenu.Text = "Thống kê";
            this.tabPageMenu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Location = new System.Drawing.Point(435, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 351);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thu chi";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(2, 16);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(425, 335);
            this.dataGridView3.TabIndex = 1;
            // 
            // grbListStaff
            // 
            this.grbListStaff.Controls.Add(this.dataGridView2);
            this.grbListStaff.Location = new System.Drawing.Point(3, 37);
            this.grbListStaff.Name = "grbListStaff";
            this.grbListStaff.Size = new System.Drawing.Size(428, 351);
            this.grbListStaff.TabIndex = 2;
            this.grbListStaff.TabStop = false;
            this.grbListStaff.Text = "Danh sách nhân viên công ty";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(428, 332);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Location = new System.Drawing.Point(434, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(422, 28);
            this.panel4.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(256, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(163, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbFindUser);
            this.panel3.Location = new System.Drawing.Point(3, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 25);
            this.panel3.TabIndex = 0;
            // 
            // tbFindUser
            // 
            this.tbFindUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbFindUser.Location = new System.Drawing.Point(264, 3);
            this.tbFindUser.Name = "tbFindUser";
            this.tbFindUser.Size = new System.Drawing.Size(158, 21);
            this.tbFindUser.TabIndex = 3;
            this.tbFindUser.Text = "Tìm kiếm";
            this.tbFindUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLoginning
            // 
            this.lbLoginning.AutoSize = true;
            this.lbLoginning.Location = new System.Drawing.Point(597, 430);
            this.lbLoginning.Name = "lbLoginning";
            this.lbLoginning.Size = new System.Drawing.Size(91, 13);
            this.lbLoginning.TabIndex = 1;
            this.lbLoginning.Text = "Đang đăng nhập:";
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.AutoSize = true;
            this.lbDisplayName.Location = new System.Drawing.Point(694, 430);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(38, 13);
            this.lbDisplayName.TabIndex = 2;
            this.lbDisplayName.Text = "Cường";
            // 
            // btnPrev
            // 
            this.btnPrev.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrev.Location = new System.Drawing.Point(16, 425);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(82, 23);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "Quay lại";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnPrev;
            this.ClientSize = new System.Drawing.Size(881, 452);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.lbDisplayName);
            this.Controls.Add(this.lbLoginning);
            this.Controls.Add(this.tabp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmManager";
            this.Text = "Chức năng-Quản lý";
            this.tabp.ResumeLayout(false);
            this.tabpAccount.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.grbChoosingAcc.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAllAcc)).EndInit();
            this.tabPageMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.grbListStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabp;
        private System.Windows.Forms.TabPage tabpAccount;
        private System.Windows.Forms.DataGridView dtgvAllAcc;
        private System.Windows.Forms.TabPage tabPageMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewListAcc;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.Button btnDelAcc;
        private System.Windows.Forms.Button btnEditAcc;
        private System.Windows.Forms.TextBox tbFindAcc;
        private System.Windows.Forms.Label lbLoginning;
        private System.Windows.Forms.Label lbDisplayName;
        private System.Windows.Forms.GroupBox grbChoosingAcc;
        private System.Windows.Forms.Button btnResetPassW;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbPassW;
        private System.Windows.Forms.Label lbPassW;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cbbTypeAcc;
        private System.Windows.Forms.Label lbTypeAcc;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lbAccName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbListStaff;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.TextBox tbFindUser;
    }
}