﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string log, pass;
            log = Tb_Username.Text;
            pass = Tb_Password.Text;

            if (string.IsNullOrWhiteSpace(log))
            {
                MessageBox.Show("Enter login first");
                Tb_Username.Focus();
                Lb_ErrorUsername.Text = "login is empty";
            }
            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Enter password first");
                Tb_Password.Focus();
                Lb_ErrorPassword.Text = "password is empty";
            }
            //MessageBox.Show($"Login = {log}, Password = {pass}");

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void Tb_Username_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(Tb_Username.Text)))
                Lb_ErrorUsername.Text = "";
        }

        private void Tb_Password_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(Tb_Password.Text)))
                Lb_ErrorPassword.Text = "";
        }
    }
}
