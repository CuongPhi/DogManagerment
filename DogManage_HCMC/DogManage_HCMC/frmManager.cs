﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogManage_HCMC
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void tabpAccount_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnResetPassW_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Đặt lại mật khẩu cho tài khoản: {0} thành công", tbUserName.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
