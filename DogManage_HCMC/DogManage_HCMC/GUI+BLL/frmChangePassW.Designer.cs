namespace DogManage_HCMC.GUI_BLL
{
    partial class frmChangePassW
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbNewPassW1 = new System.Windows.Forms.TextBox();
            this.lbNewpass1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbNewPassW0 = new System.Windows.Forms.TextBox();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbCurrPassW = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 135);
            this.panel2.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbNewPassW1);
            this.panel6.Controls.Add(this.lbNewpass1);
            this.panel6.Location = new System.Drawing.Point(0, 90);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(289, 37);
            this.panel6.TabIndex = 4;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // tbNewPassW1
            // 
            this.tbNewPassW1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbNewPassW1.Location = new System.Drawing.Point(137, 6);
            this.tbNewPassW1.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewPassW1.Name = "tbNewPassW1";
            this.tbNewPassW1.Size = new System.Drawing.Size(146, 23);
            this.tbNewPassW1.TabIndex = 2;
            // 
            // lbNewpass1
            // 
            this.lbNewpass1.AutoSize = true;
            this.lbNewpass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNewpass1.Location = new System.Drawing.Point(10, 9);
            this.lbNewpass1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNewpass1.Name = "lbNewpass1";
            this.lbNewpass1.Size = new System.Drawing.Size(73, 17);
            this.lbNewpass1.TabIndex = 1;
            this.lbNewpass1.Text = "Nhập lại:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbNewPassW0);
            this.panel5.Controls.Add(this.lbNewPass);
            this.panel5.Location = new System.Drawing.Point(-1, 45);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(289, 37);
            this.panel5.TabIndex = 3;
            // 
            // tbNewPassW0
            // 
            this.tbNewPassW0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbNewPassW0.Location = new System.Drawing.Point(137, 6);
            this.tbNewPassW0.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewPassW0.Name = "tbNewPassW0";
            this.tbNewPassW0.Size = new System.Drawing.Size(146, 23);
            this.tbNewPassW0.TabIndex = 2;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.tbCurrPassW);
            this.panel4.Controls.Add(this.lbPass);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 37);
            this.panel4.TabIndex = 2;
            // 
            // tbCurrPassW
            // 
            this.tbCurrPassW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbCurrPassW.Location = new System.Drawing.Point(136, 6);
            this.tbCurrPassW.Margin = new System.Windows.Forms.Padding(4);
            this.tbCurrPassW.Name = "tbCurrPassW";
            this.tbCurrPassW.Size = new System.Drawing.Size(146, 23);
            this.tbCurrPassW.TabIndex = 2;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPass.Location = new System.Drawing.Point(10, 9);
            this.lbPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(79, 17);
            this.lbPass.TabIndex = 1;
            this.lbPass.Text = "Mật khẩu:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(110, 153);
            this.btnOK.Name = "btnOK";
            this.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOK.Size = new System.Drawing.Size(75, 29);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmChangePassW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 185);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panel2);
            this.Name = "frmChangePassW";
            this.Text = "Đổi mật khẩu";
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbNewPassW1;
        private System.Windows.Forms.Label lbNewpass1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbNewPassW0;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbCurrPassW;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Button btnOK;
    }
}