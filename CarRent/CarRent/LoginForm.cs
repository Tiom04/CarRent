using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class LoginForm : Form
    {
        private CarRentDbContext _dbContext = new CarRentDbContext();
        public LoginForm()
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

            try
            {
                SHA256 sha = SHA256.Create();
                string hashPassword = Utils.HashPassword(pass);

                var userFromDb = _dbContext.Users
                                        .FirstOrDefault(x => x.Password == hashPassword && x.Username == log);

                //var userFromDb = (from user in _dbContext.Users
                //           where user.Password == hashPassword && user.Username == log
                //           select user).FirstOrDefault();//

                if(userFromDb == null)
                {
                    MessageBox.Show("Incorrect password or login");
                }
                else//user exists
                {
                    MainWindow mainWindow = new MainWindow(this, userFromDb);
                    mainWindow.Show();
                    Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Call admin");
            }
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
