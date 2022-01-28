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
            }
            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Enter password first");
                Tb_Password.Focus();
            }

            MessageBox.Show($"Login = {log}, Password = {pass}");

        }
    }
}
