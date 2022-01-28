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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void Btn_ResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                //get id of selected row  from grid
                var id = dataGridUsers.SelectedRows[0].Cells["Id"].Value;
                //get user by id
                var user = "Artem";//user model
                string hashedPassword = Utils.DefaultHashPassword();
                //user.password = hashedPassword;
                //db.saveRecord;
                MessageBox.Show("Password was reset");

                PopulateGrid();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void PopulateGrid()
        {
            //

        }
    }
}
