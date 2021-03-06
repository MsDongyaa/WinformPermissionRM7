﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM7.Login
{
    public partial class Login : Form
    {
        internal bool IsLoginSuccessful;

        public Login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(account.Text)||string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("账号密码不能为空！");
                return;
            }

            //TODO:后面的代码要等验证成功后才能执行
            IsLoginSuccessful = true;
            this.Close();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            COTI login = new COTI();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                Application.Run(new COTI());
            }
            else if (login.DialogResult == DialogResult.Cancel)
            {
                login.Dispose();
                return;
            }
        }
    }
}
