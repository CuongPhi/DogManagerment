﻿using DogManage_HCMC.DAL;
using DogManage_HCMC.DTO;
using DogManage_HCMC.GUI_BLL;
using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
           
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isLogin() && true)
            {
                Account acc = AccountConnection.Inst.getAccountByuserName(tbUserName.Text);
                frmIntro frmIntro = new frmIntro(acc);
                this.Hide();
                frmIntro.ShowDialog();
                this.Show();
                this.tbPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !");
            }
        }
        private bool isLogin()
        {
            return AccountConnection.Inst.isLogin(tbUserName.Text, tbPassword.Text);
        }
        private void llbForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotPassW frmFgPW = new frmForgotPassW();
            frmFgPW.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình ??", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
            
        }
    }
}
