using FitnessTracker.Classes;
using FitnessTracker.Repository;
using FitnessTrackerNet4.Forms;
using FitnessTrackerNet4.Services;
using System;
using System.Windows.Forms;

namespace FitnessTracker.Forms
{
    public partial class Signup : Form
    {
        RepositoryService service = new RepositoryService();

        public Signup()
        {
            InitializeComponent();
            lbl_error.Text = String.Empty;
            
        }

        private async void btn_submit_Click(object sender, EventArgs e)
        {
            if (validateField()) 
            {
                FitnessTrackerData.user = new User()
                {
                    Name = input_name.Text,
                    Age = Int32.Parse(input_age.Text),
                    HeightInCm = Int32.Parse(input_heightInCm.Text),
                    Gender = input_gender.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                };
                await service.RegisterAsync(FitnessTrackerData.user);
                this.Hide();
                FitnessTrackerForms.Signin = new Signin();
                FitnessTrackerForms.Signin.Show();
            }
        }

        private bool validateField()
        {
            bool valid = false;
            int output;

            if (input_name.Text.Length <= 0)
            {
                lbl_error.Text = "Name is empty";
            }
            else if (input_age.Text.Length <= 0)
            {
                lbl_error.Text = "Age is empty";
            }
            else if (input_heightInCm.Text.Length <= 0)
            {
                lbl_error.Text = "Height is empty";
            }
            else if (input_gender.Text.Length <= 0)
            {
                lbl_error.Text = "Gender is empty";
            }
            else if (input_gender.Text != "Male" && input_gender.Text != "Female")
            {
                lbl_error.Text = "Gender should be Male / Female";
            }
            else if (!Int32.TryParse(input_age.Text,out output)) 
            {
                lbl_error.Text = "Age should be a number";
            }
            else if (!Int32.TryParse(input_heightInCm.Text, out output))
            {
                lbl_error.Text = "heightInCm should be a number";
            }
            else
            {
                valid = true;
            }

            return valid;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FitnessTrackerForms.Signin = new Signin();
            FitnessTrackerForms.Signin.Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPassword.PlaceHolderText)
            {
                txtPassword.PasswordChar = Convert.ToChar("\0");
            }
            else if (txtPassword.Text.Length > 0)
            {
                txtPassword.PasswordChar = Convert.ToChar("*");
            }
            else if(txtPassword.Text.Length == 0)
            {
                txtPassword.PasswordChar = Convert.ToChar("\0");
            }
        }
    }
}
