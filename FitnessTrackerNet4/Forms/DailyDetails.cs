using FitnessTracker.Classes;
using FitnessTracker.Repository;
using FitnessTrackerNet4.Services;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FitnessTracker.Forms
{
    public partial class DailyDetails : Form
    {
        public Record record = new Record();
        private RepositoryService repositoryService= new RepositoryService();
        public bool isOnEdit = false;
        public DailyDetails()
        {
            InitializeComponent();
            /*loadInitialData();

            input_datePicker.MaxDate = DateTime.Now;

            updateMealCalories();
            updateWorkoutCalories();

            loadMealList();
            loadWorkoutList();*/

            
        }

      
        public DailyDetails(bool isOnEdit,Record record)
        {
            this.isOnEdit = isOnEdit;
            this.record = record;
            InitializeComponent();
            /*loadInitialData();

            input_datePicker.MaxDate = DateTime.Now;

            updateMealCalories();
            updateWorkoutCalories();*/

            loadEditData();

           /* loadMealList();
            loadWorkoutList();*/


        }

        private void loadMealList()
        {
            if(record.Meals.Count > 0)
            {
                foreach(var mealPair in record.Meals) 
                {
                    listView_meals.Items.Add(mealPair.Key.Name + " x " + mealPair.Value);
                }
            }
        }


        private void loadWorkoutList()
        {
            if (record.Workouts.Count > 0)
            {
                foreach (var mealPair in record.Workouts)
                {
                    listView_workouts.Items.Add(mealPair.Key.Name + " x " + mealPair.Value);
                }
            }
        }

        private void loadEditData()
        {
            input_datePicker.Value = record.Date;
            input_datePicker.Enabled = false;
            input_weight.Text = record.Weight.ToString();
        }

        private void loadInitialData()
        {
            foreach (Meal meal in FitnessTrackerData.meals)
            {
                comboBox_meals.Items.Add(meal.Name);
            }

            foreach (Workout workout in FitnessTrackerData.workouts)
            {
                comboBox_workouts.Items.Add(workout.Name);
            }
        }

        private void btn_addMeal_Click(object sender, EventArgs e)
        {
            if (comboBox_meals.SelectedItem != null && input_mealQuantity.Text != null) 
            {
                bool status = record.addMeal(FitnessTrackerData.meals[comboBox_meals.SelectedIndex],
                    Int32.Parse(input_mealQuantity.Text));

                if (status) 
                { 
                    listView_meals.Items.Add(comboBox_meals.SelectedItem.ToString() + " - " + input_mealQuantity.Text);
                    comboBox_meals.ResetText();
                    input_mealQuantity.ResetText();
                    updateMealCalories();
                }
            }
        }

        private void btn_addWorkout_Click(object sender, EventArgs e)
        {
            if (comboBox_workouts.SelectedItem != null && input_workoutReps.Text != null && comboBox_workouts.SelectedIndex != -1)
            {
                bool status = record.addWorkout(FitnessTrackerData.workouts[comboBox_workouts.SelectedIndex], 
                    Int32.Parse(input_workoutReps.Text));

                if (status) 
                { 
                    listView_workouts.Items.Add(comboBox_workouts.SelectedItem.ToString() + " - " + input_workoutReps.Text);
                    comboBox_workouts.ResetText();
                    input_workoutReps.ResetText();
                    updateWorkoutCalories();
                }
            }
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            record.Date = input_datePicker.Value;
            if(input_weight.Text == "")
            {
                MessageBox.Show("Please enter the weight");
                return;
            }

            record.Weight = Int32.Parse(input_weight.Text);
            
            if (!isOnEdit) { 
                FitnessTrackerData.user.addRecord(record);
                await repositoryService.AddRecord(record);
                MessageBox.Show("Successfully added");
            }
            else
            {
                FitnessTrackerData.user.updateRecord(record);
                await repositoryService.UpdateRecord(record);
                FitnessTrackerForms.ProfileForm.loadListView();
                MessageBox.Show("Successfully update");
            }
            this.Hide();
        }

        private void btn_resetMeals_Click(object sender, EventArgs e)
        {
            record.resetMeals();
            foreach (ListViewItem element in listView_meals.Items)
            {
                listView_meals.Items.Remove(element);
            }

            updateMealCalories();
        }

        private void btn_resetWorkouts_Click(object sender, EventArgs e)
        {
            record.resetWorkouts();
            foreach (ListViewItem element in listView_workouts.Items) 
            { 
                listView_workouts.Items.Remove(element);
            }

            updateWorkoutCalories();
        }

        private void updateMealCalories()
        {
            lbl_mealCalories.Text = "Total calories - " + record.getMealCalories();
        }
        private void updateWorkoutCalories()
        {
            lbl_workoutCalories.Text = "Total calories - " + record.getWorkoutCalories();
        }

        private async void DailyDetails_Load(object sender, EventArgs e)
        {
            ThreadStart getMeals = new ThreadStart(repositoryService.GetMeals);
            ThreadStart getWorkouts = new ThreadStart(repositoryService.GetWorkouts);

            Thread getMealsThread = new Thread(getMeals);
            Thread getWorkoutsThread = new Thread(getWorkouts);

            getMealsThread.Start();
            getWorkoutsThread.Start();

            loadInitialData();

            input_datePicker.MaxDate = DateTime.Now;

            updateMealCalories();
            updateWorkoutCalories();

           // loadEditData();

            loadMealList();
            loadWorkoutList();
        }
    }
}
