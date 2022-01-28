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
    public partial class MainWindow : Form
    {
        private LoginForm _login;
        public string user;//model (db)
        public string roleName;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(LoginForm loginForm, string userModel)
        {
            _login = loginForm;
            user = userModel;
            roleName = "systAdmin";
            //user.role      role:id,name,shortname
            //roleName= userModel.role.shortname;

            

            MessageBox.Show($"{user}");
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //if user pass = default pass -> window for pass reset

            

            if(roleName != "admin")
            {
                //hide some item
            }




        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();

        }

        private void manageVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
