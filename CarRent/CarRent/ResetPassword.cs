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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void Btn_resetPassword_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(Tb_NewPassword.Text) || string.IsNullOrWhiteSpace(Tb_ConfirmPassword.Text)))
            {
                if (Tb_NewPassword.Text == Tb_ConfirmPassword.Text)
                {
                    if (Utils.HashPassword(Tb_NewPassword.Text) == Utils.DefaultHashPassword())
                    {
                        MessageBox.Show("Using default password is not allowed!");
                    }
                    else
                    {
                        //save to database
                        MessageBox.Show("Data saved to db");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords are different");
                    Tb_NewPassword.Clear();
                    Tb_NewPassword.Clear();
                }
            }
            else
            {
                MessageBox.Show("enter password first");
            }
        }
    }
}
