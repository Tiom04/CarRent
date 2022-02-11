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
    public partial class AddCarWindow : Form
    {
        public AddCarWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TypeOfCar typeOfCar = new TypeOfCar();
            if (!string.IsNullOrWhiteSpace(tbModel.Text))
            {
                typeOfCar.Model = tbModel.Text.Trim();
            }
            else
            {
                MessageBox.Show("Enter car model");
                tbModel.Focus();
            }
            if (!string.IsNullOrWhiteSpace(tb_Make.Text))
            {
                typeOfCar.Make = tb_Make.Text.Trim();
            }
            else
            {
                MessageBox.Show("Enter car Make");
                tb_Make.Focus();
            }
            if (!string.IsNullOrWhiteSpace(tbVIN.Text))
            {
                typeOfCar.VIN = tbVIN.Text.Trim();
            }
            else
            {
                MessageBox.Show("Enter car VIN");
                tbVIN.Focus();
            }
            if (!string.IsNullOrWhiteSpace(tbYear.Text))
            {
                typeOfCar.Year = Convert.ToInt32(tbYear.Text.Trim());
            }
            else
            {
                MessageBox.Show("Enter car production year");
                tbYear.Focus();
            }
            LicenseNumber:
            if (!string.IsNullOrWhiteSpace(tbLicenseNumber.Text))
            {
                typeOfCar.LicensePlateNumber = tbLicenseNumber.Text.Trim();
            }
            else
            {
                MessageBox.Show("Enter car License plate number");
                tbLicenseNumber.Focus();
                goto LicenseNumber;//demo
            }

            CarRentDbContext dbContext = new CarRentDbContext();

            try
            {
                dbContext.TypeOfCars.Add(typeOfCar);
                dbContext.SaveChanges();
                MessageBox.Show("Added new type of car");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception while adding new type of car " + ex.Message);
            }
            
        }
    }
}
