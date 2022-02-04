using System;
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
        public User user;
        public string roleName;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(LoginForm loginForm, User userModel)
        {
            InitializeComponent();
            _login = loginForm;
            user = userModel;
            roleName = user.UserRoles.FirstOrDefault().Role.ShortName;

            //MessageBox.Show($"{user.Username} {roleName}");
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //if user pass = default pass -> window for pass reset

            

            //var resetPassword = new ResetPassword();
            //resetPassword.ShowDialog();
            

            if(roleName.ToLower() == "user")
            {
                //hide some item
                manageUsersToolStripMenuItem.Visible = false;

            }




        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();

        }

        private void manageVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.ShowDialog();
            Hide();
        }
    }
}
