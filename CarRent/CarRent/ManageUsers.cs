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
        private readonly CarRentDbContext _dbContext = new CarRentDbContext();
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
            var users = _dbContext.Users.Select(x => new
            {
                x.Id,
                x.Username,
                x.UserRoles.FirstOrDefault().Role.Name,
                x.IsActive
            }).ToList();

            dataGridUsers.DataSource = users;

            dataGridUsers.Columns["Username"].HeaderText = "Username";
            dataGridUsers.Columns["Name"].HeaderText = "Role Name";
            dataGridUsers.Columns["IsActive"].HeaderText = "Active";
            dataGridUsers.Columns["Id"].Visible = false;
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();

        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
