using FitnessTracker.Classes;
using FitnessTracker.Repository;
using FitnessTrackerNet4.Forms;
using FitnessTrackerNet4.Services;
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

namespace FitnessTracker.Forms
{
    public partial class Index : Form
    {
        private RepositoryService repositoryService = new RepositoryService();
        public Index()
        {
            InitializeComponent();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            FitnessTrackerForms.ProfileForm = new Profile();
            FitnessTrackerForms.ProfileForm.Show();
        }

        private void btn_addDetails_Click(object sender, EventArgs e)
        {
            FitnessTrackerForms.DailyDetailsForm = new DailyDetails();
            FitnessTrackerForms.DailyDetailsForm.Show();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            FitnessTrackerForms.PreviewForm = new Preview();
            FitnessTrackerForms.PreviewForm.Show();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            ThreadStart getMeals = new ThreadStart(repositoryService.GetMeals);
            ThreadStart getWorkouts = new ThreadStart(repositoryService.GetWorkouts);

            Thread getMealsThread = new Thread(getMeals);
            Thread getWorkoutsThread = new Thread(getWorkouts);

            getMealsThread.Start();
            getWorkoutsThread.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            File.WriteAllText(FitnessTrackerData.tempFilePath, "");
            FitnessTrackerForms.Signin = new Signin();
            FitnessTrackerForms.Signin.Show();
            this.Hide();
        }
    }
}
