namespace DogManage_HCMC
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnUsername = new System.Windows.Forms.Panel();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.pnPassw = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbIntroSoft = new System.Windows.Forms.Label();
            this.lbver = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llbForgotPass = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnUsername.SuspendLayout();
            this.pnPassw.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogin.Location = new System.Drawing.Point(117, 97);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(77, 31);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "OK";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnUsername
            // 
            this.pnUsername.Controls.Add(this.tbUserName);
            this.pnUsername.Controls.Add(this.lbUsername);
            this.pnUsername.Location = new System.Drawing.Point(4, 4);
            this.pnUsername.Margin = new System.Windows.Forms.Padding(4);
            this.pnUsername.Name = "pnUsername";
            this.pnUsername.Size = new System.Drawing.Size(309, 36);
            this.pnUsername.TabIndex = 1;
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbUserName.Location = new System.Drawing.Point(97, 9);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(198, 23);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.Text = "admin";
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUsername.Location = new System.Drawing.Point(10, 12);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(85, 17);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Tài khoản:";
            // 
            // pnPassw
            // 
            this.pnPassw.Controls.Add(this.tbPassword);
            this.pnPassw.Controls.Add(this.lbPassword);
            this.pnPassw.Location = new System.Drawing.Point(4, 48);
            this.pnPassw.Margin = new System.Windows.Forms.Padding(4);
            this.pnPassw.Name = "pnPassw";
            this.pnPassw.Size = new System.Drawing.Size(309, 37);
            this.pnPassw.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbPassword.Location = new System.Drawing.Point(97, 6);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(198, 23);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "admin";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPassword.Location = new System.Drawing.Point(10, 9);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(79, 17);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Mật khẩu:";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(202, 97);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbIntroSoft
            // 
            this.lbIntroSoft.AutoSize = true;
            this.lbIntroSoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbIntroSoft.ForeColor = System.Drawing.Color.Red;
            this.lbIntroSoft.Location = new System.Drawing.Point(1, 137);
            this.lbIntroSoft.Name = "lbIntroSoft";
            this.lbIntroSoft.Size = new System.Drawing.Size(93, 15);
            this.lbIntroSoft.TabIndex = 4;
            this.lbIntroSoft.Text = "Made by Cteam";
            // 
            // lbver
            // 
            this.lbver.AutoSize = true;
            this.lbver.ForeColor = System.Drawing.Color.DarkRed;
            this.lbver.Location = new System.Drawing.Point(292, 9);
            this.lbver.Name = "lbver";
            this.lbver.Size = new System.Drawing.Size(39, 15);
            this.lbver.TabIndex = 5;
            this.lbver.Text = "v1.0.0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.llbForgotPass);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lbIntroSoft);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 156);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // llbForgotPass
            // 
            this.llbForgotPass.AutoSize = true;
            this.llbForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llbForgotPass.Location = new System.Drawing.Point(194, 132);
            this.llbForgotPass.Name = "llbForgotPass";
            this.llbForgotPass.Size = new System.Drawing.Size(105, 15);
            this.llbForgotPass.TabIndex = 6;
            this.llbForgotPass.TabStop = true;
            this.llbForgotPass.Text = "Quên mật khẩu??";
            this.llbForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbForgotPass_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(83, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pnUsername);
            this.panel2.Controls.Add(this.pnPassw);
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 89);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(349, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbver);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chó-Đăng nhập ";
            this.pnUsername.ResumeLayout(false);
            this.pnUsername.PerformLayout();
            this.pnPassw.ResumeLayout(false);
            this.pnPassw.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnUsername;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Panel pnPassw;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbIntroSoft;
        private System.Windows.Forms.Label lbver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llbForgotPass;
        private System.Windows.Forms.Panel panel2;
    }
}

