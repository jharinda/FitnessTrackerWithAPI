using FitnessTracker.Classes;
using FitnessTracker.Forms;
using FitnessTrackerNet4.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTrackerNet4.Forms
{
    public partial class Signin : Form
    {

        public Signin()
        {
            InitializeComponent();
            lbl_error.Text = "";
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Email = input_email.Text;
            user.Password = input_password.Text;

            RepositoryService service = new RepositoryService();

            if(user.Email != "" && user.Password != "")
            {
                var res = await service.ValidateAsync(user.Email, user.Password);

                if (res)
                {
                    this.Hide();
                    FitnessTrackerForms.IndexForm = new Index();
                    FitnessTrackerForms.IndexForm.Show();
                }

            }

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FitnessTrackerForms.SignupForm = new Signup();
            FitnessTrackerForms.SignupForm.Show();
        }

        private void input_password_TextChanged(object sender, EventArgs e)
        {
            if (input_password.Text == input_password.PlaceHolderText)
            {
                input_password.PasswordChar = Convert.ToChar("\0");
            }
            else if (input_password.Text.Length > 0)
            {
                input_password.PasswordChar = Convert.ToChar("*");
            }
            else if (input_password.Text.Length == 0)
            {
                input_password.PasswordChar = Convert.ToChar("\0");
            }
        }
    }
}
