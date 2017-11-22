namespace DogManage_HCMC.GUI_BLL
{
    partial class frmForgotPassW
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
            this.pnUsername = new System.Windows.Forms.Panel();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnPassw = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbTypeAgain = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnUsername.SuspendLayout();
            this.pnPassw.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnUsername
            // 
            this.pnUsername.Controls.Add(this.tbUserName);
            this.pnUsername.Controls.Add(this.lbUsername);
            this.pnUsername.Location = new System.Drawing.Point(13, 23);
            this.pnUsername.Margin = new System.Windows.Forms.Padding(4);
            this.pnUsername.Name = "pnUsername";
            this.pnUsername.Size = new System.Drawing.Size(329, 36);
            this.pnUsername.TabIndex = 0;
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbUserName.Location = new System.Drawing.Point(146, 6);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(159, 23);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.Text = "admin";
            this.tbUserName.TabIndexChanged += new System.EventHandler(this.tbUserName_TabIndexChanged);
            this.tbUserName.TabStopChanged += new System.EventHandler(this.tbUserName_TabStopChanged);
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUsername.Location = new System.Drawing.Point(4, 9);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(113, 17);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Tên tài khoản:";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.Location = new System.Drawing.Point(130, 207);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 25);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "OK";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnPassw
            // 
            this.pnPassw.Controls.Add(this.tbPassword);
            this.pnPassw.Controls.Add(this.lbPassword);
            this.pnPassw.Location = new System.Drawing.Point(13, 67);
            this.pnPassw.Margin = new System.Windows.Forms.Padding(4);
            this.pnPassw.Name = "pnPassw";
            this.pnPassw.Size = new System.Drawing.Size(329, 37);
            this.pnPassw.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbPassword.Location = new System.Drawing.Point(146, 9);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(159, 23);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Text = "admin";
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPassword.Location = new System.Drawing.Point(10, 9);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(124, 17);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Mật khẩu cấp 2:";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(227, 207);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 25);
            this.btnExit.TabIndex = 6;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lbNewPass);
            this.panel1.Location = new System.Drawing.Point(13, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 37);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(146, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(159, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "admin";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNewPass.Location = new System.Drawing.Point(10, 9);
            this.lbNewPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(109, 17);
            this.lbNewPass.TabIndex = 1;
            this.lbNewPass.Text = "Mật khẩu mới:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.lbTypeAgain);
            this.panel2.Location = new System.Drawing.Point(13, 157);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 37);
            this.panel2.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox2.Location = new System.Drawing.Point(146, 6);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(159, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "admin";
            // 
            // lbTypeAgain
            // 
            this.lbTypeAgain.AutoSize = true;
            this.lbTypeAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTypeAgain.Location = new System.Drawing.Point(10, 9);
            this.lbTypeAgain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTypeAgain.Name = "lbTypeAgain";
            this.lbTypeAgain.Size = new System.Drawing.Size(73, 17);
            this.lbTypeAgain.TabIndex = 1;
            this.lbTypeAgain.Text = "Nhập lại:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmForgotPassW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 257);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnPassw);
            this.Controls.Add(this.btnExit);
            this.Name = "frmForgotPassW";
            this.Text = "Lấy lại mật khẩu";
            this.Load += new System.EventHandler(this.frmForgotPassW_Load);
            this.pnUsername.ResumeLayout(false);
            this.pnUsername.PerformLayout();
            this.pnPassw.ResumeLayout(false);
            this.pnPassw.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnUsername;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnPassw;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbTypeAgain;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}