namespace DogManage_HCMC
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabpAccount = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSearchUser = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ctmnstripSearch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tìmTheoTênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmTheoMãToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmTheoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnViewListUser = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvListDog = new System.Windows.Forms.DataGridView();
            this.tabDogList = new System.Windows.Forms.TabControl();
            this.ctmnstripDTGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabpAccount.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ctmnstripSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListDog)).BeginInit();
            this.tabDogList.SuspendLayout();
            this.ctmnstripDTGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(399, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabpAccount
            // 
            this.tabpAccount.AutoScroll = true;
            this.tabpAccount.Controls.Add(this.groupBox1);
            this.tabpAccount.Controls.Add(this.panel2);
            this.tabpAccount.Controls.Add(this.dtgvListDog);
            this.tabpAccount.Location = new System.Drawing.Point(4, 22);
            this.tabpAccount.Name = "tabpAccount";
            this.tabpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabpAccount.Size = new System.Drawing.Size(704, 426);
            this.tabpAccount.TabIndex = 0;
            this.tabpAccount.Text = "D.Sách chó";
            this.tabpAccount.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSearchUser);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnViewListUser);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Location = new System.Drawing.Point(3, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 51);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbSearchUser
            // 
            this.tbSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSearchUser.Location = new System.Drawing.Point(502, 15);
            this.tbSearchUser.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchUser.Name = "tbSearchUser";
            this.tbSearchUser.Size = new System.Drawing.Size(157, 24);
            this.tbSearchUser.TabIndex = 0;
            this.tt.SetToolTip(this.tbSearchUser, "Tìm kiếm mã gần đúng");
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(5, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "   Thoát";
            this.tt.SetToolTip(this.btnThoat, "Nhấn để thoát ");
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(167, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "   Sửa";
            this.tt.SetToolTip(this.btnSua, "Sửa thông tin chó");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.ContextMenuStrip = this.ctmnstripSearch;
            this.button3.Location = new System.Drawing.Point(657, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 26);
            this.button3.TabIndex = 7;
            this.tt.SetToolTip(this.button3, "Nhấn chuột trái để tìm chính xác hoặc chuột phải để tìm kiếm nâng cao");
            this.button3.UseVisualStyleBackColor = false;
            // 
            // ctmnstripSearch
            // 
            this.ctmnstripSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmTheoTênToolStripMenuItem,
            this.tìmTheoMãToolStripMenuItem,
            this.tìmTheoToolStripMenuItem});
            this.ctmnstripSearch.Name = "ctmnstripSearch";
            this.ctmnstripSearch.Size = new System.Drawing.Size(154, 70);
            // 
            // tìmTheoTênToolStripMenuItem
            // 
            this.tìmTheoTênToolStripMenuItem.Name = "tìmTheoTênToolStripMenuItem";
            this.tìmTheoTênToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.tìmTheoTênToolStripMenuItem.Text = "Tìm theo Mã";
            this.tìmTheoTênToolStripMenuItem.Click += new System.EventHandler(this.tìmTheoTênToolStripMenuItem_Click);
            // 
            // tìmTheoMãToolStripMenuItem
            // 
            this.tìmTheoMãToolStripMenuItem.Name = "tìmTheoMãToolStripMenuItem";
            this.tìmTheoMãToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.tìmTheoMãToolStripMenuItem.Text = "Tìm theo Loại";
            // 
            // tìmTheoToolStripMenuItem
            // 
            this.tìmTheoToolStripMenuItem.Name = "tìmTheoToolStripMenuItem";
            this.tìmTheoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.tìmTheoToolStripMenuItem.Text = "Tìm theo Ngày";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(86, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "  Thêm";
            this.tt.SetToolTip(this.btnThem, "Thêm chó");
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnViewListUser
            // 
            this.btnViewListUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewListUser.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnViewListUser.ForeColor = System.Drawing.Color.Blue;
            this.btnViewListUser.Image = ((System.Drawing.Image)(resources.GetObject("btnViewListUser.Image")));
            this.btnViewListUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewListUser.Location = new System.Drawing.Point(329, 12);
            this.btnViewListUser.Name = "btnViewListUser";
            this.btnViewListUser.Size = new System.Drawing.Size(85, 31);
            this.btnViewListUser.TabIndex = 6;
            this.btnViewListUser.Text = "    Refresh";
            this.tt.SetToolTip(this.btnViewListUser, "Làm mới danh sách");
            this.btnViewListUser.UseVisualStyleBackColor = true;
            this.btnViewListUser.Click += new System.EventHandler(this.btnViewListUser_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(248, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.tt.SetToolTip(this.btnXoa, "Xóa chó này");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 40);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(172, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ DANH SÁCH CHÓ";
            // 
            // dtgvListDog
            // 
            this.dtgvListDog.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvListDog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvListDog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListDog.Location = new System.Drawing.Point(3, 107);
            this.dtgvListDog.Name = "dtgvListDog";
            this.dtgvListDog.Size = new System.Drawing.Size(695, 319);
            this.dtgvListDog.TabIndex = 13;
            this.dtgvListDog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListDog_CellContentClick);
            this.dtgvListDog.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListDog_CellDoubleClick);
            this.dtgvListDog.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvListDog_CellMouseClick);
            this.dtgvListDog.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvListDog_CellMouseDoubleClick);
            this.dtgvListDog.SelectionChanged += new System.EventHandler(this.dtgvListDog_SelectionChanged);
            // 
            // tabDogList
            // 
            this.tabDogList.Controls.Add(this.tabpAccount);
            this.tabDogList.Location = new System.Drawing.Point(12, 3);
            this.tabDogList.Name = "tabDogList";
            this.tabDogList.SelectedIndex = 0;
            this.tabDogList.Size = new System.Drawing.Size(712, 452);
            this.tabDogList.TabIndex = 1;
            // 
            // ctmnstripDTGV
            // 
            this.ctmnstripDTGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.ctmnstripDTGV.Name = "ctmnstripDTGV";
            this.ctmnstripDTGV.Size = new System.Drawing.Size(95, 48);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // tt
            // 
            this.tt.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(728, 457);
            this.Controls.Add(this.tabDogList);
            this.Controls.Add(this.tabControl1);
            this.HelpButton = true;
            this.Name = "frmStaff";
            this.Text = "Nhân viên: ";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpAccount.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ctmnstripSearch.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListDog)).EndInit();
            this.tabDogList.ResumeLayout(false);
            this.ctmnstripDTGV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabpAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSearchUser;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnViewListUser;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvListDog;
        private System.Windows.Forms.TabControl tabDogList;
        private System.Windows.Forms.ContextMenuStrip ctmnstripSearch;
        private System.Windows.Forms.ToolStripMenuItem tìmTheoTênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmTheoMãToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmTheoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctmnstripDTGV;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolTip tt;
    }
}