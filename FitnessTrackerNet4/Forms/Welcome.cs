using FitnessTracker.Classes;
using FitnessTracker.Forms;
using FitnessTracker.Repository;
using FitnessTrackerNet4.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTrackerNet4.Forms
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            FitnessTrackerForms.SignupForm = new Signup();
            FitnessTrackerForms.SignupForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
